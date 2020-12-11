namespace MainClient.UserControls.GenericControls
{
    partial class ContentNoEditUserControlBase
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
            this.SaveAndExitButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.AddMargin = new System.Windows.Forms.Label();
            this.SaveButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.CloseViewButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.SaveAndExitButton);
            this.ButtonsPanel.Controls.Add(this.AddMargin);
            this.ButtonsPanel.Controls.Add(this.SaveButton);
            this.ButtonsPanel.Controls.Add(this.CloseViewButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(628, 23);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // SaveAndExitButton
            // 
            this.SaveAndExitButton.BackColor = System.Drawing.Color.Tomato;
            this.SaveAndExitButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.SaveAndExitButton.BackColorGradientEnabled = false;
            this.SaveAndExitButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.SaveAndExitButton.BorderColor = System.Drawing.Color.Tomato;
            this.SaveAndExitButton.BorderColorEnabled = false;
            this.SaveAndExitButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.SaveAndExitButton.BorderColorOnHoverEnabled = false;
            this.SaveAndExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAndExitButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveAndExitButton.ForeColor = System.Drawing.Color.Black;
            this.SaveAndExitButton.Location = new System.Drawing.Point(116, 0);
            this.SaveAndExitButton.Name = "SaveAndExitButton";
            this.SaveAndExitButton.RippleColor = System.Drawing.Color.Black;
            this.SaveAndExitButton.RoundingEnable = true;
            this.SaveAndExitButton.Size = new System.Drawing.Size(201, 23);
            this.SaveAndExitButton.TabIndex = 2;
            this.SaveAndExitButton.Text = "Сохранить и закрыть";
            this.SaveAndExitButton.TextHover = null;
            this.SaveAndExitButton.UseDownPressEffectOnClick = false;
            this.SaveAndExitButton.UseRippleEffect = true;
            this.SaveAndExitButton.UseZoomEffectOnHover = false;
            // 
            // AddMargin
            // 
            this.AddMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddMargin.Location = new System.Drawing.Point(100, 0);
            this.AddMargin.Name = "AddMargin";
            this.AddMargin.Size = new System.Drawing.Size(16, 23);
            this.AddMargin.TabIndex = 3;
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
            this.SaveButton.Size = new System.Drawing.Size(100, 23);
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
            this.CloseViewButton.Location = new System.Drawing.Point(528, 0);
            this.CloseViewButton.Name = "CloseViewButton";
            this.CloseViewButton.RippleColor = System.Drawing.Color.Black;
            this.CloseViewButton.RoundingEnable = true;
            this.CloseViewButton.Size = new System.Drawing.Size(100, 23);
            this.CloseViewButton.TabIndex = 0;
            this.CloseViewButton.Text = "Закрыть";
            this.CloseViewButton.TextHover = null;
            this.CloseViewButton.UseDownPressEffectOnClick = false;
            this.CloseViewButton.UseRippleEffect = true;
            this.CloseViewButton.UseZoomEffectOnHover = false;
            // 
            // ContentNoEditUserControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonsPanel);
            this.Name = "ContentNoEditUserControlBase";
            this.Size = new System.Drawing.Size(628, 455);
            this.Resize += new System.EventHandler(this.ContentUserControlBaseResize);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel ButtonsPanel;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton SaveAndExitButton;
        private System.Windows.Forms.Label AddMargin;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton SaveButton;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton CloseViewButton;
    }
}
