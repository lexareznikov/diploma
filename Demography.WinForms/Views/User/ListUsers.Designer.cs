namespace Demography.WinForms.Views.User
{
    partial class UsersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersList));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CertificatesButton = new System.Windows.Forms.Button();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.BlankButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RemovePageButton = new System.Windows.Forms.Button();
            this.AddPageButton = new System.Windows.Forms.Button();
            this.CurrentPageTextBox = new System.Windows.Forms.TextBox();
            this.PageMaxCountLabel = new System.Windows.Forms.Label();
            this.UsersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            this.ButtonFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.ButtonsPanel.TabIndex = 3;
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
            // RemovePageButton
            // 
            this.RemovePageButton.BackgroundImage = global::Demography.WinForms.Properties.Resources.backarrow;
            this.RemovePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovePageButton.Location = new System.Drawing.Point(876, 997);
            this.RemovePageButton.Name = "RemovePageButton";
            this.RemovePageButton.Size = new System.Drawing.Size(50, 22);
            this.RemovePageButton.TabIndex = 10;
            this.RemovePageButton.UseVisualStyleBackColor = true;
            this.RemovePageButton.Click += new System.EventHandler(this.RemovePageButton_Click);
            // 
            // AddPageButton
            // 
            this.AddPageButton.BackgroundImage = global::Demography.WinForms.Properties.Resources.forwardarrow;
            this.AddPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddPageButton.Location = new System.Drawing.Point(988, 997);
            this.AddPageButton.Name = "AddPageButton";
            this.AddPageButton.Size = new System.Drawing.Size(50, 22);
            this.AddPageButton.TabIndex = 9;
            this.AddPageButton.UseVisualStyleBackColor = true;
            this.AddPageButton.Click += new System.EventHandler(this.AddPageButton_Click);
            // 
            // CurrentPageTextBox
            // 
            this.CurrentPageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentPageTextBox.Location = new System.Drawing.Point(932, 997);
            this.CurrentPageTextBox.Name = "CurrentPageTextBox";
            this.CurrentPageTextBox.Size = new System.Drawing.Size(25, 22);
            this.CurrentPageTextBox.TabIndex = 8;
            this.CurrentPageTextBox.Text = "1";
            this.CurrentPageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentPageTextBox_KeyPress);
            // 
            // PageMaxCountLabel
            // 
            this.PageMaxCountLabel.AutoSize = true;
            this.PageMaxCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageMaxCountLabel.Location = new System.Drawing.Point(963, 1000);
            this.PageMaxCountLabel.Name = "PageMaxCountLabel";
            this.PageMaxCountLabel.Size = new System.Drawing.Size(19, 16);
            this.PageMaxCountLabel.TabIndex = 6;
            this.PageMaxCountLabel.Text = "/1";
            // 
            // UsersFlowLayoutPanel
            // 
            this.UsersFlowLayoutPanel.BackColor = System.Drawing.Color.Azure;
            this.UsersFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFlowLayoutPanel.Location = new System.Drawing.Point(360, 52);
            this.UsersFlowLayoutPanel.Name = "UsersFlowLayoutPanel";
            this.UsersFlowLayoutPanel.Size = new System.Drawing.Size(1200, 941);
            this.UsersFlowLayoutPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1666, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1561, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Фамилия:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(1671, 120);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.LastNameTextBox.TabIndex = 13;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(1671, 166);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.FirstNameTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1613, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Имя:";
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(1671, 218);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.MiddleNameTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1560, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Отчество:";
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.Location = new System.Drawing.Point(1565, 388);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(339, 74);
            this.FilterButton.TabIndex = 20;
            this.FilterButton.Text = "Поиск";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(1674, 277);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(215, 33);
            this.StatusComboBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1585, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Статус:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1604, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Роли:";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(1674, 331);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(215, 33);
            this.RoleComboBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "ФИО Врача";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(817, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Логин (Email)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1067, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Статус заявки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1248, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 50);
            this.label10.TabIndex = 26;
            this.label10.Text = "Дата последнего\r\nвхода/выхода";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(1044, 996);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(90, 25);
            this.CountLabel.TabIndex = 27;
            this.CountLabel.Text = "0-0 из 0";
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemovePageButton);
            this.Controls.Add(this.AddPageButton);
            this.Controls.Add(this.CurrentPageTextBox);
            this.Controls.Add(this.PageMaxCountLabel);
            this.Controls.Add(this.UsersFlowLayoutPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "ListUsers";
            this.Text = "Список пользователей";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListUsers_FormClosing);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.FlowLayoutPanel ButtonFlowLayoutPanel;
        private System.Windows.Forms.Button CertificatesButton;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button BlankButton;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RemovePageButton;
        private System.Windows.Forms.Button AddPageButton;
        private System.Windows.Forms.TextBox CurrentPageTextBox;
        private System.Windows.Forms.Label PageMaxCountLabel;
        private System.Windows.Forms.FlowLayoutPanel UsersFlowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label CountLabel;
    }
}