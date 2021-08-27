namespace Demography.WinForms.Views.Blanks
{
    partial class ExpenseBlanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseBlanks));
            this.BlankFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CountLabel = new System.Windows.Forms.Label();
            this.RemovePageButton = new System.Windows.Forms.Button();
            this.AddPageButton = new System.Windows.Forms.Button();
            this.CurrentPageTextBox = new System.Windows.Forms.TextBox();
            this.PageMaxCountLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BlankFlowLayoutPanel
            // 
            this.BlankFlowLayoutPanel.BackColor = System.Drawing.Color.Azure;
            this.BlankFlowLayoutPanel.Location = new System.Drawing.Point(2, 106);
            this.BlankFlowLayoutPanel.Name = "BlankFlowLayoutPanel";
            this.BlankFlowLayoutPanel.Size = new System.Drawing.Size(837, 764);
            this.BlankFlowLayoutPanel.TabIndex = 46;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(486, 875);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(90, 25);
            this.CountLabel.TabIndex = 51;
            this.CountLabel.Text = "0-0 из 0";
            // 
            // RemovePageButton
            // 
            this.RemovePageButton.BackgroundImage = global::Demography.WinForms.Properties.Resources.backarrow;
            this.RemovePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovePageButton.Location = new System.Drawing.Point(318, 876);
            this.RemovePageButton.Name = "RemovePageButton";
            this.RemovePageButton.Size = new System.Drawing.Size(50, 22);
            this.RemovePageButton.TabIndex = 50;
            this.RemovePageButton.UseVisualStyleBackColor = true;
            this.RemovePageButton.Click += new System.EventHandler(this.RemovePageButton_Click);
            // 
            // AddPageButton
            // 
            this.AddPageButton.BackgroundImage = global::Demography.WinForms.Properties.Resources.forwardarrow;
            this.AddPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddPageButton.Location = new System.Drawing.Point(430, 876);
            this.AddPageButton.Name = "AddPageButton";
            this.AddPageButton.Size = new System.Drawing.Size(50, 22);
            this.AddPageButton.TabIndex = 49;
            this.AddPageButton.UseVisualStyleBackColor = true;
            this.AddPageButton.Click += new System.EventHandler(this.AddPageButton_Click);
            // 
            // CurrentPageTextBox
            // 
            this.CurrentPageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentPageTextBox.Location = new System.Drawing.Point(374, 876);
            this.CurrentPageTextBox.Name = "CurrentPageTextBox";
            this.CurrentPageTextBox.Size = new System.Drawing.Size(25, 22);
            this.CurrentPageTextBox.TabIndex = 48;
            this.CurrentPageTextBox.Text = "1";
            this.CurrentPageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentPageTextBox_KeyPress);
            // 
            // PageMaxCountLabel
            // 
            this.PageMaxCountLabel.AutoSize = true;
            this.PageMaxCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageMaxCountLabel.Location = new System.Drawing.Point(405, 879);
            this.PageMaxCountLabel.Name = "PageMaxCountLabel";
            this.PageMaxCountLabel.Size = new System.Drawing.Size(19, 16);
            this.PageMaxCountLabel.TabIndex = 47;
            this.PageMaxCountLabel.Text = "/1";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(226, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(365, 25);
            this.TextLabel.TabIndex = 52;
            this.TextLabel.Text = "Задействовано 10 из 1020 бланков";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Серия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Статус";
            // 
            // ExpenseBlanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(842, 904);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.RemovePageButton);
            this.Controls.Add(this.AddPageButton);
            this.Controls.Add(this.CurrentPageTextBox);
            this.Controls.Add(this.PageMaxCountLabel);
            this.Controls.Add(this.BlankFlowLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(858, 943);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(858, 943);
            this.Name = "ExpenseBlanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расход бланков";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel BlankFlowLayoutPanel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button RemovePageButton;
        private System.Windows.Forms.Button AddPageButton;
        private System.Windows.Forms.TextBox CurrentPageTextBox;
        private System.Windows.Forms.Label PageMaxCountLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}