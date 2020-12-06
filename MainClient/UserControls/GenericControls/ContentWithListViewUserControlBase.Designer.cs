namespace MainClient.UserControls.GenericControls
{
    partial class ContentWithListViewUserControlBase
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
            this.CollectionView = new System.Windows.Forms.ListView();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Controls.Add(this.CollectionView);
            this.ContentPanel.Size = new System.Drawing.Size(628, 432);
            // 
            // CollectionView
            // 
            this.CollectionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollectionView.FullRowSelect = true;
            this.CollectionView.GridLines = true;
            this.CollectionView.HideSelection = false;
            this.CollectionView.Location = new System.Drawing.Point(0, 0);
            this.CollectionView.Name = "CollectionView";
            this.CollectionView.Size = new System.Drawing.Size(628, 432);
            this.CollectionView.TabIndex = 0;
            this.CollectionView.UseCompatibleStateImageBehavior = false;
            this.CollectionView.View = System.Windows.Forms.View.Details;
            // 
            // ContentWithListViewUserControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ContentWithListViewUserControlBase";
            this.Size = new System.Drawing.Size(628, 455);
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView CollectionView;
    }
}
