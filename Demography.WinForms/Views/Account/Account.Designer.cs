namespace Demography.WinForms.Views.Account
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CertificatesButton = new System.Windows.Forms.Button();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.BlankButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.PostDataGridView = new System.Windows.Forms.DataGridView();
            this.MO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RolesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IndividualPermissionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ProfileTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.WorkPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            this.ButtonFlowLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.ButtonsPanel.Controls.Add(this.ButtonFlowLayoutPanel);
            this.ButtonsPanel.Controls.Add(this.MainButton);
            this.ButtonsPanel.Controls.Add(this.AccountButton);
            this.ButtonsPanel.Controls.Add(this.ExitButton);
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
            this.ButtonFlowLayoutPanel.Location = new System.Drawing.Point(0, 3);
            this.ButtonFlowLayoutPanel.Name = "ButtonFlowLayoutPanel";
            this.ButtonFlowLayoutPanel.Size = new System.Drawing.Size(342, 352);
            this.ButtonFlowLayoutPanel.TabIndex = 30;
            // 
            // CertificatesButton
            // 
            this.CertificatesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CertificatesButton.Location = new System.Drawing.Point(3, 3);
            this.CertificatesButton.Name = "CertificatesButton";
            this.CertificatesButton.Size = new System.Drawing.Size(339, 74);
            this.CertificatesButton.TabIndex = 4;
            this.CertificatesButton.Text = "Свидетельства";
            this.CertificatesButton.UseVisualStyleBackColor = true;
            this.CertificatesButton.Click += new System.EventHandler(this.ListCertificatesButton_Click);
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryButton.Location = new System.Drawing.Point(3, 83);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(339, 74);
            this.DirectoryButton.TabIndex = 35;
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
            this.ReportButton.TabIndex = 36;
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
            this.BlankButton.TabIndex = 37;
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
            this.MainButton.TabIndex = 3;
            this.MainButton.Text = "Новости";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.PostDataGridView);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.BirthdayDateTimePicker);
            this.panel1.Controls.Add(this.RolesRichTextBox);
            this.panel1.Controls.Add(this.IndividualPermissionRichTextBox);
            this.panel1.Controls.Add(this.CommentRichTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ProfileTypeComboBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.SexComboBox);
            this.panel1.Controls.Add(this.WorkPhoneTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PhoneTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.MiddleNameTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FirstNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LastNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(360, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 981);
            this.panel1.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(642, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Комментарий:";
            // 
            // PostDataGridView
            // 
            this.PostDataGridView.AllowUserToAddRows = false;
            this.PostDataGridView.AllowUserToDeleteRows = false;
            this.PostDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PostDataGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.PostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MO,
            this.Post});
            this.PostDataGridView.Location = new System.Drawing.Point(182, 570);
            this.PostDataGridView.Name = "PostDataGridView";
            this.PostDataGridView.ReadOnly = true;
            this.PostDataGridView.Size = new System.Drawing.Size(1248, 222);
            this.PostDataGridView.TabIndex = 28;
            // 
            // MO
            // 
            this.MO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MO.FillWeight = 200F;
            this.MO.HeaderText = "Медицинская организация";
            this.MO.Name = "MO";
            this.MO.ReadOnly = true;
            // 
            // Post
            // 
            this.Post.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Post.FillWeight = 200F;
            this.Post.HeaderText = "Должность";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Индивид. права:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "Роли:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Дата рождения:";
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Enabled = false;
            this.BirthdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(182, 141);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(437, 31);
            this.BirthdayDateTimePicker.TabIndex = 24;
            // 
            // RolesRichTextBox
            // 
            this.RolesRichTextBox.Location = new System.Drawing.Point(182, 328);
            this.RolesRichTextBox.Name = "RolesRichTextBox";
            this.RolesRichTextBox.ReadOnly = true;
            this.RolesRichTextBox.Size = new System.Drawing.Size(1248, 96);
            this.RolesRichTextBox.TabIndex = 23;
            this.RolesRichTextBox.Text = "";
            // 
            // IndividualPermissionRichTextBox
            // 
            this.IndividualPermissionRichTextBox.Location = new System.Drawing.Point(182, 440);
            this.IndividualPermissionRichTextBox.Name = "IndividualPermissionRichTextBox";
            this.IndividualPermissionRichTextBox.ReadOnly = true;
            this.IndividualPermissionRichTextBox.Size = new System.Drawing.Size(1248, 96);
            this.IndividualPermissionRichTextBox.TabIndex = 22;
            this.IndividualPermissionRichTextBox.Text = "";
            // 
            // CommentRichTextBox
            // 
            this.CommentRichTextBox.Location = new System.Drawing.Point(804, 205);
            this.CommentRichTextBox.Name = "CommentRichTextBox";
            this.CommentRichTextBox.ReadOnly = true;
            this.CommentRichTextBox.Size = new System.Drawing.Size(626, 96);
            this.CommentRichTextBox.TabIndex = 21;
            this.CommentRichTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Профиль:";
            // 
            // ProfileTypeComboBox
            // 
            this.ProfileTypeComboBox.FormattingEnabled = true;
            this.ProfileTypeComboBox.Location = new System.Drawing.Point(182, 273);
            this.ProfileTypeComboBox.Name = "ProfileTypeComboBox";
            this.ProfileTypeComboBox.Size = new System.Drawing.Size(437, 33);
            this.ProfileTypeComboBox.TabIndex = 19;
            this.ProfileTypeComboBox.TextChanged += new System.EventHandler(this.ProfileTypeComboBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(929, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Пол:";
            // 
            // SexComboBox
            // 
            this.SexComboBox.Enabled = false;
            this.SexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Location = new System.Drawing.Point(993, 15);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(437, 33);
            this.SexComboBox.TabIndex = 17;
            // 
            // WorkPhoneTextBox
            // 
            this.WorkPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkPhoneTextBox.Location = new System.Drawing.Point(993, 135);
            this.WorkPhoneTextBox.Name = "WorkPhoneTextBox";
            this.WorkPhoneTextBox.ReadOnly = true;
            this.WorkPhoneTextBox.Size = new System.Drawing.Size(437, 31);
            this.WorkPhoneTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(791, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Рабочий телефон:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTextBox.Location = new System.Drawing.Point(993, 94);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.ReadOnly = true;
            this.PhoneTextBox.Size = new System.Drawing.Size(437, 31);
            this.PhoneTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(879, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Телефон:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(993, 57);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(437, 31);
            this.EmailTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(872, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Эл. почта:";
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleNameTextBox.Location = new System.Drawing.Point(182, 101);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.ReadOnly = true;
            this.MiddleNameTextBox.Size = new System.Drawing.Size(437, 31);
            this.MiddleNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(64, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(182, 61);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.ReadOnly = true;
            this.FirstNameTextBox.Size = new System.Drawing.Size(437, 31);
            this.FirstNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(116, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextBox.Location = new System.Drawing.Point(182, 21);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(437, 31);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль пользователя";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Account_FormClosing);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonFlowLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.DataGridView PostDataGridView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox RolesRichTextBox;
        private System.Windows.Forms.RichTextBox IndividualPermissionRichTextBox;
        private System.Windows.Forms.RichTextBox CommentRichTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ProfileTypeComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.TextBox WorkPhoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.Button CertificatesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.Button BlankButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.FlowLayoutPanel ButtonFlowLayoutPanel;
    }
}