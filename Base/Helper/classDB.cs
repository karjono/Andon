using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Base.Helper
{
    public class classDB
    {
        public static WebServices.JJWebService webServices = new WebServices.JJWebService();

        public DataSet DS_SetParam = new DataSet("Set Parameter");
        public DataSet DS_Return = new DataSet("Return value");

        public dynamic[] Set_Parameter_Name;
        public dynamic[] Set_Parameter_Type;
        public dynamic[] Set_Parameter_Value;

        public void Set_Parameter(int inc)
        {
            Set_Parameter_Name = new dynamic[inc];
            Set_Parameter_Type = new dynamic[inc];
            Set_Parameter_Value = new dynamic[inc];
        }

        public classDB()
        {
            webServices.Timeout = System.Threading.Timeout.Infinite;
        }

        #region LMES Service
        //FIX
        public DataSet LMES_Pkg_Select_ds(string ProcName, bool ShowMsg = true)
        {
            try
            {
                DS_Return = webServices.LMES_Pkg_Select_Ds(ProcName, Set_Parameter_Name, Set_Parameter_Type, Set_Parameter_Value);
                if (DS_Return == null)
                {
                    //LogError(ShowMsg);
                    return null;
                }
                else
                    return DS_Return;
            }
            catch (Exception ex)
            {
                //LogError(ex, ShowMsg);
                return null;
            }
        }

        //FIX
        public DataTable LMES_Pkg_Select_Dt(string ProcName, bool ShowMsg = true)
        {
            try
            {
                DS_Return = webServices.LMES_Pkg_Select_Ds(ProcName, Set_Parameter_Name, Set_Parameter_Type, Set_Parameter_Value);
                if (DS_Return == null)
                {
                    //LogError(ShowMsg);
                    return null;
                }
                else
                    return DS_Return.Tables[0];

            }
            catch (Exception ex)
            {
                //LogError(ex, ShowMsg);
                return null;
            }
        }

        //FIX
        public DataTable LMES_Query_Select_Dt(string Query, bool ShowMsg = true)
        {
            try
            {
                DS_Return = webServices.LMES_Query_Select_Ds(Query);
                if (DS_Return == null)
                {
                    //LogError(ShowMsg);
                    return null;
                }
                else
                    return DS_Return.Tables[0];
            }
            catch (Exception ex)
            {
                //LogError(ex, ShowMsg);
                return null;
            }
        }

        //FIX
        public bool LMES_Query_Execute(string[] Query, bool ShowMsg = true)
        {
            try
            {
                bool tmp = webServices.LMES_Query_Modify(Query);
                if (tmp == false)
                {
                    //LogError(ShowMsg);
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                //LogError(ex, ShowMsg);
                return false;
            }
        }

        //FIX
        public dynamic LMES_Pkg_Get_Value(string ProcName, int index, bool ShowMsg = true)
        {
            try
            {
                dynamic tmp = null;
                DataTable DtTmp;
                DtTmp = LMES_Pkg_Select_Dt(ProcName);

                if (DtTmp == null)
                {
                    //LogError(ShowMsg);
                    return null;
                }
                else
                {
                    foreach (DataRow row in DtTmp.Rows)
                    {
                        tmp = row[index];
                    }
                    return tmp;
                }

            }
            catch (Exception ex)
            {
                //LogError(ex, ShowMsg);
                return null;
            }
        }

        //FIX
        public bool LMES_Pkg_Modify(string ProcName, bool ShowMsg = true)
        {
            try
            {
                bool tmp = webServices.LMES_Pkg_Modify(ProcName, Set_Parameter_Name, Set_Parameter_Type, Set_Parameter_Value);
                if (tmp == false)
                {
                    //LogError(ShowMsg);
                    return false;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                //LogError(ex, ShowMsg);
                return false;
            }
        }

        //FIX
        public dynamic LMES_Query_GetValue(string query)
        {
            try
            {
                return webServices.LMES_Query_GetValue(query);
            }
            catch (Exception ex)
            {
                //LogError(ex, false);
                return null;
            }
        }

        #endregion
    }
}
