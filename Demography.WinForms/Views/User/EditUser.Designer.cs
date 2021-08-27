namespace Demography.WinForms.Views.User
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.ButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CertificatesButton = new System.Windows.Forms.Button();
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.BlankButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.AllowAccessButton = new System.Windows.Forms.Button();
            this.DeniedAccessButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.BidRoleComboBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.IdUser = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddPostButton = new System.Windows.Forms.Button();
            this.AddRoleButton = new System.Windows.Forms.Button();
            this.RolesDataGridView = new System.Windows.Forms.DataGridView();
            this.RoleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.PostDataGridView = new System.Windows.Forms.DataGridView();
            this.MO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CommentRichTextBox = new System.Windows.Forms.RichTextBox();
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
            this.UserEditErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ButtonsPanel.SuspendLayout();
            this.ButtonFlowLayoutPanel.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEditErrorProvider)).BeginInit();
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
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.BackColor = System.Drawing.Color.Azure;
            this.Panel.Controls.Add(this.AllowAccessButton);
            this.Panel.Controls.Add(this.DeniedAccessButton);
            this.Panel.Controls.Add(this.label22);
            this.Panel.Controls.Add(this.BidRoleComboBox);
            this.Panel.Controls.Add(this.label21);
            this.Panel.Controls.Add(this.StatusComboBox);
            this.Panel.Controls.Add(this.IdUser);
            this.Panel.Controls.Add(this.BackButton);
            this.Panel.Controls.Add(this.SaveButton);
            this.Panel.Controls.Add(this.AddPostButton);
            this.Panel.Controls.Add(this.AddRoleButton);
            this.Panel.Controls.Add(this.RolesDataGridView);
            this.Panel.Controls.Add(this.label14);
            this.Panel.Controls.Add(this.PostDataGridView);
            this.Panel.Controls.Add(this.label11);
            this.Panel.Controls.Add(this.BirthdayDateTimePicker);
            this.Panel.Controls.Add(this.CommentRichTextBox);
            this.Panel.Controls.Add(this.label9);
            this.Panel.Controls.Add(this.SexComboBox);
            this.Panel.Controls.Add(this.WorkPhoneTextBox);
            this.Panel.Controls.Add(this.label7);
            this.Panel.Controls.Add(this.PhoneTextBox);
            this.Panel.Controls.Add(this.label6);
            this.Panel.Controls.Add(this.EmailTextBox);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.MiddleNameTextBox);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.FirstNameTextBox);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.LastNameTextBox);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Panel.Location = new System.Drawing.Point(363, 15);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1510, 981);
            this.Panel.TabIndex = 5;
            // 
            // AllowAccessButton
            // 
            this.AllowAccessButton.Location = new System.Drawing.Point(45, 416);
            this.AllowAccessButton.Name = "AllowAccessButton";
            this.AllowAccessButton.Size = new System.Drawing.Size(256, 44);
            this.AllowAccessButton.TabIndex = 65;
            this.AllowAccessButton.Text = "Разрешить доступ";
            this.AllowAccessButton.UseVisualStyleBackColor = true;
            this.AllowAccessButton.Click += new System.EventHandler(this.AllowAccessButton_Click);
            // 
            // DeniedAccessButton
            // 
            this.DeniedAccessButton.Location = new System.Drawing.Point(45, 416);
            this.DeniedAccessButton.Name = "DeniedAccessButton";
            this.DeniedAccessButton.Size = new System.Drawing.Size(256, 44);
            this.DeniedAccessButton.TabIndex = 64;
            this.DeniedAccessButton.Text = "Запретить доступ";
            this.DeniedAccessButton.UseVisualStyleBackColor = true;
            this.DeniedAccessButton.Click += new System.EventHandler(this.DeniedAccessButton_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(712, 185);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(274, 25);
            this.label22.TabIndex = 63;
            this.label22.Text = "Роль, указанная в заявке:";
            // 
            // BidRoleComboBox
            // 
            this.BidRoleComboBox.Enabled = false;
            this.BidRoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BidRoleComboBox.FormattingEnabled = true;
            this.BidRoleComboBox.Location = new System.Drawing.Point(993, 182);
            this.BidRoleComboBox.Name = "BidRoleComboBox";
            this.BidRoleComboBox.Size = new System.Drawing.Size(437, 33);
            this.BidRoleComboBox.TabIndex = 62;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(825, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 25);
            this.label21.TabIndex = 61;
            this.label21.Text = "Статус заявки:";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Enabled = false;
            this.StatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(993, 141);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(437, 33);
            this.StatusComboBox.TabIndex = 60;
            // 
            // IdUser
            // 
            this.IdUser.AutoSize = true;
            this.IdUser.Location = new System.Drawing.Point(61, 846);
            this.IdUser.Name = "IdUser";
            this.IdUser.Size = new System.Drawing.Size(0, 25);
            this.IdUser.TabIndex = 45;
            this.IdUser.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(910, 416);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(256, 44);
            this.BackButton.TabIndex = 44;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1174, 416);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(256, 44);
            this.SaveButton.TabIndex = 42;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddPostButton
            // 
            this.AddPostButton.Location = new System.Drawing.Point(501, 751);
            this.AddPostButton.Name = "AddPostButton";
            this.AddPostButton.Size = new System.Drawing.Size(256, 44);
            this.AddPostButton.TabIndex = 39;
            this.AddPostButton.Text = "Добавить";
            this.AddPostButton.UseVisualStyleBackColor = true;
            this.AddPostButton.Click += new System.EventHandler(this.AddPostButton_Click);
            // 
            // AddRoleButton
            // 
            this.AddRoleButton.Location = new System.Drawing.Point(1174, 751);
            this.AddRoleButton.Name = "AddRoleButton";
            this.AddRoleButton.Size = new System.Drawing.Size(256, 44);
            this.AddRoleButton.TabIndex = 37;
            this.AddRoleButton.Text = "Добавить";
            this.AddRoleButton.UseVisualStyleBackColor = true;
            this.AddRoleButton.Click += new System.EventHandler(this.AddRoleButton_Click);
            // 
            // RolesDataGridView
            // 
            this.RolesDataGridView.AllowUserToAddRows = false;
            this.RolesDataGridView.AllowUserToDeleteRows = false;
            this.RolesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RolesDataGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.RolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleNameDataGridViewTextBoxColumn,
            this.IdRole});
            this.RolesDataGridView.Location = new System.Drawing.Point(804, 523);
            this.RolesDataGridView.Name = "RolesDataGridView";
            this.RolesDataGridView.ReadOnly = true;
            this.RolesDataGridView.Size = new System.Drawing.Size(626, 222);
            this.RolesDataGridView.TabIndex = 35;
            this.RolesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RolesDataGridView_CellClick);
            // 
            // RoleNameDataGridViewTextBoxColumn
            // 
            this.RoleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.RoleNameDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.RoleNameDataGridViewTextBoxColumn.Name = "RoleNameDataGridViewTextBoxColumn";
            this.RoleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IdRole
            // 
            this.IdRole.HeaderText = "";
            this.IdRole.Name = "IdRole";
            this.IdRole.ReadOnly = true;
            this.IdRole.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(40, 262);
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
            this.Post,
            this.IdPost});
            this.PostDataGridView.Location = new System.Drawing.Point(123, 523);
            this.PostDataGridView.Name = "PostDataGridView";
            this.PostDataGridView.ReadOnly = true;
            this.PostDataGridView.Size = new System.Drawing.Size(634, 222);
            this.PostDataGridView.TabIndex = 28;
            this.PostDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PostDataGridView_CellClick);
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
            // IdPost
            // 
            this.IdPost.HeaderText = "";
            this.IdPost.Name = "IdPost";
            this.IdPost.ReadOnly = true;
            this.IdPost.Visible = false;
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
            this.BirthdayDateTimePicker.Checked = false;
            this.BirthdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(182, 141);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(437, 31);
            this.BirthdayDateTimePicker.TabIndex = 24;
            // 
            // CommentRichTextBox
            // 
            this.CommentRichTextBox.Location = new System.Drawing.Point(202, 262);
            this.CommentRichTextBox.Name = "CommentRichTextBox";
            this.CommentRichTextBox.ReadOnly = true;
            this.CommentRichTextBox.Size = new System.Drawing.Size(1228, 96);
            this.CommentRichTextBox.TabIndex = 21;
            this.CommentRichTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(118, 181);
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
            this.SexComboBox.Location = new System.Drawing.Point(182, 182);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(437, 33);
            this.SexComboBox.TabIndex = 17;
            // 
            // WorkPhoneTextBox
            // 
            this.WorkPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkPhoneTextBox.Location = new System.Drawing.Point(993, 104);
            this.WorkPhoneTextBox.Name = "WorkPhoneTextBox";
            this.WorkPhoneTextBox.Size = new System.Drawing.Size(437, 31);
            this.WorkPhoneTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(791, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Рабочий телефон:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTextBox.Location = new System.Drawing.Point(993, 63);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(437, 31);
            this.PhoneTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(879, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Телефон:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(993, 22);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(437, 31);
            this.EmailTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(872, 22);
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
            // UserEditErrorProvider
            // 
            this.UserEditErrorProvider.ContainerControl = this;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.ButtonsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "EditUser";
            this.Text = "Редактирование пользователя";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditUser_FormClosing);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonFlowLayoutPanel.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserEditErrorProvider)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView PostDataGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.RichTextBox CommentRichTextBox;
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
        private System.Windows.Forms.DataGridView RolesDataGridView;
        private System.Windows.Forms.Button AddRoleButton;
        private System.Windows.Forms.Button AddPostButton;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox BidRoleComboBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label IdUser;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRole;
        private System.Windows.Forms.Button DeniedAccessButton;
        private System.Windows.Forms.Button AllowAccessButton;
        private System.Windows.Forms.ErrorProvider UserEditErrorProvider;
    }
}