namespace MainClient.UserControls.Settings
{
    partial class SettingsView
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestTypesCheckedComboBox = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.PositionComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddingPermissionCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.AddingPositionCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.DeletePositionPermissionButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.AddPositionPermissionButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.mainLayoutPanel = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.label7 = new System.Windows.Forms.Label();
            this.TechPosition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PositionPermissionsGrid = new DevExpress.XtraGrid.GridControl();
            this.positionPermissionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPermission = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RequestTypesCheckedComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddingPermissionCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddingPositionCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutPanel)).BeginInit();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionPermissionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionPermissionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.mainLayoutPanel.SetColumn(this.label5, 0);
            this.mainLayoutPanel.SetColumnSpan(this.label5, 5);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 125);
            this.label5.Name = "label5";
            this.mainLayoutPanel.SetRow(this.label5, 4);
            this.label5.Size = new System.Drawing.Size(605, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Должность - Разрешения";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.mainLayoutPanel.SetColumn(this.label1, 0);
            this.mainLayoutPanel.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.mainLayoutPanel.SetRow(this.label1, 1);
            this.label1.Size = new System.Drawing.Size(605, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройка связей для должностей:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RequestTypesCheckedComboBox
            // 
            this.mainLayoutPanel.SetColumn(this.RequestTypesCheckedComboBox, 2);
            this.mainLayoutPanel.SetColumnSpan(this.RequestTypesCheckedComboBox, 3);
            this.RequestTypesCheckedComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestTypesCheckedComboBox.Enabled = false;
            this.RequestTypesCheckedComboBox.Location = new System.Drawing.Point(296, 103);
            this.RequestTypesCheckedComboBox.Name = "RequestTypesCheckedComboBox";
            this.RequestTypesCheckedComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RequestTypesCheckedComboBox.Properties.PopupSizeable = false;
            this.RequestTypesCheckedComboBox.Properties.SelectAllItemVisible = false;
            this.mainLayoutPanel.SetRow(this.RequestTypesCheckedComboBox, 3);
            this.RequestTypesCheckedComboBox.Size = new System.Drawing.Size(312, 20);
            this.RequestTypesCheckedComboBox.TabIndex = 4;
            this.RequestTypesCheckedComboBox.QueryCloseUp += new System.ComponentModel.CancelEventHandler(this.RequestTypesCheckedComboBoxQueryCloseUp);
            this.RequestTypesCheckedComboBox.EditValueChanged += new System.EventHandler(this.RequestTypesCheckedComboBox_EditValueChanged);
            // 
            // PositionComboBox
            // 
            this.mainLayoutPanel.SetColumn(this.PositionComboBox, 0);
            this.mainLayoutPanel.SetColumnSpan(this.PositionComboBox, 2);
            this.PositionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionComboBox.Location = new System.Drawing.Point(3, 103);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PositionComboBox.Properties.NullText = "Выберите должность";
            this.PositionComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.mainLayoutPanel.SetRow(this.PositionComboBox, 3);
            this.PositionComboBox.Size = new System.Drawing.Size(287, 20);
            this.PositionComboBox.TabIndex = 5;
            this.PositionComboBox.SelectedIndexChanged += new System.EventHandler(this.PositionComboBoxSelectedIndexChanged);
            // 
            // label3
            // 
            this.mainLayoutPanel.SetColumn(this.label3, 0);
            this.mainLayoutPanel.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label3.Name = "label3";
            this.mainLayoutPanel.SetRow(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(287, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Должность";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.mainLayoutPanel.SetColumn(this.label4, 2);
            this.mainLayoutPanel.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(296, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.mainLayoutPanel.SetRow(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(312, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Типы заявок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.mainLayoutPanel.SetColumn(this.label6, 3);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(321, 370);
            this.label6.Name = "label6";
            this.mainLayoutPanel.SetRow(this.label6, 6);
            this.label6.Size = new System.Drawing.Size(94, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Разрешение";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddingPermissionCB
            // 
            this.AddingPermissionCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumn(this.AddingPermissionCB, 4);
            this.AddingPermissionCB.Location = new System.Drawing.Point(421, 378);
            this.AddingPermissionCB.Name = "AddingPermissionCB";
            this.AddingPermissionCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AddingPermissionCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.mainLayoutPanel.SetRow(this.AddingPermissionCB, 6);
            this.AddingPermissionCB.Size = new System.Drawing.Size(187, 20);
            this.AddingPermissionCB.TabIndex = 3;
            // 
            // AddingPositionCB
            // 
            this.AddingPositionCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLayoutPanel.SetColumn(this.AddingPositionCB, 1);
            this.AddingPositionCB.Location = new System.Drawing.Point(103, 378);
            this.AddingPositionCB.Name = "AddingPositionCB";
            this.AddingPositionCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AddingPositionCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.mainLayoutPanel.SetRow(this.AddingPositionCB, 6);
            this.AddingPositionCB.Size = new System.Drawing.Size(187, 20);
            this.AddingPositionCB.TabIndex = 1;
            // 
            // label2
            // 
            this.mainLayoutPanel.SetColumn(this.label2, 0);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 370);
            this.label2.Name = "label2";
            this.mainLayoutPanel.SetRow(this.label2, 6);
            this.label2.Size = new System.Drawing.Size(94, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Должность";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeletePositionPermissionButton
            // 
            this.DeletePositionPermissionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePositionPermissionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.DeletePositionPermissionButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.DeletePositionPermissionButton.BackColorGradientEnabled = false;
            this.DeletePositionPermissionButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.DeletePositionPermissionButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.DeletePositionPermissionButton.BorderColorEnabled = false;
            this.DeletePositionPermissionButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.DeletePositionPermissionButton.BorderColorOnHoverEnabled = false;
            this.mainLayoutPanel.SetColumn(this.DeletePositionPermissionButton, 3);
            this.mainLayoutPanel.SetColumnSpan(this.DeletePositionPermissionButton, 2);
            this.DeletePositionPermissionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePositionPermissionButton.Enabled = false;
            this.DeletePositionPermissionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.DeletePositionPermissionButton.Location = new System.Drawing.Point(321, 409);
            this.DeletePositionPermissionButton.Name = "DeletePositionPermissionButton";
            this.DeletePositionPermissionButton.RippleColor = System.Drawing.Color.Black;
            this.DeletePositionPermissionButton.RoundingEnable = true;
            this.mainLayoutPanel.SetRow(this.DeletePositionPermissionButton, 7);
            this.DeletePositionPermissionButton.Size = new System.Drawing.Size(287, 24);
            this.DeletePositionPermissionButton.TabIndex = 1;
            this.DeletePositionPermissionButton.Text = "Удалить связь";
            this.DeletePositionPermissionButton.TextHover = null;
            this.DeletePositionPermissionButton.UseDownPressEffectOnClick = false;
            this.DeletePositionPermissionButton.UseRippleEffect = true;
            this.DeletePositionPermissionButton.UseZoomEffectOnHover = false;
            // 
            // AddPositionPermissionButton
            // 
            this.AddPositionPermissionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPositionPermissionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.AddPositionPermissionButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.AddPositionPermissionButton.BackColorGradientEnabled = false;
            this.AddPositionPermissionButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.AddPositionPermissionButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.AddPositionPermissionButton.BorderColorEnabled = false;
            this.AddPositionPermissionButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.AddPositionPermissionButton.BorderColorOnHoverEnabled = false;
            this.mainLayoutPanel.SetColumn(this.AddPositionPermissionButton, 0);
            this.mainLayoutPanel.SetColumnSpan(this.AddPositionPermissionButton, 2);
            this.AddPositionPermissionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPositionPermissionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.AddPositionPermissionButton.Location = new System.Drawing.Point(3, 409);
            this.AddPositionPermissionButton.Name = "AddPositionPermissionButton";
            this.AddPositionPermissionButton.RippleColor = System.Drawing.Color.Black;
            this.AddPositionPermissionButton.RoundingEnable = true;
            this.mainLayoutPanel.SetRow(this.AddPositionPermissionButton, 7);
            this.AddPositionPermissionButton.Size = new System.Drawing.Size(287, 24);
            this.AddPositionPermissionButton.TabIndex = 0;
            this.AddPositionPermissionButton.Text = "Добавить связь";
            this.AddPositionPermissionButton.TextHover = null;
            this.AddPositionPermissionButton.UseDownPressEffectOnClick = false;
            this.AddPositionPermissionButton.UseRippleEffect = true;
            this.AddPositionPermissionButton.UseZoomEffectOnHover = false;
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoScroll = true;
            this.mainLayoutPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.mainLayoutPanel.Controls.Add(this.tablePanel1);
            this.mainLayoutPanel.Controls.Add(this.PositionPermissionsGrid);
            this.mainLayoutPanel.Controls.Add(this.AddingPermissionCB);
            this.mainLayoutPanel.Controls.Add(this.label6);
            this.mainLayoutPanel.Controls.Add(this.DeletePositionPermissionButton);
            this.mainLayoutPanel.Controls.Add(this.AddPositionPermissionButton);
            this.mainLayoutPanel.Controls.Add(this.AddingPositionCB);
            this.mainLayoutPanel.Controls.Add(this.label4);
            this.mainLayoutPanel.Controls.Add(this.label2);
            this.mainLayoutPanel.Controls.Add(this.label3);
            this.mainLayoutPanel.Controls.Add(this.RequestTypesCheckedComboBox);
            this.mainLayoutPanel.Controls.Add(this.PositionComboBox);
            this.mainLayoutPanel.Controls.Add(this.label5);
            this.mainLayoutPanel.Controls.Add(this.label1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 23);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 220F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 36F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.mainLayoutPanel.Size = new System.Drawing.Size(628, 432);
            this.mainLayoutPanel.TabIndex = 3;
            // 
            // tablePanel1
            // 
            this.mainLayoutPanel.SetColumn(this.tablePanel1, 0);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.mainLayoutPanel.SetColumnSpan(this.tablePanel1, 3);
            this.tablePanel1.Controls.Add(this.label7);
            this.tablePanel1.Controls.Add(this.TechPosition);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(3, 3);
            this.tablePanel1.Name = "tablePanel1";
            this.mainLayoutPanel.SetRow(this.tablePanel1, 0);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(312, 44);
            this.tablePanel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tablePanel1.SetColumn(this.label7, 0);
            this.label7.Location = new System.Drawing.Point(3, 15);
            this.label7.Name = "label7";
            this.tablePanel1.SetRow(this.label7, 0);
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Должность используемая в заявках на ремонт";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TechPosition
            // 
            this.tablePanel1.SetColumn(this.TechPosition, 1);
            this.TechPosition.Location = new System.Drawing.Point(142, 12);
            this.TechPosition.Name = "TechPosition";
            this.TechPosition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.TechPosition, 0);
            this.TechPosition.Size = new System.Drawing.Size(167, 20);
            this.TechPosition.TabIndex = 12;
            this.TechPosition.SelectedIndexChanged += new System.EventHandler(this.TechPositionSelectedIndexChanged);
            // 
            // PositionPermissionsGrid
            // 
            this.mainLayoutPanel.SetColumn(this.PositionPermissionsGrid, 0);
            this.mainLayoutPanel.SetColumnSpan(this.PositionPermissionsGrid, 5);
            this.PositionPermissionsGrid.DataSource = this.positionPermissionModelBindingSource;
            this.PositionPermissionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionPermissionsGrid.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PositionPermissionsGrid.Location = new System.Drawing.Point(3, 153);
            this.PositionPermissionsGrid.MainView = this.gridView1;
            this.PositionPermissionsGrid.Name = "PositionPermissionsGrid";
            this.mainLayoutPanel.SetRow(this.PositionPermissionsGrid, 5);
            this.PositionPermissionsGrid.Size = new System.Drawing.Size(605, 214);
            this.PositionPermissionsGrid.TabIndex = 10;
            this.PositionPermissionsGrid.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.PositionPermissionsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // positionPermissionModelBindingSource
            // 
            this.positionPermissionModelBindingSource.DataSource = typeof(ApplicationModels.PositionPermissionModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPosition,
            this.colPermission});
            this.gridView1.GridControl = this.PositionPermissionsGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.OptionsColumn.AllowEdit = false;
            this.colPosition.OptionsColumn.ReadOnly = true;
            this.colPosition.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.True;
            this.colPosition.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 0;
            // 
            // colPermission
            // 
            this.colPermission.FieldName = "Permission";
            this.colPermission.Name = "colPermission";
            this.colPermission.OptionsColumn.AllowEdit = false;
            this.colPermission.OptionsColumn.ReadOnly = true;
            this.colPermission.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.True;
            this.colPermission.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;
            this.colPermission.Visible = true;
            this.colPermission.VisibleIndex = 1;
            // 
            // SettingsView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "SettingsView";
            this.Controls.SetChildIndex(this.mainLayoutPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.RequestTypesCheckedComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddingPermissionCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddingPositionCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutPanel)).EndInit();
            this.mainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionPermissionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionPermissionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit RequestTypesCheckedComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit PositionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton DeletePositionPermissionButton;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton AddPositionPermissionButton;
        private DevExpress.XtraEditors.ComboBoxEdit AddingPermissionCB;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit AddingPositionCB;
        private System.Windows.Forms.Label label2;
        private DevExpress.Utils.Layout.TablePanel mainLayoutPanel;
        private DevExpress.XtraGrid.GridControl PositionPermissionsGrid;
        private System.Windows.Forms.BindingSource positionPermissionModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colPermission;
        private DevExpress.XtraEditors.ComboBoxEdit TechPosition;
        private System.Windows.Forms.Label label7;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
    }
}
