using Demography.Infrastructure.Domain;
using System;
using Demography.WinForms.Views.Authorization;
using System.Windows.Forms;
using Demography.WinForms.Controllers;
using Demography.WinForms.Views.News;
using Demography.WinForms.Views.Shared;
using System.Linq;
using Demography.Infrastructure.Utility;
using System.Net.Mail;
using System.Net;
using Demography.WinForms.Models;
using Demography.WinForms.Views.User;
using System.Runtime.InteropServices;
using System.Windows.Threading;
using Demography.WinForms.Views.CertificateBirth;

namespace Demography.WinForms.Views.Authorization
{
    public partial class Authorization : Form
    {
       
        private string EmailText { get { return EmailTextBox.Text; } }
        private string PasswordText { get {return PasswordTextBox.Text; } } 
        private bool Checkrr { get { return PasswordCharCheckСheckBox.Checked;  }set { PasswordCharCheckСheckBox.Checked = value; } }
        private AuthorizationController _authorizationController;
       
        public Authorization()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true;
            _authorizationController = new AuthorizationController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {

            if (CheckEmail(EmailText))
            {
                try
                {
                    if (_authorizationController.IsSetPassword(EmailText, PasswordText))
                    {
                        new SetPassword(EmailText).ShowDialog();
                    }
                    else
                    {
                        if (_authorizationController.LogIn(EmailText, PasswordText))
                        {
                            if (CurrentUser.AccesAlowed)
                            {
                                Hide();
                                new News.News().ShowDialog();
                            }
                            else
                            {
                                new Okey("Доступ запрещен администратором!").ShowDialog();
                            }
                        }
                        else
                        {
                            new Okey("Неверная пара логин пароль").ShowDialog();
                        }
                    }
                }
                catch(Exception ex)
                {
                    new Okey("Неверная пара логин пароль").ShowDialog();
                }
            }
            else
            {
                new Okey("Электронная почта не по формату").ShowDialog();
            }
        }

        private void ButtonRegistation_Click(object sender, EventArgs e)
        {
            Hide();
            new Registration().ShowDialog();

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
        private void СheckBoxPasswordCharCheck_CheckedChanged(object sender, EventArgs e)
        {

            var CheckBoxPasswordCharCheck = (CheckBox)sender;
            if (CheckBoxPasswordCharCheck.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

       

    }
}
