namespace Demography.WinForms.Views.Authorization
{
    partial class SetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPassword));
            this.RegistationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SecondPasswordTextBox = new System.Windows.Forms.TextBox();
            this.FirstPasswordlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RegistationButton
            // 
            this.RegistationButton.Location = new System.Drawing.Point(21, 145);
            this.RegistationButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RegistationButton.Name = "RegistationButton";
            this.RegistationButton.Size = new System.Drawing.Size(256, 44);
            this.RegistationButton.TabIndex = 21;
            this.RegistationButton.Text = "Назад";
            this.RegistationButton.UseVisualStyleBackColor = true;
            this.RegistationButton.Click += new System.EventHandler(this.RegistationButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль:";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(393, 145);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(256, 44);
            this.LoginButton.TabIndex = 17;
            this.LoginButton.Text = "Задать пароль";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SecondPasswordTextBox
            // 
            this.SecondPasswordTextBox.Location = new System.Drawing.Point(282, 75);
            this.SecondPasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SecondPasswordTextBox.Name = "SecondPasswordTextBox";
            this.SecondPasswordTextBox.PasswordChar = '*';
            this.SecondPasswordTextBox.Size = new System.Drawing.Size(252, 31);
            this.SecondPasswordTextBox.TabIndex = 16;
            // 
            // FirstPasswordlTextBox
            // 
            this.FirstPasswordlTextBox.Location = new System.Drawing.Point(282, 32);
            this.FirstPasswordlTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FirstPasswordlTextBox.Name = "FirstPasswordlTextBox";
            this.FirstPasswordlTextBox.PasswordChar = '*';
            this.FirstPasswordlTextBox.Size = new System.Drawing.Size(252, 31);
            this.FirstPasswordlTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Пароль еще раз:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(254, 9);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(0, 25);
            this.EmailLabel.TabIndex = 23;
            // 
            // PasswordErrorProvider
            // 
            this.PasswordErrorProvider.ContainerControl = this;
            // 
            // SetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(687, 209);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SecondPasswordTextBox);
            this.Controls.Add(this.FirstPasswordlTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(703, 248);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(703, 248);
            this.Name = "SetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задать значение";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistationButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox SecondPasswordTextBox;
        private System.Windows.Forms.TextBox FirstPasswordlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.ErrorProvider PasswordErrorProvider;
    }
}