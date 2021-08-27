namespace Demography.WinForms.Views.Authorization
{
    partial class Authorization
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.PasswordCharCheckСheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordCharCheckСheckBox
            // 
            this.PasswordCharCheckСheckBox.AutoSize = true;
            this.PasswordCharCheckСheckBox.Location = new System.Drawing.Point(304, 296);
            this.PasswordCharCheckСheckBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PasswordCharCheckСheckBox.Name = "PasswordCharCheckСheckBox";
            this.PasswordCharCheckСheckBox.Size = new System.Drawing.Size(202, 29);
            this.PasswordCharCheckСheckBox.TabIndex = 13;
            this.PasswordCharCheckСheckBox.Text = "Показать пароль";
            this.PasswordCharCheckСheckBox.UseVisualStyleBackColor = true;
            this.PasswordCharCheckСheckBox.CheckedChanged += new System.EventHandler(this.СheckBoxPasswordCharCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Электронная почта";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(301, 340);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(256, 44);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Авторизоваться";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(301, 248);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(252, 31);
            this.PasswordTextBox.TabIndex = 9;
            this.PasswordTextBox.Text = "1111";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(301, 150);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(252, 31);
            this.EmailTextBox.TabIndex = 8;
            this.EmailTextBox.Text = "lexa@mail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(296, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 74);
            this.label1.TabIndex = 7;
            this.label1.Text = "Приветствуем в\r\n    МИС \"Аист\"";
            // 
            // RegistationButton
            // 
            this.RegistationButton.Location = new System.Drawing.Point(301, 396);
            this.RegistationButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RegistationButton.Name = "RegistationButton";
            this.RegistationButton.Size = new System.Drawing.Size(256, 44);
            this.RegistationButton.TabIndex = 14;
            this.RegistationButton.Text = "Зарегистрироваться";
            this.RegistationButton.UseVisualStyleBackColor = true;
            this.RegistationButton.Click += new System.EventHandler(this.ButtonRegistation_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(860, 462);
            this.Controls.Add(this.RegistationButton);
            this.Controls.Add(this.PasswordCharCheckСheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(876, 501);
            this.MinimumSize = new System.Drawing.Size(876, 501);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PasswordCharCheckСheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegistationButton;
    }
}

