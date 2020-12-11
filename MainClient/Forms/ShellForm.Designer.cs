namespace MainClient.Forms
{
    partial class ShellForm
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ContentTabControl = new System.Windows.Forms.TabControl();
            this.infoLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.SalesButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientsButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.ClientsTopMargin = new System.Windows.Forms.Label();
            this.RequestTypesButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.RequestTypesTopMargin = new System.Windows.Forms.Label();
            this.PositionsButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.PositionTopMargin = new System.Windows.Forms.Label();
            this.UsersButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.UserTopMargin = new System.Windows.Forms.Label();
            this.SettingsButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.SettingsTopMargin = new System.Windows.Forms.Label();
            this.DockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.LeftDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.RepairsButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.label2 = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.LeftDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTable.Controls.Add(this.RightPanel, 0, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(21, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(763, 461);
            this.MainTable.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.ContentTabControl);
            this.RightPanel.Controls.Add(this.infoLabel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(3, 3);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(757, 455);
            this.RightPanel.TabIndex = 10;
            // 
            // ContentTabControl
            // 
            this.ContentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTabControl.Location = new System.Drawing.Point(0, 0);
            this.ContentTabControl.Name = "ContentTabControl";
            this.ContentTabControl.SelectedIndex = 0;
            this.ContentTabControl.Size = new System.Drawing.Size(757, 455);
            this.ContentTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.ContentTabControl.TabIndex = 1;
            this.ContentTabControl.Visible = false;
            this.ContentTabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ContentTabControlControlAdded);
            this.ContentTabControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.ContentTabControlControlRemoved);
            this.ContentTabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContentTabControlMouseClick);
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Location = new System.Drawing.Point(0, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(757, 455);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Для начала работы с информационной системой используйте меню управления";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.RepairsButton);
            this.ButtonsPanel.Controls.Add(this.label2);
            this.ButtonsPanel.Controls.Add(this.SalesButton);
            this.ButtonsPanel.Controls.Add(this.label1);
            this.ButtonsPanel.Controls.Add(this.ClientsButton);
            this.ButtonsPanel.Controls.Add(this.ClientsTopMargin);
            this.ButtonsPanel.Controls.Add(this.RequestTypesButton);
            this.ButtonsPanel.Controls.Add(this.RequestTypesTopMargin);
            this.ButtonsPanel.Controls.Add(this.PositionsButton);
            this.ButtonsPanel.Controls.Add(this.PositionTopMargin);
            this.ButtonsPanel.Controls.Add(this.UsersButton);
            this.ButtonsPanel.Controls.Add(this.UserTopMargin);
            this.ButtonsPanel.Controls.Add(this.SettingsButton);
            this.ButtonsPanel.Controls.Add(this.SettingsTopMargin);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(193, 432);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.Color.Tomato;
            this.SalesButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.SalesButton.BackColorGradientEnabled = false;
            this.SalesButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.SalesButton.BorderColor = System.Drawing.Color.Tomato;
            this.SalesButton.BorderColorEnabled = false;
            this.SalesButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.SalesButton.BorderColorOnHoverEnabled = false;
            this.SalesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesButton.ForeColor = System.Drawing.Color.Black;
            this.SalesButton.Location = new System.Drawing.Point(0, 210);
            this.SalesButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.RippleColor = System.Drawing.Color.Black;
            this.SalesButton.RoundingEnable = true;
            this.SalesButton.Size = new System.Drawing.Size(193, 30);
            this.SalesButton.TabIndex = 10;
            this.SalesButton.Text = "Продажи";
            this.SalesButton.TextHover = null;
            this.SalesButton.UseDownPressEffectOnClick = false;
            this.SalesButton.UseRippleEffect = true;
            this.SalesButton.UseZoomEffectOnHover = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 10);
            this.label1.TabIndex = 11;
            this.label1.Tag = "Margin";
            // 
            // ClientsButton
            // 
            this.ClientsButton.BackColor = System.Drawing.Color.Tomato;
            this.ClientsButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.ClientsButton.BackColorGradientEnabled = false;
            this.ClientsButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ClientsButton.BorderColor = System.Drawing.Color.Tomato;
            this.ClientsButton.BorderColorEnabled = false;
            this.ClientsButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.ClientsButton.BorderColorOnHoverEnabled = false;
            this.ClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsButton.ForeColor = System.Drawing.Color.Black;
            this.ClientsButton.Location = new System.Drawing.Point(0, 170);
            this.ClientsButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.RippleColor = System.Drawing.Color.Black;
            this.ClientsButton.RoundingEnable = true;
            this.ClientsButton.Size = new System.Drawing.Size(193, 30);
            this.ClientsButton.TabIndex = 1;
            this.ClientsButton.Text = "Клиенты";
            this.ClientsButton.TextHover = null;
            this.ClientsButton.UseDownPressEffectOnClick = false;
            this.ClientsButton.UseRippleEffect = true;
            this.ClientsButton.UseZoomEffectOnHover = false;
            // 
            // ClientsTopMargin
            // 
            this.ClientsTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsTopMargin.Location = new System.Drawing.Point(0, 160);
            this.ClientsTopMargin.Name = "ClientsTopMargin";
            this.ClientsTopMargin.Size = new System.Drawing.Size(193, 10);
            this.ClientsTopMargin.TabIndex = 3;
            this.ClientsTopMargin.Tag = "Margin";
            // 
            // RequestTypesButton
            // 
            this.RequestTypesButton.BackColor = System.Drawing.Color.Tomato;
            this.RequestTypesButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.RequestTypesButton.BackColorGradientEnabled = false;
            this.RequestTypesButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.RequestTypesButton.BorderColor = System.Drawing.Color.Tomato;
            this.RequestTypesButton.BorderColorEnabled = false;
            this.RequestTypesButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.RequestTypesButton.BorderColorOnHoverEnabled = false;
            this.RequestTypesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequestTypesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestTypesButton.ForeColor = System.Drawing.Color.Black;
            this.RequestTypesButton.Location = new System.Drawing.Point(0, 130);
            this.RequestTypesButton.Name = "RequestTypesButton";
            this.RequestTypesButton.RippleColor = System.Drawing.Color.Black;
            this.RequestTypesButton.RoundingEnable = true;
            this.RequestTypesButton.Size = new System.Drawing.Size(193, 30);
            this.RequestTypesButton.TabIndex = 8;
            this.RequestTypesButton.Text = "Типы заявок";
            this.RequestTypesButton.TextHover = null;
            this.RequestTypesButton.UseDownPressEffectOnClick = false;
            this.RequestTypesButton.UseRippleEffect = true;
            this.RequestTypesButton.UseZoomEffectOnHover = false;
            // 
            // RequestTypesTopMargin
            // 
            this.RequestTypesTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestTypesTopMargin.Location = new System.Drawing.Point(0, 120);
            this.RequestTypesTopMargin.Name = "RequestTypesTopMargin";
            this.RequestTypesTopMargin.Size = new System.Drawing.Size(193, 10);
            this.RequestTypesTopMargin.TabIndex = 9;
            this.RequestTypesTopMargin.Tag = "Margin";
            // 
            // PositionsButton
            // 
            this.PositionsButton.BackColor = System.Drawing.Color.Tomato;
            this.PositionsButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.PositionsButton.BackColorGradientEnabled = false;
            this.PositionsButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.PositionsButton.BorderColor = System.Drawing.Color.Tomato;
            this.PositionsButton.BorderColorEnabled = false;
            this.PositionsButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.PositionsButton.BorderColorOnHoverEnabled = false;
            this.PositionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PositionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PositionsButton.ForeColor = System.Drawing.Color.Black;
            this.PositionsButton.Location = new System.Drawing.Point(0, 90);
            this.PositionsButton.Name = "PositionsButton";
            this.PositionsButton.RippleColor = System.Drawing.Color.Black;
            this.PositionsButton.RoundingEnable = true;
            this.PositionsButton.Size = new System.Drawing.Size(193, 30);
            this.PositionsButton.TabIndex = 6;
            this.PositionsButton.Text = "Должности";
            this.PositionsButton.TextHover = null;
            this.PositionsButton.UseDownPressEffectOnClick = false;
            this.PositionsButton.UseRippleEffect = true;
            this.PositionsButton.UseZoomEffectOnHover = false;
            // 
            // PositionTopMargin
            // 
            this.PositionTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PositionTopMargin.Location = new System.Drawing.Point(0, 80);
            this.PositionTopMargin.Name = "PositionTopMargin";
            this.PositionTopMargin.Size = new System.Drawing.Size(193, 10);
            this.PositionTopMargin.TabIndex = 7;
            this.PositionTopMargin.Tag = "Margin";
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.Color.Tomato;
            this.UsersButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.UsersButton.BackColorGradientEnabled = false;
            this.UsersButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.UsersButton.BorderColor = System.Drawing.Color.Tomato;
            this.UsersButton.BorderColorEnabled = false;
            this.UsersButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.UsersButton.BorderColorOnHoverEnabled = false;
            this.UsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersButton.ForeColor = System.Drawing.Color.Black;
            this.UsersButton.Location = new System.Drawing.Point(0, 50);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.RippleColor = System.Drawing.Color.Black;
            this.UsersButton.RoundingEnable = true;
            this.UsersButton.Size = new System.Drawing.Size(193, 30);
            this.UsersButton.TabIndex = 0;
            this.UsersButton.Text = "Сотрудники";
            this.UsersButton.TextHover = null;
            this.UsersButton.UseDownPressEffectOnClick = false;
            this.UsersButton.UseRippleEffect = true;
            this.UsersButton.UseZoomEffectOnHover = false;
            // 
            // UserTopMargin
            // 
            this.UserTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserTopMargin.Location = new System.Drawing.Point(0, 40);
            this.UserTopMargin.Name = "UserTopMargin";
            this.UserTopMargin.Size = new System.Drawing.Size(193, 10);
            this.UserTopMargin.TabIndex = 2;
            this.UserTopMargin.Tag = "Margin";
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Tomato;
            this.SettingsButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.SettingsButton.BackColorGradientEnabled = false;
            this.SettingsButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.SettingsButton.BorderColor = System.Drawing.Color.Tomato;
            this.SettingsButton.BorderColorEnabled = false;
            this.SettingsButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.SettingsButton.BorderColorOnHoverEnabled = false;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.Location = new System.Drawing.Point(0, 10);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.RippleColor = System.Drawing.Color.Black;
            this.SettingsButton.RoundingEnable = true;
            this.SettingsButton.Size = new System.Drawing.Size(193, 30);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.TextHover = null;
            this.SettingsButton.UseDownPressEffectOnClick = false;
            this.SettingsButton.UseRippleEffect = true;
            this.SettingsButton.UseZoomEffectOnHover = false;
            // 
            // SettingsTopMargin
            // 
            this.SettingsTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTopMargin.Location = new System.Drawing.Point(0, 0);
            this.SettingsTopMargin.Name = "SettingsTopMargin";
            this.SettingsTopMargin.Size = new System.Drawing.Size(193, 10);
            this.SettingsTopMargin.TabIndex = 5;
            this.SettingsTopMargin.Tag = "Margin";
            // 
            // DockManager
            // 
            this.DockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.DockManager.Form = this;
            this.DockManager.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2});
            this.DockManager.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Classic;
            this.DockManager.TopZIndexControls.AddRange(new string[] {
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
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.SystemColors.Control;
            this.hideContainerLeft.Controls.Add(this.LeftDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(21, 461);
            // 
            // LeftDockPanel
            // 
            this.LeftDockPanel.Controls.Add(this.dockPanel1_Container);
            this.LeftDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.LeftDockPanel.ID = new System.Guid("6fe844f1-aab1-491c-a9e9-b81c47860dcd");
            this.LeftDockPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftDockPanel.Name = "LeftDockPanel";
            this.LeftDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.LeftDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.LeftDockPanel.SavedIndex = 0;
            this.LeftDockPanel.Size = new System.Drawing.Size(200, 461);
            this.LeftDockPanel.Text = "Меню управления";
            this.LeftDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ButtonsPanel);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 432);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel2.ID = new System.Guid("491ca89f-7503-4744-bd58-12a6f246972d");
            this.dockPanel2.Location = new System.Drawing.Point(200, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel2.SavedIndex = 1;
            this.dockPanel2.Size = new System.Drawing.Size(584, 200);
            this.dockPanel2.Text = "dockPanel2";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(578, 170);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // RepairsButton
            // 
            this.RepairsButton.BackColor = System.Drawing.Color.Tomato;
            this.RepairsButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.RepairsButton.BackColorGradientEnabled = false;
            this.RepairsButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.RepairsButton.BorderColor = System.Drawing.Color.Tomato;
            this.RepairsButton.BorderColorEnabled = false;
            this.RepairsButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.RepairsButton.BorderColorOnHoverEnabled = false;
            this.RepairsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepairsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RepairsButton.ForeColor = System.Drawing.Color.Black;
            this.RepairsButton.Location = new System.Drawing.Point(0, 250);
            this.RepairsButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.RepairsButton.Name = "RepairsButton";
            this.RepairsButton.RippleColor = System.Drawing.Color.Black;
            this.RepairsButton.RoundingEnable = true;
            this.RepairsButton.Size = new System.Drawing.Size(193, 30);
            this.RepairsButton.TabIndex = 12;
            this.RepairsButton.Text = "Ремонт";
            this.RepairsButton.TextHover = null;
            this.RepairsButton.UseDownPressEffectOnClick = false;
            this.RepairsButton.UseRippleEffect = true;
            this.RepairsButton.UseZoomEffectOnHover = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 10);
            this.label2.TabIndex = 13;
            this.label2.Tag = "Margin";
            // 
            // ShellForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainTable);
            this.Controls.Add(this.hideContainerLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShellForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShellForm";
            this.Resize += new System.EventHandler(this.ShellFormResize);
            this.MainTable.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.LeftDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.TabControl ContentTabControl;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton ClientsButton;
        private System.Windows.Forms.Label UserTopMargin;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton UsersButton;
        private System.Windows.Forms.Label ClientsTopMargin;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton SettingsButton;
        private System.Windows.Forms.Label SettingsTopMargin;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton PositionsButton;
        private System.Windows.Forms.Label PositionTopMargin;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton RequestTypesButton;
        private System.Windows.Forms.Label RequestTypesTopMargin;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label infoLabel;
        private DevExpress.XtraBars.Docking.DockManager DockManager;
        private DevExpress.XtraBars.Docking.DockPanel LeftDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton SalesButton;
        private System.Windows.Forms.Label label1;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton RepairsButton;
        private System.Windows.Forms.Label label2;
    }
}