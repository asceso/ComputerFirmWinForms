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
            this.headersPanel = new System.Windows.Forms.Panel();
            this.valuesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ContactNumberTE = new System.Windows.Forms.MaskedTextBox();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IsDeletedCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsLeadCB.Properties)).BeginInit();
            this.headersPanel.SuspendLayout();
            this.valuesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.valuesPanel);
            this.ContentPanel.Controls.Add(this.headersPanel);
            // 
            // IsDeletedCB
            // 
            this.IsDeletedCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IsDeletedCB.Location = new System.Drawing.Point(3, 175);
            this.IsDeletedCB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.IsDeletedCB.Name = "IsDeletedCB";
            this.IsDeletedCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IsDeletedCB.Properties.ReadOnly = true;
            this.IsDeletedCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IsDeletedCB.Size = new System.Drawing.Size(463, 20);
            this.IsDeletedCB.TabIndex = 11;
            // 
            // LastNameTE
            // 
            this.LastNameTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameTE.Location = new System.Drawing.Point(3, 76);
            this.LastNameTE.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.LastNameTE.Name = "LastNameTE";
            this.LastNameTE.Size = new System.Drawing.Size(463, 20);
            this.LastNameTE.TabIndex = 8;
            // 
            // SecondNameTE
            // 
            this.SecondNameTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondNameTE.Location = new System.Drawing.Point(3, 43);
            this.SecondNameTE.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.SecondNameTE.Name = "SecondNameTE";
            this.SecondNameTE.Size = new System.Drawing.Size(463, 20);
            this.SecondNameTE.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(0, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(0, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(0, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Контактный номер";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(0, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Холодный контакт";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(0, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Удален в архив";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstNameTE
            // 
            this.FirstNameTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameTE.Location = new System.Drawing.Point(3, 10);
            this.FirstNameTE.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.FirstNameTE.Name = "FirstNameTE";
            this.FirstNameTE.Size = new System.Drawing.Size(463, 20);
            this.FirstNameTE.TabIndex = 6;
            // 
            // IsLeadCB
            // 
            this.IsLeadCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IsLeadCB.Location = new System.Drawing.Point(3, 142);
            this.IsLeadCB.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.IsLeadCB.Name = "IsLeadCB";
            this.IsLeadCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IsLeadCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.IsLeadCB.Size = new System.Drawing.Size(463, 20);
            this.IsLeadCB.TabIndex = 10;
            // 
            // headersPanel
            // 
            this.headersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headersPanel.Controls.Add(this.label6);
            this.headersPanel.Controls.Add(this.label5);
            this.headersPanel.Controls.Add(this.label4);
            this.headersPanel.Controls.Add(this.label3);
            this.headersPanel.Controls.Add(this.label2);
            this.headersPanel.Controls.Add(this.label1);
            this.headersPanel.Location = new System.Drawing.Point(3, 4);
            this.headersPanel.Name = "headersPanel";
            this.headersPanel.Size = new System.Drawing.Size(138, 421);
            this.headersPanel.TabIndex = 1;
            // 
            // valuesPanel
            // 
            this.valuesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesPanel.Controls.Add(this.FirstNameTE);
            this.valuesPanel.Controls.Add(this.SecondNameTE);
            this.valuesPanel.Controls.Add(this.LastNameTE);
            this.valuesPanel.Controls.Add(this.ContactNumberTE);
            this.valuesPanel.Controls.Add(this.IsLeadCB);
            this.valuesPanel.Controls.Add(this.IsDeletedCB);
            this.valuesPanel.Location = new System.Drawing.Point(147, 5);
            this.valuesPanel.Name = "valuesPanel";
            this.valuesPanel.Size = new System.Drawing.Size(476, 420);
            this.valuesPanel.TabIndex = 2;
            // 
            // ContactNumberTE
            // 
            this.ContactNumberTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactNumberTE.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.ContactNumberTE.Location = new System.Drawing.Point(3, 109);
            this.ContactNumberTE.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ContactNumberTE.Name = "ContactNumberTE";
            this.ContactNumberTE.Size = new System.Drawing.Size(463, 20);
            this.ContactNumberTE.TabIndex = 9;
            this.ContactNumberTE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.headersPanel.ResumeLayout(false);
            this.valuesPanel.ResumeLayout(false);
            this.valuesPanel.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel valuesPanel;
        private System.Windows.Forms.Panel headersPanel;
        private System.Windows.Forms.MaskedTextBox ContactNumberTE;
    }
}
