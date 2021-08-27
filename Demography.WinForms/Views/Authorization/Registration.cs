using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Extensions;
using Demography.WinForms.Controllers;
using Demography.WinForms.MapperConfig;
using Demography.WinForms.Models;
using Demography.WinForms.Views.Shared;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Demography.WinForms.Views.Authorization
{
    public partial class Registration : Form
    {
        #region GetValueFromForm
        public string FirstName { get { return FirstNameTextBox.Text; } }
        public string LastName { get { return LastNameTextBox.Text; } }
        public string MiddleName { get { return MiddleNameTextBox.Text; } }
        public string Email { get { return EmailMaskedTextBox.Text; } }
        public string Phone { get { return PhoneMaskedTextBox.Text; } }
        public string WorkPhone { get { return WorkPhoneMaskedTextBox.Text; } }
        public string Comment { get { return CommentRichTextBox.Text; } }
        public DateTime? BirthDate { get { return BirthdayDateTimePicker.Value; } }
        public int? Clinic { get { return (int?)ClinicComboBox.SelectedValue; } }
       
        public int? BidRole { get { return (int?)BidRoleComboBox.SelectedValue; } }
        public int? Sex { get { return (int?)SexComboBox.SelectedValue; } }
        public string Position { get { return PositionComboBox.SelectedValue.ToString(); } }
        #endregion

        private ListController _listController;

        private UserConfig _userConfig;
        private UserController _userController;

        public Registration()
        {
            InitializeComponent();
            _userConfig = new UserConfig();
            _userController = new UserController();
            _listController = new ListController();
            InitForm();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Authorization"].Show();
        }


       
        private bool IsValidModel(RegistrationModel model)
        {
            bool IsValidModel = true;
            if (string.IsNullOrEmpty(model.FirstName))
            {
                CreateErrorProvider.SetError(FirstNameTextBox, "Обязательное поле");
                IsValidModel = false;
            }
            if (string.IsNullOrEmpty(model.Comment))
            {
                CreateErrorProvider.SetError(CommentRichTextBox, "Обязательное поле");
                IsValidModel = false;
            }
           
            if (!CheckEmail(model.Email))
            {
                CreateErrorProvider.SetError(EmailMaskedTextBox, "Формат: q@q.r");
                IsValidModel = false;
            }
            else if (_userController.IsExistEmail(model.Email))
            {
                CreateErrorProvider.SetError(EmailMaskedTextBox, "Пользователь с данной электронной почтой зарегистрирован");
                IsValidModel = false;
            }
           
            if (string.IsNullOrEmpty(model.Email))
            {
                CreateErrorProvider.SetError(EmailMaskedTextBox, "Обязательное поле");
                IsValidModel = false;
            }
            if (string.IsNullOrEmpty(model.LastName))
            {
                CreateErrorProvider.SetError(LastNameTextBox, "Обязательное поле");
                IsValidModel = false;
            }
            
            if (model.WorkPhone.Length != model.WorkPhone.Where(x => char.IsDigit(x)).Count())
            {
                CreateErrorProvider.SetError(WorkPhoneMaskedTextBox, "Должны присутствовать только цифры");
                IsValidModel = false;
            }
            if (model.BirthDate.Value > DateTime.Now.AddYears(-(DateTime.Now.Year - model.BirthDate.Value.Year)) ? DateTime.Now.Year - model.BirthDate.Value.Year - 1 < 16 : DateTime.Now.Year - model.BirthDate.Value.Year < 16)
            {

                CreateErrorProvider.SetError(BirthdayDateTimePicker, "Сотруднику должно исполниться 16 лет");
                IsValidModel = false;

            }
            return IsValidModel;
        }

        private bool CheckEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                var afterDog = mail.Host.Split('.');
                if (afterDog.Count() != 2)
                    return false;
                if (string.IsNullOrEmpty(afterDog.FirstOrDefault()))
                    return false;
                if (string.IsNullOrEmpty(afterDog.LastOrDefault()))
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void InitForm()
        {
            _listController.DropDownListClinics(ClinicComboBox);
            _listController.DropDownListPositions(PositionComboBox);
            _listController.DropDownListRoles(BidRoleComboBox);
            _listController.InitDropDownListEnum<SexPeople>(SexComboBox);
            //_listController.DropDownListDocType(DocTypeComboBox, true);
        }

        private void SnilsMaskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (((MaskedTextBox)sender).Text.Replace(" ","").Length == 2)
            {
                ((MaskedTextBox)sender).SelectionStart = 0;
            }
        }

        private void PhoneMaskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (((MaskedTextBox)sender).Text.Replace(" ", "").Length == 2)
            {
                ((MaskedTextBox)sender).SelectionStart = 0;
            }
        }

      

      

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendFormButton_Click(object sender, EventArgs e)
        {
            CreateErrorProvider.Clear();
            var model = new RegistrationModel(this);

            if (IsValidModel(model))
            {
                try
                {
                    var user = _userConfig.RegistrationModelToUser(model);
                    _userController.AddOrUpdateUser(user);
                    new Okey("Вы подали заявку, ожидайте сообщение на почте").ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    new Okey(ex.Message).ShowDialog();
                }

            }
        }

       

       
    }
}
