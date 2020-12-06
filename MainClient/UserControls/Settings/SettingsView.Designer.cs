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
            this.button1 = new System.Windows.Forms.Button();
            this.SettingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SettingsParam2 = new System.Windows.Forms.ComboBox();
            this.RequestTypesCheckedComboBox = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.PositionComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SettingsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestTypesCheckedComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionComboBox.Properties)).BeginInit();
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
            // SettingsTable
            // 
            this.SettingsTable.ColumnCount = 4;
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SettingsTable.Controls.Add(this.label1, 0, 0);
            this.SettingsTable.Controls.Add(this.label2, 0, 3);
            this.SettingsTable.Controls.Add(this.SettingsParam2, 1, 3);
            this.SettingsTable.Controls.Add(this.RequestTypesCheckedComboBox, 1, 2);
            this.SettingsTable.Controls.Add(this.PositionComboBox, 0, 2);
            this.SettingsTable.Controls.Add(this.label3, 0, 1);
            this.SettingsTable.Controls.Add(this.label4, 1, 1);
            this.SettingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTable.Location = new System.Drawing.Point(0, 23);
            this.SettingsTable.Name = "SettingsTable";
            this.SettingsTable.RowCount = 5;
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsTable.Size = new System.Drawing.Size(594, 421);
            this.SettingsTable.TabIndex = 2;
            // 
            // label1
            // 
            this.SettingsTable.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройка связей для должностей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Параметр 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsParam2
            // 
            this.SettingsParam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTable.SetColumnSpan(this.SettingsParam2, 2);
            this.SettingsParam2.FormattingEnabled = true;
            this.SettingsParam2.Location = new System.Drawing.Point(153, 87);
            this.SettingsParam2.Name = "SettingsParam2";
            this.SettingsParam2.Size = new System.Drawing.Size(344, 21);
            this.SettingsParam2.TabIndex = 3;
            // 
            // RequestTypesCheckedComboBox
            // 
            this.RequestTypesCheckedComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTable.SetColumnSpan(this.RequestTypesCheckedComboBox, 2);
            this.RequestTypesCheckedComboBox.Enabled = false;
            this.RequestTypesCheckedComboBox.Location = new System.Drawing.Point(153, 52);
            this.RequestTypesCheckedComboBox.Name = "RequestTypesCheckedComboBox";
            this.RequestTypesCheckedComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RequestTypesCheckedComboBox.Properties.PopupSizeable = false;
            this.RequestTypesCheckedComboBox.Properties.SelectAllItemVisible = false;
            this.RequestTypesCheckedComboBox.Size = new System.Drawing.Size(344, 20);
            this.RequestTypesCheckedComboBox.TabIndex = 4;
            this.RequestTypesCheckedComboBox.QueryCloseUp += new System.ComponentModel.CancelEventHandler(this.RequestTypesCheckedComboBoxQueryCloseUp);
            this.RequestTypesCheckedComboBox.EditValueChanged += new System.EventHandler(this.RequestTypesCheckedComboBox_EditValueChanged);
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionComboBox.Location = new System.Drawing.Point(3, 52);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PositionComboBox.Properties.NullText = "Выберите должность";
            this.PositionComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.PositionComboBox.Size = new System.Drawing.Size(144, 20);
            this.PositionComboBox.TabIndex = 5;
            this.PositionComboBox.SelectedIndexChanged += new System.EventHandler(this.PositionComboBoxSelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Должность";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.SettingsTable.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(153, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Типы заявок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SettingsTable);
            this.Name = "SettingsView";
            this.Controls.SetChildIndex(this.SettingsTable, 0);
            this.SettingsTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RequestTypesCheckedComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionComboBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel SettingsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SettingsParam2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit RequestTypesCheckedComboBox;
        private DevExpress.XtraEditors.ComboBoxEdit PositionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
