namespace Andon
{
    partial class FrmAndonSmart2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAndonSmart2));
            this.grdLayout = new DevExpress.XtraGrid.GridControl();
            this.gvwLayout = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCtrl = new DevExpress.XtraGrid.GridControl();
            this.gvwData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repoMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.timerCheckAndon = new System.Windows.Forms.Timer(this.components);
            this.bwAndon = new System.ComponentModel.BackgroundWorker();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.pnlAndon = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAndonTitle = new System.Windows.Forms.Panel();
            this.lblAndonTitle = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAndonLine = new DevExpress.XtraEditors.LabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAndonMC = new DevExpress.XtraEditors.LabelControl();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.lblAndonLineVal = new DevExpress.XtraEditors.LabelControl();
            this.pnlMC = new System.Windows.Forms.Panel();
            this.lblAndonMCVal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinimize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictClose.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoMemoEdit)).BeginInit();
            this.pnlAndon.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlAndonTitle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlLine.SuspendLayout();
            this.pnlMC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblTitle1.Location = new System.Drawing.Point(94, 0);
            // 
            // picLogo
            // 
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblTitle.Size = new System.Drawing.Size(10, 53);
            this.lblTitle.Text = "";
            // 
            // pictMinimize
            // 
            this.pictMinimize.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictMinimize.Properties.Appearance.Options.UseBackColor = true;
            // 
            // pictClose
            // 
            this.pictClose.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictClose.Properties.Appearance.Options.UseBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Location = new System.Drawing.Point(0, 743);
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIPAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblIPAddress.Text = "10.10.11.77";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            // 
            // lblLasUpdate
            // 
            this.lblLasUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLasUpdate.Text = "2021-05-27 11:33:55";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlAndon);
            this.pnlContainer.Controls.Add(this.grdCtrl);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.None;
            this.pnlContainer.Location = new System.Drawing.Point(192, 234);
            this.pnlContainer.Size = new System.Drawing.Size(1360, 688);
            // 
            // tmrTimeNow
            // 
            this.tmrTimeNow.Enabled = true;
            this.tmrTimeNow.Tick += new System.EventHandler(this.tmrTimeNow_Tick);
            // 
            // lblDateNow
            // 
            this.lblDateNow.Text = "2021-07-02";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // loadBar
            // 
            // 
            // grdLayout
            // 
            this.grdLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLayout.Location = new System.Drawing.Point(0, 55);
            this.grdLayout.MainView = this.gvwLayout;
            this.grdLayout.Name = "grdLayout";
            this.grdLayout.Size = new System.Drawing.Size(1360, 688);
            this.grdLayout.TabIndex = 5;
            this.grdLayout.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwLayout});
            // 
            // gvwLayout
            // 
            this.gvwLayout.ColumnPanelRowHeight = 40;
            this.gvwLayout.GridControl = this.grdLayout;
            this.gvwLayout.IndicatorWidth = 100;
            this.gvwLayout.Name = "gvwLayout";
            this.gvwLayout.OptionsView.ColumnAutoWidth = false;
            this.gvwLayout.OptionsView.ShowGroupPanel = false;
            this.gvwLayout.PaintStyleName = "UltraFlat";
            this.gvwLayout.RowHeight = 25;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1360, 688);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grdCtrl
            // 
            this.grdCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCtrl.Location = new System.Drawing.Point(0, 0);
            this.grdCtrl.MainView = this.gvwData;
            this.grdCtrl.Name = "grdCtrl";
            this.grdCtrl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoMemoEdit});
            this.grdCtrl.Size = new System.Drawing.Size(1358, 686);
            this.grdCtrl.TabIndex = 0;
            this.grdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwData});
            // 
            // gvwData
            // 
            this.gvwData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvwData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvwData.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwData.Appearance.OddRow.Options.UseFont = true;
            this.gvwData.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwData.Appearance.Row.Options.UseFont = true;
            this.gvwData.Appearance.Row.Options.UseTextOptions = true;
            this.gvwData.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvwData.ColumnPanelRowHeight = 40;
            this.gvwData.GridControl = this.grdCtrl;
            this.gvwData.IndicatorWidth = 20;
            this.gvwData.Name = "gvwData";
            this.gvwData.OptionsSelection.MultiSelect = true;
            this.gvwData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvwData.OptionsView.ShowGroupPanel = false;
            this.gvwData.PaintStyleName = "Style3D";
            this.gvwData.RowHeight = 25;
            this.gvwData.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvwData_CustomDrawRowIndicator);
            this.gvwData.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvwData_RowCellStyle);
            this.gvwData.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvwData_CustomColumnDisplayText);
            // 
            // repoMemoEdit
            // 
            this.repoMemoEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.repoMemoEdit.Appearance.Options.UseFont = true;
            this.repoMemoEdit.Appearance.Options.UseTextOptions = true;
            this.repoMemoEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repoMemoEdit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repoMemoEdit.Name = "repoMemoEdit";
            this.repoMemoEdit.ReadOnly = true;
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 600000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // timerCheckAndon
            // 
            this.timerCheckAndon.Tick += new System.EventHandler(this.timerCheckAndon_Tick);
            // 
            // bwAndon
            // 
            this.bwAndon.WorkerSupportsCancellation = true;
            this.bwAndon.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAndon_DoWork);
            this.bwAndon.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwAndon_ProgressChanged);
            this.bwAndon.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAndon_RunWorkerCompleted);
            // 
            // timerBlink
            // 
            this.timerBlink.Interval = 800;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // pnlAndon
            // 
            this.pnlAndon.BackColor = System.Drawing.Color.Transparent;
            this.pnlAndon.Controls.Add(this.tableLayoutPanel2);
            this.pnlAndon.Location = new System.Drawing.Point(446, 225);
            this.pnlAndon.Name = "pnlAndon";
            this.pnlAndon.Size = new System.Drawing.Size(1300, 601);
            this.pnlAndon.TabIndex = 44;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnlAndonTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pnlLine, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pnlMC, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.61356F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.61413F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.77232F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1300, 601);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlAndonTitle
            // 
            this.pnlAndonTitle.BackgroundImage = global::Andon.Properties.Resources.Picture6;
            this.pnlAndonTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.SetColumnSpan(this.pnlAndonTitle, 2);
            this.pnlAndonTitle.Controls.Add(this.lblAndonTitle);
            this.pnlAndonTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAndonTitle.Location = new System.Drawing.Point(3, 3);
            this.pnlAndonTitle.Name = "pnlAndonTitle";
            this.pnlAndonTitle.Size = new System.Drawing.Size(1294, 141);
            this.pnlAndonTitle.TabIndex = 218;
            // 
            // lblAndonTitle
            // 
            this.lblAndonTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblAndonTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Bold);
            this.lblAndonTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAndonTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAndonTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblAndonTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAndonTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAndonTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblAndonTitle.Name = "lblAndonTitle";
            this.lblAndonTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.lblAndonTitle.Size = new System.Drawing.Size(1294, 141);
            this.lblAndonTitle.TabIndex = 219;
            this.lblAndonTitle.Text = "MAINTENANCE";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Andon.Properties.Resources.Picture6;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lblAndonLine);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(644, 141);
            this.panel4.TabIndex = 219;
            // 
            // lblAndonLine
            // 
            this.lblAndonLine.Appearance.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Bold);
            this.lblAndonLine.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAndonLine.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAndonLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAndonLine.Location = new System.Drawing.Point(0, 0);
            this.lblAndonLine.Margin = new System.Windows.Forms.Padding(0, 0, 3, 6);
            this.lblAndonLine.Name = "lblAndonLine";
            this.lblAndonLine.Padding = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.lblAndonLine.Size = new System.Drawing.Size(644, 141);
            this.lblAndonLine.TabIndex = 215;
            this.lblAndonLine.Text = "LINE";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Andon.Properties.Resources.Picture6;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.lblAndonMC);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(653, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 141);
            this.panel5.TabIndex = 220;
            // 
            // lblAndonMC
            // 
            this.lblAndonMC.Appearance.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Bold);
            this.lblAndonMC.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAndonMC.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAndonMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAndonMC.Location = new System.Drawing.Point(0, 0);
            this.lblAndonMC.Margin = new System.Windows.Forms.Padding(3, 0, 0, 6);
            this.lblAndonMC.Name = "lblAndonMC";
            this.lblAndonMC.Padding = new System.Windows.Forms.Padding(0, 0, 0, 60);
            this.lblAndonMC.Size = new System.Drawing.Size(644, 141);
            this.lblAndonMC.TabIndex = 216;
            this.lblAndonMC.Text = "ZONA";
            // 
            // pnlLine
            // 
            this.pnlLine.BackgroundImage = global::Andon.Properties.Resources.Picture8;
            this.pnlLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLine.Controls.Add(this.lblAndonLineVal);
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine.Location = new System.Drawing.Point(3, 297);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(644, 301);
            this.pnlLine.TabIndex = 221;
            // 
            // lblAndonLineVal
            // 
            this.lblAndonLineVal.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F);
            this.lblAndonLineVal.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblAndonLineVal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAndonLineVal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAndonLineVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAndonLineVal.Location = new System.Drawing.Point(0, 0);
            this.lblAndonLineVal.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblAndonLineVal.Name = "lblAndonLineVal";
            this.lblAndonLineVal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 90);
            this.lblAndonLineVal.Size = new System.Drawing.Size(644, 301);
            this.lblAndonLineVal.TabIndex = 218;
            this.lblAndonLineVal.Text = "00";
            // 
            // pnlMC
            // 
            this.pnlMC.BackgroundImage = global::Andon.Properties.Resources.Picture9;
            this.pnlMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMC.Controls.Add(this.lblAndonMCVal);
            this.pnlMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMC.Location = new System.Drawing.Point(653, 297);
            this.pnlMC.Name = "pnlMC";
            this.pnlMC.Size = new System.Drawing.Size(644, 301);
            this.pnlMC.TabIndex = 222;
            // 
            // lblAndonMCVal
            // 
            this.lblAndonMCVal.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F);
            this.lblAndonMCVal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblAndonMCVal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAndonMCVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAndonMCVal.Location = new System.Drawing.Point(0, 0);
            this.lblAndonMCVal.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblAndonMCVal.Name = "lblAndonMCVal";
            this.lblAndonMCVal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 90);
            this.lblAndonMCVal.Size = new System.Drawing.Size(644, 301);
            this.lblAndonMCVal.TabIndex = 217;
            this.lblAndonMCVal.Text = "00";
            // 
            // FrmAndonSmart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grdLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAndonSmart2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAndonOSP_Load);
            this.Resize += new System.EventHandler(this.FrmAndonOSP_Resize);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.grdLayout, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.pnlContainer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinimize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictClose.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoMemoEdit)).EndInit();
            this.pnlAndon.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlAndonTitle.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlLine.ResumeLayout(false);
            this.pnlMC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLayout;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwLayout;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwData;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Timer timerCheckAndon;
        private System.ComponentModel.BackgroundWorker bwAndon;
        private System.Windows.Forms.Timer timerBlink;
        private System.Windows.Forms.Panel pnlAndon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repoMemoEdit;
        private System.Windows.Forms.Panel pnlAndonTitle;
        private DevExpress.XtraEditors.LabelControl lblAndonTitle;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl lblAndonLine;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.LabelControl lblAndonMC;
        private System.Windows.Forms.Panel pnlLine;
        private DevExpress.XtraEditors.LabelControl lblAndonLineVal;
        private System.Windows.Forms.Panel pnlMC;
        private DevExpress.XtraEditors.LabelControl lblAndonMCVal;
    }
}

