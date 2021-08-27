namespace Demography.WinForms.Views.News
{
    partial class News
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(News));
            this.ExitButton = new System.Windows.Forms.Button();
            this.NewsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CertificatesButton = new System.Windows.Forms.Button();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.BlankButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.PageMaxCountLabel = new System.Windows.Forms.Label();
            this.CurrentPageTextBox = new System.Windows.Forms.TextBox();
            this.AddNewsButton = new System.Windows.Forms.Button();
            this.AddPageButton = new System.Windows.Forms.Button();
            this.RemovePageButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.ButtonFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(3, 904);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(339, 74);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NewsFlowLayoutPanel
            // 
            this.NewsFlowLayoutPanel.BackColor = System.Drawing.Color.Azure;
            this.NewsFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewsFlowLayoutPanel.Location = new System.Drawing.Point(360, 12);
            this.NewsFlowLayoutPanel.Name = "NewsFlowLayoutPanel";
            this.NewsFlowLayoutPanel.Size = new System.Drawing.Size(1200, 981);
            this.NewsFlowLayoutPanel.TabIndex = 1;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonsPanel.Controls.Add(this.ButtonFlowLayoutPanel);
            this.ButtonsPanel.Controls.Add(this.MainButton);
            this.ButtonsPanel.Controls.Add(this.AccountButton);
            this.ButtonsPanel.Controls.Add(this.ExitButton);
            this.ButtonsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 12);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(345, 981);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // ButtonFlowLayoutPanel
            // 
            this.ButtonFlowLayoutPanel.Controls.Add(this.CertificatesButton);
            this.ButtonFlowLayoutPanel.Controls.Add(this.DirectoryButton);
            this.ButtonFlowLayoutPanel.Controls.Add(this.ReportButton);
            this.ButtonFlowLayoutPanel.Controls.Add(this.BlankButton);
            this.ButtonFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ButtonFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonFlowLayoutPanel.Name = "ButtonFlowLayoutPanel";
            this.ButtonFlowLayoutPanel.Size = new System.Drawing.Size(342, 352);
            this.ButtonFlowLayoutPanel.TabIndex = 7;
            // 
            // CertificatesButton
            // 
            this.CertificatesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CertificatesButton.Location = new System.Drawing.Point(3, 3);
            this.CertificatesButton.Name = "CertificatesButton";
            this.CertificatesButton.Size = new System.Drawing.Size(339, 74);
            this.CertificatesButton.TabIndex = 3;
            this.CertificatesButton.Text = "Свидетельства";
            this.CertificatesButton.UseVisualStyleBackColor = true;
            this.CertificatesButton.Click += new System.EventHandler(this.CertificatesButton_Click);
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryButton.Location = new System.Drawing.Point(3, 83);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(339, 74);
            this.DirectoryButton.TabIndex = 4;
            this.DirectoryButton.Text = "Справочники";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportButton.Location = new System.Drawing.Point(3, 163);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(339, 74);
            this.ReportButton.TabIndex = 5;
            this.ReportButton.Text = "Статистика";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // BlankButton
            // 
            this.BlankButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlankButton.Location = new System.Drawing.Point(3, 243);
            this.BlankButton.Name = "BlankButton";
            this.BlankButton.Size = new System.Drawing.Size(339, 74);
            this.BlankButton.TabIndex = 6;
            this.BlankButton.Text = "Бланки";
            this.BlankButton.UseVisualStyleBackColor = true;
            this.BlankButton.Click += new System.EventHandler(this.BlankButton_Click);
            // 
            // MainButton
            // 
            this.MainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainButton.Location = new System.Drawing.Point(3, 744);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(339, 74);
            this.MainButton.TabIndex = 2;
            this.MainButton.Text = "Новости";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountButton.Location = new System.Drawing.Point(3, 824);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(339, 74);
            this.AccountButton.TabIndex = 1;
            this.AccountButton.Text = "Профиль";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // PageMaxCountLabel
            // 
            this.PageMaxCountLabel.AutoSize = true;
            this.PageMaxCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageMaxCountLabel.Location = new System.Drawing.Point(960, 997);
            this.PageMaxCountLabel.Name = "PageMaxCountLabel";
            this.PageMaxCountLabel.Size = new System.Drawing.Size(19, 16);
            this.PageMaxCountLabel.TabIndex = 0;
            this.PageMaxCountLabel.Text = "/1";
            // 
            // CurrentPageTextBox
            // 
            this.CurrentPageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentPageTextBox.Location = new System.Drawing.Point(929, 994);
            this.CurrentPageTextBox.Name = "CurrentPageTextBox";
            this.CurrentPageTextBox.Size = new System.Drawing.Size(25, 22);
            this.CurrentPageTextBox.TabIndex = 3;
            this.CurrentPageTextBox.Text = "1";
            this.CurrentPageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentPageTextBox_KeyPress);
            // 
            // AddNewsButton
            // 
            this.AddNewsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewsButton.Location = new System.Drawing.Point(1564, 12);
            this.AddNewsButton.Name = "AddNewsButton";
            this.AddNewsButton.Size = new System.Drawing.Size(339, 74);
            this.AddNewsButton.TabIndex = 1;
            this.AddNewsButton.Text = "Добавить новость";
            this.AddNewsButton.UseVisualStyleBackColor = true;
            this.AddNewsButton.Click += new System.EventHandler(this.AddNewsButton_Click);
            // 
            // AddPageButton
            // 
            this.AddPageButton.BackgroundImage = global::Demography.WinForms.Properties.Resources.forwardarrow;
            this.AddPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddPageButton.Location = new System.Drawing.Point(985, 994);
            this.AddPageButton.Name = "AddPageButton";
            this.AddPageButton.Size = new System.Drawing.Size(50, 22);
            this.AddPageButton.TabIndex = 4;
            this.AddPageButton.UseVisualStyleBackColor = true;
            this.AddPageButton.Click += new System.EventHandler(this.AddPageButton_Click);
            // 
            // RemovePageButton
            // 
            this.RemovePageButton.BackgroundImage = global::Demography.WinForms.Properties.Resources.backarrow;
            this.RemovePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovePageButton.Location = new System.Drawing.Point(873, 994);
            this.RemovePageButton.Name = "RemovePageButton";
            this.RemovePageButton.Size = new System.Drawing.Size(50, 22);
            this.RemovePageButton.TabIndex = 5;
            this.RemovePageButton.UseVisualStyleBackColor = true;
            this.RemovePageButton.Click += new System.EventHandler(this.RemovePageButton_Click);
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.RemovePageButton);
            this.Controls.Add(this.AddPageButton);
            this.Controls.Add(this.AddNewsButton);
            this.Controls.Add(this.CurrentPageTextBox);
            this.Controls.Add(this.PageMaxCountLabel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.NewsFlowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "News";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объявления";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.News_FormClosing);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FlowLayoutPanel NewsFlowLayoutPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Label PageMaxCountLabel;
        private System.Windows.Forms.TextBox CurrentPageTextBox;
        private System.Windows.Forms.Button AddNewsButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Button CertificatesButton;
        private System.Windows.Forms.Button AddPageButton;
        private System.Windows.Forms.Button RemovePageButton;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.Button BlankButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.FlowLayoutPanel ButtonFlowLayoutPanel;
    }
}