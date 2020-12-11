using Ninject;

namespace MainClient.UserControls.Requests.Sale
{
    partial class SalesView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesView));
            this.DockPanelManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerBottom = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.CreateSalePanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.CloseViewButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.MainLayoutTable = new DevExpress.Utils.Layout.TablePanel();
            this.CloseRequestButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.saleModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSaleNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPositionCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DockPanelManager)).BeginInit();
            this.hideContainerBottom.SuspendLayout();
            this.CreateSalePanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutTable)).BeginInit();
            this.MainLayoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DockPanelManager
            // 
            this.DockPanelManager.AutoHiddenPanelCaptionShowMode = DevExpress.XtraBars.Docking.AutoHiddenPanelCaptionShowMode.ShowForActivePanel;
            this.DockPanelManager.AutoHiddenPanelShowMode = DevExpress.XtraBars.Docking.AutoHiddenPanelShowMode.MouseHover;
            this.DockPanelManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerBottom});
            this.DockPanelManager.DockingOptions.FloatOnDblClick = false;
            this.DockPanelManager.DockingOptions.HidePanelsImmediately = DevExpress.XtraBars.Docking.Helpers.HidePanelsImmediatelyMode.OnAutoHide;
            this.DockPanelManager.DockModeVS2005FadeSpeed = 1000;
            this.DockPanelManager.Form = this;
            this.DockPanelManager.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light;
            this.DockPanelManager.TopZIndexControls.AddRange(new string[] {
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
            this.hideContainerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.hideContainerBottom.Controls.Add(this.CreateSalePanel);
            this.hideContainerBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hideContainerBottom.Location = new System.Drawing.Point(0, 430);
            this.hideContainerBottom.Name = "hideContainerBottom";
            this.hideContainerBottom.Size = new System.Drawing.Size(628, 25);
            // 
            // CreateSalePanel
            // 
            this.CreateSalePanel.AutoScroll = true;
            this.CreateSalePanel.Controls.Add(this.dockPanel1_Container);
            this.CreateSalePanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.CreateSalePanel.ID = new System.Guid("b7fe7861-984d-43b3-9681-b0c71cb36263");
            this.CreateSalePanel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CreateSalePanel.ImageOptions.Image")));
            this.CreateSalePanel.Location = new System.Drawing.Point(0, 0);
            this.CreateSalePanel.Name = "CreateSalePanel";
            this.CreateSalePanel.Options.AllowFloating = false;
            this.CreateSalePanel.Options.FloatOnDblClick = false;
            this.CreateSalePanel.Options.ShowCloseButton = false;
            this.CreateSalePanel.OriginalSize = new System.Drawing.Size(200, 272);
            this.CreateSalePanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.CreateSalePanel.SavedIndex = 0;
            this.CreateSalePanel.Size = new System.Drawing.Size(628, 272);
            this.CreateSalePanel.Text = "Оформление продажи";
            this.CreateSalePanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(628, 248);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.CloseViewButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(628, 23);
            this.ButtonsPanel.TabIndex = 4;
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
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.MainLayoutTable.Controls.Add(this.gridControl1);
            this.MainLayoutTable.Controls.Add(this.CloseRequestButton);
            this.MainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutTable.Location = new System.Drawing.Point(0, 23);
            this.MainLayoutTable.Name = "MainLayoutTable";
            this.MainLayoutTable.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F)});
            this.MainLayoutTable.Size = new System.Drawing.Size(628, 407);
            this.MainLayoutTable.TabIndex = 14;
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
            this.MainLayoutTable.SetColumn(this.CloseRequestButton, 0);
            this.CloseRequestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseRequestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.CloseRequestButton.Location = new System.Drawing.Point(3, 380);
            this.CloseRequestButton.Name = "CloseRequestButton";
            this.CloseRequestButton.RippleColor = System.Drawing.Color.Black;
            this.CloseRequestButton.RoundingEnable = true;
            this.MainLayoutTable.SetRow(this.CloseRequestButton, 1);
            this.CloseRequestButton.Size = new System.Drawing.Size(622, 24);
            this.CloseRequestButton.TabIndex = 2;
            this.CloseRequestButton.Text = "Закрыть продажу";
            this.CloseRequestButton.TextHover = null;
            this.CloseRequestButton.UseDownPressEffectOnClick = false;
            this.CloseRequestButton.UseRippleEffect = true;
            this.CloseRequestButton.UseZoomEffectOnHover = false;
            // 
            // gridControl1
            // 
            this.MainLayoutTable.SetColumn(this.gridControl1, 0);
            this.gridControl1.DataSource = this.saleModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.MainLayoutTable.SetRow(this.gridControl1, 0);
            this.gridControl1.Size = new System.Drawing.Size(622, 371);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSaleNumber,
            this.colSaleDate,
            this.colWarehouse,
            this.colSeller,
            this.colPriceList,
            this.colPositionCount,
            this.colIsClosed});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // saleModelBindingSource
            // 
            this.saleModelBindingSource.DataSource = typeof(ApplicationModels.SaleModel);
            // 
            // colSaleNumber
            // 
            this.colSaleNumber.FieldName = "SaleNumber";
            this.colSaleNumber.Name = "colSaleNumber";
            this.colSaleNumber.Visible = true;
            this.colSaleNumber.VisibleIndex = 1;
            // 
            // colSaleDate
            // 
            this.colSaleDate.FieldName = "SaleDate";
            this.colSaleDate.Name = "colSaleDate";
            this.colSaleDate.Visible = true;
            this.colSaleDate.VisibleIndex = 2;
            // 
            // colWarehouse
            // 
            this.colWarehouse.FieldName = "Warehouse";
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Visible = true;
            this.colWarehouse.VisibleIndex = 3;
            // 
            // colSeller
            // 
            this.colSeller.FieldName = "Seller";
            this.colSeller.Name = "colSeller";
            this.colSeller.Visible = true;
            this.colSeller.VisibleIndex = 4;
            // 
            // colPriceList
            // 
            this.colPriceList.FieldName = "PriceList";
            this.colPriceList.Name = "colPriceList";
            this.colPriceList.Visible = true;
            this.colPriceList.VisibleIndex = 5;
            // 
            // colPositionCount
            // 
            this.colPositionCount.FieldName = "PositionCount";
            this.colPositionCount.Name = "colPositionCount";
            this.colPositionCount.Visible = true;
            this.colPositionCount.VisibleIndex = 6;
            // 
            // colIsClosed
            // 
            this.colIsClosed.FieldName = "IsClosed";
            this.colIsClosed.Name = "colIsClosed";
            this.colIsClosed.Visible = true;
            this.colIsClosed.VisibleIndex = 7;
            // 
            // SalesView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.MainLayoutTable);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.hideContainerBottom);
            this.Name = "SalesView";
            this.Size = new System.Drawing.Size(628, 455);
            ((System.ComponentModel.ISupportInitialize)(this.DockPanelManager)).EndInit();
            this.hideContainerBottom.ResumeLayout(false);
            this.CreateSalePanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainLayoutTable)).EndInit();
            this.MainLayoutTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private DevExpress.XtraBars.Docking.DockManager DockPanelManager;
        internal System.Windows.Forms.Panel ButtonsPanel;
        public CoreClient.StyleExtensions.Controls.BaseStyledButton CloseViewButton;
        private DevExpress.XtraBars.Docking.DockPanel CreateSalePanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        public DevExpress.Utils.Layout.TablePanel MainLayoutTable;
        public CoreClient.StyleExtensions.Controls.BaseStyledButton CloseRequestButton;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerBottom;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource saleModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colSeller;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceList;
        private DevExpress.XtraGrid.Columns.GridColumn colPositionCount;
        private DevExpress.XtraGrid.Columns.GridColumn colIsClosed;
    }
}
