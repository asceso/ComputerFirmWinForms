namespace MainClient.Forms
{
    partial class ShellForm
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
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ClientsButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.ClientsTopMargin = new System.Windows.Forms.Label();
            this.PositionsButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.PositionTopMargin = new System.Windows.Forms.Label();
            this.UsersButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.UserTopMargin = new System.Windows.Forms.Label();
            this.SettingsButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.SettingsTopMargin = new System.Windows.Forms.Label();
            this.ContentTabControl = new System.Windows.Forms.TabControl();
            this.RequestTypesButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.RequestTypesTopMargin = new System.Windows.Forms.Label();
            this.MainTable.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnCount = 2;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.ButtonsPanel, 0, 0);
            this.MainTable.Controls.Add(this.ContentTabControl, 1, 0);
            this.MainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTable.Location = new System.Drawing.Point(0, 0);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 1;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Size = new System.Drawing.Size(800, 450);
            this.MainTable.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.ClientsButton);
            this.ButtonsPanel.Controls.Add(this.ClientsTopMargin);
            this.ButtonsPanel.Controls.Add(this.RequestTypesButton);
            this.ButtonsPanel.Controls.Add(this.RequestTypesTopMargin);
            this.ButtonsPanel.Controls.Add(this.PositionsButton);
            this.ButtonsPanel.Controls.Add(this.PositionTopMargin);
            this.ButtonsPanel.Controls.Add(this.UsersButton);
            this.ButtonsPanel.Controls.Add(this.UserTopMargin);
            this.ButtonsPanel.Controls.Add(this.SettingsButton);
            this.ButtonsPanel.Controls.Add(this.SettingsTopMargin);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 3);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(144, 444);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // ClientsButton
            // 
            this.ClientsButton.BackColor = System.Drawing.Color.Tomato;
            this.ClientsButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.ClientsButton.BackColorGradientEnabled = false;
            this.ClientsButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ClientsButton.BorderColor = System.Drawing.Color.Tomato;
            this.ClientsButton.BorderColorEnabled = false;
            this.ClientsButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.ClientsButton.BorderColorOnHoverEnabled = false;
            this.ClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsButton.ForeColor = System.Drawing.Color.Black;
            this.ClientsButton.Location = new System.Drawing.Point(0, 170);
            this.ClientsButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.RippleColor = System.Drawing.Color.Black;
            this.ClientsButton.RoundingEnable = true;
            this.ClientsButton.Size = new System.Drawing.Size(144, 30);
            this.ClientsButton.TabIndex = 1;
            this.ClientsButton.Text = "Клиенты";
            this.ClientsButton.TextHover = null;
            this.ClientsButton.UseDownPressEffectOnClick = false;
            this.ClientsButton.UseRippleEffect = true;
            this.ClientsButton.UseZoomEffectOnHover = false;
            // 
            // ClientsTopMargin
            // 
            this.ClientsTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsTopMargin.Location = new System.Drawing.Point(0, 160);
            this.ClientsTopMargin.Name = "ClientsTopMargin";
            this.ClientsTopMargin.Size = new System.Drawing.Size(144, 10);
            this.ClientsTopMargin.TabIndex = 3;
            this.ClientsTopMargin.Tag = "Margin";
            // 
            // PositionsButton
            // 
            this.PositionsButton.BackColor = System.Drawing.Color.Tomato;
            this.PositionsButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.PositionsButton.BackColorGradientEnabled = false;
            this.PositionsButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.PositionsButton.BorderColor = System.Drawing.Color.Tomato;
            this.PositionsButton.BorderColorEnabled = false;
            this.PositionsButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.PositionsButton.BorderColorOnHoverEnabled = false;
            this.PositionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PositionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PositionsButton.ForeColor = System.Drawing.Color.Black;
            this.PositionsButton.Location = new System.Drawing.Point(0, 90);
            this.PositionsButton.Name = "PositionsButton";
            this.PositionsButton.RippleColor = System.Drawing.Color.Black;
            this.PositionsButton.RoundingEnable = true;
            this.PositionsButton.Size = new System.Drawing.Size(144, 30);
            this.PositionsButton.TabIndex = 6;
            this.PositionsButton.Text = "Должности";
            this.PositionsButton.TextHover = null;
            this.PositionsButton.UseDownPressEffectOnClick = false;
            this.PositionsButton.UseRippleEffect = true;
            this.PositionsButton.UseZoomEffectOnHover = false;
            // 
            // PositionTopMargin
            // 
            this.PositionTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PositionTopMargin.Location = new System.Drawing.Point(0, 80);
            this.PositionTopMargin.Name = "PositionTopMargin";
            this.PositionTopMargin.Size = new System.Drawing.Size(144, 10);
            this.PositionTopMargin.TabIndex = 7;
            this.PositionTopMargin.Tag = "Margin";
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.Color.Tomato;
            this.UsersButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.UsersButton.BackColorGradientEnabled = false;
            this.UsersButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.UsersButton.BorderColor = System.Drawing.Color.Tomato;
            this.UsersButton.BorderColorEnabled = false;
            this.UsersButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.UsersButton.BorderColorOnHoverEnabled = false;
            this.UsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersButton.ForeColor = System.Drawing.Color.Black;
            this.UsersButton.Location = new System.Drawing.Point(0, 50);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.RippleColor = System.Drawing.Color.Black;
            this.UsersButton.RoundingEnable = true;
            this.UsersButton.Size = new System.Drawing.Size(144, 30);
            this.UsersButton.TabIndex = 0;
            this.UsersButton.Text = "Сотрудники";
            this.UsersButton.TextHover = null;
            this.UsersButton.UseDownPressEffectOnClick = false;
            this.UsersButton.UseRippleEffect = true;
            this.UsersButton.UseZoomEffectOnHover = false;
            // 
            // UserTopMargin
            // 
            this.UserTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserTopMargin.Location = new System.Drawing.Point(0, 40);
            this.UserTopMargin.Name = "UserTopMargin";
            this.UserTopMargin.Size = new System.Drawing.Size(144, 10);
            this.UserTopMargin.TabIndex = 2;
            this.UserTopMargin.Tag = "Margin";
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Tomato;
            this.SettingsButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.SettingsButton.BackColorGradientEnabled = false;
            this.SettingsButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.SettingsButton.BorderColor = System.Drawing.Color.Tomato;
            this.SettingsButton.BorderColorEnabled = false;
            this.SettingsButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.SettingsButton.BorderColorOnHoverEnabled = false;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.Location = new System.Drawing.Point(0, 10);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.RippleColor = System.Drawing.Color.Black;
            this.SettingsButton.RoundingEnable = true;
            this.SettingsButton.Size = new System.Drawing.Size(144, 30);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.TextHover = null;
            this.SettingsButton.UseDownPressEffectOnClick = false;
            this.SettingsButton.UseRippleEffect = true;
            this.SettingsButton.UseZoomEffectOnHover = false;
            // 
            // SettingsTopMargin
            // 
            this.SettingsTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTopMargin.Location = new System.Drawing.Point(0, 0);
            this.SettingsTopMargin.Name = "SettingsTopMargin";
            this.SettingsTopMargin.Size = new System.Drawing.Size(144, 10);
            this.SettingsTopMargin.TabIndex = 5;
            this.SettingsTopMargin.Tag = "Margin";
            // 
            // ContentTabControl
            // 
            this.ContentTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTabControl.Location = new System.Drawing.Point(153, 3);
            this.ContentTabControl.Name = "ContentTabControl";
            this.ContentTabControl.SelectedIndex = 0;
            this.ContentTabControl.Size = new System.Drawing.Size(644, 444);
            this.ContentTabControl.TabIndex = 1;
            // 
            // RequestTypesButton
            // 
            this.RequestTypesButton.BackColor = System.Drawing.Color.Tomato;
            this.RequestTypesButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.RequestTypesButton.BackColorGradientEnabled = false;
            this.RequestTypesButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.RequestTypesButton.BorderColor = System.Drawing.Color.Tomato;
            this.RequestTypesButton.BorderColorEnabled = false;
            this.RequestTypesButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.RequestTypesButton.BorderColorOnHoverEnabled = false;
            this.RequestTypesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequestTypesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestTypesButton.ForeColor = System.Drawing.Color.Black;
            this.RequestTypesButton.Location = new System.Drawing.Point(0, 130);
            this.RequestTypesButton.Name = "RequestTypesButton";
            this.RequestTypesButton.RippleColor = System.Drawing.Color.Black;
            this.RequestTypesButton.RoundingEnable = true;
            this.RequestTypesButton.Size = new System.Drawing.Size(144, 30);
            this.RequestTypesButton.TabIndex = 8;
            this.RequestTypesButton.Text = "Типы заявок";
            this.RequestTypesButton.TextHover = null;
            this.RequestTypesButton.UseDownPressEffectOnClick = false;
            this.RequestTypesButton.UseRippleEffect = true;
            this.RequestTypesButton.UseZoomEffectOnHover = false;
            // 
            // RequestTypesTopMargin
            // 
            this.RequestTypesTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestTypesTopMargin.Location = new System.Drawing.Point(0, 120);
            this.RequestTypesTopMargin.Name = "RequestTypesTopMargin";
            this.RequestTypesTopMargin.Size = new System.Drawing.Size(144, 10);
            this.RequestTypesTopMargin.TabIndex = 9;
            this.RequestTypesTopMargin.Tag = "Margin";
            // 
            // ShellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTable);
            this.Name = "ShellForm";
            this.Text = "ShellForm";
            this.Resize += new System.EventHandler(this.ShellFormResize);
            this.MainTable.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTable;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.TabControl ContentTabControl;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton ClientsButton;
        private System.Windows.Forms.Label UserTopMargin;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton UsersButton;
        private System.Windows.Forms.Label ClientsTopMargin;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton SettingsButton;
        private System.Windows.Forms.Label SettingsTopMargin;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton PositionsButton;
        private System.Windows.Forms.Label PositionTopMargin;
        private CoreClient.StyleExtensions.Controls.BaseStyledButton RequestTypesButton;
        private System.Windows.Forms.Label RequestTypesTopMargin;
    }
}