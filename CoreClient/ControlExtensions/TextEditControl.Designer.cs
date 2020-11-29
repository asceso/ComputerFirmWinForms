namespace CoreClient.ControlExtensions
{
    partial class TextEditControl
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
            this.TextEditValueBox = new System.Windows.Forms.TextBox();
            this.TextEditHeader = new System.Windows.Forms.Label();
            this.TextEditPanel = new System.Windows.Forms.Panel();
            this.TextEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextEditValueBox
            // 
            this.TextEditValueBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextEditValueBox.Location = new System.Drawing.Point(56, 3);
            this.TextEditValueBox.Name = "TextEditValueBox";
            this.TextEditValueBox.Size = new System.Drawing.Size(141, 20);
            this.TextEditValueBox.TabIndex = 0;
            // 
            // TextEditHeader
            // 
            this.TextEditHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextEditHeader.Location = new System.Drawing.Point(0, 0);
            this.TextEditHeader.MinimumSize = new System.Drawing.Size(50, 0);
            this.TextEditHeader.Name = "TextEditHeader";
            this.TextEditHeader.Size = new System.Drawing.Size(50, 25);
            this.TextEditHeader.TabIndex = 1;
            this.TextEditHeader.Text = "Header";
            this.TextEditHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextEditPanel
            // 
            this.TextEditPanel.Controls.Add(this.TextEditValueBox);
            this.TextEditPanel.Controls.Add(this.TextEditHeader);
            this.TextEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditPanel.Location = new System.Drawing.Point(0, 0);
            this.TextEditPanel.Name = "TextEditPanel";
            this.TextEditPanel.Size = new System.Drawing.Size(200, 25);
            this.TextEditPanel.TabIndex = 2;
            // 
            // TextEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextEditPanel);
            this.Name = "TextEditControl";
            this.Size = new System.Drawing.Size(200, 25);
            this.TextEditPanel.ResumeLayout(false);
            this.TextEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextEditValueBox;
        private System.Windows.Forms.Label TextEditHeader;
        private System.Windows.Forms.Panel TextEditPanel;
    }
}
