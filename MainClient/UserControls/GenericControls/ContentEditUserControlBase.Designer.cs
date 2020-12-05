namespace MainClient.UserControls.GenericControls
{
    partial class ContentEditUserControlBase
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
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.DeclineButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.SaveAndExitMargin = new System.Windows.Forms.Label();
            this.SaveAndExit = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.SaveMargin = new System.Windows.Forms.Label();
            this.SaveButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.CloseViewButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonsPanel.Controls.Add(this.DeclineButton);
            this.ButtonsPanel.Controls.Add(this.SaveAndExitMargin);
            this.ButtonsPanel.Controls.Add(this.SaveAndExit);
            this.ButtonsPanel.Controls.Add(this.SaveMargin);
            this.ButtonsPanel.Controls.Add(this.SaveButton);
            this.ButtonsPanel.Controls.Add(this.CloseViewButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(427, 25);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // DeclineButton
            // 
            this.DeclineButton.BackColor = System.Drawing.Color.Tomato;
            this.DeclineButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.DeclineButton.BackColorGradientEnabled = false;
            this.DeclineButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.DeclineButton.BorderColor = System.Drawing.Color.Tomato;
            this.DeclineButton.BorderColorEnabled = false;
            this.DeclineButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.DeclineButton.BorderColorOnHoverEnabled = false;
            this.DeclineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeclineButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeclineButton.ForeColor = System.Drawing.Color.Black;
            this.DeclineButton.Location = new System.Drawing.Point(226, 0);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.RippleColor = System.Drawing.Color.Black;
            this.DeclineButton.RoundingEnable = true;
            this.DeclineButton.Size = new System.Drawing.Size(81, 23);
            this.DeclineButton.TabIndex = 3;
            this.DeclineButton.Text = "Отменить";
            this.DeclineButton.TextHover = null;
            this.DeclineButton.UseDownPressEffectOnClick = false;
            this.DeclineButton.UseRippleEffect = true;
            this.DeclineButton.UseZoomEffectOnHover = false;
            // 
            // SaveAndExitMargin
            // 
            this.SaveAndExitMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveAndExitMargin.Location = new System.Drawing.Point(216, 0);
            this.SaveAndExitMargin.Name = "SaveAndExitMargin";
            this.SaveAndExitMargin.Size = new System.Drawing.Size(10, 23);
            this.SaveAndExitMargin.TabIndex = 5;
            // 
            // SaveAndExit
            // 
            this.SaveAndExit.BackColor = System.Drawing.Color.Tomato;
            this.SaveAndExit.BackColorAdditional = System.Drawing.Color.Gray;
            this.SaveAndExit.BackColorGradientEnabled = false;
            this.SaveAndExit.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.SaveAndExit.BorderColor = System.Drawing.Color.Tomato;
            this.SaveAndExit.BorderColorEnabled = false;
            this.SaveAndExit.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.SaveAndExit.BorderColorOnHoverEnabled = false;
            this.SaveAndExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAndExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveAndExit.ForeColor = System.Drawing.Color.Black;
            this.SaveAndExit.Location = new System.Drawing.Point(91, 0);
            this.SaveAndExit.Name = "SaveAndExit";
            this.SaveAndExit.RippleColor = System.Drawing.Color.Black;
            this.SaveAndExit.RoundingEnable = true;
            this.SaveAndExit.Size = new System.Drawing.Size(125, 23);
            this.SaveAndExit.TabIndex = 2;
            this.SaveAndExit.Text = "Сохранить и закрыть";
            this.SaveAndExit.TextHover = null;
            this.SaveAndExit.UseDownPressEffectOnClick = false;
            this.SaveAndExit.UseRippleEffect = true;
            this.SaveAndExit.UseZoomEffectOnHover = false;
            // 
            // SaveMargin
            // 
            this.SaveMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveMargin.Location = new System.Drawing.Point(81, 0);
            this.SaveMargin.Name = "SaveMargin";
            this.SaveMargin.Size = new System.Drawing.Size(10, 23);
            this.SaveMargin.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Tomato;
            this.SaveButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.SaveButton.BackColorGradientEnabled = false;
            this.SaveButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.SaveButton.BorderColor = System.Drawing.Color.Tomato;
            this.SaveButton.BorderColorEnabled = false;
            this.SaveButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.SaveButton.BorderColorOnHoverEnabled = false;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.RippleColor = System.Drawing.Color.Black;
            this.SaveButton.RoundingEnable = true;
            this.SaveButton.Size = new System.Drawing.Size(81, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.TextHover = null;
            this.SaveButton.UseDownPressEffectOnClick = false;
            this.SaveButton.UseRippleEffect = true;
            this.SaveButton.UseZoomEffectOnHover = false;
            // 
            // CloseViewButton
            // 
            this.CloseViewButton.BackColor = System.Drawing.Color.Tomato;
            this.CloseViewButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.CloseViewButton.BackColorGradientEnabled = false;
            this.CloseViewButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.CloseViewButton.BorderColor = System.Drawing.Color.Tomato;
            this.CloseViewButton.BorderColorEnabled = false;
            this.CloseViewButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.CloseViewButton.BorderColorOnHoverEnabled = false;
            this.CloseViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseViewButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseViewButton.ForeColor = System.Drawing.Color.Black;
            this.CloseViewButton.Location = new System.Drawing.Point(344, 0);
            this.CloseViewButton.Name = "CloseViewButton";
            this.CloseViewButton.RippleColor = System.Drawing.Color.Black;
            this.CloseViewButton.RoundingEnable = true;
            this.CloseViewButton.Size = new System.Drawing.Size(81, 23);
            this.CloseViewButton.TabIndex = 0;
            this.CloseViewButton.Text = "Закрыть";
            this.CloseViewButton.TextHover = null;
            this.CloseViewButton.UseDownPressEffectOnClick = false;
            this.CloseViewButton.UseRippleEffect = true;
            this.CloseViewButton.UseZoomEffectOnHover = false;
            this.CloseViewButton.Click += new System.EventHandler(this.CloseViewButtonClick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 25);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(427, 419);
            this.ContentPanel.TabIndex = 1;
            // 
            // ContentEditUserControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Name = "ContentEditUserControlBase";
            this.Size = new System.Drawing.Size(427, 444);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label SaveAndExitMargin;
        private System.Windows.Forms.Label SaveMargin;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton DeclineButton;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton SaveAndExit;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton SaveButton;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton CloseViewButton;
        public System.Windows.Forms.Panel ContentPanel;
    }
}
