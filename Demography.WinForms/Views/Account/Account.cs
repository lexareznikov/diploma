using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Controllers;
using Demography.WinForms.Utility;
using Demography.WinForms.Views.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demography.WinForms.Views.Account
{
    public partial class Account : Form
    {
        #region GetValueFromForm
        public string FirstName { get { return FirstNameTextBox.Text; } set { FirstNameTextBox.Text = value; } }
        public string LastName { get { return LastNameTextBox.Text; } set { LastNameTextBox.Text = value; } }
        public string MiddleName { get { return MiddleNameTextBox.Text; } set { MiddleNameTextBox.Text = value; } }
      //  public string INN { get { return InnTextBox.Text; } set { InnTextBox.Text = value; } }
        public string Email { get { return EmailTextBox.Text; } set { EmailTextBox.Text = value; } }
        public string Phone { get { return PhoneTextBox.Text; } set { PhoneTextBox.Text = value; } }
        public string WorkPhone { get { return WorkPhoneTextBox.Text; } set { WorkPhoneTextBox.Text = value; } }
        public string Comment { get { return CommentRichTextBox.Text; } set { CommentRichTextBox.Text = value; } }
        public string Roles { get { return RolesRichTextBox.Text; } set { RolesRichTextBox.Text = value; } }
       // public string Snils { get { return SnilsMaskedTextBox.Text.Replace("-", "").Replace(" ", ""); } set { SnilsMaskedTextBox.Text = value; } }
        public DateTime? BirthDate { get { return BirthdayDateTimePicker.Value; } set { BirthdayDateTimePicker.Value = value.Value; } }
        public int? Sex { get { return (int?)SexComboBox.SelectedValue; } set { SexComboBox.SelectedValue = value; } }
        public int? ProfileType { get { return (int?)ProfileTypeComboBox.SelectedValue; } set { ProfileTypeComboBox.SelectedValue = value; } }
        #endregion


        private ListController _listController;
        private UserController _userController;
        private bool IsChangeProfile;

        public Account()
        {
            InitializeComponent();
            _listController = new ListController();
            _userController = new UserController();
            IsChangeProfile = false;
            InitForm();

            ButtonsWithProfileAndPermission();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }



        private void AccountButton_Click(object sender, EventArgs e)
        {

            InitForm();
              
            //var t = this.Owner as News.News;
            //t.testic();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            //returnValue = 2;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void InitForm()
        {
            IsChangeProfile = false;
            _listController.InitDropDownListEnum<SexPeople>(SexComboBox);
            _listController.DropDownListProfileTypeForUser(ProfileTypeComboBox);
            PostDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

           
            FillForm();
        }
       
        private void FillForm()
        {
            PostDataGridView.Rows.Clear();
            var model = _userController.GetById(CurrentUser.Id).FirstOrDefault();
            _userController.Reload(model);
            FirstName = model.FirstName;
            LastName = model.LastName;
            MiddleName = model.MiddleName;
           // INN = model.INN;
            Email = model.Email;
            Phone = model.Phone;
            WorkPhone = model.WorkPhone;
            Comment = model.Comment;
            //Snils = model.Snils;
            BirthDate = model.BirthDate;
            Sex = model.SexId;
            ProfileType = model.ProfileTypeId;
            IsChangeProfile = true;
            Roles = string.Join(", ", CurrentUser.RolesWithoutRestrictionProfile.Select(x => x.Name).ToArray());
            foreach (var item in model.UserClinics)
            {
                PostDataGridView.Rows.Add(item.Clinic.ShortName, item.Position.Name);
            }
        }

        private void ProfileTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (IsChangeProfile)
            {
                ProfileTypeChanged();
            }
        }

        private void ProfileTypeChanged()
        {
            _userController.UpdateProfile(ProfileType.Value);
            //Отображать кнопкуи

            ButtonsWithProfileAndPermission();

        }
        public int ReturnButton { get; private set; }
        private void ListCertificatesButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.DialogResult = DialogResult.Abort;
            //returnValue = 1;
            var form =new ButtonList("Свидетельства", (int)SwitchButtonsType.CertificatesList);
            var result = form.ShowDialog();
            if (result == DialogResult.Abort)
            {
                ReturnButton = form.ReturnButton;
                this.Close();
                this.DialogResult = DialogResult.Abort;
            }
           
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            var form = new ButtonList("Справочники", (int)SwitchButtonsType.Directories);
            var result = form.ShowDialog();
            if (result == DialogResult.Abort)
            {
                ReturnButton = form.ReturnButton;
                this.Close();
                this.DialogResult = DialogResult.Abort;
            }
           
        }
        private void ButtonsWithProfileAndPermission()
        {
            ButtonsWithPermission();

            if (CurrentUser.HasRoles(RoleApp.Medstatistic))
            {
                ReportButton.Show();
                BlankButton.Show();

            }
            else
            {
                BlankButton.Hide();
                ReportButton.Hide();
            }
        }
        private void ButtonsWithPermission()
        {
            var t = CurrentUser.HasPermission(PermissionsApp.CerBirthView);
            if (CurrentUser.HasPermission(PermissionsApp.CerBirthView))
            {
                CertificatesButton.Show();
            }
            else
            {
                CertificatesButton.Hide();
            }
            if (CurrentUser.HasPermission(PermissionsApp.UserAdd))
            {
                DirectoryButton.Show();
            }
            else
            {
                DirectoryButton.Hide();
            }

        }

        private void BlankButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Blanks;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Reports;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }
    }
}
