namespace Demography.WinForms.Views.News
{
    partial class AddNews
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNews));
            this.NameShortTextBox = new System.Windows.Forms.TextBox();
            this.NewsFullRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddNewsButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NameShortLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.NameFullLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NameShortTextBox
            // 
            this.NameShortTextBox.Location = new System.Drawing.Point(24, 65);
            this.NameShortTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.NameShortTextBox.Name = "NameShortTextBox";
            this.NameShortTextBox.Size = new System.Drawing.Size(622, 31);
            this.NameShortTextBox.TabIndex = 0;
            // 
            // NewsFullRichTextBox
            // 
            this.NewsFullRichTextBox.Location = new System.Drawing.Point(24, 165);
            this.NewsFullRichTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.NewsFullRichTextBox.Name = "NewsFullRichTextBox";
            this.NewsFullRichTextBox.Size = new System.Drawing.Size(1058, 254);
            this.NewsFullRichTextBox.TabIndex = 1;
            this.NewsFullRichTextBox.Text = "";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(686, 65);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(396, 31);
            this.DateTimePicker.TabIndex = 2;
            // 
            // AddNewsButton
            // 
            this.AddNewsButton.Location = new System.Drawing.Point(20, 431);
            this.AddNewsButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddNewsButton.Name = "AddNewsButton";
            this.AddNewsButton.Size = new System.Drawing.Size(150, 44);
            this.AddNewsButton.TabIndex = 3;
            this.AddNewsButton.Text = "Добавить";
            this.AddNewsButton.UseVisualStyleBackColor = true;
            this.AddNewsButton.Click += new System.EventHandler(this.AddNewsButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(932, 431);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 44);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameShortLabel
            // 
            this.NameShortLabel.AutoSize = true;
            this.NameShortLabel.Location = new System.Drawing.Point(24, 35);
            this.NameShortLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameShortLabel.Name = "NameShortLabel";
            this.NameShortLabel.Size = new System.Drawing.Size(207, 25);
            this.NameShortLabel.TabIndex = 5;
            this.NameShortLabel.Text = "Короткое название";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(680, 35);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(62, 25);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Дата";
            // 
            // NameFullLabel
            // 
            this.NameFullLabel.AutoSize = true;
            this.NameFullLabel.Location = new System.Drawing.Point(24, 135);
            this.NameFullLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameFullLabel.Name = "NameFullLabel";
            this.NameFullLabel.Size = new System.Drawing.Size(215, 25);
            this.NameFullLabel.TabIndex = 7;
            this.NameFullLabel.Text = "Полное содержание";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1128, 490);
            this.Controls.Add(this.NameFullLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.NameShortLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddNewsButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.NewsFullRichTextBox);
            this.Controls.Add(this.NameShortTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1144, 529);
            this.MinimumSize = new System.Drawing.Size(1144, 529);
            this.Name = "AddNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить новость";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameShortTextBox;
        private System.Windows.Forms.RichTextBox NewsFullRichTextBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button AddNewsButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label NameShortLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label NameFullLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}