namespace MainClient.UserControls.Clients
{
    partial class ClientsView
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
            this.ClientsGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecondName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsLead = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.ClientsGrid);
            this.ContentPanel.Size = new System.Drawing.Size(628, 532);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsGrid.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.ClientsGrid.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.ClientsGrid.Location = new System.Drawing.Point(0, 0);
            this.ClientsGrid.MainView = this.gridView1;
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.Size = new System.Drawing.Size(628, 532);
            this.ClientsGrid.TabIndex = 0;
            this.ClientsGrid.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.ClientsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colSecondName,
            this.colLastName,
            this.colContactNumber,
            this.colIsLead,
            this.colIsDeleted});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.ClientsGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.ShowFooterItem = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIsDeleted, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.GridRowStyle);
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.AllowEdit = false;
            this.colFirstName.OptionsColumn.AllowFocus = false;
            this.colFirstName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FirstName", "Всего клиентов={0}")});
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            this.colFirstName.Width = 124;
            // 
            // colSecondName
            // 
            this.colSecondName.FieldName = "SecondName";
            this.colSecondName.Name = "colSecondName";
            this.colSecondName.OptionsColumn.AllowEdit = false;
            this.colSecondName.OptionsColumn.AllowFocus = false;
            this.colSecondName.Visible = true;
            this.colSecondName.VisibleIndex = 1;
            this.colSecondName.Width = 104;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.AllowEdit = false;
            this.colLastName.OptionsColumn.AllowFocus = false;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 104;
            // 
            // colContactNumber
            // 
            this.colContactNumber.FieldName = "ContactNumber";
            this.colContactNumber.Name = "colContactNumber";
            this.colContactNumber.OptionsColumn.AllowEdit = false;
            this.colContactNumber.OptionsColumn.AllowFocus = false;
            this.colContactNumber.Visible = true;
            this.colContactNumber.VisibleIndex = 3;
            this.colContactNumber.Width = 69;
            // 
            // colIsLead
            // 
            this.colIsLead.FieldName = "IsLead";
            this.colIsLead.Name = "colIsLead";
            this.colIsLead.OptionsColumn.AllowEdit = false;
            this.colIsLead.OptionsColumn.AllowFocus = false;
            this.colIsLead.Visible = true;
            this.colIsLead.VisibleIndex = 4;
            this.colIsLead.Width = 69;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            this.colIsDeleted.OptionsColumn.AllowEdit = false;
            this.colIsDeleted.OptionsColumn.AllowFocus = false;
            this.colIsDeleted.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colIsDeleted.Visible = true;
            this.colIsDeleted.VisibleIndex = 5;
            this.colIsDeleted.Width = 77;
            // 
            // ClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ClientsView";
            this.Size = new System.Drawing.Size(628, 555);
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ClientsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colSecondName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colIsLead;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
    }
}
