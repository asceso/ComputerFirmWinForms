namespace MainClient.Forms
{
    partial class ChangePasswordForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.AcceptButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.DeclineButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.OldPassPanel = new System.Windows.Forms.Panel();
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPassPanel = new System.Windows.Forms.Panel();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.ConfPassPanel = new System.Windows.Forms.Panel();
            this.ConfitmPasswordBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.OldPassPanel.SuspendLayout();
            this.NewPassPanel.SuspendLayout();
            this.ConfPassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.AcceptButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.AcceptButton.BackColorGradientEnabled = false;
            this.AcceptButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.AcceptButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.AcceptButton.BorderColorEnabled = false;
            this.AcceptButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.AcceptButton.BorderColorOnHoverEnabled = false;
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.AcceptButton.Location = new System.Drawing.Point(22, 96);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.RippleColor = System.Drawing.Color.Black;
            this.AcceptButton.RoundingEnable = true;
            this.AcceptButton.Size = new System.Drawing.Size(100, 30);
            this.AcceptButton.TabIndex = 3;
            this.AcceptButton.Text = "Подтвердить";
            this.AcceptButton.TextHover = null;
            this.AcceptButton.UseDownPressEffectOnClick = false;
            this.AcceptButton.UseRippleEffect = true;
            this.AcceptButton.UseZoomEffectOnHover = false;
            // 
            // DeclineButton
            // 
            this.DeclineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.DeclineButton.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.DeclineButton.BackColorGradientEnabled = false;
            this.DeclineButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.DeclineButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.DeclineButton.BorderColorEnabled = false;
            this.DeclineButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.DeclineButton.BorderColorOnHoverEnabled = false;
            this.DeclineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeclineButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(238)))));
            this.DeclineButton.Location = new System.Drawing.Point(148, 96);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.RippleColor = System.Drawing.Color.Black;
            this.DeclineButton.RoundingEnable = true;
            this.DeclineButton.Size = new System.Drawing.Size(100, 30);
            this.DeclineButton.TabIndex = 4;
            this.DeclineButton.Text = "Отменить";
            this.DeclineButton.TextHover = null;
            this.DeclineButton.UseDownPressEffectOnClick = false;
            this.DeclineButton.UseRippleEffect = true;
            this.DeclineButton.UseZoomEffectOnHover = false;
            // 
            // OldPassPanel
            // 
            this.OldPassPanel.Controls.Add(this.OldPasswordBox);
            this.OldPassPanel.Controls.Add(label1);
            this.OldPassPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OldPassPanel.Location = new System.Drawing.Point(0, 0);
            this.OldPassPanel.Name = "OldPassPanel";
            this.OldPassPanel.Size = new System.Drawing.Size(270, 30);
            this.OldPassPanel.TabIndex = 5;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Старый пароль";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPasswordBox.Location = new System.Drawing.Point(95, 6);
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.Size = new System.Drawing.Size(172, 20);
            this.OldPasswordBox.TabIndex = 0;
            this.OldPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OldPasswordBox.UseSystemPasswordChar = true;
            // 
            // NewPassPanel
            // 
            this.NewPassPanel.Controls.Add(this.NewPasswordBox);
            this.NewPassPanel.Controls.Add(label2);
            this.NewPassPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewPassPanel.Location = new System.Drawing.Point(0, 30);
            this.NewPassPanel.Name = "NewPassPanel";
            this.NewPassPanel.Size = new System.Drawing.Size(270, 30);
            this.NewPassPanel.TabIndex = 6;
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPasswordBox.Location = new System.Drawing.Point(95, 6);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.Size = new System.Drawing.Size(172, 20);
            this.NewPasswordBox.TabIndex = 1;
            this.NewPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewPasswordBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Left;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 30);
            label2.TabIndex = 0;
            label2.Text = "Новый пароль";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfPassPanel
            // 
            this.ConfPassPanel.Controls.Add(this.ConfitmPasswordBox);
            this.ConfPassPanel.Controls.Add(label3);
            this.ConfPassPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConfPassPanel.Location = new System.Drawing.Point(0, 60);
            this.ConfPassPanel.Name = "ConfPassPanel";
            this.ConfPassPanel.Size = new System.Drawing.Size(270, 30);
            this.ConfPassPanel.TabIndex = 7;
            // 
            // ConfitmPasswordBox
            // 
            this.ConfitmPasswordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfitmPasswordBox.Location = new System.Drawing.Point(95, 6);
            this.ConfitmPasswordBox.Name = "ConfitmPasswordBox";
            this.ConfitmPasswordBox.Size = new System.Drawing.Size(172, 20);
            this.ConfitmPasswordBox.TabIndex = 2;
            this.ConfitmPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConfitmPasswordBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Left;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 30);
            label3.TabIndex = 0;
            label3.Text = "Подтверждение";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 132);
            this.Controls.Add(this.ConfPassPanel);
            this.Controls.Add(this.NewPassPanel);
            this.Controls.Add(this.OldPassPanel);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.OldPassPanel.ResumeLayout(false);
            this.OldPassPanel.PerformLayout();
            this.NewPassPanel.ResumeLayout(false);
            this.NewPassPanel.PerformLayout();
            this.ConfPassPanel.ResumeLayout(false);
            this.ConfPassPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private new CoreClient.StyleExtensions.Controls.BaseStyledButton AcceptButton;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton DeclineButton;
        private System.Windows.Forms.Panel OldPassPanel;
        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.Panel NewPassPanel;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.Panel ConfPassPanel;
        private System.Windows.Forms.TextBox ConfitmPasswordBox;
    }
}