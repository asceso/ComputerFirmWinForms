namespace InjectingCoreLibrary.MessagingCore.MessageBox
{
    partial class MessageInjectForm
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
            this.OKButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.Tomato;
            this.OKButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.OKButton.BackColorGradientEnabled = false;
            this.OKButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.OKButton.BorderColor = System.Drawing.Color.Tomato;
            this.OKButton.BorderColorEnabled = false;
            this.OKButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.OKButton.BorderColorOnHoverEnabled = false;
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.ForeColor = System.Drawing.Color.Black;
            this.OKButton.Location = new System.Drawing.Point(108, 123);
            this.OKButton.Name = "OKButton";
            this.OKButton.RippleColor = System.Drawing.Color.Black;
            this.OKButton.RoundingEnable = true;
            this.OKButton.Size = new System.Drawing.Size(100, 25);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.TextHover = null;
            this.OKButton.UseDownPressEffectOnClick = false;
            this.OKButton.UseRippleEffect = true;
            this.OKButton.UseZoomEffectOnHover = false;
            // 
            // MessageInjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 150);
            this.Controls.Add(this.OKButton);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MessageInjectForm";
            this.Text = "MessageInjectForm";
            this.Controls.SetChildIndex(this.OKButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreClient.StyleExtensions.Controls.BaseStyledButton OKButton;
    }
}