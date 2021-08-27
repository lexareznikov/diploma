using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.WinForms.Controllers;
using Demography.WinForms.MapperConfig;
using Demography.WinForms.Models;
using System;
using Demography.Domain.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demography.Infrastructure.Extensions;
using Demography.WinForms.Views.Shared;
using Demography.WinForms.Utility;
using Demography.Infrastructure.Utility;

namespace Demography.WinForms.Views.User
{
    public partial class UsersList : Form
    {
        #region GetSearchForm
        public int? RoleId { get { return (int?)RoleComboBox.SelectedValue; } }
        public int? StatusId { get { return (int?)StatusComboBox.SelectedValue; } }
        public string FirstName { get { return FirstNameTextBox.Text; } }
        public string LastName { get { return LastNameTextBox.Text; } }
        public string MiddleName { get { return MiddleNameTextBox.Text; } }
        #endregion
        #region Constants
        private const int ElementWidth = 175;
        private const int DateWidth = 215;
        private const int EmailWidth = 250;
        private const int FioWidth = 450;
        private const int PanelWidth = 1175;
        private const int PanelHeight = 105;
        private const int ButtonWidth = 45;
        private const int ButtonHeight = 45;
        private const int SmallElementHeight = 100;
        private const int SplitterHeight = 1;
        #endregion

        private ListController _listController;
        private UserController _userController;
        private int CurrentPage { get { return int.Parse(CurrentPageTextBox.Text); } }
        private int MaxCountPage;
        private List<Domain.Classes.User> Users;

        public UsersList()
        {
            InitializeComponent();
            _listController = new ListController();
            _userController = new UserController();
            InitForm();

            ButtonsWithProfileAndPermission();
        }
        public int ReturnButton { get; private set; }
        private void InitForm()
        {
            _listController.InitDropDownListEnum<UserRegStatus>(StatusComboBox, true);
            _listController.DropDownListRoles(RoleComboBox, true);
            FilterButton_Click(null, null);
        }
        private void ReloadList()
        {
            FilterButton_Click(null, null);
        }
        private int InitListUsers(int currentPage)
        {
            var elementOnForm = 25;
            UsersFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            UsersFlowLayoutPanel.AutoScroll = true;
            UsersFlowLayoutPanel.WrapContents = false;
            //6 пикселей на элемент
            UsersFlowLayoutPanel.Controls.Clear();
            if (Users.Count > 0)
            {
                var totalCountPage = Users.Count % elementOnForm == 0 ? Users.Count / elementOnForm : Users.Count / elementOnForm + 1;
                foreach (var item in Users.GetRange(elementOnForm * (currentPage - 1), (currentPage == totalCountPage && Users.Count % elementOnForm != 0) ? Users.Count % elementOnForm : elementOnForm))

                {
                    var pn = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.LeftToRight,
                        Size = new Size(PanelWidth, PanelHeight)
                    };
                    UsersFlowLayoutPanel.Controls.Add(pn);

                    var splitter = new Label
                    {
                        Size = new Size(PanelWidth, SplitterHeight),
                        BackColor = Color.Black
                    };

                    var Name = new Label
                    {
                        Size = new Size(FioWidth, SmallElementHeight),
                        Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic),
                        Text = item.Name
                    };
                    pn.Controls.Add(Name);


                    var login = new Label
                    {
                        Size = new Size(EmailWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = item.Email
                    };
                    pn.Controls.Add(login);


                    var status = new Label
                    {
                        Size = new Size(ElementWidth, SmallElementHeight),
                        //Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = ((UserRegStatus)item.StatusId).GetDisplayName()
                    };
                    pn.Controls.Add(status);


                    var lastLoginDate = new Label
                    {
                        Size = new Size(DateWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = (item.LastLoginDate == null ? "-" : item.LastLoginDate.Value.ToString("dd-MM-yyyy HH:mm:ss")) + "\r\n" + (item.LastExitDate == null ? "-" : item.LastExitDate.Value.ToString("dd-MM-yyyy HH:mm:ss"))
                    };
                    pn.Controls.Add(lastLoginDate);


                    var editButton = new Button
                    {
                        Size = new Size(ButtonWidth, ButtonHeight),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Name = item.Id.ToString(),
                        BackgroundImage = Properties.Resources.penEdit
                    };
                    editButton.Click += EditUserButton_Click;
                    pn.Controls.Add(editButton);
                    pn.Controls.Add(splitter);
                }
                CountLabel.Text = $"{(currentPage - 1) * elementOnForm + 1}-{(currentPage - 1) * elementOnForm + ((currentPage == totalCountPage && Users.Count % elementOnForm != 0) ? Users.Count % elementOnForm : elementOnForm)} из {Users.Count}";
                return totalCountPage;
            }
            else
            {
                CountLabel.Text = "0-0 из 0";
                return 1;
            }
        }
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var searchModel = new UserSearchViewModel(this);
            Users = _userController.GetListUsers(searchModel);
            CurrentPageTextBox.Text = "1";
            MaxCountPage = InitListUsers(CurrentPage);
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            BlockPageButtons();
            //ReloadList();
        }

        private void RemovePageButton_Click(object sender, EventArgs e)
        {
            CurrentPageInitNewsList(CurrentPage - 1);
        }

        private void AddPageButton_Click(object sender, EventArgs e)
        {
            CurrentPageInitNewsList(CurrentPage + 1);
        }
        private void CurrentPageInitNewsList(int pageNum)
        {

            MaxCountPage = InitListUsers(pageNum);
            CurrentPageTextBox.Text = pageNum.ToString();
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            BlockPageButtons();
        }
        private void BlockPageButtons()
        {
            if (CurrentPage <= 1)
            {
                RemovePageButton.Enabled = false;
            }
            else
            {
                RemovePageButton.Enabled = true;
            }
            if (CurrentPage >= MaxCountPage)
            {
                AddPageButton.Enabled = false;
            }
            else
            {
                AddPageButton.Enabled = true;
            }
            return;
        }
        private void CurrentPageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (number == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(CurrentPageTextBox.Text) || CurrentPageTextBox.Text == "0")
                {
                    CurrentPageTextBox.Text = "1";
                }
                if (MaxCountPage < int.Parse(CurrentPageTextBox.Text))
                {
                    CurrentPageTextBox.Text = MaxCountPage.ToString();
                }

                MaxCountPage = InitListUsers(CurrentPage);
                PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
                BlockPageButtons();
            }
        }
        private void EditUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var button = sender as Button;
            var form = new EditUser(int.Parse(button.Name));
            var result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.Show();
                ReloadList();
            }
            else if(result == DialogResult.Abort)
            {
                ReturnButton = form.ReturnButton;
                this.Close();
                this.DialogResult = DialogResult.Abort;
            }
            else if(result == DialogResult.OK)
            {
                
                this.Close();
                this.DialogResult = DialogResult.OK;
            }

        }

        private void ListUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AccountButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Profile;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }

        private void BlankButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Blanks;
            this.Close();
            this.DialogResult = DialogResult.Abort;
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
