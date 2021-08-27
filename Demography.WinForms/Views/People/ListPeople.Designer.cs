namespace Demography.WinForms.Views.People
{
    partial class ListPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPeople));
            this.PeopleFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddPeopleButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SnilsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.RemovePageButton = new System.Windows.Forms.Button();
            this.AddPageButton = new System.Windows.Forms.Button();
            this.CurrentPageTextBox = new System.Windows.Forms.TextBox();
            this.PageMaxCountLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PeopleFlowLayoutPanel
            // 
            this.PeopleFlowLayoutPanel.BackColor = System.Drawing.Color.Azure;
            this.PeopleFlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleFlowLayoutPanel.Location = new System.Drawing.Point(12, 40);
            this.PeopleFlowLayoutPanel.Name = "PeopleFlowLayoutPanel";
            this.PeopleFlowLayoutPanel.Size = new System.Drawing.Size(1045, 689);
            this.PeopleFlowLayoutPanel.TabIndex = 2;
            // 
            // AddPeopleButton
            // 
            this.AddPeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPeopleButton.Location = new System.Drawing.Point(1107, 50);
            this.AddPeopleButton.Name = "AddPeopleButton";
            this.AddPeopleButton.Size = new System.Drawing.Size(339, 74);
            this.AddPeopleButton.TabIndex = 8;
            this.AddPeopleButton.Text = "Добавить пациентку";
            this.AddPeopleButton.UseVisualStyleBackColor = true;
            this.AddPeopleButton.Click += new System.EventHandler(this.AddPeopleButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilterButton.Location = new System.Drawing.Point(1107, 454);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(339, 74);
            this.FilterButton.TabIndex = 32;
            this.FilterButton.Text = "Поиск";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(1241, 292);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.MiddleNameTextBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1124, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Отчество:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(1241, 240);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.FirstNameTextBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1176, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Имя:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(1241, 194);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.LastNameTextBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1125, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1201, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Фильтрация";
            // 
            // BirthDateDateTimePicker
            // 
            this.BirthDateDateTimePicker.Checked = false;
            this.BirthDateDateTimePicker.Location = new System.Drawing.Point(1241, 339);
            this.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker";
            this.BirthDateDateTimePicker.ShowCheckBox = true;
            this.BirthDateDateTimePicker.Size = new System.Drawing.Size(218, 31);
            this.BirthDateDateTimePicker.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1063, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Дата рождения:";
            // 
            // SnilsMaskedTextBox
            // 
            this.SnilsMaskedTextBox.Location = new System.Drawing.Point(1241, 389);
            this.SnilsMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.SnilsMaskedTextBox.Mask = "000-000-000 00";
            this.SnilsMaskedTextBox.Name = "SnilsMaskedTextBox";
            this.SnilsMaskedTextBox.Size = new System.Drawing.Size(218, 31);
            this.SnilsMaskedTextBox.TabIndex = 58;
            this.SnilsMaskedTextBox.ValidatingType = typeof(int);
            this.SnilsMaskedTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SnilsMaskedTextBox_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1131, 389);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Снилс*:";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(568, 734);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(90, 25);
            this.CountLabel.TabIndex = 63;
            this.CountLabel.Text = "0-0 из 0";
            // 
            // RemovePageButton
            // 
            this.RemovePageButton.BackgroundImage = global::Demography.WinForms.Properties.Resources.backarrow;
            this.RemovePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemovePageButton.Location = new System.Drawing.Point(400, 735);
            this.RemovePageButton.Name = "RemovePageButton";
            this.RemovePageButton.Size = new System.Drawing.Size(50, 22);
            this.RemovePageButton.TabIndex = 62;
            this.RemovePageButton.UseVisualStyleBackColor = true;
            this.RemovePageButton.Click += new System.EventHandler(this.RemovePageButton_Click);
            // 
            // AddPageButton
            // 
            this.AddPageButton.BackgroundImage = global::Demography.WinForms.Properties.Resources.forwardarrow;
            this.AddPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddPageButton.Location = new System.Drawing.Point(512, 735);
            this.AddPageButton.Name = "AddPageButton";
            this.AddPageButton.Size = new System.Drawing.Size(50, 22);
            this.AddPageButton.TabIndex = 61;
            this.AddPageButton.UseVisualStyleBackColor = true;
            this.AddPageButton.Click += new System.EventHandler(this.AddPageButton_Click);
            // 
            // CurrentPageTextBox
            // 
            this.CurrentPageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentPageTextBox.Location = new System.Drawing.Point(456, 735);
            this.CurrentPageTextBox.Name = "CurrentPageTextBox";
            this.CurrentPageTextBox.Size = new System.Drawing.Size(25, 22);
            this.CurrentPageTextBox.TabIndex = 60;
            this.CurrentPageTextBox.Text = "1";
            this.CurrentPageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentPageTextBox_KeyPress);
            // 
            // PageMaxCountLabel
            // 
            this.PageMaxCountLabel.AutoSize = true;
            this.PageMaxCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageMaxCountLabel.Location = new System.Drawing.Point(487, 738);
            this.PageMaxCountLabel.Name = "PageMaxCountLabel";
            this.PageMaxCountLabel.Size = new System.Drawing.Size(19, 16);
            this.PageMaxCountLabel.TabIndex = 59;
            this.PageMaxCountLabel.Text = "/1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 64;
            this.label8.Text = "ФИО";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "Дата рождения";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(637, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 25);
            this.label10.TabIndex = 66;
            this.label10.Text = "Место жительства";
            // 
            // ListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1474, 762);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.RemovePageButton);
            this.Controls.Add(this.AddPageButton);
            this.Controls.Add(this.CurrentPageTextBox);
            this.Controls.Add(this.PageMaxCountLabel);
            this.Controls.Add(this.SnilsMaskedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BirthDateDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPeopleButton);
            this.Controls.Add(this.PeopleFlowLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1490, 801);
            this.MinimumSize = new System.Drawing.Size(1490, 801);
            this.Name = "ListPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список пациенток";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListPeople_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PeopleFlowLayoutPanel;
        private System.Windows.Forms.Button AddPeopleButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BirthDateDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox SnilsMaskedTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button RemovePageButton;
        private System.Windows.Forms.Button AddPageButton;
        private System.Windows.Forms.TextBox CurrentPageTextBox;
        private System.Windows.Forms.Label PageMaxCountLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}