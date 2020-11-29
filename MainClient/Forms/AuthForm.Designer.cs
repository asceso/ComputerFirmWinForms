namespace MainClient.Forms
{
    partial class AuthForm
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
            this.AuthorizeButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.PasswordTE = new CoreClient.ControlExtensions.TextEditControl();
            this.LoginTE = new CoreClient.ControlExtensions.TextEditControl();
            this.CancelButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.EmptyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.BackColor = System.Drawing.Color.Tomato;
            this.AuthorizeButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.AuthorizeButton.BackColorGradientEnabled = false;
            this.AuthorizeButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.AuthorizeButton.BorderColor = System.Drawing.Color.Tomato;
            this.AuthorizeButton.BorderColorEnabled = false;
            this.AuthorizeButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.AuthorizeButton.BorderColorOnHoverEnabled = false;
            this.AuthorizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorizeButton.Font = new System.Drawing.Font("Fira Code", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizeButton.ForeColor = System.Drawing.Color.Black;
            this.AuthorizeButton.Location = new System.Drawing.Point(5, 77);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.RippleColor = System.Drawing.Color.Black;
            this.AuthorizeButton.RoundingEnable = true;
            this.AuthorizeButton.Size = new System.Drawing.Size(125, 30);
            this.AuthorizeButton.TabIndex = 2;
            this.AuthorizeButton.Text = "Авторизация";
            this.AuthorizeButton.TextHover = null;
            this.AuthorizeButton.UseDownPressEffectOnClick = false;
            this.AuthorizeButton.UseRippleEffect = true;
            this.AuthorizeButton.UseZoomEffectOnHover = false;
            // 
            // PasswordTE
            // 
            this.PasswordTE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordTE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTE.Header = "Пароль";
            this.PasswordTE.HeaderSize = new System.Drawing.Size(150, 30);
            this.PasswordTE.Location = new System.Drawing.Point(0, 43);
            this.PasswordTE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PasswordTE.MinHeaderSize = new System.Drawing.Size(75, 0);
            this.PasswordTE.Name = "PasswordTE";
            this.PasswordTE.Size = new System.Drawing.Size(277, 30);
            this.PasswordTE.TabIndex = 1;
            this.PasswordTE.UsingPasswordChar = true;
            this.PasswordTE.Value = "";
            this.PasswordTE.ValueTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginTE
            // 
            this.LoginTE.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginTE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTE.Header = "Логин";
            this.LoginTE.HeaderSize = new System.Drawing.Size(150, 30);
            this.LoginTE.Location = new System.Drawing.Point(0, 13);
            this.LoginTE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LoginTE.MinHeaderSize = new System.Drawing.Size(75, 0);
            this.LoginTE.Name = "LoginTE";
            this.LoginTE.Size = new System.Drawing.Size(277, 30);
            this.LoginTE.TabIndex = 0;
            this.LoginTE.UsingPasswordChar = false;
            this.LoginTE.Value = "";
            this.LoginTE.ValueTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Tomato;
            this.CancelButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.CancelButton.BackColorGradientEnabled = false;
            this.CancelButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.CancelButton.BorderColor = System.Drawing.Color.Tomato;
            this.CancelButton.BorderColorEnabled = false;
            this.CancelButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.CancelButton.BorderColorOnHoverEnabled = false;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("Fira Code", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(143, 77);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.RippleColor = System.Drawing.Color.Black;
            this.CancelButton.RoundingEnable = true;
            this.CancelButton.Size = new System.Drawing.Size(125, 30);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.TextHover = null;
            this.CancelButton.UseDownPressEffectOnClick = false;
            this.CancelButton.UseRippleEffect = true;
            this.CancelButton.UseZoomEffectOnHover = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // EmptyLabel
            // 
            this.EmptyLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmptyLabel.Location = new System.Drawing.Point(0, 0);
            this.EmptyLabel.Name = "EmptyLabel";
            this.EmptyLabel.Size = new System.Drawing.Size(277, 13);
            this.EmptyLabel.TabIndex = 4;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(277, 118);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AuthorizeButton);
            this.Controls.Add(this.PasswordTE);
            this.Controls.Add(this.LoginTE);
            this.Controls.Add(this.EmptyLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);

        }

        #endregion

        private CoreClient.ControlExtensions.TextEditControl LoginTE;
        private CoreClient.ControlExtensions.TextEditControl PasswordTE;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton AuthorizeButton;
        private new CoreClient.StyleExtensions.Controls.BaseStyledButton CancelButton;
        private System.Windows.Forms.Label EmptyLabel;
    }
}