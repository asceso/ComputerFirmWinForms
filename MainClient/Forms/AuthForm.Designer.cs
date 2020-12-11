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
            this.BackAuth = new System.ComponentModel.BackgroundWorker();
            this.PasswordTE = new DevExpress.XtraEditors.TextEdit();
            this.LoginTE = new DevExpress.XtraEditors.TextEdit();
            this.CancelButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.AuthorizeButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BackAuth
            // 
            this.BackAuth.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackAuthDoWork);
            this.BackAuth.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackAuthRunWorkerCompleted);
            // 
            // PasswordTE
            // 
            this.PasswordTE.Location = new System.Drawing.Point(11, 47);
            this.PasswordTE.Name = "PasswordTE";
            this.PasswordTE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTE.Properties.Appearance.Options.UseFont = true;
            this.PasswordTE.Properties.Appearance.Options.UseTextOptions = true;
            this.PasswordTE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PasswordTE.Properties.NullText = "Введите пароль";
            this.PasswordTE.Size = new System.Drawing.Size(276, 26);
            this.PasswordTE.TabIndex = 5;
            // 
            // LoginTE
            // 
            this.LoginTE.Location = new System.Drawing.Point(11, 10);
            this.LoginTE.Name = "LoginTE";
            this.LoginTE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTE.Properties.Appearance.Options.UseFont = true;
            this.LoginTE.Properties.Appearance.Options.UseTextOptions = true;
            this.LoginTE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LoginTE.Properties.NullText = "Введите логин";
            this.LoginTE.Size = new System.Drawing.Size(276, 26);
            this.LoginTE.TabIndex = 4;
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
            this.CancelButton.Location = new System.Drawing.Point(155, 79);
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
            this.AuthorizeButton.Location = new System.Drawing.Point(17, 79);
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
            // AuthForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 119);
            this.Controls.Add(this.PasswordTE);
            this.Controls.Add(this.LoginTE);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AuthorizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTE.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CoreClient.StyleExtensions.Controls.BaseStyledButton AuthorizeButton;
        private new CoreClient.StyleExtensions.Controls.BaseStyledButton CancelButton;
        private System.ComponentModel.BackgroundWorker BackAuth;
        private DevExpress.XtraEditors.TextEdit PasswordTE;
        private DevExpress.XtraEditors.TextEdit LoginTE;
    }
}