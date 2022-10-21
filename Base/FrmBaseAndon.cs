using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Helper;

namespace Base
{
    public partial class FrmBaseAndon : Form
    {
        public static classDB connections = new classDB();

        public FrmBaseAndon()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            lblLasUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblIPAddress.Text = Functions.LocalIPAddress();

            lblDateNow.Text = DateTime.Now.ToString("yyyy-MM-dd");

            tmrTimeNow.Enabled = true;
            tmrTimeNow.Start();
        }

        private void pictClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picLogo_MouseDown(object sender, MouseEventArgs e)
        {
            fnDragDropForm(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            fnDragDropForm(e);
        }

        private void fnDragDropForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.SizeAll;
                Functions.ReleaseCapture();
                Functions.SendMessage(Handle, Functions.WM_NCLBUTTONDOWN, Functions.HT_CAPTION, 0);
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            this.Cursor = Cursors.Default;
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            fnDragDropForm(e);
        }

        private void lblTitle1_MouseDown(object sender, MouseEventArgs e)
        {
            fnDragDropForm(e);
        }

        private void tmrTimeNow_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("yyyy-MM-dd") != lblDateNow.Text.ToString())
                lblDateNow.Text = DateTime.Now.ToString("yyyy-MM-dd");

            lblTimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
