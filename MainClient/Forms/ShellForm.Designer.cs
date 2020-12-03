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
            this.ClientsTopMargin = new System.Windows.Forms.Label();
            this.UserTopMargin = new System.Windows.Forms.Label();
            this.ContentTabControl = new System.Windows.Forms.TabControl();
            this.ClientsButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
            this.UsersButton = new CoreClient.StyleExtensions.Controls.BaseStyledButton();
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
            this.ButtonsPanel.Controls.Add(this.UsersButton);
            this.ButtonsPanel.Controls.Add(this.UserTopMargin);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 3);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(144, 444);
            this.ButtonsPanel.TabIndex = 0;
            // 
            // ClientsTopMargin
            // 
            this.ClientsTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsTopMargin.Location = new System.Drawing.Point(0, 40);
            this.ClientsTopMargin.Name = "ClientsTopMargin";
            this.ClientsTopMargin.Size = new System.Drawing.Size(144, 10);
            this.ClientsTopMargin.TabIndex = 3;
            this.ClientsTopMargin.Tag = "Margin";
            // 
            // UserTopMargin
            // 
            this.UserTopMargin.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserTopMargin.Location = new System.Drawing.Point(0, 0);
            this.UserTopMargin.Name = "UserTopMargin";
            this.UserTopMargin.Size = new System.Drawing.Size(144, 10);
            this.UserTopMargin.TabIndex = 2;
            this.UserTopMargin.Tag = "Margin";
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
            this.ClientsButton.Location = new System.Drawing.Point(0, 50);
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
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButtonClick);
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
            this.UsersButton.Location = new System.Drawing.Point(0, 10);
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
            this.UsersButton.Click += new System.EventHandler(this.UsersButtonClick);
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
    }
}