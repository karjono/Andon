using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base;
using Base.Helper;
using System.Data.OracleClient;
using System.Media;
using System.IO;
using System.Threading;

namespace Andon
{
    public partial class FrmAndonOSR2 : FrmBase
    {
        public int idx_form;
        private string formTitle = "OUTSOLE ROLL";
        DataTable dtLayout = new DataTable();
        DataTable dtAndon = new DataTable();
        DataTable dtGet = new DataTable();
        DataTable dtAllLine = null;
        Base.Helper.classDB ClsDB = new Base.Helper.classDB();
        string andonLine = "0";
        string andonZone = "0";
        string andonTitle = "";
        string andonMC_Title = "";
        string andonOP_CD = "";
        bool form_load = false;

        public FrmAndonOSR2(int int_idx = 0)
        {
            InitializeComponent();
            this.idx_form = int_idx;
            Functions.CopyDependency(Application.StartupPath, "digital-7.ttf");
            Functions.AddFontResource(Application.StartupPath + "digital-7.ttf");
        }

        private void FrmAndonPlantC_Load(object sender, EventArgs e)
        {
            timerRefresh.Interval = Functions.refresh * 60000;
            Functions.Form_Maximized(this, this.idx_form);
            lblTitle1.Text = formTitle;
            int pictWidth = panel3.Width / 5;
            pnlLayout.Width = pictWidth;
            pnlBreakdown.Width = pictWidth;
            pnlUnderRepair.Width = pictWidth;
            pnlDone.Width = pictWidth;
            pnlD3.Width = pictWidth;

            pnlAndon.Location = new Point((this.ClientSize.Width - pnlAndon.Width) / 2, ((this.ClientSize.Height - pnlAndon.Height) / 2) + 20);
            pnlAndon.Visible = false;

            setContentLayout(this.layoutOSR, null);
            setLayout();

            timerRefresh.Enabled = true;
            timerRefresh.Start();

            form_load = true;
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
                ClsDB.Set_Parameter_Name[i++] = "V_P_LOCATION";
                ClsDB.Set_Parameter_Name[i++] = "V_P_AREA";
                ClsDB.Set_Parameter_Name[i++] = "V_P_DIVISION";
                ClsDB.Set_Parameter_Name[i++] = "V_P_MC_LINE";
                ClsDB.Set_Parameter_Name[i++] = "V_P_MC_NO";
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
                ClsDB.Set_Parameter_Value[i++] = param3;
                ClsDB.Set_Parameter_Value[i++] = param4;
                ClsDB.Set_Parameter_Value[i++] = param5;
                ClsDB.Set_Parameter_Value[i++] = param6;
                ClsDB.Set_Parameter_Value[i++] = param7;
                ClsDB.Set_Parameter_Value[i++] = param8;

                return ClsDB.LMES_Pkg_Select_Dt("PKG_JJ_ANDON.PLANT_C_Q");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Administrator");
                return null;
            }
        }

        private bool fn_Save(string p_action, string p_plant_cd, string p_location, string p_area, string p_wo_no = "", string p_status = "")
        {
            int i = 6;
            ClsDB.Set_Parameter(i);

            i = 0;
            ClsDB.Set_Parameter_Name[i++] = "V_P_ACTION";
            ClsDB.Set_Parameter_Name[i++] = "V_P_PLANT_CD";
            ClsDB.Set_Parameter_Name[i++] = "V_P_LOCATION";
            ClsDB.Set_Parameter_Name[i++] = "V_P_AREA";
            ClsDB.Set_Parameter_Name[i++] = "V_P_WO_NO";
            ClsDB.Set_Parameter_Name[i++] = "V_P_STATUS";

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
            ClsDB.Set_Parameter_Value[i++] = p_location;
            ClsDB.Set_Parameter_Value[i++] = p_area;
            ClsDB.Set_Parameter_Value[i++] = p_wo_no;
            ClsDB.Set_Parameter_Value[i++] = p_status;

            if (ClsDB.LMES_Pkg_Modify("PKG_JJ_ANDON.PLANT_C_S"))
                return true;
            else
                return false;
        }

        private void setLayout()
        {
            try
            {
                loadBar.EditValue = 20;
                loadBar.Update();

                timerCheckAndon.Stop();

                lblDone.Text = "0";
                lblRepair.Text = "0";
                lblBreakdown.Text = "0";
                lblB.Text = "0";
                lblNotConfirm.Text = "0";
                lblValTotal.Text = "0";

                dtGet = fnSearch("GET_LAYOUT_PLANT", Functions.plant_cd, Functions.location, Functions.area);

                loadBar.EditValue = 50;
                loadBar.Update();

                if (dtGet != null && dtGet.Rows.Count > 0)
                {
                    var dt = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "DATA");
                    
                    if (dt.Any())
                    {
                        dtLayout = dt.CopyToDataTable();

                        if (dtLayout != null && dtLayout.Rows.Count > 0)
                        {
                            setContentLayout(this.layoutOSR, dtLayout);
                        }

                        loadBar.EditValue = 75;
                        loadBar.Update();

                        var done = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("NEW_STATUS") == "F");
                        var repair = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("NEW_STATUS") == "C");
                        var breakdown = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("NEW_STATUS") == "R");
                        var black = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("NEW_STATUS").Contains("B"));
                        var notConfirm = dtGet.AsEnumerable().Where(row => row.Field<string>("DIV") == "SUMMARY" && row.Field<string>("NEW_STATUS").Contains("D"));

                        lblDone.Text = (done.Any() ? done.CopyToDataTable().Rows[0]["CONT"].ToString() : "0");
                        lblRepair.Text = (repair.Any() ? repair.CopyToDataTable().Rows[0]["CONT"].ToString() : "0");
                        lblBreakdown.Text = (breakdown.Any() ? breakdown.CopyToDataTable().Rows[0]["CONT"].ToString() : "0");
                        lblB.Text = (black.Any() ? black.CopyToDataTable().Rows[0]["CONT"].ToString() : "0");
                        lblNotConfirm.Text = (notConfirm.Any() ? notConfirm.CopyToDataTable().Rows[0]["CONT"].ToString() : "0");
                        lblValTotal.Text = (Convert.ToInt32(lblBreakdown.Text) + Convert.ToInt32(lblRepair.Text) + Convert.ToInt32(lblB.Text) + Convert.ToInt32(lblNotConfirm.Text)).ToString();
                    }
                    else
                        return;

                    loadBar.EditValue = 100;
                    loadBar.Update();

                    dtGet.Clear();
                    dtGet.Dispose();

                    //dtLayout.Clear();
                    //dtLayout.Dispose();
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

        private void setContentLayout(Control ctrl, DataTable dtTbl)
        {
            int chk = 0;
            int chk1 = 0;
            string val = "";
            int chk2 = 0;
            string str = "";
            List<Control> allControls = Functions.GetAllControls(ctrl);
            foreach (Control c in allControls)
            {
                if (c.Name.ToUpper().Contains("OSR_"))
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                }

                if (dtTbl != null && dtTbl.Rows.Count > 0)
                {
                    chk = c.Name.IndexOf("_") + 1;
                    chk1 = c.Name.IndexOf("_", chk) + 1;
                    str = c.Name.ToUpper().Substring(3, 3);
                    chk2 = c.Name.IndexOf("zone") + 4;

                    var dt = dtTbl.AsEnumerable().Where(row => row.Field<string>("OP_CD") == str
                                    && row.Field<string>("MACHINE_LINE") == c.Name.Substring(chk, 1)
                                    && row.Field<string>("MACHINE_SEQ") == c.Name.Substring(chk2, c.Name.Length - chk2)
                                    && row.Field<string>("DIVISION") == c.Name.Substring(chk1, 3)
                                    );

                    if (dt.Any())
                    {
                        c.Text = dt.CopyToDataTable().Rows[0]["CONT"].ToString();
                        val = dt.CopyToDataTable().Rows[0]["NEW_STATUS"].ToString();
                        c.Parent.Text = val.Substring(0, 1);

                        switch (val.Substring(val.Length - 1, 1))
                        {
                            case "R":
                                c.BackColor = Color.Red;
                                c.ForeColor = Color.White;
                                break;
                            case "C":
                                c.BackColor = Color.Yellow;
                                c.ForeColor = Color.Black;
                                break;
                            case "F":
                                c.BackColor = Color.LightGreen;
                                c.ForeColor = Color.Black;
                                break;
                            case "B":
                                c.BackColor = Color.Black;
                                c.ForeColor = Color.White;
                                break;
                            case "D":
                                c.BackColor = Color.Gold;
                                c.ForeColor = Color.Black;
                                break;
                        }
                    }
                }
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            setContentLayout(this.layoutOSR, null);
            setLayout();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            timerRefresh_Tick(null, null);
        }

        private void timerCheckAndon_Tick(object sender, EventArgs e)
        {
            if (bwAndon.IsBusy)
                return;

            dtAndon = fnSearch("GET_ANDON", Functions.plant_cd, Functions.location, Functions.area);

            if (dtAndon != null && dtAndon.Rows.Count > 0 && !bwAndon.IsBusy && form_load)
            {
                loadBar.EditValue = 20;
                loadBar.Update();

                pnlAndon.Visible = true;
                timerBlink.Start();
                bwAndon.RunWorkerAsync();
            }
        }

        private void callSound(DataTable dtParam)
        {
            //var dt = dtParam.AsEnumerable().Where(row => Convert.ToInt32(row.Field<string>("MACHINE_LINE")) >= Functions.lineFrom && Convert.ToInt32(row.Field<string>("MACHINE_LINE")) <= Functions.lineTo);

            //dtParam = dt.CopyToDataTable();

            if (dtParam != null && dtParam.Rows.Count > 0)
            {
                foreach (DataRow row in dtParam.Rows)
                {
                    //if (row["PLANT_CD"].ToString() == Functions.plant_cd && row["WH_CD"].ToString() == Functions.location && row["OP_CD"].ToString().Contains(Functions.area))
                    //{

                    if ((row["MACHINE_LINE"].ToString() == "1" && row["ZONE"].ToString() == "1") || (row["MACHINE_LINE"].ToString() == "2" && row["ZONE"].ToString() == "1"))
                    {
                        andonLine = "BANBURY " + row["MACHINE_LINE"].ToString();
                    }
                    else
                    if ((row["MACHINE_LINE"].ToString() == "1" || row["MACHINE_LINE"].ToString() == "2" || row["MACHINE_LINE"].ToString() == "3"))
                    {

                        if (row["MACHINE_LINE"].ToString() == "2" && row["ZONE"].ToString() == "4")
                        {
                            andonLine = "MIXING ROLL " + 3;
                        }
                        else
                        if (row["MACHINE_LINE"].ToString() == "3" && row["ZONE"].ToString() == "1")
                        {
                            andonLine = "MIXING ROLL " + 4;
                        }
                        else
                        if (row["MACHINE_LINE"].ToString() == "1" && row["ZONE"].ToString() == "4")
                        {
                            andonLine = "MINI CALENDAR " + 4;
                        }
                        else
                        if ((row["MACHINE_LINE"].ToString() == "1" || row["MACHINE_LINE"].ToString() == "2") && row["ZONE"].ToString() == "2")
                        {
                            andonLine = "MIXING ROLL " + row["MACHINE_LINE"].ToString();
                        }
                        else
                        if (row["ZONE"].ToString() == "3" || row["ZONE"].ToString() == "2")
                        {
                            andonLine = "RUBBER CALENDAR " + row["MACHINE_LINE"].ToString();
                        }
                        else
                        if ((row["MACHINE_LINE"].ToString() == "1" || row["MACHINE_LINE"].ToString() == "2") && row["ZONE"].ToString() == "5")
                        {
                            andonLine = "DUMPING ROLL " + row["MACHINE_LINE"].ToString();
                        }
                    }
                    else
                    if (row["MACHINE_LINE"].ToString() == "4" & (row["ZONE"].ToString() == "1" || row["ZONE"].ToString() == "3"))
                    {
                        andonLine = "KNEADER " + (row["ZONE"].ToString() == "1" ? "2" : "1");
                    }
                    else
                    if (row["MACHINE_LINE"].ToString() == "4" & (row["ZONE"].ToString() == "2" || row["ZONE"].ToString() == "4"))
                    {

                        andonLine = "ROLL EVA " + (row["ZONE"].ToString() == "4" ? "1" : row["ZONE"].ToString());
                    }
                    else
                    if (row["MACHINE_LINE"].ToString() == "4" & row["ZONE"].ToString() == "5")
                    {
                        andonLine = "EVA CALENDAR"; //+ (row["ZONE"].ToString() == "4" ? "1" : row["ZONE"].ToString());
                    }
                    else
                    if (row["MACHINE_LINE"].ToString() == "5")
                    {
                        andonLine = "MINI ROLL " + row["ZONE"].ToString();
                    }
                    else
                    if (row["MACHINE_LINE"].ToString() == "6")
                    {
                        andonLine = "CUTTING RUBBER " + row["ZONE"].ToString();
                    }

                    andonTitle = row["SOUND_DIVISION"].ToString() + (row["SOUND_DIVISION"].ToString() == "MAINTENANCE" && row["DIVISION_TYPE"].ToString() != "UMUM" ? "  " + row["DIVISION_TYPE"].ToString() : "");
                    andonOP_CD = row["OP_CD_NAME"].ToString();

                    for (int i = 0; i < Functions.repeat; i++)
                    {
                        playSound(row["OP_CD_NAME"].ToString(), Convert.ToInt16(row["MACHINE_LINE"]), Convert.ToInt16(row["ZONE"]), row["SOUND_DIVISION"].ToString(), row["DIVISION_TYPE"].ToString(), (i == 0 ? true : false), (i == Functions.repeat - 1 ? true : false));
                    }
                }

                //UPDATE SOUND YN
                string wo_no = "";
                foreach (DataRow row in dtParam.Rows)
                {
                    //if (
                    //    (row["PLANT_CD"].ToString() == Functions.plant_cd && row["WH_CD"].ToString() == Functions.location && row["OP_CD"].ToString().Contains(Functions.area))
                    //   )
                    //{
                        wo_no += row["WO_NO"].ToString() + "|";
                    //}
                }

                if (wo_no.Length > 0)
                {
                    wo_no = wo_no.Remove(wo_no.Length - 1, 1);
                    fn_Save("UPDATE_SOUND", Functions.plant_cd, Functions.location, Functions.area, wo_no, "Y");
                }
            }
        }

        private void playSound(string op_cd, int param_line, int param_mc_zone, string param_division, string param_division_type, bool param_open = false, bool param_close = false)
        {
            SoundPlayer player;

            if (param_open)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("open"));
                player.PlaySync();
            }

            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("panggilan"));
            player.PlaySync();

            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject(param_division.ToLower().Replace(' ', '_')));
            player.PlaySync();


            if (param_division == "MAINTENANCE" && param_division_type != "UMUM")
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject(param_division_type.ToLower()));
                player.PlaySync();
            }

            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("outsole"));
            player.PlaySync();

            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("roll"));
            player.PlaySync();

            player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("mesin"));
            player.PlaySync();

            if ((param_line == 1 && param_mc_zone == 1) || (param_line == 2 && param_mc_zone == 1))
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("banbury"));
                player.PlaySync();

                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_line));
                player.PlaySync();
            }
            else
            if (param_line == 1 || param_line == 2 || param_line == 3)
            {
                if (param_line == 1 && param_mc_zone == 4)
                {
                    player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("minicalendar"));
                    player.PlaySync();

                    player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_mc_zone));
                    player.PlaySync();
                }
                else
                if (((param_line == 1 || param_line == 2) && param_mc_zone == 2) || (param_line == 2 && param_mc_zone == 4) || (param_line == 3 && param_mc_zone == 1))
                {
                    player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("mixingroll"));
                    player.PlaySync();

                    if (param_line == 1 && param_mc_zone == 2)
                    {
                        player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + 1));
                        player.PlaySync();
                    }
                    else
                    if (param_line == 2 && param_mc_zone == 2)
                    {
                        player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + 2));
                        player.PlaySync();
                    }
                    else
                    if (param_line == 2 && param_mc_zone == 4)
                    {
                        player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + 3));
                        player.PlaySync();
                    }
                    else
                    if (param_line == 3 && param_mc_zone == 1)
                    {
                        player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + 4));
                        player.PlaySync();
                    }
                }
                else
                if ((param_line == 1 || param_line == 2) && param_mc_zone == 5)
                {
                    player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("dumpingroll"));
                    player.PlaySync();

                    player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_line));
                    player.PlaySync();
                    
                }
                else
                if (param_mc_zone == 3 || param_mc_zone == 2)
                {
                    player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("rubbercalendar"));
                    player.PlaySync();

                    player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_line));
                    player.PlaySync();
                }
            }
            else
            if (param_line == 4 & (param_mc_zone == 1 || param_mc_zone == 3))
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("kneader"));
                player.PlaySync();

                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + (param_mc_zone == 1 ? 2 : 1)));
                player.PlaySync();
            }
            else
            if (param_line == 4 & (param_mc_zone == 2 || param_mc_zone == 4))
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("rolleva"));
                player.PlaySync();

                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + (param_mc_zone == 4 ? 1 : param_mc_zone)));
                player.PlaySync();
            }
            else
            if (param_line == 4 & param_mc_zone == 5)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("evacalendar"));
                player.PlaySync();
            }
            else
            if (param_line == 5)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("miniroll"));
                player.PlaySync();

                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_mc_zone));
                player.PlaySync();

            }
            else
            if (param_line == 6)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("cuttingrubber"));
                player.PlaySync();

                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("_" + param_mc_zone));
                player.PlaySync();

            }

            if (param_close)
            {
                player = new SoundPlayer((Stream)Properties.Resources.ResourceManager.GetObject("close"));
                player.PlaySync();
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

        private void bwAndon_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadBar.EditValue = e.ProgressPercentage;
            loadBar.Update();
        }

        private void bwAndon_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                pnlAndon.Visible = false;
                timerBlink.Stop();
                zz = 0;
                lblAndonLineVal.Text = "";
                //lblAndonZoneVal.Text = "";

                setLayout();
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
            lblAndonLineVal.Text = andonLine;
            //lblAndonZoneVal.Text = andonZone;
            lblAndonTitle.Text = andonTitle;
            lblOP_CD.Text = andonOP_CD;
            //lblAndonMC.Text = andonMC_Title;


            if (zz % 2 == 1)
            {
                //lblAndonLineVal.BackColor = Color.Red;
                pnlLine.BackgroundImage = Properties.Resources.Picture8;
                lblAndonLineVal.ForeColor = Color.White;
                //lblAndonMCVal.BackColor = Color.Yellow;
                //pnlMC.BackgroundImage = Properties.Resources.Picture9;
                //lblAndonZoneVal.ForeColor = Color.Black;
                //lblAndonTitle.BackColor = Color.FromArgb(195, 215, 245);
                pnlAndonTitle.BackgroundImage = Properties.Resources.Picture6;
            }
            else
            {
                //lblAndonLineVal.BackColor = Color.Yellow;
                pnlLine.BackgroundImage = Properties.Resources.Picture9;
                lblAndonLineVal.ForeColor = Color.Black;
                //lblAndonMCVal.BackColor = Color.Red;
                //pnlMC.BackgroundImage = Properties.Resources.Picture8;
                //lblAndonZoneVal.ForeColor = Color.White;
                //lblAndonTitle.BackColor = Color.Goldenrod;
                pnlAndonTitle.BackgroundImage = Properties.Resources.Picture7;
            }
            zz++;
        }

        private void FrmAndonPlantC_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                if (form_load)
                    setLayout();

                pnlAndon.Location = new Point((this.ClientSize.Width - pnlAndon.Width) / 2, ((this.ClientSize.Height - pnlAndon.Height) / 2) + 20);
            }
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void lblAndonMC_Click(object sender, EventArgs e)
        {

        }

        private void lblNotConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
