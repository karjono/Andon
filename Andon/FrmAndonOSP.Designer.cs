namespace Andon
{
    partial class FrmAndonOSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAndonOSP));
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel43 = new System.Windows.Forms.TableLayoutPanel();
            this.panel192 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotConfirm = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pnlUnderRepair = new System.Windows.Forms.Panel();
            this.tblLayoutUnderRepair = new System.Windows.Forms.TableLayoutPanel();
            this.lblRepair = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pnlDone = new System.Windows.Forms.Panel();
            this.tblLayoutDone = new System.Windows.Forms.TableLayoutPanel();
            this.lblDone = new DevExpress.XtraEditors.LabelControl();
            this.lblDoneTitle = new DevExpress.XtraEditors.LabelControl();
            this.pnlBreakdown = new System.Windows.Forms.Panel();
            this.tblLayoutBreakdown = new System.Windows.Forms.TableLayoutPanel();
            this.lblBreakdown = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pnlD3 = new System.Windows.Forms.Panel();
            this.tblLayoutD3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblB = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.tblLayoutTotal = new System.Windows.Forms.TableLayoutPanel();
            this.lblValTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.panel3.SuspendLayout();
            this.tableLayoutPanel43.SuspendLayout();
            this.panel192.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlUnderRepair.SuspendLayout();
            this.tblLayoutUnderRepair.SuspendLayout();
            this.pnlDone.SuspendLayout();
            this.tblLayoutDone.SuspendLayout();
            this.pnlBreakdown.SuspendLayout();
            this.tblLayoutBreakdown.SuspendLayout();
            this.pnlD3.SuspendLayout();
            this.tblLayoutD3.SuspendLayout();
            this.pnlLayout.SuspendLayout();
            this.tblLayoutTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
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
            // panel2
            // 
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
            this.pnlContainer.Controls.Add(this.grdCtrl);
            this.pnlContainer.Controls.Add(this.panel3);
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
            this.btnRefresh.Size = new System.Drawing.Size(40, 38);
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
            this.grdCtrl.Location = new System.Drawing.Point(0, 100);
            this.grdCtrl.MainView = this.gvwData;
            this.grdCtrl.Name = "grdCtrl";
            this.grdCtrl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoMemoEdit});
            this.grdCtrl.Size = new System.Drawing.Size(1358, 586);
            this.grdCtrl.TabIndex = 0;
            this.grdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwData});
            // 
            // gvwData
            // 
            this.gvwData.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gvwData.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvwData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvwData.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gvwData.Appearance.Row.Options.UseFont = true;
            this.gvwData.Appearance.Row.Options.UseTextOptions = true;
            this.gvwData.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvwData.ColumnPanelRowHeight = 40;
            this.gvwData.GridControl = this.grdCtrl;
            this.gvwData.IndicatorWidth = 100;
            this.gvwData.Name = "gvwData";
            this.gvwData.OptionsSelection.MultiSelect = true;
            this.gvwData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvwData.OptionsView.ColumnAutoWidth = false;
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
            this.pnlAndon.Location = new System.Drawing.Point(15, 200);
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
            this.lblAndonMC.Text = "LOCATION";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel43);
            this.panel3.Controls.Add(this.pnlDone);
            this.panel3.Controls.Add(this.pnlBreakdown);
            this.panel3.Controls.Add(this.pnlD3);
            this.panel3.Controls.Add(this.pnlLayout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1358, 100);
            this.panel3.TabIndex = 6;
            // 
            // tableLayoutPanel43
            // 
            this.tableLayoutPanel43.ColumnCount = 2;
            this.tableLayoutPanel43.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel43.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel43.Controls.Add(this.panel192, 1, 0);
            this.tableLayoutPanel43.Controls.Add(this.pnlUnderRepair, 0, 0);
            this.tableLayoutPanel43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel43.Location = new System.Drawing.Point(406, 0);
            this.tableLayoutPanel43.Name = "tableLayoutPanel43";
            this.tableLayoutPanel43.RowCount = 1;
            this.tableLayoutPanel43.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel43.Size = new System.Drawing.Size(652, 100);
            this.tableLayoutPanel43.TabIndex = 17;
            // 
            // panel192
            // 
            this.panel192.Controls.Add(this.tableLayoutPanel1);
            this.panel192.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel192.Location = new System.Drawing.Point(329, 3);
            this.panel192.Name = "panel192";
            this.panel192.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.panel192.Size = new System.Drawing.Size(320, 94);
            this.panel192.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblNotConfirm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 91);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // lblNotConfirm
            // 
            this.lblNotConfirm.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNotConfirm.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblNotConfirm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNotConfirm.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNotConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotConfirm.Location = new System.Drawing.Point(3, 46);
            this.lblNotConfirm.Name = "lblNotConfirm";
            this.lblNotConfirm.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.lblNotConfirm.Size = new System.Drawing.Size(304, 42);
            this.lblNotConfirm.TabIndex = 9;
            this.lblNotConfirm.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.labelControl3.Size = new System.Drawing.Size(304, 37);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "NOT CONFIRM";
            // 
            // pnlUnderRepair
            // 
            this.pnlUnderRepair.Controls.Add(this.tblLayoutUnderRepair);
            this.pnlUnderRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUnderRepair.Location = new System.Drawing.Point(3, 3);
            this.pnlUnderRepair.Name = "pnlUnderRepair";
            this.pnlUnderRepair.Padding = new System.Windows.Forms.Padding(0, 3, 10, 0);
            this.pnlUnderRepair.Size = new System.Drawing.Size(320, 94);
            this.pnlUnderRepair.TabIndex = 14;
            // 
            // tblLayoutUnderRepair
            // 
            this.tblLayoutUnderRepair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblLayoutUnderRepair.BackgroundImage")));
            this.tblLayoutUnderRepair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblLayoutUnderRepair.ColumnCount = 1;
            this.tblLayoutUnderRepair.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutUnderRepair.Controls.Add(this.lblRepair, 0, 1);
            this.tblLayoutUnderRepair.Controls.Add(this.labelControl6, 0, 0);
            this.tblLayoutUnderRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutUnderRepair.Location = new System.Drawing.Point(0, 3);
            this.tblLayoutUnderRepair.Name = "tblLayoutUnderRepair";
            this.tblLayoutUnderRepair.RowCount = 2;
            this.tblLayoutUnderRepair.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tblLayoutUnderRepair.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tblLayoutUnderRepair.Size = new System.Drawing.Size(310, 91);
            this.tblLayoutUnderRepair.TabIndex = 9;
            // 
            // lblRepair
            // 
            this.lblRepair.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblRepair.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRepair.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRepair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRepair.Location = new System.Drawing.Point(3, 46);
            this.lblRepair.Name = "lblRepair";
            this.lblRepair.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.lblRepair.Size = new System.Drawing.Size(304, 42);
            this.lblRepair.TabIndex = 9;
            this.lblRepair.Text = "0";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(3, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.labelControl6.Size = new System.Drawing.Size(304, 37);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "UNDER REPAIR";
            // 
            // pnlDone
            // 
            this.pnlDone.Controls.Add(this.tblLayoutDone);
            this.pnlDone.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDone.Location = new System.Drawing.Point(1058, 0);
            this.pnlDone.MaximumSize = new System.Drawing.Size(165, 0);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlDone.Size = new System.Drawing.Size(150, 100);
            this.pnlDone.TabIndex = 15;
            // 
            // tblLayoutDone
            // 
            this.tblLayoutDone.BackgroundImage = global::Andon.Properties.Resources.Picture4;
            this.tblLayoutDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblLayoutDone.ColumnCount = 1;
            this.tblLayoutDone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutDone.Controls.Add(this.lblDone, 0, 1);
            this.tblLayoutDone.Controls.Add(this.lblDoneTitle, 0, 0);
            this.tblLayoutDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutDone.Location = new System.Drawing.Point(0, 5);
            this.tblLayoutDone.Name = "tblLayoutDone";
            this.tblLayoutDone.RowCount = 2;
            this.tblLayoutDone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tblLayoutDone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tblLayoutDone.Size = new System.Drawing.Size(150, 95);
            this.tblLayoutDone.TabIndex = 11;
            // 
            // lblDone
            // 
            this.lblDone.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDone.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDone.Location = new System.Drawing.Point(3, 48);
            this.lblDone.Name = "lblDone";
            this.lblDone.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.lblDone.Size = new System.Drawing.Size(144, 44);
            this.lblDone.TabIndex = 9;
            this.lblDone.Text = "0";
            // 
            // lblDoneTitle
            // 
            this.lblDoneTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDoneTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDoneTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDoneTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoneTitle.Location = new System.Drawing.Point(3, 3);
            this.lblDoneTitle.Name = "lblDoneTitle";
            this.lblDoneTitle.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.lblDoneTitle.Size = new System.Drawing.Size(144, 39);
            this.lblDoneTitle.TabIndex = 8;
            this.lblDoneTitle.Text = "DONE";
            // 
            // pnlBreakdown
            // 
            this.pnlBreakdown.Controls.Add(this.tblLayoutBreakdown);
            this.pnlBreakdown.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBreakdown.Location = new System.Drawing.Point(150, 0);
            this.pnlBreakdown.MaximumSize = new System.Drawing.Size(256, 0);
            this.pnlBreakdown.Name = "pnlBreakdown";
            this.pnlBreakdown.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlBreakdown.Size = new System.Drawing.Size(256, 100);
            this.pnlBreakdown.TabIndex = 13;
            // 
            // tblLayoutBreakdown
            // 
            this.tblLayoutBreakdown.BackgroundImage = global::Andon.Properties.Resources.Picture3;
            this.tblLayoutBreakdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblLayoutBreakdown.ColumnCount = 1;
            this.tblLayoutBreakdown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutBreakdown.Controls.Add(this.lblBreakdown, 0, 1);
            this.tblLayoutBreakdown.Controls.Add(this.labelControl4, 0, 0);
            this.tblLayoutBreakdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutBreakdown.Location = new System.Drawing.Point(0, 5);
            this.tblLayoutBreakdown.Name = "tblLayoutBreakdown";
            this.tblLayoutBreakdown.RowCount = 2;
            this.tblLayoutBreakdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tblLayoutBreakdown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tblLayoutBreakdown.Size = new System.Drawing.Size(256, 95);
            this.tblLayoutBreakdown.TabIndex = 8;
            // 
            // lblBreakdown
            // 
            this.lblBreakdown.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBreakdown.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblBreakdown.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBreakdown.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBreakdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBreakdown.Location = new System.Drawing.Point(3, 48);
            this.lblBreakdown.Name = "lblBreakdown";
            this.lblBreakdown.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.lblBreakdown.Size = new System.Drawing.Size(250, 44);
            this.lblBreakdown.TabIndex = 9;
            this.lblBreakdown.Text = "0";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(3, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.labelControl4.Size = new System.Drawing.Size(250, 39);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "BREAKDOWN";
            // 
            // pnlD3
            // 
            this.pnlD3.Controls.Add(this.tblLayoutD3);
            this.pnlD3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlD3.Location = new System.Drawing.Point(1208, 0);
            this.pnlD3.MaximumSize = new System.Drawing.Size(165, 0);
            this.pnlD3.Name = "pnlD3";
            this.pnlD3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlD3.Size = new System.Drawing.Size(150, 100);
            this.pnlD3.TabIndex = 16;
            // 
            // tblLayoutD3
            // 
            this.tblLayoutD3.BackgroundImage = global::Andon.Properties.Resources.Picture5;
            this.tblLayoutD3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblLayoutD3.ColumnCount = 1;
            this.tblLayoutD3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutD3.Controls.Add(this.lblB, 0, 1);
            this.tblLayoutD3.Controls.Add(this.labelControl8, 0, 0);
            this.tblLayoutD3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutD3.Location = new System.Drawing.Point(0, 5);
            this.tblLayoutD3.Name = "tblLayoutD3";
            this.tblLayoutD3.RowCount = 2;
            this.tblLayoutD3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tblLayoutD3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tblLayoutD3.Size = new System.Drawing.Size(150, 95);
            this.tblLayoutD3.TabIndex = 10;
            // 
            // lblB
            // 
            this.lblB.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblB.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblB.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblB.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblB.Location = new System.Drawing.Point(3, 48);
            this.lblB.Name = "lblB";
            this.lblB.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.lblB.Size = new System.Drawing.Size(144, 44);
            this.lblB.TabIndex = 9;
            this.lblB.Text = "0";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl8.Location = new System.Drawing.Point(3, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.labelControl8.Size = new System.Drawing.Size(144, 39);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "D > 3";
            // 
            // pnlLayout
            // 
            this.pnlLayout.Controls.Add(this.tblLayoutTotal);
            this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLayout.Location = new System.Drawing.Point(0, 0);
            this.pnlLayout.MaximumSize = new System.Drawing.Size(165, 0);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlLayout.Size = new System.Drawing.Size(150, 100);
            this.pnlLayout.TabIndex = 12;
            // 
            // tblLayoutTotal
            // 
            this.tblLayoutTotal.BackgroundImage = global::Andon.Properties.Resources.Picture1;
            this.tblLayoutTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblLayoutTotal.ColumnCount = 1;
            this.tblLayoutTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutTotal.Controls.Add(this.lblValTotal, 0, 1);
            this.tblLayoutTotal.Controls.Add(this.labelControl1, 0, 0);
            this.tblLayoutTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutTotal.Location = new System.Drawing.Point(0, 5);
            this.tblLayoutTotal.Name = "tblLayoutTotal";
            this.tblLayoutTotal.RowCount = 2;
            this.tblLayoutTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tblLayoutTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tblLayoutTotal.Size = new System.Drawing.Size(150, 95);
            this.tblLayoutTotal.TabIndex = 7;
            // 
            // lblValTotal
            // 
            this.lblValTotal.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblValTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblValTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblValTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValTotal.Location = new System.Drawing.Point(3, 48);
            this.lblValTotal.Name = "lblValTotal";
            this.lblValTotal.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblValTotal.Size = new System.Drawing.Size(144, 44);
            this.lblValTotal.TabIndex = 9;
            this.lblValTotal.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(144, 39);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "TOTAL";
            // 
            // FrmAndonOSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pnlAndon);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.grdLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAndonOSP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAndonOSP_Load);
            this.Resize += new System.EventHandler(this.FrmAndonOSP_Resize);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.grdLayout, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.pnlContainer, 0);
            this.Controls.SetChildIndex(this.pnlAndon, 0);
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
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel43.ResumeLayout(false);
            this.panel192.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlUnderRepair.ResumeLayout(false);
            this.tblLayoutUnderRepair.ResumeLayout(false);
            this.pnlDone.ResumeLayout(false);
            this.tblLayoutDone.ResumeLayout(false);
            this.pnlBreakdown.ResumeLayout(false);
            this.tblLayoutBreakdown.ResumeLayout(false);
            this.pnlD3.ResumeLayout(false);
            this.tblLayoutD3.ResumeLayout(false);
            this.pnlLayout.ResumeLayout(false);
            this.tblLayoutTotal.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel43;
        private System.Windows.Forms.Panel panel192;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblNotConfirm;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel pnlUnderRepair;
        private System.Windows.Forms.TableLayoutPanel tblLayoutUnderRepair;
        private DevExpress.XtraEditors.LabelControl lblRepair;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Panel pnlDone;
        private System.Windows.Forms.TableLayoutPanel tblLayoutDone;
        private DevExpress.XtraEditors.LabelControl lblDone;
        private DevExpress.XtraEditors.LabelControl lblDoneTitle;
        private System.Windows.Forms.Panel pnlBreakdown;
        private System.Windows.Forms.TableLayoutPanel tblLayoutBreakdown;
        private DevExpress.XtraEditors.LabelControl lblBreakdown;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel pnlD3;
        private System.Windows.Forms.TableLayoutPanel tblLayoutD3;
        private DevExpress.XtraEditors.LabelControl lblB;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Panel pnlLayout;
        private System.Windows.Forms.TableLayoutPanel tblLayoutTotal;
        private DevExpress.XtraEditors.LabelControl lblValTotal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

