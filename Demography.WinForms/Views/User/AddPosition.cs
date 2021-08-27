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
    public partial class AddPosition : Form
    {
        #region GetBalueFromForm
        public int ClinicId { get { return (int)ClinicComboBox.SelectedValue; } }
        public string Position { get { return PositionComboBox.SelectedValue.ToString(); } }
        #endregion
        private int UserId;
        private ListController _listController;
        private UserController _userController;
        public AddPosition(int userId)
        {
            InitializeComponent();
            _listController = new ListController();
            _userController = new UserController();
            InitForm();
            UserId = userId;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_userController.AddPosition(UserId, new Models.UserClinicViewModel(this)))
            { this.Close(); }
            else
            {
                new Shared.Okey("У данного пользователя есть указанная должность в медицинской организации").ShowDialog();
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitForm()
        {
            _listController.DropDownListPositions(PositionComboBox);
            _listController.DropDownListClinics(ClinicComboBox);
        }
    }
}
