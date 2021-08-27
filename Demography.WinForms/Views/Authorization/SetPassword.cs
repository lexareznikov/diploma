using Demography.WinForms.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demography.WinForms.Views.Authorization
{
    public partial class SetPassword : Form
    {
        private string FirstPassword { get { return FirstPasswordlTextBox.Text; }  }
        private string SecondPassword { get { return SecondPasswordTextBox.Text; } }
        private string Email { get { return EmailLabel.Text; }set { EmailLabel.Text = value; } }
        private UserController _userController;
        public SetPassword(string email)
        {
            InitializeComponent();
            _userController = new UserController();
            Email = email;
        }

        private void RegistationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            PasswordErrorProvider.Clear();
            if(FirstPassword != SecondPassword)
            {
                PasswordErrorProvider.SetError(SecondPasswordTextBox, "Пароли не совпадают");
            }
            else
            {
                _userController.SetPassword(Email, FirstPassword);
                this.Close();
            }
            
        }
    }
}
