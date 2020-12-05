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
            this.SettingsParam1 = new System.Windows.Forms.TextBox();
            this.SettingsParam2 = new System.Windows.Forms.ComboBox();
            this.SettingsTable.SuspendLayout();
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
            this.SettingsTable.ColumnCount = 3;
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SettingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SettingsTable.Controls.Add(this.label1, 0, 0);
            this.SettingsTable.Controls.Add(this.label2, 0, 1);
            this.SettingsTable.Controls.Add(this.SettingsParam1, 1, 0);
            this.SettingsTable.Controls.Add(this.SettingsParam2, 1, 1);
            this.SettingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTable.Location = new System.Drawing.Point(0, 23);
            this.SettingsTable.Name = "SettingsTable";
            this.SettingsTable.RowCount = 3;
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SettingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SettingsTable.Size = new System.Drawing.Size(594, 421);
            this.SettingsTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметр 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Параметр 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsParam1
            // 
            this.SettingsParam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsParam1.Location = new System.Drawing.Point(153, 7);
            this.SettingsParam1.Name = "SettingsParam1";
            this.SettingsParam1.Size = new System.Drawing.Size(410, 20);
            this.SettingsParam1.TabIndex = 2;
            // 
            // SettingsParam2
            // 
            this.SettingsParam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsParam2.FormattingEnabled = true;
            this.SettingsParam2.Location = new System.Drawing.Point(153, 42);
            this.SettingsParam2.Name = "SettingsParam2";
            this.SettingsParam2.Size = new System.Drawing.Size(410, 21);
            this.SettingsParam2.TabIndex = 3;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SettingsTable);
            this.Name = "SettingsView";
            this.Controls.SetChildIndex(this.SettingsTable, 0);
            this.SettingsTable.ResumeLayout(false);
            this.SettingsTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel SettingsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SettingsParam1;
        private System.Windows.Forms.ComboBox SettingsParam2;
    }
}
