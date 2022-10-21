using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Base.Helper;
using System.Reflection;
namespace Andon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Functions.readXML("App.xml");
                Assembly frmAssembly = Assembly.Load("JJ_Andon");

                foreach (Type type in frmAssembly.GetTypes())
                {
                    if (type.Name == Functions.formName)
                    {
                        Form frmshow = (Form)Activator.CreateInstance(type, Functions.monitor);
                        Application.Run(frmshow);
                    }
                }

                //Application.Run(new FrmAndonOSP());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
