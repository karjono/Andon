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

namespace Andon
{
    public partial class FrmAndonSmart2 : FrmBase
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

        public FrmAndonSmart2(int int_idx = 0)
        {
            InitializeComponent();
            this.idx_form = int_idx;
            Functions.AddFontResource(Application.StartupPath + "\\digital-7.ttf");
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
                ClsDB.Set_Parameter_Name[i++] = "V_P_ITEM_CLASS_TYPE";
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
                ClsDB.Set_Parameter_Value[i++] = Properties.Settings.Default.OP_GROUP ;
                ClsDB.Set_Parameter_Value[i++] = param5;
                ClsDB.Set_Parameter_Value[i++] = Properties.Settings.Default.LINE_CD ;
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
            string OP_GROUP    = Properties.Settings.Default.OP_GROUP;

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

            if (ClsDB.LMES_Pkg_Modify("PKG_MSPD_ANDON.UPDATE_ANDON_SOUND"))
                return true;
            else
                return false;
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
                gvwData.Columns[0].Caption = "No"; gvwData.Columns[0].Width = 100;
                gvwData.Columns[1].Caption = "Proc";
                gvwData.Columns[2].Caption = "Div";
                gvwData.Columns[3].Caption = "Start";
                gvwData.Columns[3].AppearanceHeader.BackColor = Color.LightGreen; 
                gvwData.Columns[3].AppearanceHeader.BackColor2 = Color.LightGreen;
                gvwData.Columns[4].Caption = "Arrive"; 
                gvwData.Columns[4].AppearanceHeader.BackColor = Color.PeachPuff;
                gvwData.Columns[4].AppearanceHeader.BackColor2 = Color.PeachPuff;
                gvwData.Columns[5].Caption = "Hour";
                gvwData.Columns[5].AppearanceHeader.BackColor = Color.PeachPuff;
                gvwData.Columns[5].AppearanceHeader.BackColor2 = Color.PeachPuff;
                gvwData.Columns[6].Caption = "Finish"; 

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
            if (bwAndon.IsBusy)
                return;

            dtAndon = fnSearch("GET_ANDON_SOUND", Functions.plant_cd, Functions.item_class, "", Functions.division);

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
                    if (
                        (Convert.ToInt16(row["MACHINE_LINE"]) >= Functions.lineFrom && Convert.ToInt16(row["MACHINE_LINE"]) <= Functions.lineTo
                        && Convert.ToInt16(row["MACHINE_NO"]) >= Functions.mcFrom && Convert.ToInt16(row["MACHINE_NO"]) <= Functions.mcTo)
                        || (
                            Convert.ToInt16(row["MACHINE_NO"]) == 98 || Convert.ToInt16(row["MACHINE_NO"]) == 99 || Convert.ToInt16(row["MACHINE_NO"]) == 100
                            )
                        )
                    {
                        andonLine = row["MACHINE_LINE"].ToString().PadLeft(2, '0');
                        andonMC = row["MACHINE_NO"].ToString().PadLeft(2, '0');
                        andonTitle = row["SOUND_DIVISION"].ToString() + (row["SOUND_DIVISION"].ToString() == "MAINTENANCE" && row["DIVISION_TYPE"].ToString() != "UMUM" ? "  " + row["DIVISION_TYPE"].ToString() : "");

                        for (int i = 0; i < Functions.repeat; i++)
                        {
                            playSound(Convert.ToInt16(row["MACHINE_LINE"]), Convert.ToInt16(row["MACHINE_NO"]), row["SOUND_DIVISION"].ToString(), row["DIVISION_TYPE"].ToString(), (i == 0 ? true : false), (i == Functions.repeat - 1 ? true : false));
                        }
                        fn_Save("UPDATE_SOUND", Functions.plant_cd, Functions.item_class, row["WO_NO"].ToString(), row["WO_NO"].ToString());
                    }
                }

                

                ////UPDATE SOUND YN
                //string wo_no = "";
                //foreach (DataRow row in dtParam.Rows)
                //{
                //    if (
                //        Convert.ToInt16(row["MACHINE_LINE"]) >= Functions.lineFrom && Convert.ToInt16(row["MACHINE_LINE"]) <= Functions.lineTo
                //        && Convert.ToInt16(row["MACHINE_NO"]) >= Functions.mcFrom && Convert.ToInt16(row["MACHINE_NO"]) <= Functions.mcTo
                //        || (
                //            Convert.ToInt16(row["MACHINE_NO"]) == 98 || Convert.ToInt16(row["MACHINE_NO"]) == 99 || Convert.ToInt16(row["MACHINE_NO"]) == 100
                //            )
                //       )
                //    {
                //        wo_no += row["WO_NO"].ToString() + "|";
                //    }
                //}

                //if (wo_no.Length > 0)
                //{
                //    wo_no = wo_no.Remove(wo_no.Length - 1, 1);
                //    fn_Save("UPDATE_SOUND", Functions.plant_cd, Functions.item_class, wo_no, "Y");
                //}
            }
        }
        private void playSound(int param_line, int param_mc_no, string param_division, string param_division_type, bool param_open = false, bool param_close = false)
        {
            SoundPlayer player;

            if (param_open)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("open"));
                player.PlaySync();
            }

            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("panggilan"));
            player.PlaySync();

            //--> MAINTENANCE/TEAM LEADER/QUALITY
            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject(param_division.ToLower().Replace(' ', '_' )));
            player.PlaySync();

            //--> 
            //if (param_division == "MAINTENANCE" && param_division_type != "UMUM")
            //{
            //    player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject(param_division_type.ToLower()));
            //    player.PlaySync();
            //}

            // LINE
            if (param_mc_no != 100)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("line"));
                player.PlaySync();

                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_line));
                player.PlaySync();
            }
            //ZONA/LOKASI
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

                //lblDone.Text = "0";
                //lblRepair.Text = "0";
                //lblBreakdown.Text = "0";
                //lblB.Text = "0";
                //lblNotConfirm.Text = "0";
                //lblValTotal.Text = "0";

                dtGet = new DataTable();

                dtGet = fnSearch("GET_LAYOUT", Functions.plant_cd, Functions.item_class, "", Functions.division);

                loadBar.EditValue = 50;
                loadBar.Update();

                if (dtGet != null )
                {
                    grdCtrl.DataSource = dtGet;

                    Application.DoEvents();

                    fn_FormatGrid();
                }
                
                //setGrid(grdCtrl, gvwData, null);

                //if (dtGet != null && dtGet.Rows.Count > 0)
                //{
                //    var dt = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "DATA");
                //    var onoff = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SET_ON_OFF");
                //    var cis = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SET_CIS");

                //    if (dt.Any())
                //    {
                //        dtLayout = dt.CopyToDataTable();
                //        setGrid(grdCtrl, gvwData, dtLayout);
                //        fn_FormatGrid();

                //        loadBar.EditValue = 75;
                //        loadBar.Update();

                //        var done = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("1") == "F");
                //        var repair = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("1") == "C");
                //        var breakdown = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("1") == "R");
                //        var black = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("1").Contains("B"));
                //        var notConfirm = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("1").Contains("D"));

                //        lblDone.Text = (done.Any() ? done.CopyToDataTable().Rows[0]["2"].ToString() : "0");
                //        lblRepair.Text = (repair.Any() ? repair.CopyToDataTable().Rows[0]["2"].ToString() : "0");
                //        lblBreakdown.Text = (breakdown.Any() ? breakdown.CopyToDataTable().Rows[0]["2"].ToString() : "0");
                //        lblB.Text = (black.Any() ? black.CopyToDataTable().Rows[0]["2"].ToString() : "0");
                //        lblNotConfirm.Text = (notConfirm.Any() ? notConfirm.CopyToDataTable().Rows[0]["2"].ToString() : "0");
                //        lblValTotal.Text = (Convert.ToInt32(lblBreakdown.Text) + Convert.ToInt32(lblRepair.Text) + Convert.ToInt32(lblB.Text) + Convert.ToInt32(lblNotConfirm.Text)).ToString();
                //    }
                //    else
                //        return;

                //    loadBar.EditValue = 100;
                //    loadBar.Update();

                //    if (onoff.Any())
                //    {
                //        dtOnOff.Clear();
                //        dtOnOff.Dispose();
                //        dtOnOff = onoff.CopyToDataTable();
                //    }
                //    else
                //        return;

                //    if (cis.Any())
                //    {
                //        dtCIS.Clear();
                //        dtCIS.Dispose();
                //        dtCIS = cis.CopyToDataTable();

                //        if (dtCIS == null)
                //            return;
                //        else
                //            fn_setHeaderColor();
                //    }

                //    dtGet.Clear();
                //    dtGet.Dispose();

                //    //dtLayout.Clear();
                //    //dtLayout.Dispose();
                //}
            }
            catch(Exception ex)
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

        private void lblAndonLine_Click(object sender, EventArgs e)
        {

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

        private void lblB_Click(object sender, EventArgs e)
        {

        }

        private void tmrTimeNow_Tick(object sender, EventArgs e)
        {

        }
    }
}
