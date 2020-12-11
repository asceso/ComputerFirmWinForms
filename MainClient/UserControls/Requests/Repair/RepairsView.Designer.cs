namespace MainClient.UserControls.Requests.Repair
{
    partial class RepairsView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.CloseViewButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.MainLayoutTable = new DevExpress.Utils.Layout.TablePanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.repairsRequestModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRepairsNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CloseRequestButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.CreateReportButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.ReqDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerBottom = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.CreateRequestPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.clientLUE = new DevExpress.XtraEditors.LookUpEdit();
            this.clientModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reqTypeCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.userCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateTargetDE = new DevExpress.XtraEditors.DateEdit();
            this.dateStartDE = new DevExpress.XtraEditors.DateEdit();
            this.reqNumTE = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateRequestButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutTable)).BeginInit();
            this.MainLayoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsRequestModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReqDockManager)).BeginInit();
            this.hideContainerBottom.SuspendLayout();
            this.CreateRequestPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientLUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqTypeCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTargetDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTargetDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqNumTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.CloseViewButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(628, 23);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // CloseViewButton
            // 
            this.CloseViewButton.BackColor = System.Drawing.Color.Tomato;
            this.CloseViewButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.CloseViewButton.BackColorGradientEnabled = false;
            this.CloseViewButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.CloseViewButton.BorderColor = System.Drawing.Color.Tomato;
            this.CloseViewButton.BorderColorEnabled = false;
            this.CloseViewButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.CloseViewButton.BorderColorOnHoverEnabled = false;
            this.CloseViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseViewButton.ForeColor = System.Drawing.Color.Black;
            this.CloseViewButton.Location = new System.Drawing.Point(528, 0);
            this.CloseViewButton.Name = "CloseViewButton";
            this.CloseViewButton.RippleColor = System.Drawing.Color.Black;
            this.CloseViewButton.RoundingEnable = true;
            this.CloseViewButton.Size = new System.Drawing.Size(100, 23);
            this.CloseViewButton.TabIndex = 0;
            this.CloseViewButton.Text = "Закрыть";
            this.CloseViewButton.TextHover = null;
            this.CloseViewButton.UseDownPressEffectOnClick = false;
            this.CloseViewButton.UseRippleEffect = true;
            this.CloseViewButton.UseZoomEffectOnHover = false;
            // 
            // MainLayoutTable
            // 
            this.MainLayoutTable.AutoScroll = true;
            this.MainLayoutTable.AutoSize = true;
            this.MainLayoutTable.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.MainLayoutTable.Controls.Add(this.gridControl1);
            this.MainLayoutTable.Controls.Add(this.CloseRequestButton);
            this.MainLayoutTable.Controls.Add(this.CreateReportButton);
            this.MainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutTable.Location = new System.Drawing.Point(0, 23);
            this.MainLayoutTable.Name = "MainLayoutTable";
            this.MainLayoutTable.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F)});
            this.MainLayoutTable.Size = new System.Drawing.Size(628, 411);
            this.MainLayoutTable.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.MainLayoutTable.SetColumn(this.gridControl1, 0);
            this.MainLayoutTable.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.DataSource = this.repairsRequestModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.MainLayoutTable.SetRow(this.gridControl1, 0);
            this.gridControl1.Size = new System.Drawing.Size(622, 375);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // repairsRequestModelBindingSource
            // 
            this.repairsRequestModelBindingSource.DataSource = typeof(ApplicationModels.RepairsRequestModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRepairsNumber,
            this.colOpenedDate,
            this.colTargetDate,
            this.colTargetUser,
            this.colRequestType,
            this.colTargetClient,
            this.colState});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRepairsNumber, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colRepairsNumber
            // 
            this.colRepairsNumber.FieldName = "RepairsNumber";
            this.colRepairsNumber.Name = "colRepairsNumber";
            this.colRepairsNumber.Visible = true;
            this.colRepairsNumber.VisibleIndex = 0;
            // 
            // colOpenedDate
            // 
            this.colOpenedDate.FieldName = "OpenedDate";
            this.colOpenedDate.Name = "colOpenedDate";
            this.colOpenedDate.Visible = true;
            this.colOpenedDate.VisibleIndex = 1;
            // 
            // colTargetDate
            // 
            this.colTargetDate.FieldName = "TargetDate";
            this.colTargetDate.Name = "colTargetDate";
            this.colTargetDate.Visible = true;
            this.colTargetDate.VisibleIndex = 2;
            // 
            // colTargetUser
            // 
            this.colTargetUser.FieldName = "TargetUser";
            this.colTargetUser.Name = "colTargetUser";
            this.colTargetUser.Visible = true;
            this.colTargetUser.VisibleIndex = 3;
            // 
            // colRequestType
            // 
            this.colRequestType.FieldName = "RequestType";
            this.colRequestType.Name = "colRequestType";
            this.colRequestType.Visible = true;
            this.colRequestType.VisibleIndex = 4;
            // 
            // colTargetClient
            // 
            this.colTargetClient.FieldName = "TargetClient";
            this.colTargetClient.Name = "colTargetClient";
            this.colTargetClient.Visible = true;
            this.colTargetClient.VisibleIndex = 5;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 6;
            // 
            // CloseRequestButton
            // 
            this.CloseRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CloseRequestButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CloseRequestButton.BackColorGradientEnabled = false;
            this.CloseRequestButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.CloseRequestButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CloseRequestButton.BorderColorEnabled = false;
            this.CloseRequestButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.CloseRequestButton.BorderColorOnHoverEnabled = false;
            this.MainLayoutTable.SetColumn(this.CloseRequestButton, 1);
            this.CloseRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseRequestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.CloseRequestButton.Location = new System.Drawing.Point(317, 384);
            this.CloseRequestButton.Name = "CloseRequestButton";
            this.CloseRequestButton.RippleColor = System.Drawing.Color.Black;
            this.CloseRequestButton.RoundingEnable = true;
            this.MainLayoutTable.SetRow(this.CloseRequestButton, 1);
            this.CloseRequestButton.Size = new System.Drawing.Size(308, 24);
            this.CloseRequestButton.TabIndex = 2;
            this.CloseRequestButton.Text = "Закрыть заявку";
            this.CloseRequestButton.TextHover = null;
            this.CloseRequestButton.UseDownPressEffectOnClick = false;
            this.CloseRequestButton.UseRippleEffect = true;
            this.CloseRequestButton.UseZoomEffectOnHover = false;
            // 
            // CreateReportButton
            // 
            this.CreateReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CreateReportButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CreateReportButton.BackColorGradientEnabled = false;
            this.CreateReportButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.CreateReportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CreateReportButton.BorderColorEnabled = false;
            this.CreateReportButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.CreateReportButton.BorderColorOnHoverEnabled = false;
            this.MainLayoutTable.SetColumn(this.CreateReportButton, 0);
            this.CreateReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateReportButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.CreateReportButton.Location = new System.Drawing.Point(3, 384);
            this.CreateReportButton.Name = "CreateReportButton";
            this.CreateReportButton.RippleColor = System.Drawing.Color.Black;
            this.CreateReportButton.RoundingEnable = true;
            this.MainLayoutTable.SetRow(this.CreateReportButton, 1);
            this.CreateReportButton.Size = new System.Drawing.Size(308, 24);
            this.CreateReportButton.TabIndex = 1;
            this.CreateReportButton.Text = "Загрузка отчета";
            this.CreateReportButton.TextHover = null;
            this.CreateReportButton.UseDownPressEffectOnClick = false;
            this.CreateReportButton.UseRippleEffect = true;
            this.CreateReportButton.UseZoomEffectOnHover = false;
            // 
            // ReqDockManager
            // 
            this.ReqDockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerBottom});
            this.ReqDockManager.Form = this;
            this.ReqDockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // hideContainerBottom
            // 
            this.hideContainerBottom.BackColor = System.Drawing.SystemColors.Control;
            this.hideContainerBottom.Controls.Add(this.CreateRequestPanel);
            this.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hideContainerBottom.Location = new System.Drawing.Point(0, 434);
            this.hideContainerBottom.Name = "hideContainerBottom";
            this.hideContainerBottom.Size = new System.Drawing.Size(628, 21);
            // 
            // CreateRequestPanel
            // 
            this.CreateRequestPanel.AutoScroll = true;
            this.CreateRequestPanel.Controls.Add(this.dockPanel1_Container);
            this.CreateRequestPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.CreateRequestPanel.ID = new System.Guid("3c1c0715-077e-41e7-8f60-cb99d929a66f");
            this.CreateRequestPanel.Location = new System.Drawing.Point(0, 0);
            this.CreateRequestPanel.Name = "CreateRequestPanel";
            this.CreateRequestPanel.Options.AllowDockTop = false;
            this.CreateRequestPanel.Options.FloatOnDblClick = false;
            this.CreateRequestPanel.Options.ShowCloseButton = false;
            this.CreateRequestPanel.Options.ShowMaximizeButton = false;
            this.CreateRequestPanel.OriginalSize = new System.Drawing.Size(200, 160);
            this.CreateRequestPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.CreateRequestPanel.SavedIndex = 0;
            this.CreateRequestPanel.Size = new System.Drawing.Size(628, 160);
            this.CreateRequestPanel.Text = "Создать заявку";
            this.CreateRequestPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.tablePanel1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 27);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(622, 130);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F)});
            this.tablePanel1.Controls.Add(this.CreateRequestButton);
            this.tablePanel1.Controls.Add(this.clientLUE);
            this.tablePanel1.Controls.Add(this.reqTypeCB);
            this.tablePanel1.Controls.Add(this.userCB);
            this.tablePanel1.Controls.Add(this.dateTargetDE);
            this.tablePanel1.Controls.Add(this.dateStartDE);
            this.tablePanel1.Controls.Add(this.reqNumTE);
            this.tablePanel1.Controls.Add(this.label6);
            this.tablePanel1.Controls.Add(this.label5);
            this.tablePanel1.Controls.Add(this.label4);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 10F)});
            this.tablePanel1.Size = new System.Drawing.Size(622, 130);
            this.tablePanel1.TabIndex = 0;
            // 
            // clientLUE
            // 
            this.tablePanel1.SetColumn(this.clientLUE, 5);
            this.clientLUE.Location = new System.Drawing.Point(501, 55);
            this.clientLUE.Name = "clientLUE";
            this.clientLUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clientLUE.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "Имя", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SecondName", "Фамилия", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "Отчество", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactNumber", "Контактный номер", 105, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsLead", "Холодный контакт", 105, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsDeleted", "Удален в архив", 89, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.clientLUE.Properties.DataSource = this.clientModelBindingSource;
            this.clientLUE.Properties.DropDownRows = 10;
            this.clientLUE.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Simple;
            this.clientLUE.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.clientLUE.Properties.PopupFormMinSize = new System.Drawing.Size(600, 200);
            this.clientLUE.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.tablePanel1.SetRow(this.clientLUE, 3);
            this.clientLUE.Size = new System.Drawing.Size(118, 20);
            this.clientLUE.TabIndex = 11;
            // 
            // clientModelBindingSource
            // 
            this.clientModelBindingSource.DataSource = typeof(ApplicationModels.ClientModel);
            // 
            // reqTypeCB
            // 
            this.tablePanel1.SetColumn(this.reqTypeCB, 1);
            this.reqTypeCB.Location = new System.Drawing.Point(86, 55);
            this.reqTypeCB.Name = "reqTypeCB";
            this.reqTypeCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.reqTypeCB, 3);
            this.reqTypeCB.Size = new System.Drawing.Size(118, 20);
            this.reqTypeCB.TabIndex = 10;
            this.reqTypeCB.SelectedValueChanged += new System.EventHandler(this.reqTypeCB_SelectedValueChanged);
            // 
            // userCB
            // 
            this.tablePanel1.SetColumn(this.userCB, 3);
            this.userCB.Enabled = false;
            this.userCB.Location = new System.Drawing.Point(293, 55);
            this.userCB.Name = "userCB";
            this.userCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.userCB, 3);
            this.userCB.Size = new System.Drawing.Size(118, 20);
            this.userCB.TabIndex = 9;
            // 
            // dateTargetDE
            // 
            this.tablePanel1.SetColumn(this.dateTargetDE, 5);
            this.dateTargetDE.EditValue = null;
            this.dateTargetDE.Location = new System.Drawing.Point(501, 15);
            this.dateTargetDE.Name = "dateTargetDE";
            this.dateTargetDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTargetDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.dateTargetDE, 1);
            this.dateTargetDE.Size = new System.Drawing.Size(118, 20);
            this.dateTargetDE.TabIndex = 8;
            // 
            // dateStartDE
            // 
            this.tablePanel1.SetColumn(this.dateStartDE, 3);
            this.dateStartDE.EditValue = new System.DateTime(2020, 12, 8, 2, 26, 31, 0);
            this.dateStartDE.Enabled = false;
            this.dateStartDE.Location = new System.Drawing.Point(293, 15);
            this.dateStartDE.Name = "dateStartDE";
            this.dateStartDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStartDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.dateStartDE, 1);
            this.dateStartDE.Size = new System.Drawing.Size(118, 20);
            this.dateStartDE.TabIndex = 7;
            // 
            // reqNumTE
            // 
            this.reqNumTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.reqNumTE, 1);
            this.reqNumTE.Location = new System.Drawing.Point(86, 15);
            this.reqNumTE.Name = "reqNumTE";
            this.reqNumTE.Properties.ReadOnly = true;
            this.tablePanel1.SetRow(this.reqNumTE, 1);
            this.reqNumTE.Size = new System.Drawing.Size(118, 20);
            this.reqNumTE.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tablePanel1.SetColumn(this.label6, 4);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(418, 50);
            this.label6.Name = "label6";
            this.tablePanel1.SetRow(this.label6, 3);
            this.label6.Size = new System.Drawing.Size(77, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Клиент";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tablePanel1.SetColumn(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(210, 50);
            this.label5.Name = "label5";
            this.tablePanel1.SetRow(this.label5, 3);
            this.label5.Size = new System.Drawing.Size(77, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сотрудник";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tablePanel1.SetColumn(this.label4, 0);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.tablePanel1.SetRow(this.label4, 3);
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип заявки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tablePanel1.SetColumn(this.label3, 4);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(418, 10);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 1);
            this.label3.Size = new System.Drawing.Size(77, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Назначенная дата";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tablePanel1.SetColumn(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(210, 10);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 1);
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата создания";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 0);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 1);
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заявки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateRequestButton
            // 
            this.CreateRequestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CreateRequestButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CreateRequestButton.BackColorGradientEnabled = false;
            this.CreateRequestButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.CreateRequestButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.CreateRequestButton.BorderColorEnabled = false;
            this.CreateRequestButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.CreateRequestButton.BorderColorOnHoverEnabled = false;
            this.tablePanel1.SetColumn(this.CreateRequestButton, 2);
            this.tablePanel1.SetColumnSpan(this.CreateRequestButton, 2);
            this.CreateRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateRequestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.CreateRequestButton.Location = new System.Drawing.Point(210, 92);
            this.CreateRequestButton.Name = "CreateRequestButton";
            this.CreateRequestButton.RippleColor = System.Drawing.Color.Black;
            this.CreateRequestButton.RoundingEnable = true;
            this.tablePanel1.SetRow(this.CreateRequestButton, 4);
            this.CreateRequestButton.Size = new System.Drawing.Size(201, 25);
            this.CreateRequestButton.TabIndex = 12;
            this.CreateRequestButton.Text = "Создать заявку";
            this.CreateRequestButton.TextHover = null;
            this.CreateRequestButton.UseDownPressEffectOnClick = false;
            this.CreateRequestButton.UseRippleEffect = true;
            this.CreateRequestButton.UseZoomEffectOnHover = false;
            this.CreateRequestButton.Click += new System.EventHandler(this.CreateRequestButton_Click);
            // 
            // RepairsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayoutTable);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.hideContainerBottom);
            this.Name = "RepairsView";
            this.Size = new System.Drawing.Size(628, 455);
            this.Load += new System.EventHandler(this.RepairsViewLoad);
            this.ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutTable)).EndInit();
            this.MainLayoutTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairsRequestModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReqDockManager)).EndInit();
            this.hideContainerBottom.ResumeLayout(false);
            this.CreateRequestPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientLUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqTypeCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTargetDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTargetDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStartDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqNumTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel ButtonsPanel;
        public CoreClient.StyleExtensions.Controls.BaseStyledButton CloseViewButton;
        public DevExpress.Utils.Layout.TablePanel MainLayoutTable;
        public CoreClient.StyleExtensions.Controls.BaseStyledButton CloseRequestButton;
        public CoreClient.StyleExtensions.Controls.BaseStyledButton CreateReportButton;
        private DevExpress.XtraBars.Docking.DockManager ReqDockManager;
        private DevExpress.XtraBars.Docking.DockPanel CreateRequestPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerBottom;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource repairsRequestModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRepairsNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetUser;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestType;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetClient;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LookUpEdit clientLUE;
        private DevExpress.XtraEditors.ComboBoxEdit reqTypeCB;
        private DevExpress.XtraEditors.ComboBoxEdit userCB;
        private DevExpress.XtraEditors.DateEdit dateTargetDE;
        private DevExpress.XtraEditors.DateEdit dateStartDE;
        private DevExpress.XtraEditors.TextEdit reqNumTE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clientModelBindingSource;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton CreateRequestButton;
    }
}
