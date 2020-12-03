namespace MainClient.UserControls
{
    partial class ContentUserControlBase
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
            this.DeleteButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.EditMargin = new System.Windows.Forms.Label();
            this.EditButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.AddMargin = new System.Windows.Forms.Label();
            this.AddButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.CloseViewButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.CollectionView = new System.Windows.Forms.ListView();
            this.ButtonsPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.DeleteButton);
            this.ButtonsPanel.Controls.Add(this.EditMargin);
            this.ButtonsPanel.Controls.Add(this.EditButton);
            this.ButtonsPanel.Controls.Add(this.AddMargin);
            this.ButtonsPanel.Controls.Add(this.AddButton);
            this.ButtonsPanel.Controls.Add(this.CloseViewButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(594, 23);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Tomato;
            this.DeleteButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.DeleteButton.BackColorGradientEnabled = false;
            this.DeleteButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.DeleteButton.BorderColor = System.Drawing.Color.Tomato;
            this.DeleteButton.BorderColorEnabled = false;
            this.DeleteButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.DeleteButton.BorderColorOnHoverEnabled = false;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.Location = new System.Drawing.Point(232, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.RippleColor = System.Drawing.Color.Black;
            this.DeleteButton.RoundingEnable = true;
            this.DeleteButton.Size = new System.Drawing.Size(100, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.TextHover = null;
            this.DeleteButton.UseDownPressEffectOnClick = false;
            this.DeleteButton.UseRippleEffect = true;
            this.DeleteButton.UseZoomEffectOnHover = false;
            // 
            // EditMargin
            // 
            this.EditMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditMargin.Location = new System.Drawing.Point(216, 0);
            this.EditMargin.Name = "EditMargin";
            this.EditMargin.Size = new System.Drawing.Size(16, 23);
            this.EditMargin.TabIndex = 4;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Tomato;
            this.EditButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.EditButton.BackColorGradientEnabled = false;
            this.EditButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.EditButton.BorderColor = System.Drawing.Color.Tomato;
            this.EditButton.BorderColorEnabled = false;
            this.EditButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.EditButton.BorderColorOnHoverEnabled = false;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.Location = new System.Drawing.Point(116, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.RippleColor = System.Drawing.Color.Black;
            this.EditButton.RoundingEnable = true;
            this.EditButton.Size = new System.Drawing.Size(100, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Изменить";
            this.EditButton.TextHover = null;
            this.EditButton.UseDownPressEffectOnClick = false;
            this.EditButton.UseRippleEffect = true;
            this.EditButton.UseZoomEffectOnHover = false;
            // 
            // AddMargin
            // 
            this.AddMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddMargin.Location = new System.Drawing.Point(100, 0);
            this.AddMargin.Name = "AddMargin";
            this.AddMargin.Size = new System.Drawing.Size(16, 23);
            this.AddMargin.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Tomato;
            this.AddButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.AddButton.BackColorGradientEnabled = false;
            this.AddButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.AddButton.BorderColor = System.Drawing.Color.Tomato;
            this.AddButton.BorderColorEnabled = false;
            this.AddButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.AddButton.BorderColorOnHoverEnabled = false;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.RippleColor = System.Drawing.Color.Black;
            this.AddButton.RoundingEnable = true;
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.TextHover = null;
            this.AddButton.UseDownPressEffectOnClick = false;
            this.AddButton.UseRippleEffect = true;
            this.AddButton.UseZoomEffectOnHover = false;
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
            this.CloseViewButton.Location = new System.Drawing.Point(494, 0);
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
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.CollectionView);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 23);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(594, 421);
            this.ContentPanel.TabIndex = 1;
            // 
            // CollectionView
            // 
            this.CollectionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollectionView.FullRowSelect = true;
            this.CollectionView.GridLines = true;
            this.CollectionView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CollectionView.HideSelection = false;
            this.CollectionView.Location = new System.Drawing.Point(0, 0);
            this.CollectionView.Name = "CollectionView";
            this.CollectionView.Size = new System.Drawing.Size(594, 421);
            this.CollectionView.TabIndex = 0;
            this.CollectionView.UseCompatibleStateImageBehavior = false;
            this.CollectionView.View = System.Windows.Forms.View.Details;
            // 
            // ContentUserControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Name = "ContentUserControlBase";
            this.Size = new System.Drawing.Size(594, 444);
            this.Resize += new System.EventHandler(this.ContentUserControlBaseResize);
            this.ButtonsPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CoreClient.StyleExtensions.Controls.BaseStyledButton CloseViewButton;
        private System.Windows.Forms.Label EditMargin;
        private System.Windows.Forms.Label AddMargin;
        internal System.Windows.Forms.ListView CollectionView;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton DeleteButton;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton EditButton;
        internal CoreClient.StyleExtensions.Controls.BaseStyledButton AddButton;
        internal System.Windows.Forms.Panel ContentPanel;
        internal System.Windows.Forms.Panel ButtonsPanel;
    }
}
