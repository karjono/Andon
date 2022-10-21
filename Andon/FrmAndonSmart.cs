using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using Base.Helper;
using System.Data.OracleClient;
using DevExpress.XtraGrid.Views.Grid;
using System.Media;
//using System.Reflection;
//using System.IO;
using System.Net;
using System.Net.Sockets;
namespace Andon
{
    public partial class FrmAndonSmart : FrmBaseAndon
    {
        public int idx_form;
        private string formTitle = Properties.Settings.Default.FormTittle.ToUpper();
        //bool installFont = false;
        Base.Helper.classDB ClsDB = new Base.Helper.classDB();
        DataTable dtLayout = new DataTable();
        DataTable dtAndon = new DataTable();
        DataTable dtGet = new DataTable();
        DataTable dtOnOff = new DataTable();
        DataTable dtCIS = new DataTable();
        //DataTable dtCurrAndon = new DataTable();
        string andonLine = "0";
        string andonMC = "0";
        string andonTitle = "";
        public int intSwitch = 0;

        //==> ANDON GATE
        Boolean status_response = false;
        string hasil_data;
        string[] hasilsplit;

        Devart.Data.Oracle.OracleConnection myConnection;
        Devart.Data.Oracle.OracleDataAdapter myDataAdapter;
        Devart.Data.Oracle.OracleCommand myCommand;
        public FrmAndonSmart(int int_idx = 0)
        {
            InitializeComponent();
            this.idx_form = int_idx;
            Functions.AddFontResource(Application.StartupPath + "\\digital-7.ttf");
            lblStatus.Text = "Waiting..";
        }
        private void FrmAndonOSP_Load(object sender, EventArgs e)
        {
            timerRefresh.Interval = Functions.refresh * 60000;
            timerCheckAndon.Interval = Convert.ToInt32(Properties.Settings.Default.TIMER_ANDON * 60000);
            Functions.Form_Maximized(this, this.idx_form);
            lblTitle1.Text = Properties.Settings.Default.FormTittle.ToUpper(); ;
            //int pictWidth = panel3.Width / 5;
            //pnlLayout.Width = pictWidth;
            //pnlBreakdown.Width = pictWidth;
            //pnlUnderRepair.Width = pictWidth;
            //pnlDone.Width = pictWidth;
            //pnlD3.Width = pictWidth;

            pnlAndon.Location = new Point((this.ClientSize.Width - pnlAndon.Width) / 2, ((this.ClientSize.Height - pnlAndon.Height) / 2) + 20);
            pnlAndon.Visible = false;

            //setLayout();

            timerRefresh.Enabled = true;
            timerRefresh.Start();

            //==> CHECK PORT
            portConnected();

            //==> SOCKET SERVER
            if (Properties.Settings.Default.GATE_SERVER_SOCKET_YN == "Y")
            {
                labelControl1.Text = "Listening...";
                //ExecuteServer();
            }

            if (Properties.Settings.Default.DIRECT_CONNECT_YN == "Y")
            {
                myConnection = new Devart.Data.Oracle.OracleConnection(Properties.Settings.Default.DIRECT_CONNECTION);
            }

            if (Properties.Settings.Default.SWITCH_FORM_YN == "Y")
            {
                tmrSwitch.Enabled = true;
                tmrSwitch.Interval = 60000 * Properties.Settings.Default.SWITCH_TIMER;
            }
            checkDirrect();
        }

        private DataTable fnSearch(string param1, string param2 = "", string param3 = "", string param4 = "", string param5 = "", string param6 = "", string param7 = "", string param8 = "")
        {
            try
            {
                int i = 8;
                ClsDB.Set_Parameter(i);

                i = 0;
                ClsDB.Set_Parameter_Name[i++] = "V_P_ACTION";
                ClsDB.Set_Parameter_Name[i++] = "V_P_PLANT_CD";
                ClsDB.Set_Parameter_Name[i++] = "V_P_PLANT_PB_CD";
                ClsDB.Set_Parameter_Name[i++] = "V_P_OP_CD";
                ClsDB.Set_Parameter_Name[i++] = "V_P_DIVISION";
                ClsDB.Set_Parameter_Name[i++] = "V_P_MC_LINE";
                ClsDB.Set_Parameter_Name[i++] = "V_P_ANDON_DT";
                ClsDB.Set_Parameter_Name[i++] = "OUT_CURSOR";

                i = 0;
                ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
                ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
                ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
                ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
                ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
                ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
                ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
                ClsDB.Set_Parameter_Type[i++] = (int)OracleType.Cursor;

                i = 0;
                ClsDB.Set_Parameter_Value[i++] = param1;
                ClsDB.Set_Parameter_Value[i++] = param2;
                ClsDB.Set_Parameter_Value[i++] = Properties.Settings.Default.PLANT_BD_CD;
                ClsDB.Set_Parameter_Value[i++] = Properties.Settings.Default.OP_GROUP;
                ClsDB.Set_Parameter_Value[i++] = param5;
                ClsDB.Set_Parameter_Value[i++] = Properties.Settings.Default.LINE_CD;
                ClsDB.Set_Parameter_Value[i++] = DateTime.Today.ToString("yyyyMMdd");
                ClsDB.Set_Parameter_Value[i++] = param8;
                if (param1 == "GET_ANDON_SOUND")
                    return ClsDB.LMES_Pkg_Select_Dt("PKG_MSPD_ANDON.SELECT_ANDON_SOUND_YN");
                else
                    return ClsDB.LMES_Pkg_Select_Dt("PKG_MSPD_ANDON.SELECT_ANDON_TIME");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Administrator");
                return null;
            }
        }

        private bool fn_Save(string p_action, string p_plant_cd, string p_item_class, string p_wo_no = "", string p_seq_no = "")
        {
            string wh_cd = "";
            if (p_item_class == "OS" || p_item_class == "PU")
                wh_cd = "51BT";
            else
                if (p_item_class == "II" || p_item_class == "PP")
                    wh_cd = "51IP";

            int i = 6;
            ClsDB.Set_Parameter(i);

            string PLANT_BD_CD = Properties.Settings.Default.PLANT_BD_CD;
            string OP_GROUP = Properties.Settings.Default.OP_GROUP;

            i = 0;
            ClsDB.Set_Parameter_Name[i++] = "V_P_ACTION";
            ClsDB.Set_Parameter_Name[i++] = "V_P_PLANT_CD";
            ClsDB.Set_Parameter_Name[i++] = "V_PLANT_BD_CD";
            ClsDB.Set_Parameter_Name[i++] = "V_P_OP_GROUP";
            ClsDB.Set_Parameter_Name[i++] = "V_P_ANDON_DT";
            ClsDB.Set_Parameter_Name[i++] = "V_P_ANDON_SEQ";

            i = 0;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;

            i = 0;
            ClsDB.Set_Parameter_Value[i++] = p_action;
            ClsDB.Set_Parameter_Value[i++] = p_plant_cd;
            ClsDB.Set_Parameter_Value[i++] = PLANT_BD_CD;
            ClsDB.Set_Parameter_Value[i++] = OP_GROUP;
            ClsDB.Set_Parameter_Value[i++] = DateTime.Today.ToString("yyyyMMdd");
            ClsDB.Set_Parameter_Value[i++] = p_seq_no;

            return ClsDB.LMES_Pkg_Modify("PKG_MSPD_ANDON.UPDATE_ANDON_SOUND");

            //if (ClsDB.LMES_Pkg_Modify("PKG_MSPD_ANDON."))
            //    return true;
            //else
            //    return false;
        }

        private DataTable fn_Save_andon(string p_button_id, string p_problem, string p_status, string p_time_andon)
        {

            int i = 5;
            ClsDB.Set_Parameter(i);

            i = 0;
            ClsDB.Set_Parameter_Name[i++] = "ARG_BUTTON_ID";
            ClsDB.Set_Parameter_Name[i++] = "ARG_PROBLEM";
            ClsDB.Set_Parameter_Name[i++] = "ARG_STATUS";
            ClsDB.Set_Parameter_Name[i++] = "ARG_TIME_ANDON";
            ClsDB.Set_Parameter_Name[i++] = "OUT_CURSOR";

            i = 0;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.VarChar;
            ClsDB.Set_Parameter_Type[i++] = (int)OracleType.Cursor;

            i = 0;
            ClsDB.Set_Parameter_Value[i++] = p_button_id;
            ClsDB.Set_Parameter_Value[i++] = p_problem;
            ClsDB.Set_Parameter_Value[i++] = p_status;
            ClsDB.Set_Parameter_Value[i++] = p_time_andon;
            ClsDB.Set_Parameter_Value[i++] = "";

            return ClsDB.LMES_Pkg_Select_Dt("PKG_MSPD_ANDON.SAVE_ANDON_NEW2");

            //return ClsDB.LMES_Pkg_Modify("PKG_MSPD_ANDON.SAVE_ANDON_NEW");
        }

        private void setGrid(DevExpress.XtraGrid.GridControl grdCtrl, DevExpress.XtraGrid.Views.Grid.GridView gvw, DataTable dt)
        {
            //gvw.BeginUpdate();
            //gvw.Columns.Clear();
            grdCtrl.DataSource = dt;
            //gvw.PopulateColumns(grdCtrl.DataSource);
            //gvw.EndUpdate();
        }

        private void gvwData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            //if (e.Info.Kind == DevExpress.Utils.Drawing.IndicatorKind.Header)
            //{
            //    e.Info.DisplayText = "M/C  ~  LINE";
            //}

            //if (e.Info.Kind != DevExpress.Utils.Drawing.IndicatorKind.Header)
            //{
            //    e.Info.DisplayText = (grdCtrl.DataSource as DataTable).Rows[e.RowHandle]["MACHINE_SEQ"].ToString();

            //    if (e.Info.DisplayText == "CUTTING" || e.Info.DisplayText == "TRIMMING" || e.Info.DisplayText == "HEATER")
            //        e.Info.BackAppearance.BackColor = Color.Cornsilk;
            //}

            //e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        }

        private void fn_FormatGrid()
        {
            try
            {
                int width = 0;
                width = ((grdCtrl.Width - gvwData.IndicatorWidth) / (gvwData.Columns.Count)) + 1;

                //if (chkFit.Checked)
                //    width += 25;

                for (int i = 0; i < gvwData.Columns.Count; i++)
                {
                    gvwData.Columns[i].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwData.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gvwData.Columns[i].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                    gvwData.Columns[i].OptionsColumn.AllowEdit = false;
                    gvwData.Columns[i].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                    gvwData.Columns[i].Width = width;

                    //if (i <= 1)
                    //    gvwData.Columns[i].Visible = false;

                    gvwData.Columns[i].ColumnEdit = repoMemoEdit;
                }
                gvwData.Columns[0].Caption = "No";   gvwData.Columns[0].Width = 90;
                gvwData.Columns[1].Caption = "Proc"; gvwData.Columns[1].Width = 210;
                gvwData.Columns[2].Caption = "Div";
                gvwData.Columns[3].Caption = "Start";  gvwData.Columns[3].Width = 180;
                gvwData.Columns[3].AppearanceHeader.BackColor = Color.LightGreen;
                gvwData.Columns[3].AppearanceHeader.BackColor2 = Color.LightGreen;
                gvwData.Columns[4].Caption = "Arrive"; gvwData.Columns[4].Width = 180;
                gvwData.Columns[4].AppearanceHeader.BackColor = Color.PeachPuff;
                gvwData.Columns[4].AppearanceHeader.BackColor2 = Color.PeachPuff;
                gvwData.Columns[5].Caption = "Hour";
                gvwData.Columns[5].AppearanceHeader.BackColor = Color.PeachPuff;
                gvwData.Columns[5].AppearanceHeader.BackColor2 = Color.PeachPuff;
                gvwData.Columns[6].Caption = "Finish"; gvwData.Columns[6].Width = 180;

                gvwData.Columns[6].AppearanceHeader.BackColor = Color.Yellow;
                gvwData.Columns[6].AppearanceHeader.BackColor2 = Color.Yellow;
                gvwData.Columns[7].Caption = "Hour";
                gvwData.Columns[7].AppearanceHeader.BackColor = Color.Yellow;
                gvwData.Columns[7].AppearanceHeader.BackColor2 = Color.Yellow;
                gvwData.RowHeight = ((grdCtrl.Height - gvwData.ColumnPanelRowHeight - 50) / gvwData.RowCount); //- (chkFit.Checked ? 1 : 0);
            }
            catch (Exception)
            {

            }
        }

        private void gvwData_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //if (e.Value != null && e.Value.ToString() != " " && e.Value.ToString() != "")
            //{
            //    string val = e.Value.ToString();
            //    int idx = val.IndexOf("~");
            //    e.DisplayText = val.Substring(0, (val.Length - 1) - (val.Length - 1 - idx));
            //}
        }

        private void gvwData_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;

            string val = view.GetRowCellValue(e.RowHandle, e.Column.FieldName).ToString();
            val = (val.Length > 1 ? val.Substring(val.Length - 1, 1) : val);


            if (val != "" && val != " ")
            {
                if (val == "R")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
                else
                    if (val == "C")
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else
                        if (val == "F")
                        {
                            e.Appearance.BackColor = Color.LightGreen;
                            e.Appearance.ForeColor = Color.Black;
                        }
                        else
                            if (val == "B")
                            {
                                e.Appearance.BackColor = Color.Black;
                                e.Appearance.ForeColor = Color.White;
                            }
                            else
                                if (val == "D")
                                {
                                    e.Appearance.BackColor = Color.Gold;
                                    e.Appearance.ForeColor = Color.Black;
                                }
            }

            if (e.Column.ColumnHandle > 1)
            {
                for (int j = 2; j < dtOnOff.Columns.Count; j++)
                {
                    string chk = dtOnOff.Rows[e.RowHandle][j].ToString();

                    if (e.Column.ColumnHandle == j && (chk == "O" || chk == ""))
                        e.Appearance.BackColor = Color.Gray;
                }
            }
        }

        private void fn_setHeaderColor()
        {
            int idx = 0;
            foreach (DataRow row in dtCIS.Rows)
            {
                for (int i = 0; i < gvwData.Columns.Count; i++)
                {
                    if (row["2"].ToString() == gvwData.Columns[i].FieldName)
                    {
                        int[] objBackColor = new int[3];
                        int[] objForeColor = new int[3];
                        string[] strBackColor = dtCIS.Rows[idx]["3"].ToString().Split(new Char[] { ',' });
                        string[] strForeColor = dtCIS.Rows[idx]["4"].ToString().Split(new Char[] { ',' });

                        int z = 0;
                        foreach (string dt in strBackColor)
                        {
                            objBackColor[z] = Convert.ToInt32(dt);
                            z++;
                        }
                        gvwData.Columns[i].AppearanceHeader.BackColor = Color.FromArgb(objBackColor[0], objBackColor[1], objBackColor[2]);

                        z = 0;
                        foreach (string dt in strForeColor)
                        {
                            objForeColor[z] = Convert.ToInt32(dt);
                            z++;
                        }
                        gvwData.Columns[i].AppearanceHeader.ForeColor = Color.FromArgb(objForeColor[0], objForeColor[1], objForeColor[2]);
                    }
                }
                idx++;
            }
        }

        private void timerCheckAndon_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SOUND_YN == "Y")
            {
                checkAndon();
            }
        }

        private void checkAndon()
        {
            if (bwAndon.IsBusy)
                return;
            string opGroup = Properties.Settings.Default.OP_GROUP.ToString();

            dtAndon = fnSearch("GET_ANDON_SOUND", Functions.plant_cd, opGroup, "", Functions.division);

            if (dtAndon != null && dtAndon.Rows.Count > 0 && !bwAndon.IsBusy)
            {
                var dt = dtAndon.AsEnumerable().Where(row => Convert.ToInt32(row.Field<string>("MACHINE_LINE")) >= Functions.lineFrom && Convert.ToInt32(row.Field<string>("MACHINE_LINE")) <= Functions.lineTo);

                if (!dt.Any())
                    return;
                loadBar.EditValue = 20;
                loadBar.Update();

                pnlAndon.Visible = true;
                timerBlink.Start();
                bwAndon.RunWorkerAsync();
            }
        }

        private void checkDirrect()
        {
            if (bwAndon.IsBusy)
                return;
            dtAndon = new DataTable();
            string sql = "SELECT * " +
                                                                    "        FROM (SELECT PLANT_CD, " + 
                                                                    "                     PLANT_BD_CD WH_CD, " + 
                                                                    "                     DECODE(A.ANDON_BUTTON_CD, " + 
                                                                    "                            1, " + 
                                                                    "                            'MAINTENANCE', " + 
                                                                    "                            2, " + 
                                                                    "                            'TIM LEADER', " + 
                                                                    "                            3, " + 
                                                                    "                            'QUALITY') SOUND_DIVISION, " + 
                                                                    "                     ANDON_SEQ WO_NO, " + 
                                                                    "                     TO_CHAR(TO_NUMBER(A.LINE_CD)) AS MACHINE_LINE, " + 
                                                                    "                     TO_CHAR(A.LOC_SEQ) MACHINE_NO, " + 
                                                                    "                     A.ANNOUNCE_YN STATUS_YN, " + 
                                                                    "                     '' DIVISION_TYPE, " + 
                                                                    "                     A.EXTRA1_FLD SOUND_AREA_NM, " +
                                                                    "                     A.EXTRA2_FLD SOUND_AREA_YN, " +
                                                                    "                     START_DT UPDATE_DT" + 
                                                                    "                FROM MSPD_ANDON_DATA A " + 
                                                                    "               WHERE A.PLANT_CD = '" + Functions.plant_cd + "'" + 
                                                                    "                 AND A.PLANT_BD_CD = '" + Properties.Settings.Default.PLANT_BD_CD +  "'" +
                                                                    "                 AND A.OP_GROUP IN  (SELECT REGEXP_SUBSTR(STR, '[^,]+', 1, LEVEL) VALUE " +
                                                                    " FROM (SELECT '" +  Properties.Settings.Default.OP_GROUP + "' AS STR FROM DUAL) " +
                                                                    " CONNECT BY LEVEL <= LENGTH(STR) - LENGTH(REPLACE(STR, ',')) + 1) " +
                                                                    "                 AND A.ANDON_DATE = '" + DateTime.Today.ToString("yyyyMMdd") + "'" +
                                                                    "                 AND A.ANNOUNCE_YN = 'N') ORDER BY UPDATE_DT";
            myDataAdapter = new Devart.Data.Oracle.OracleDataAdapter(sql, myConnection);
            myDataAdapter.Fill(dtAndon);
            if (dtAndon.Rows.Count > 0)
            {
                if (dtAndon != null && dtAndon.Rows.Count > 0 && !bwAndon.IsBusy)
                {
                    var dt = dtAndon.AsEnumerable().Where(row => Convert.ToInt32(row.Field<string>("MACHINE_LINE")) >= Functions.lineFrom && Convert.ToInt32(row.Field<string>("MACHINE_LINE")) <= Functions.lineTo);

                    if (!dt.Any())
                        return;
                    loadBar.EditValue = 20;
                    loadBar.Update();

                    pnlAndon.Visible = true;
                    timerBlink.Start();
                    bwAndon.RunWorkerAsync();
                }
            }
        }

        private void bwAndon_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                callSound(dtAndon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Showing Andon Error : " + ex.ToString(), "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void callSound(DataTable dtParam)
        {
            var dt = dtParam.AsEnumerable().Where(row => Convert.ToInt32(row.Field<string>("MACHINE_LINE")) >= Functions.lineFrom && Convert.ToInt32(row.Field<string>("MACHINE_LINE")) <= Functions.lineTo);

            dtParam = dt.CopyToDataTable();

            if (dtParam != null && dtParam.Rows.Count > 0)
            {
                foreach (DataRow row in dtParam.Rows)
                {
                    //if (
                    //    (Convert.ToInt16(row["MACHINE_LINE"]) >= Functions.lineFrom && Convert.ToInt16(row["MACHINE_LINE"]) <= Functions.lineTo
                    //    && Convert.ToInt16(row["MACHINE_NO"]) >= Functions.mcFrom && Convert.ToInt16(row["MACHINE_NO"]) <= Functions.mcTo)
                    //    || (
                    //        Convert.ToInt16(row["MACHINE_NO"]) == 98 || Convert.ToInt16(row["MACHINE_NO"]) == 99 || Convert.ToInt16(row["MACHINE_NO"]) == 100
                    //        )
                    //    )
                    {
                        andonLine = row["MACHINE_LINE"].ToString().PadLeft(2, '0');
                        andonMC = row["MACHINE_NO"].ToString().PadLeft(2, '0');
                        andonTitle = row["SOUND_DIVISION"].ToString() + (row["SOUND_AREA_YN"].ToString() == "Y" ? "  " + row["SOUND_AREA_NM"].ToString() : "");

                        for (int i = 0; i < Functions.repeat; i++)
                        {
                            playSound(Convert.ToInt16(row["MACHINE_LINE"]), Convert.ToInt16(row["MACHINE_NO"]), row["SOUND_DIVISION"].ToString(), row["SOUND_AREA_NM"].ToString(), (i == 0 ? true : false), (i == Functions.repeat - 1 ? true : false), (row["SOUND_AREA_YN"].ToString() == "Y" ? true : false));
                        }

                        if (fn_Save("UPDATE_SOUND", Functions.plant_cd, Properties.Settings.Default.OP_GROUP , row["WO_NO"].ToString(), row["WO_NO"].ToString()) == false)
                        {
                            //==> FAILED SAVE DATA
                            if (Properties.Settings.Default.DIRECT_CONNECT_YN == "Y")
                            {
                                string sql = "UPDATE MSPD_ANDON_DATA A SET A.ANNOUNCE_YN='Y', A.ANNOUNCE_DT=SYSDATE " +
                                           "       WHERE A.PLANT_CD  = '" + Functions.plant_cd + "'  " +
                                           "       AND A.PLANT_BD_CD = '" + Properties.Settings.Default.PLANT_BD_CD + "' " +
                                           "       AND A.ANNOUNCE_YN = 'N' " +
                                           "       AND A.OP_GROUP IN  (SELECT REGEXP_SUBSTR(STR, '[^,]+', 1, LEVEL) VALUE " +
                                           " FROM (SELECT '" +  Properties.Settings.Default.OP_GROUP + "' AS STR FROM DUAL) " +
                                           " CONNECT BY LEVEL <= LENGTH(STR) - LENGTH(REPLACE(STR, ',')) + 1) " +
                                           "       AND A.ANDON_SEQ   = '" + row["WO_NO"].ToString() + "'";

                                
                                if (myConnection.State != ConnectionState.Open)
                                {
                                    myConnection.Open();
                                }

                                myCommand = new Devart.Data.Oracle.OracleCommand(sql, myConnection);
                                myCommand.ExecuteNonQuery();

                                if (myConnection.State != ConnectionState.Closed)
                                {
                                    myConnection.Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void playSound(int param_line, int param_mc_no, string param_division, string param_division_area, bool param_open = false, bool param_close = false, bool call_area_yn = false )
        {
            SoundPlayer player;

            if (param_open)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("open"));
                player.PlaySync();
            }

            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("panggilan"));
            player.PlaySync();

            //--> MAINTENANCE / TEAM LEADER / QUALITY
            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject(param_division.ToLower().Replace(' ', '_')));
            player.PlaySync();
            
            //--> PROCESS AREA
            if (call_area_yn == true )
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject(param_division_area.ToLower()));
                player.PlaySync();
            }

            //--> LINE
            if (param_mc_no != 100)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("line"));
                player.PlaySync();

                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_line));
                player.PlaySync();
            }

            //--> ZONA/LOKASI
            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("zona"));
            player.PlaySync();

            //player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("mesin"));
            //player.PlaySync();

            if (param_mc_no != 98 && param_mc_no != 99 && param_mc_no != 100)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_mc_no));
                player.PlaySync();
            }

            if (param_mc_no == 98 || param_mc_no == 99 || param_mc_no == 100)
            {
                if (param_mc_no == 98)
                {
                    player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("cutting"));
                    player.PlaySync();
                }
                else
                    if (param_mc_no == 99)
                    {
                        player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("trimming"));
                        player.PlaySync();
                    }
                    else
                        if (param_mc_no == 100)
                        {
                            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("hii_ter"));
                            player.PlaySync();

                            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_line));
                            player.PlaySync();
                        }
            }

            if (param_close)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("close"));
                player.PlaySync();
            }
        }

        private void bwAndon_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                pnlAndon.Visible = false;
                timerBlink.Stop();
                zz = 0;
                lblAndonLineVal.Text = "";
                lblAndonMCVal.Text = "";

                setLayout();

                //dtAndon.Clear();
                //dtAndon.Dispose();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                bwAndon.Dispose();
                loadBar.EditValue = 0;
                loadBar.Update();
            }
        }

        int zz = 0;

        private void timerBlink_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            lblAndonLineVal.Text = andonLine;
            lblAndonMCVal.Text = (andonMC == "98" ? "CUT" : (andonMC == "99" ? "TRIM" : (andonMC == "100" ? "HEAT" : andonMC)));

            lblAndonLine.Text = (andonMC == "100" ? "NO" : "LINE");
            lblAndonTitle.Text = andonTitle;

            if (zz % 2 == 1)
            {
                //lblAndonLineVal.BackColor = Color.Red;
                pnlLine.BackgroundImage = Properties.Resources.Picture8;
                lblAndonLineVal.ForeColor = Color.White;
                //lblAndonMCVal.BackColor = Color.Yellow;
                pnlMC.BackgroundImage = Properties.Resources.Picture9;
                lblAndonMCVal.ForeColor = Color.Black;
                //lblAndonTitle.BackColor = Color.FromArgb(195, 215, 245);
                pnlAndonTitle.BackgroundImage = Properties.Resources.Picture6;
            }
            else
            {
                //lblAndonLineVal.BackColor = Color.Yellow;
                pnlLine.BackgroundImage = Properties.Resources.Picture9;
                lblAndonLineVal.ForeColor = Color.Black;
                //lblAndonMCVal.BackColor = Color.Red;
                pnlMC.BackgroundImage = Properties.Resources.Picture8;
                lblAndonMCVal.ForeColor = Color.White;
                //lblAndonTitle.BackColor = Color.Goldenrod;
                pnlAndonTitle.BackgroundImage = Properties.Resources.Picture7;
            }
            zz++;
        }

        private void setLayout()
        {
            try
            {
                loadBar.EditValue = 20;
                loadBar.Update();

                timerCheckAndon.Stop();

                dtGet = new DataTable();

                dtGet = fnSearch("GET_LAYOUT", Functions.plant_cd, Functions.item_class, "", Functions.division);

                loadBar.EditValue = 50;
                loadBar.Update();

                if (dtGet != null)
                {
                    grdCtrl.DataSource = dtGet;

                    Application.DoEvents();

                    fn_FormatGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Administrator");
            }
            finally
            {
                lblLasUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");
                timerRefresh.Stop();
                timerRefresh.Start();
                timerCheckAndon.Start();
                loadBar.EditValue = 0;
                loadBar.Update();
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            setLayout();
        }

        private void lblAndonTitle_Click(object sender, EventArgs e)
        {

        }

        private void FrmAndonOSP_Resize(object sender, EventArgs e)
        {
            //MessageBox.Show("Form Resized", "Administrator");
            if (this.WindowState == FormWindowState.Maximized)
            {
                setLayout();
                pnlAndon.Location = new Point((this.ClientSize.Width - pnlAndon.Width) / 2, ((this.ClientSize.Height - pnlAndon.Height) / 2) + 20);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            timerRefresh_Tick(null, null);
        }

        private void bwAndon_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadBar.EditValue = e.ProgressPercentage;
            loadBar.Update();
        }

        private void tmrSwitch_Tick(object sender, EventArgs e)
        {
            if (intSwitch == 0)
            {
                intSwitch = 1;
                andonStatus1.BringToFront();
                pnlAndon.BringToFront();
            }
            else
            {
                intSwitch = 0;
                grdCtrl.BringToFront();
                pnlAndon.BringToFront();
            }
        }

        private void tmrGate_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.DIRECT_GATE_YN == "Y")
                {
                    if (status_response == true)
                    {
                        saveAndon();
                    }
                }

                //==> CEK CONNECTION PORT
                if (Properties.Settings.Default.DIRECT_GATE_YN == "Y")
                {
                    if (serialPortGate.IsOpen)
                    {
                        labelControl1.Text = Properties.Settings.Default.GATE_COM + " connected";
                    }
                    else
                    {
                        portConnected();
                    }
                }
            }
            catch
            {
                portConnected();
            }
            
        }

        private void portConnected()
        {
            try
            {
                if (Properties.Settings.Default.DIRECT_GATE_YN == "Y")
                {
                    if (!serialPortGate.IsOpen)
                    {
                        serialPortGate.PortName = Properties.Settings.Default.GATE_COM;
                        serialPortGate.BaudRate = Properties.Settings.Default.GATE_BAUDRATE;
                        serialPortGate.Open();
                    }
                    try
                    {
                        if (serialPortGate.IsOpen)
                        {
                            labelControl1.Text = Properties.Settings.Default.GATE_COM + " Connected";
                            tmrGate.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        labelControl1.Text = Properties.Settings.Default.GATE_COM + " not connected";
                    }
                }
                else
                {
                    tmrGate.Enabled = false;
                    labelControl1.Text = "-";
                }
            }
            catch
            {
                labelControl1.Text = Properties.Settings.Default.GATE_COM + " not connected"; ;
            }
        }

        private void saveAndon()
        {
            try
            {
                string id_andon = "";
                string problem_andon = "";
                string status_andon = "";
                string waktu_andon = "";

                hasilsplit = hasil_data.Split(';');

                id_andon = hasilsplit[1];
                problem_andon = hasilsplit[2];
                status_andon = hasilsplit[3];
                waktu_andon = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                //--> ORI
                //if (problem_andon == "1")
                //{ problem_andon = "material"; } --> HIJAU
                //else if (problem_andon == "2")
                //{ problem_andon = "mesin"; }
                //else if (problem_andon == "3")
                //{ problem_andon = "leader"; }   --> MERAH

                if (status_andon == "1")
                { status_andon = "panggil"; }
                else if (status_andon == "2")
                { status_andon = "perbaikan"; }
                else if (status_andon == "0")
                { status_andon = "selesai"; }

                lblStatus.Text = "Received (BTN=" + id_andon.ToUpper() + ";PRB=" + problem_andon.ToUpper() + ";STS=" + status_andon.ToUpper() + ")";

                DataTable dResult = new DataTable();
                //==> SELECT MSPD_ANDON_SAVE_V2('" & id_andon.ToUpper() & "','" & problem_andon.ToUpper() & "','" & status_andon.ToUpper() & "','" & waktu_andon & "') FROM DUAL
                dResult = fn_Save_andon(id_andon.ToUpper(), problem_andon.ToUpper(), status_andon.ToUpper(), waktu_andon);

                if (dResult == null)
                {
                    if (Properties.Settings.Default.DIRECT_CONNECT_YN == "Y")
                    {
                        //==> FAILED SAVE DATA
                        if (myConnection.State != ConnectionState.Open)
                        {
                            myConnection.Open();
                        }

                        dResult = new DataTable();
                        myDataAdapter = new Devart.Data.Oracle.OracleDataAdapter("SELECT MSPD_ANDON_SAVE('" + id_andon.ToUpper() + "','" + problem_andon.ToUpper() + "','" + status_andon.ToUpper() + "','" + waktu_andon + "') FROM DUAL", myConnection);
                        myDataAdapter.Fill(dResult);
                        if (dResult.Rows.Count > 0)
                        {
                            checkDirrect();
                            lblStatus.Text = "Received (BTN=" + id_andon.ToUpper() + ";PRB=" + problem_andon.ToUpper() + ";STS=" + status_andon.ToUpper() + ")..";
                        }

                        if (myConnection.State != ConnectionState.Closed)
                        {
                            myConnection.Close();
                        }
                    }
                }
                else
                {
                    lblStatus.Text = "Received (BTN=" + id_andon.ToUpper() + ";PRB=" + problem_andon.ToUpper() + ";STS=" + status_andon.ToUpper() + ").";
                    refreshData(status_andon);
                }
            }
            catch (Exception e)
            {
                labelControl1.Text = e.Message;
            }
        }

        private void refreshData(string statusAndon)
        {
            if (statusAndon == "panggil")
            {
                checkAndon();
            }
            else
            {
                setLayout();
            }

            grdCtrl.BringToFront();
            pnlAndon.BringToFront();

            status_response = false;
        }

        private void serialPortGate_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPortGate.IsOpen)
            {
                hasil_data = serialPortGate.ReadLine();
                status_response = true;
            }
        }

        //==> SOCKET SERVER
        //public void ExecuteServer()
        //{
        //    // Establish the local endpoint
        //    // for the socket. Dns.GetHostName
        //    // returns the name of the host
        //    // running the application.
        //    IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
        //    IPAddress ipAddr = ipHost.AddressList[0];
        //    IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

        //    // Creation TCP/IP Socket using
        //    // Socket Class Constructor
        //    Socket listener = new Socket(ipAddr.AddressFamily,
        //                 SocketType.Stream, ProtocolType.Tcp);

        //    try
        //    {

        //        // Using Bind() method we associate a
        //        // network address to the Server Socket
        //        // All client that will connect to this
        //        // Server Socket must know this network
        //        // Address
        //        listener.Bind(localEndPoint);

        //        // Using Listen() method we create
        //        // the Client list that will want
        //        // to connect to Server
        //        listener.Listen(10);

        //        while (true)
        //        {

        //            Console.WriteLine("Waiting connection ... ");

        //            // Suspend while waiting for
        //            // incoming connection Using
        //            // Accept() method the server
        //            // will accept connection of client
        //            Socket clientSocket = listener.Accept();

        //            // Data buffer
        //            byte[] bytes = new Byte[1024];
        //            string data = null;

        //            while (true)
        //            {

        //                int numByte = clientSocket.Receive(bytes);

        //                data += Encoding.ASCII.GetString(bytes,
        //                                           0, numByte);

        //                if (data.IndexOf("<EOF>") > -1)
        //                {
        //                    labelControl1.Text = "received " + data;
        //                    checkAndon();
        //                    break;
        //                }
        //            }

        //            //Console.WriteLine("Text received -> {0} ", data);
        //            //byte[] message = Encoding.ASCII.GetBytes("Test Server");

        //            //// Send a message to Client
        //            //// using Send() method
        //            //clientSocket.Send(message);

        //            // Close client Socket using the
        //            // Close() method. After closing,
        //            // we can use the closed Socket
        //            // for a new Client Connection
        //            clientSocket.Shutdown(SocketShutdown.Both);
        //            clientSocket.Close();
        //        }
        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //}
    }
}
