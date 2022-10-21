using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Xml;
namespace Base.Helper
{
    public class Functions
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int KEYEVENTF_EXTENDEDKEY = 0x1;
        public const int KEYEVENTF_KEYUP = 0x2;
        public static string formName = "";
        public static string plant_cd = "";
        public static string location = "";
        public static string area = "";
        public static string sound_yn = "";
        public static string item_class = "";
        public static string division = "";
        public static int monitor = 0;
        public static int times = 0;
        public static int repeat = 0;
        public static int lineFrom = 0;
        public static int lineTo = 0;
        public static int mcFrom = 0;
        public static int mcTo = 0;
        public static int refresh = 0;

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("kernel32.dll")]
        public static extern bool SetSystemTime(ref SYSTEMTIME st);

        [DllImport("gdi32.dll", EntryPoint = "AddFontResourceW", SetLastError = true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
                                         string lpFileName);

        public static void Form_Maximized(Form frm, int monitor)
        {
            int i = 0;
            foreach (Screen s in Screen.AllScreens)
            {
                if (i == monitor)
                {
                    frm.Location = s.Bounds.Location;
                    break;
                }
                i++;
            }

            if (monitor == 0)
            {
                frm.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            }

            frm.WindowState = FormWindowState.Maximized;
        }

        public static string LocalIPAddress()
        {
            string localIP = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        public static void readXML(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(fs);

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("formName"))
                {
                    formName = xmlnode.InnerText.ToString();
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("monitor"))
                {
                    int.TryParse(xmlnode.InnerText, out monitor);
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("plant_cd"))
                {
                    plant_cd = xmlnode.InnerText.ToString(); 
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("location"))
                {
                    location = xmlnode.InnerText.ToString();
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("area"))
                {
                    area = xmlnode.InnerText.ToString();
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("sound_yn"))
                {
                    sound_yn = xmlnode.InnerText.ToString();
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("times"))
                {
                    int.TryParse(xmlnode.InnerText, out times);
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("repeat"))
                {
                    int.TryParse(xmlnode.InnerText, out repeat);
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("line"))
                {
                    foreach (XmlElement xmllist in xmlnode.ChildNodes)
                    {
                        if (xmllist.Name == "from")
                            int.TryParse(xmllist.InnerText, out lineFrom);

                        if (xmllist.Name == "to")
                            int.TryParse(xmllist.InnerText, out lineTo);
                    }
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("machine"))
                {
                    foreach (XmlElement xmllist in xmlnode.ChildNodes)
                    {
                        if (xmllist.Name == "from")
                            int.TryParse(xmllist.InnerText, out mcFrom);

                        if (xmllist.Name == "to")
                            int.TryParse(xmllist.InnerText, out mcTo);
                    }
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("item_class"))
                {
                    item_class = xmlnode.InnerText.ToString();
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("division"))
                {
                    division = xmlnode.InnerText.ToString();
                }

                foreach (XmlNode xmlnode in xmldoc.GetElementsByTagName("refresh"))
                {
                    int.TryParse(xmlnode.InnerText, out refresh);
                }
            }
        }

        public static void WriteResourceToFile(string resourceName, string fileName)
        {
            using (var resource = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (var file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
        }

        public static void CopyDependency(string appPath, string param)
        {
            //if (System.IO.File.Exists(appPath + "\\" + param) == false)
            //{
            //    try
            //    {
            //        var resourceName = Assembly.GetExecutingAssembly().GetManifestResourceNames().Single(str => str.EndsWith(param));
            //        WriteResourceToFile(resourceName, appPath + "\\" + param);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Error accessing resources!");
            //    }
            //}

            //if (System.IO.File.Exists(Application.StartupPath + "\\digital-7.ttf") == false)
            //{
            //    try
            //    {
            //        var resourceName = Assembly.GetExecutingAssembly().GetManifestResourceNames().Single(str => str.EndsWith("digital-7.ttf"));
            //        WriteResourceToFile(resourceName, Application.StartupPath + "\\digital-7.ttf");
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Error accessing resources!");
            //    }
            //}
        }

        public static List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }

        public static List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }
    }
}
