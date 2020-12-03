namespace InjectingCoreLibrary.MessagingCore.AskBox
{
    partial class AskInjectForm
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
            this.YesButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.NoButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.YesButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.YesButton.BackColorGradientEnabled = false;
            this.YesButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.YesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.YesButton.BorderColorEnabled = false;
            this.YesButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.YesButton.BorderColorOnHoverEnabled = false;
            this.YesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.YesButton.Location = new System.Drawing.Point(42, 144);
            this.YesButton.Name = "YesButton";
            this.YesButton.RippleColor = System.Drawing.Color.Black;
            this.YesButton.RoundingEnable = true;
            this.YesButton.Size = new System.Drawing.Size(100, 30);
            this.YesButton.TabIndex = 7;
            this.YesButton.Text = "Да";
            this.YesButton.TextHover = null;
            this.YesButton.UseDownPressEffectOnClick = false;
            this.YesButton.UseRippleEffect = true;
            this.YesButton.UseZoomEffectOnHover = false;
            this.YesButton.Click += new System.EventHandler(this.YesButtonClick);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.NoButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.NoButton.BackColorGradientEnabled = false;
            this.NoButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.NoButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.NoButton.BorderColorEnabled = false;
            this.NoButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.NoButton.BorderColorOnHoverEnabled = false;
            this.NoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.NoButton.Location = new System.Drawing.Point(168, 144);
            this.NoButton.Name = "NoButton";
            this.NoButton.RippleColor = System.Drawing.Color.Black;
            this.NoButton.RoundingEnable = true;
            this.NoButton.Size = new System.Drawing.Size(100, 30);
            this.NoButton.TabIndex = 8;
            this.NoButton.Text = "Нет";
            this.NoButton.TextHover = null;
            this.NoButton.UseDownPressEffectOnClick = false;
            this.NoButton.UseRippleEffect = true;
            this.NoButton.UseZoomEffectOnHover = false;
            this.NoButton.Click += new System.EventHandler(this.NoButtonClick);
            // 
            // AskInjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 178);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "AskInjectForm";
            this.Text = "AskInjectForm";
            this.Controls.SetChildIndex(this.YesButton, 0);
            this.Controls.SetChildIndex(this.NoButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private CoreClient.StyleExtensions.Controls.BaseStyledButton YesButton;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton NoButton;
    }
}