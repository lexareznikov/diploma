namespace Demography.WinForms.Views.Blanks
{
    partial class AddBlank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBlank));
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddRangeBlanksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IncomeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SeriesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberFirstTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(392, 292);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 44);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddRangeBlanksButton
            // 
            this.AddRangeBlanksButton.Location = new System.Drawing.Point(142, 292);
            this.AddRangeBlanksButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddRangeBlanksButton.Name = "AddRangeBlanksButton";
            this.AddRangeBlanksButton.Size = new System.Drawing.Size(150, 44);
            this.AddRangeBlanksButton.TabIndex = 5;
            this.AddRangeBlanksButton.Text = "Добавить";
            this.AddRangeBlanksButton.UseVisualStyleBackColor = true;
            this.AddRangeBlanksButton.Click += new System.EventHandler(this.AddRangeBlanksButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дата прихода:";
            // 
            // IncomeDateTimePicker
            // 
            this.IncomeDateTimePicker.Location = new System.Drawing.Point(314, 41);
            this.IncomeDateTimePicker.Name = "IncomeDateTimePicker";
            this.IncomeDateTimePicker.Size = new System.Drawing.Size(228, 31);
            this.IncomeDateTimePicker.TabIndex = 8;
            // 
            // SeriesTextBox
            // 
            this.SeriesTextBox.Location = new System.Drawing.Point(314, 100);
            this.SeriesTextBox.Name = "SeriesTextBox";
            this.SeriesTextBox.ReadOnly = true;
            this.SeriesTextBox.Size = new System.Drawing.Size(228, 31);
            this.SeriesTextBox.TabIndex = 9;
            this.SeriesTextBox.Text = "711000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер первого бланка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Серия:";
            // 
            // NumberFirstTextBox
            // 
            this.NumberFirstTextBox.Location = new System.Drawing.Point(314, 165);
            this.NumberFirstTextBox.MaxLength = 6;
            this.NumberFirstTextBox.Name = "NumberFirstTextBox";
            this.NumberFirstTextBox.Size = new System.Drawing.Size(228, 31);
            this.NumberFirstTextBox.TabIndex = 12;
            this.NumberFirstTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberFirstTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Количество бланков:";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(314, 225);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(228, 31);
            this.CountTextBox.TabIndex = 13;
            this.CountTextBox.Text = "1";
            this.CountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountTextBox_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(625, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.NumberFirstTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SeriesTextBox);
            this.Controls.Add(this.IncomeDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddRangeBlanksButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 405);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 405);
            this.Name = "AddBlank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить приход бланков";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddRangeBlanksButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker IncomeDateTimePicker;
        private System.Windows.Forms.TextBox SeriesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberFirstTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}