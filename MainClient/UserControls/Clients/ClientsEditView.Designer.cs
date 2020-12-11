namespace MainClient.UserControls.Clients
{
    partial class ClientsEditView
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
            this.IsDeletedCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LastNameTE = new DevExpress.XtraEditors.TextEdit();
            this.SecondNameTE = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstNameTE = new DevExpress.XtraEditors.TextEdit();
            this.IsLeadCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ContactNumberTE = new System.Windows.Forms.MaskedTextBox();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsDeletedCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsLeadCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.tablePanel1);
            // 
            // IsDeletedCB
            // 
            this.IsDeletedCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.IsDeletedCB, 1);
            this.IsDeletedCB.Location = new System.Drawing.Point(138, 210);
            this.IsDeletedCB.Name = "IsDeletedCB";
            this.IsDeletedCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IsDeletedCB.Properties.ReadOnly = true;
            this.IsDeletedCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.IsDeletedCB, 5);
            this.IsDeletedCB.Size = new System.Drawing.Size(485, 20);
            this.IsDeletedCB.TabIndex = 11;
            // 
            // LastNameTE
            // 
            this.LastNameTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.LastNameTE, 1);
            this.LastNameTE.Location = new System.Drawing.Point(138, 90);
            this.LastNameTE.Name = "LastNameTE";
            this.tablePanel1.SetRow(this.LastNameTE, 2);
            this.LastNameTE.Size = new System.Drawing.Size(485, 20);
            this.LastNameTE.TabIndex = 8;
            // 
            // SecondNameTE
            // 
            this.SecondNameTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.SecondNameTE, 1);
            this.SecondNameTE.Location = new System.Drawing.Point(138, 50);
            this.SecondNameTE.Name = "SecondNameTE";
            this.tablePanel1.SetRow(this.SecondNameTE, 1);
            this.SecondNameTE.Size = new System.Drawing.Size(485, 20);
            this.SecondNameTE.TabIndex = 7;
            // 
            // label1
            // 
            this.tablePanel1.SetColumn(this.label1, 0);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.tablePanel1.SetColumn(this.label2, 0);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.tablePanel1.SetRow(this.label2, 1);
            this.label2.Size = new System.Drawing.Size(129, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.tablePanel1.SetColumn(this.label3, 0);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.tablePanel1.SetRow(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(129, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.tablePanel1.SetColumn(this.label4, 0);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.tablePanel1.SetRow(this.label4, 3);
            this.label4.Size = new System.Drawing.Size(129, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Контактный номер";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.tablePanel1.SetColumn(this.label5, 0);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.tablePanel1.SetRow(this.label5, 4);
            this.label5.Size = new System.Drawing.Size(129, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Холодный контакт";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.tablePanel1.SetColumn(this.label6, 0);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.tablePanel1.SetRow(this.label6, 5);
            this.label6.Size = new System.Drawing.Size(129, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Удален в архив";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstNameTE
            // 
            this.FirstNameTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.FirstNameTE, 1);
            this.FirstNameTE.Location = new System.Drawing.Point(138, 10);
            this.FirstNameTE.Name = "FirstNameTE";
            this.FirstNameTE.Properties.ValidateOnEnterKey = true;
            this.tablePanel1.SetRow(this.FirstNameTE, 0);
            this.FirstNameTE.Size = new System.Drawing.Size(485, 20);
            this.FirstNameTE.TabIndex = 6;
            // 
            // IsLeadCB
            // 
            this.IsLeadCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.IsLeadCB, 1);
            this.IsLeadCB.Location = new System.Drawing.Point(138, 170);
            this.IsLeadCB.Name = "IsLeadCB";
            this.IsLeadCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IsLeadCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.tablePanel1.SetRow(this.IsLeadCB, 4);
            this.IsLeadCB.Size = new System.Drawing.Size(485, 20);
            this.IsLeadCB.TabIndex = 10;
            // 
            // ContactNumberTE
            // 
            this.ContactNumberTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel1.SetColumn(this.ContactNumberTE, 1);
            this.ContactNumberTE.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.ContactNumberTE.Location = new System.Drawing.Point(138, 129);
            this.ContactNumberTE.Name = "ContactNumberTE";
            this.tablePanel1.SetRow(this.ContactNumberTE, 3);
            this.ContactNumberTE.Size = new System.Drawing.Size(485, 21);
            this.ContactNumberTE.TabIndex = 9;
            this.ContactNumberTE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 135F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 0F)});
            this.tablePanel1.Controls.Add(this.IsDeletedCB);
            this.tablePanel1.Controls.Add(this.IsLeadCB);
            this.tablePanel1.Controls.Add(this.ContactNumberTE);
            this.tablePanel1.Controls.Add(this.LastNameTE);
            this.tablePanel1.Controls.Add(this.SecondNameTE);
            this.tablePanel1.Controls.Add(this.FirstNameTE);
            this.tablePanel1.Controls.Add(this.label6);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Controls.Add(this.label5);
            this.tablePanel1.Controls.Add(this.label2);
            this.tablePanel1.Controls.Add(this.label4);
            this.tablePanel1.Controls.Add(this.label3);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(626, 428);
            this.tablePanel1.TabIndex = 3;
            // 
            // ClientsEditView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Name = "ClientsEditView";
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IsDeletedCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsLeadCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit IsDeletedCB;
        private DevExpress.XtraEditors.TextEdit LastNameTE;
        private DevExpress.XtraEditors.TextEdit SecondNameTE;
        private DevExpress.XtraEditors.TextEdit FirstNameTE;
        private DevExpress.XtraEditors.ComboBoxEdit IsLeadCB;
        private System.Windows.Forms.MaskedTextBox ContactNumberTE;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
    }
}
