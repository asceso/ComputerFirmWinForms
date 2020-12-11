namespace MainClient.UserControls.Requests
{
    partial class ContentRequestUserControlBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContentRequestUserControlBase));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.CloseViewButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.MainLayoutTable = new DevExpress.Utils.Layout.TablePanel();
            this.CloseRequestButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.CreateReportButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.ReqDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerBottom = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.CreateRequestDock = new DevExpress.XtraBars.Docking.DockPanel();
            this.createReqDockContainer = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutTable)).BeginInit();
            this.MainLayoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReqDockManager)).BeginInit();
            this.hideContainerBottom.SuspendLayout();
            this.CreateRequestDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.CloseViewButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(628, 23);
            this.ButtonsPanel.TabIndex = 1;
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
            this.MainLayoutTable.Controls.Add(this.CloseRequestButton);
            this.MainLayoutTable.Controls.Add(this.CreateReportButton);
            this.MainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutTable.Location = new System.Drawing.Point(0, 23);
            this.MainLayoutTable.Name = "MainLayoutTable";
            this.MainLayoutTable.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F)});
            this.MainLayoutTable.Size = new System.Drawing.Size(628, 408);
            this.MainLayoutTable.TabIndex = 2;
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
            this.CloseRequestButton.Location = new System.Drawing.Point(317, 381);
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
            this.CreateReportButton.Location = new System.Drawing.Point(3, 381);
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
            this.hideContainerBottom.Controls.Add(this.CreateRequestDock);
            this.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hideContainerBottom.Location = new System.Drawing.Point(0, 431);
            this.hideContainerBottom.Name = "hideContainerBottom";
            this.hideContainerBottom.Size = new System.Drawing.Size(628, 24);
            // 
            // CreateRequestDock
            // 
            this.CreateRequestDock.Controls.Add(this.createReqDockContainer);
            this.CreateRequestDock.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.CreateRequestDock.FloatVertical = true;
            this.CreateRequestDock.ID = new System.Guid("b5de7db8-8239-403d-922b-05ba94fcb24d");
            this.CreateRequestDock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CreateRequestDock.ImageOptions.Image")));
            this.CreateRequestDock.Location = new System.Drawing.Point(0, 0);
            this.CreateRequestDock.Name = "CreateRequestDock";
            this.CreateRequestDock.OriginalSize = new System.Drawing.Size(200, 311);
            this.CreateRequestDock.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.CreateRequestDock.SavedIndex = 0;
            this.CreateRequestDock.Size = new System.Drawing.Size(628, 311);
            this.CreateRequestDock.Text = "Оформление заявки";
            this.CreateRequestDock.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // createReqDockContainer
            // 
            this.createReqDockContainer.Location = new System.Drawing.Point(3, 27);
            this.createReqDockContainer.Name = "createReqDockContainer";
            this.createReqDockContainer.Size = new System.Drawing.Size(622, 281);
            this.createReqDockContainer.TabIndex = 0;
            // 
            // ContentRequestUserControlBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.MainLayoutTable);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.hideContainerBottom);
            this.Name = "ContentRequestUserControlBase";
            this.Size = new System.Drawing.Size(628, 455);
            this.ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutTable)).EndInit();
            this.MainLayoutTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReqDockManager)).EndInit();
            this.hideContainerBottom.ResumeLayout(false);
            this.CreateRequestDock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel ButtonsPanel;
        public CoreClient.StyleExtensions.Controls.BaseStyledButton CloseViewButton;
        public DevExpress.Utils.Layout.TablePanel MainLayoutTable;
        public CoreClient.StyleExtensions.Controls.BaseStyledButton CloseRequestButton;
        public CoreClient.StyleExtensions.Controls.BaseStyledButton CreateReportButton;
        public DevExpress.XtraBars.Docking.DockManager ReqDockManager;
        public DevExpress.XtraBars.Docking.AutoHideContainer hideContainerBottom;
        public DevExpress.XtraBars.Docking.DockPanel CreateRequestDock;
        public DevExpress.XtraBars.Docking.ControlContainer createReqDockContainer;
    }
}
