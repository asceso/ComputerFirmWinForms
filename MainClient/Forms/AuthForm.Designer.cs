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
            this.LoaderBox = new System.Windows.Forms.PictureBox();
            this.CancelButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.AuthorizeButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.PasswordTE = new CoreClient.ControlExtensions.TextEditControl();
            this.LoginTE = new CoreClient.ControlExtensions.TextEditControl();
            this.BackAuth = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.LoaderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoaderBox
            // 
            this.LoaderBox.BackColor = System.Drawing.Color.Transparent;
            this.LoaderBox.Image = global::MainClient.Properties.Resources.spinner;
            this.LoaderBox.Location = new System.Drawing.Point(0, 0);
            this.LoaderBox.Name = "LoaderBox";
            this.LoaderBox.Size = new System.Drawing.Size(300, 121);
            this.LoaderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoaderBox.TabIndex = 4;
            this.LoaderBox.TabStop = false;
            this.LoaderBox.Visible = false;
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
            // PasswordTE
            // 
            this.PasswordTE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasswordTE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTE.Header = "Пароль";
            this.PasswordTE.HeaderSize = new System.Drawing.Size(150, 30);
            this.PasswordTE.Location = new System.Drawing.Point(0, 41);
            this.PasswordTE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PasswordTE.MinHeaderSize = new System.Drawing.Size(75, 0);
            this.PasswordTE.Name = "PasswordTE";
            this.PasswordTE.Size = new System.Drawing.Size(300, 30);
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
            this.LoginTE.HeaderSize = new System.Drawing.Size(150, 31);
            this.LoginTE.Location = new System.Drawing.Point(0, 0);
            this.LoginTE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LoginTE.MinHeaderSize = new System.Drawing.Size(75, 0);
            this.LoginTE.Name = "LoginTE";
            this.LoginTE.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.LoginTE.Size = new System.Drawing.Size(300, 41);
            this.LoginTE.TabIndex = 0;
            this.LoginTE.UsingPasswordChar = false;
            this.LoginTE.Value = "";
            this.LoginTE.ValueTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackAuth
            // 
            this.BackAuth.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackAuthDoWork);
            this.BackAuth.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackAuthRunWorkerCompleted);
            // 
            // AuthForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 119);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AuthorizeButton);
            this.Controls.Add(this.PasswordTE);
            this.Controls.Add(this.LoginTE);
            this.Controls.Add(this.LoaderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.LoaderBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CoreClient.ControlExtensions.TextEditControl LoginTE;
        private CoreClient.ControlExtensions.TextEditControl PasswordTE;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton AuthorizeButton;
        private new CoreClient.StyleExtensions.Controls.BaseStyledButton CancelButton;
        private System.Windows.Forms.PictureBox LoaderBox;
        private System.ComponentModel.BackgroundWorker BackAuth;
    }
}