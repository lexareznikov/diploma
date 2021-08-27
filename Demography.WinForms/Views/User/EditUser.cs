using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Extensions;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Controllers;
using Demography.WinForms.MapperConfig;
using Demography.WinForms.Models;
using Demography.WinForms.Utility;
using Demography.WinForms.Views.Shared;
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
    public partial class EditUser : Form
    {
        #region GetValueFromForm
        public string FirstName { get { return FirstNameTextBox.Text; } set { FirstNameTextBox.Text = value; } }
        public string LastName { get { return LastNameTextBox.Text; } set { LastNameTextBox.Text = value; } }
        public string MiddleName { get { return MiddleNameTextBox.Text; } set { MiddleNameTextBox.Text = value; } }
        // public string INN { get { return InnTextBox.Text; } set { InnTextBox.Text = value; } }
        public string Email { get { return EmailTextBox.Text; } set { EmailTextBox.Text = value; } }
        //public string BirthPlace { get { return BirthPlaceTextBox.Text; } set { BirthPlaceTextBox.Text = value; } }
        public string Phone { get { return PhoneTextBox.Text; } set { PhoneTextBox.Text = value; } }
        public string WorkPhone { get { return WorkPhoneTextBox.Text; } set { WorkPhoneTextBox.Text = value; } }
        public string Comment { get { return CommentRichTextBox.Text; } set { CommentRichTextBox.Text = value; } }
        //public string Snils { get { return SnilsMaskedTextBox.Text.Replace("-", "").Replace(" ", ""); } set { SnilsMaskedTextBox.Text = value; } }
        public DateTime? BirthDate { get { return BirthdayDateTimePicker.Value; } set { BirthdayDateTimePicker.NullableValue(value); } }
        public int? BidRoleId { get { return (int?)BidRoleComboBox.SelectedValue; } set { BidRoleComboBox.SelectedValue = value; } }
        public int? SexId { get { return (int?)SexComboBox.SelectedValue; } set { SexComboBox.SelectedValue = value; } }

        public int? StatusId { get { return (int?)StatusComboBox.SelectedValue; } set { StatusComboBox.SelectedValue = value; } }
        //public int? DocTypeId { get { return (int?)DocTypeComboBox.SelectedValue; } set { if (value.HasValue) { DocTypeComboBox.SelectedValue = value; } else { DocTypeComboBox.SelectedIndex = 0; } } }
        //public string DocSeries { get { return DocSeriesTextBox.Text; } set { DocSeriesTextBox.Text = value; } }
        //public string DocNumber { get { return DocNumberTextBox.Text; } set { DocNumberTextBox.Text = value; } }
        //public DateTime? DocDateOn { get { return DocDateOnDateTimePicker.NullableValue(); } set { DocDateOnDateTimePicker.NullableValue(value); } }
        //public DateTime? DocDateWith { get { return DocDateWithDateTimePicker.NullableValue(); } set { DocDateWithDateTimePicker.NullableValue(value); } }
        //public string DocOrgName { get { return DocOrgNameTextBox.Text; } set { DocOrgNameTextBox.Text = value; } }
        public int UserId { get { return int.Parse(IdUser.Text); } set { IdUser.Text = value.ToString(); } }

        public int? DocId { get; set; }

        #endregion
        private UserController _userController;
        private UserConfig _userConfig;
        private ListController _listController;
        public EditUser(int id)
        {
            InitializeComponent();
            UserId = id;
            _userController = new UserController();
            _userConfig = new UserConfig();
            _listController = new ListController();
            InitForm(id);
            ButtonsWithProfileAndPermission();
        }
        public int ReturnButton { get; private set; }
        private void FillForm(UserEditViewModel model)
        {
            FirstName = model.FirstName;
            LastName = model.LastName;
            MiddleName = model.MiddleName;
            Email = model.Email;
            Phone = model.Phone;
            WorkPhone = model.WorkPhone;
            Comment = model.Comment;
            BirthDate = model.BirthDate;
            BidRoleId = model.BidRoleId;
            SexId = model.SexId;
            DocId = model.DocId;

            StatusId = model.StatusId;

        }
        private void InitForm(int id)
        {

            var user = _userController.GetById(id).FirstOrDefault();
            _userController.Reload(user);
            _listController.InitDropDownListEnum<SexPeople>(SexComboBox);
            _listController.InitDropDownListEnum<RoleApp>(BidRoleComboBox);

            _listController.InitDropDownListEnum<UserRegStatus>(StatusComboBox);

            RefreshPositionGrid();
            RefreshRoleGrid();
            ToolTip t = new ToolTip();
            t.SetToolTip(DeniedAccessButton, "Нажатие данной кнопки не даст пользователю войти в следующий раз, но текущую сессию не прервет");
            if (user.StatusId == (int)UserRegStatus.AccessAllowed)
            {
                DeniedAccessButton.Show();
                AllowAccessButton.Hide();
            }
            else if (user.StatusId == (int)UserRegStatus.AccessDenied)
            {

                DeniedAccessButton.Hide();
                AllowAccessButton.Show();
            }
            else if (user.StatusId == (int)UserRegStatus.OnReview)
            {

                DeniedAccessButton.Hide();
                AllowAccessButton.Show();
            }
            FillForm(_userConfig.UserToUserEditViewModel(user));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Yes;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            UserEditErrorProvider.Clear();
            var model = new UserEditViewModel(this);

            var user = _userController.GetById(UserId).FirstOrDefault();

            _userController.Reload(user);
            user = _userConfig.UserEditViewModelToUser(user, model);
            _userController.AddOrUpdateUser(user);
            if (user.Id == CurrentUser.Id)
            {
                _userController.RefillCurrentUser(user);
            }
            this.Close();
            DialogResult = DialogResult.Yes;

        }

        private void EditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void AddPostButton_Click(object sender, EventArgs e)
        {
            new AddPosition(UserId).ShowDialog();
            RefreshPositionGrid();
        }

        private void AddRoleButton_Click(object sender, EventArgs e)
        {
            new AddRole(UserId).ShowDialog();
            RefreshRoleGrid();
        }
        private void RefreshPositionGrid()
        {
            PostDataGridView.Rows.Clear();
            if (PostDataGridView.Columns.Count == 4)
            {
                PostDataGridView.Columns.Remove(PostDataGridView.Columns[2]);
            }
            var user = _userController.GetById(UserId).FirstOrDefault();
            _userController.Reload(user);
            PostDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn
            {
                Image = new Bitmap(Properties.Resources.trashcan.ToBitmap(), 45, 45)
            };
            foreach (var item in user.UserClinics)
            {
                PostDataGridView.Rows.Add(item.Clinic.ShortName, item.Position.Name, item.Id);
            }
            PostDataGridView.Columns.Insert(2, iconColumn);
        }

        private void RefreshRoleGrid()
        {
            RolesDataGridView.Rows.Clear();
            if (RolesDataGridView.Columns.Count == 3)
            {
                RolesDataGridView.Columns.Remove(RolesDataGridView.Columns[1]);
            }
            var user = _userController.GetById(UserId).FirstOrDefault();
            _userController.Reload(user);
            RolesDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn
            {
                Image = new Bitmap(Properties.Resources.trashcan.ToBitmap(), 45, 45)
            };
            foreach (var item in user.UserRoles)
            {
                RolesDataGridView.Rows.Add(item.Role.Name, item.Id);
            }
            RolesDataGridView.Columns.Insert(1, iconColumn);

        }

        private void PostDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = PostDataGridView.Rows[e.RowIndex];
                var id = row.Cells[3].Value;
                if (e.ColumnIndex == 2)
                {
                    var result = new YesNot("Точно хотите удалить должность?").ShowDialog();
                    if (result == DialogResult.Yes)
                    {

                        var user = _userController.GetById(UserId).FirstOrDefault();
                        _userController.Reload(user);
                        if (user.UserClinics.Count == 1)
                        {
                            new Okey("Нельзя удалить единственную должность (у каждого пользователя должна быть должность)").ShowDialog();
                        }
                        else
                        {
                            _userController.DeletePosition((int)id);
                            RefreshPositionGrid();
                        }
                    }
                }
            }
        }

        private void RolesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = RolesDataGridView.Rows[e.RowIndex];
                var id = row.Cells[2].Value;
                if (e.ColumnIndex == 1)
                {
                    var result = new YesNot("Точно хотите удалить роль?").ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        var user = _userController.GetById(UserId).FirstOrDefault();
                        _userController.Reload(user);
                        if (user.UserRoles.Count == 1)
                        {
                            new Okey("Нельзя удалить единственную роль (у каждого пользователя должна быть роль)").ShowDialog();
                        }
                        else
                        {
                            _userController.DeleteRole((int)id);
                            RefreshRoleGrid();
                        }
                    }
                }
            }
        }

        private void DeniedAccessButton_Click(object sender, EventArgs e)
        {
            if (new Shared.YesNot("Вы уверены, что хотите запретить доступ к системе данному пользователю? Это не прервет его текующую сессию, но не даст в следующий раз войти").ShowDialog() == DialogResult.Yes)
            {
                if (_userController.DeniedAccess(UserId))
                {
                    InitForm(UserId);
                    new Shared.Okey("Доступ запрещен данному пользователю!").ShowDialog();
                }
                else
                {
                    new Shared.Okey("Произошла ошибка").ShowDialog();
                }
            }
        }

        private void AllowAccessButton_Click(object sender, EventArgs e)
        {
            if (_userController.AllowAccess(UserId))
            {
                InitForm(UserId);
                new Shared.Okey("Доступ разрешен данному пользователю!").ShowDialog();
            }
            else
            {
                new Shared.Okey("Произошла ошибка").ShowDialog();
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Profile;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void BlankButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Blanks;
            this.Close();
            this.DialogResult = DialogResult.Abort;
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

        private void CertificatesButton_Click(object sender, EventArgs e)
        {
            var form = new ButtonList("Свидетельства", (int)SwitchButtonsType.CertificatesList);
            var result = form.ShowDialog();
            if (result == DialogResult.Abort)
            {
                ReturnButton = form.ReturnButton;
                this.Close();
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Reports;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }
    }
}
