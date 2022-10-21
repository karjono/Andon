namespace Base
{
    partial class FrmBaseAndon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseAndon));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblTitle1 = new DevExpress.XtraEditors.LabelControl();
            this.pictClose = new DevExpress.XtraEditors.PictureEdit();
            this.pictMinimize = new DevExpress.XtraEditors.PictureEdit();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.lblLasUpdate = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lblIPAddress = new DevExpress.XtraEditors.LabelControl();
            this.loadBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tmrTimeNow = new System.Windows.Forms.Timer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinimize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Location = new System.Drawing.Point(84, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 53);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "JJ ANDON - ";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.lblDateNow);
            this.panel1.Controls.Add(this.lblTimeNow);
            this.panel1.Controls.Add(this.lblTitle1);
            this.panel1.Controls.Add(this.pictClose);
            this.panel1.Controls.Add(this.pictMinimize);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 55);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(1318, 34);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 17);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "v 1.4";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackgroundImage = global::Base.Properties.Resources.refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(1129, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 38);
            this.btnRefresh.TabIndex = 7;
            // 
            // lblDateNow
            // 
            this.lblDateNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNow.Location = new System.Drawing.Point(1188, 25);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(94, 21);
            this.lblDateNow.TabIndex = 6;
            this.lblDateNow.Text = "2021-06-08";
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNow.Location = new System.Drawing.Point(1197, 4);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(72, 21);
            this.lblTimeNow.TabIndex = 5;
            this.lblTimeNow.Text = "08:08:00";
            // 
            // lblTitle1
            // 
            this.lblTitle1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblTitle1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle1.Location = new System.Drawing.Point(245, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(815, 53);
            this.lblTitle1.TabIndex = 4;
            this.lblTitle1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle1_MouseDown);
            // 
            // pictClose
            // 
            this.pictClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictClose.EditValue = global::Base.Properties.Resources.icon_close_48px;
            this.pictClose.Location = new System.Drawing.Point(1327, 1);
            this.pictClose.Name = "pictClose";
            this.pictClose.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictClose.Properties.Appearance.Options.UseBackColor = true;
            this.pictClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictClose.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pictClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictClose.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictClose.Size = new System.Drawing.Size(31, 24);
            this.pictClose.TabIndex = 2;
            this.pictClose.Click += new System.EventHandler(this.pictClose_Click);
            // 
            // pictMinimize
            // 
            this.pictMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictMinimize.EditValue = global::Base.Properties.Resources.icon_minimized;
            this.pictMinimize.Location = new System.Drawing.Point(1294, 1);
            this.pictMinimize.Name = "pictMinimize";
            this.pictMinimize.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictMinimize.Properties.Appearance.Options.UseBackColor = true;
            this.pictMinimize.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictMinimize.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pictMinimize.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictMinimize.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictMinimize.Size = new System.Drawing.Size(31, 24);
            this.pictMinimize.TabIndex = 3;
            this.pictMinimize.Click += new System.EventHandler(this.pictMinimize_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.EditValue = global::Base.Properties.Resources.speaker7;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picLogo.Size = new System.Drawing.Size(84, 53);
            this.picLogo.TabIndex = 1;
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLogo_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.labelControl13);
            this.panel2.Controls.Add(this.lblLasUpdate);
            this.panel2.Controls.Add(this.labelControl12);
            this.panel2.Controls.Add(this.lblIPAddress);
            this.panel2.Controls.Add(this.loadBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 723);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 25);
            this.panel2.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatus.Location = new System.Drawing.Point(697, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblStatus.Size = new System.Drawing.Size(320, 23);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status..";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(533, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(164, 23);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "COM4 Connected";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl13.Location = new System.Drawing.Point(1166, 0);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(98, 23);
            this.labelControl13.TabIndex = 6;
            this.labelControl13.Text = "IP Address : ";
            // 
            // lblLasUpdate
            // 
            this.lblLasUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLasUpdate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLasUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLasUpdate.Location = new System.Drawing.Point(244, 0);
            this.lblLasUpdate.Name = "lblLasUpdate";
            this.lblLasUpdate.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblLasUpdate.Size = new System.Drawing.Size(289, 23);
            this.lblLasUpdate.TabIndex = 5;
            this.lblLasUpdate.Text = "-";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl12.Location = new System.Drawing.Point(137, 0);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelControl12.Size = new System.Drawing.Size(107, 23);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Last update  : ";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIPAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblIPAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblIPAddress.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIPAddress.Location = new System.Drawing.Point(1264, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblIPAddress.Size = new System.Drawing.Size(94, 23);
            this.lblIPAddress.TabIndex = 3;
            this.lblIPAddress.Text = "-";
            // 
            // loadBar
            // 
            this.loadBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadBar.Location = new System.Drawing.Point(0, 0);
            this.loadBar.Name = "loadBar";
            this.loadBar.Size = new System.Drawing.Size(137, 23);
            this.loadBar.TabIndex = 7;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 55);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1360, 668);
            this.pnlContainer.TabIndex = 3;
            // 
            // tmrTimeNow
            // 
            this.tmrTimeNow.Interval = 1000;
            this.tmrTimeNow.Tick += new System.EventHandler(this.tmrTimeNow_Tick);
            // 
            // FrmBaseAndon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 748);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBaseAndon";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinimize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadBar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lblTitle1;
        public DevExpress.XtraEditors.PictureEdit picLogo;
        public DevExpress.XtraEditors.LabelControl lblTitle;
        public DevExpress.XtraEditors.PictureEdit pictMinimize;
        public DevExpress.XtraEditors.PictureEdit pictClose;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public DevExpress.XtraEditors.LabelControl lblIPAddress;
        public DevExpress.XtraEditors.LabelControl labelControl13;
        public DevExpress.XtraEditors.LabelControl lblLasUpdate;
        public DevExpress.XtraEditors.LabelControl labelControl12;
        public System.Windows.Forms.Panel pnlContainer;
        public System.Windows.Forms.Label lblTimeNow;
        public System.Windows.Forms.Timer tmrTimeNow;
        public System.Windows.Forms.Label lblDateNow;
        public DevExpress.XtraEditors.SimpleButton btnRefresh;
        public DevExpress.XtraEditors.ProgressBarControl loadBar;
        public System.Windows.Forms.Label lblVersion;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LabelControl lblStatus;
    }
}

