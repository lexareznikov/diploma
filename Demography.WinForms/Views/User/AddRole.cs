using Demography.Infrastructure.Enums;
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

namespace Demography.WinForms.Views.User
{
    public partial class AddRole : Form
    {
        private int RoleId { get { return (int)RoleComboBox.SelectedValue; }  }
        private int UserId;
        private ListController _listController;
        private UserController _userController;
        public AddRole(int userId)
        {
            InitializeComponent();
            _listController = new ListController();
            _userController = new UserController();
            UserId = userId;
            InitForm();
        }
        private void InitForm ()
        {
            _listController.DropDownListRoles(RoleComboBox);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_userController.AddRole(UserId,RoleId))
            {
                this.Close();
            }
            else
            {
                new Shared.Okey("У данного пользователя есть указанная роль").ShowDialog();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
