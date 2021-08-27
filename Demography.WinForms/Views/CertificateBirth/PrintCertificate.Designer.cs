namespace Demography.WinForms.Views.CertificateBirth
{
    partial class PrintCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintCertificate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.PrintedButton = new System.Windows.Forms.Button();
            this.tbPageNo = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrior = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.preview1 = new FastReport.Preview.PreviewControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.PrintedButton);
            this.panel1.Controls.Add(this.tbPageNo);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrior);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.btnZoomIn);
            this.panel1.Controls.Add(this.btnZoomOut);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.preview1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 1030);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(708, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(163, 32);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PrintedButton
            // 
            this.PrintedButton.Location = new System.Drawing.Point(877, 4);
            this.PrintedButton.Name = "PrintedButton";
            this.PrintedButton.Size = new System.Drawing.Size(163, 32);
            this.PrintedButton.TabIndex = 13;
            this.PrintedButton.Text = "Распечатано";
            this.PrintedButton.UseVisualStyleBackColor = true;
            this.PrintedButton.Click += new System.EventHandler(this.PrintedButton_Click);
            // 
            // tbPageNo
            // 
            this.tbPageNo.Location = new System.Drawing.Point(390, 4);
            this.tbPageNo.Name = "tbPageNo";
            this.tbPageNo.ReadOnly = true;
            this.tbPageNo.Size = new System.Drawing.Size(36, 31);
            this.tbPageNo.TabIndex = 12;
            this.tbPageNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPageNo_KeyDown);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(466, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(46, 32);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(430, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 32);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrior
            // 
            this.btnPrior.Location = new System.Drawing.Point(355, 4);
            this.btnPrior.Name = "btnPrior";
            this.btnPrior.Size = new System.Drawing.Size(31, 32);
            this.btnPrior.TabIndex = 6;
            this.btnPrior.Text = "<";
            this.btnPrior.UseVisualStyleBackColor = true;
            this.btnPrior.Click += new System.EventHandler(this.btnPrior_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(305, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(44, 32);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(603, 4);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(32, 32);
            this.btnZoomIn.TabIndex = 8;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(567, 4);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(32, 32);
            this.btnZoomOut.TabIndex = 9;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(3, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 32);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // preview1
            // 
            this.preview1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.preview1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.preview1.Location = new System.Drawing.Point(3, 41);
            this.preview1.Name = "preview1";
            this.preview1.PageOffset = new System.Drawing.Point(10, 10);
            this.preview1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.preview1.SaveInitialDirectory = null;
            this.preview1.Size = new System.Drawing.Size(1037, 986);
            this.preview1.StatusbarVisible = false;
            this.preview1.TabIndex = 1;
            this.preview1.ToolbarVisible = false;
            this.preview1.UIStyle = FastReport.Utils.UIStyle.VisualStudio2005;
            this.preview1.PageChanged += new System.EventHandler(this.preview1_PageChanged);
            // 
            // PrintCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 1041);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1083, 1080);
            this.MinimumSize = new System.Drawing.Size(1083, 1080);
            this.Name = "PrintCertificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPageNo;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrior;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnPrint;
        private FastReport.Preview.PreviewControl preview1;
        private System.Windows.Forms.Button PrintedButton;
        private System.Windows.Forms.Button BackButton;
    }
}