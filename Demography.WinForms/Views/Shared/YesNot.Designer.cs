namespace Demography.WinForms.Views.Shared
{
    partial class YesNot
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
            this.YesButton = new System.Windows.Forms.Button();
            this.NotButton = new System.Windows.Forms.Button();
            this.MessageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesButton.Location = new System.Drawing.Point(43, 142);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(256, 44);
            this.YesButton.TabIndex = 3;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // NotButton
            // 
            this.NotButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotButton.Location = new System.Drawing.Point(481, 142);
            this.NotButton.Name = "NotButton";
            this.NotButton.Size = new System.Drawing.Size(256, 44);
            this.NotButton.TabIndex = 4;
            this.NotButton.Text = "Нет";
            this.NotButton.UseVisualStyleBackColor = true;
            this.NotButton.Click += new System.EventHandler(this.NotButton_Click);
            // 
            // MessageRichTextBox
            // 
            this.MessageRichTextBox.BackColor = System.Drawing.Color.Azure;
            this.MessageRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.MessageRichTextBox.Name = "MessageRichTextBox";
            this.MessageRichTextBox.ReadOnly = true;
            this.MessageRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MessageRichTextBox.Size = new System.Drawing.Size(777, 124);
            this.MessageRichTextBox.TabIndex = 5;
            this.MessageRichTextBox.Text = "";
            // 
            // YesNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(801, 198);
            this.ControlBox = false;
            this.Controls.Add(this.MessageRichTextBox);
            this.Controls.Add(this.NotButton);
            this.Controls.Add(this.YesButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "YesNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NotButton;
        private System.Windows.Forms.RichTextBox MessageRichTextBox;
    }
}