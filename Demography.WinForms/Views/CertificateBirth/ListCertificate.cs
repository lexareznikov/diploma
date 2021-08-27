using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Extensions;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Controllers;
using Demography.WinForms.Models;
using Demography.WinForms.Utility;
using Demography.WinForms.Views.People;
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

namespace Demography.WinForms.Views.CertificateBirth
{
    public partial class ListCertificate : Form
    {
        #region ValueFromForm
        public DateTime? CreateDateOn { get { return CreateDateOnDateTimePicker.NullableValue(); } set { CreateDateOnDateTimePicker.NullableValue(value); } }
        public DateTime? CreateDateWith { get { return CreateDateWithDateTimePicker.NullableValue(); } set { CreateDateWithDateTimePicker.NullableValue(value); } }
        public DateTime? IssueDateOn { get { return IssueOnDateTimePicker.NullableValue(); } set { IssueOnDateTimePicker.NullableValue(value); } }
        public DateTime? IssueDateWith { get { return IssueWithDateTimePicker.NullableValue(); } set { IssueWithDateTimePicker.NullableValue(value); } }
        public int? StatusId { get { return (int?)StatusComboBox.SelectedValue; } }
        public string FirstName { get { return FirstNameTextBox.Text; } }
        public string Number { get { return NumberTextBox.Text; } }
        public string LastName { get { return LastNameTextBox.Text; } }
        public string MiddleName { get { return MiddleNameTextBox.Text; } }
        #endregion
        #region Constants
        private const int ElementWidth = 100;

        private const int StatusWidth = 150;
        private const int DateWidth = 145;
        private const int FioWidth =400;
        private const int PanelWidth = 1175;
        private const int PanelHeight = 105;
        private const int ButtonWidth = 45;
        private const int ButtonHeight = 45;
        private const int SmallElementHeight = 100;
        private const int SplitterHeight = 1;
        #endregion
        private ListController _listController;
        private CertificateBirthController _CertificateBirthController;
        private int CertificatesStatus { get; set; }
        private int CurrentPage { get { return int.Parse(CurrentPageTextBox.Text); } }
        private int MaxCountPage;
        private List<Domain.Classes.CertificateBirth> Certificates;
        public ListCertificate(int certificateStatus)
        {
            InitializeComponent();
            CertificatesStatus = certificateStatus;
            _CertificateBirthController = new CertificateBirthController();
            _listController = new ListController();
            InitForm();
            HideButton();
            ButtonsWithProfileAndPermission();
        }
        private void InitForm()
        {
            _listController.InitDropDownListEnum<CertificateStatus>(StatusComboBox, true);
            FilterButton_Click(null, null);
        }

       

        private void ListCertificate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

       

        private void RemovePageButton_Click(object sender, EventArgs e)
        {
            CurrentPageInitNewsList(CurrentPage - 1);
        }

        private void AddPageButton_Click(object sender, EventArgs e)
        {
            CurrentPageInitNewsList(CurrentPage + 1);
        }
        private void ReloadList()
        {
            FilterButton_Click(null, null);

           
        }
       
        private int InitCertificatesList(int currentPage)
        {
            var elementOnForm = 25;
            CertificatesFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            CertificatesFlowLayoutPanel.AutoScroll = true;
            CertificatesFlowLayoutPanel.WrapContents = false;
            //6 пикселей на элемент
            CertificatesFlowLayoutPanel.Controls.Clear();
            if (Certificates.Count > 0)
            {
                var totalCountPage = Certificates.Count % elementOnForm == 0 ? Certificates.Count / elementOnForm : Certificates.Count / elementOnForm + 1;
                foreach (var item in Certificates.GetRange(elementOnForm * (currentPage - 1), (currentPage == totalCountPage && Certificates.Count % elementOnForm != 0) ? Certificates.Count % elementOnForm : elementOnForm))

                {
                    var pn = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.LeftToRight,
                        Size = new Size(PanelWidth, PanelHeight)
                    };
                    CertificatesFlowLayoutPanel.Controls.Add(pn);

                    var splitter = new Label
                    {
                        Size = new Size(PanelWidth, SplitterHeight),
                        BackColor = Color.Black
                    };

                    var series = new Label
                    {
                        Size = new Size(ElementWidth, SmallElementHeight),
                        Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic),
                        Text = item.Series
                    };
                    pn.Controls.Add(series);


                    var number = new Label
                    {
                        Size = new Size(ElementWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = item.Number
                    };
                    pn.Controls.Add(number);
                    var createdDate = new Label
                    {
                        Size = new Size(DateWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = (item.CreatedDate == null ? "-" : item.CreatedDate.ToString("dd-MM-yyyy"))
                    };
                    pn.Controls.Add(createdDate);
                    var issuanceDate = new Label
                    {
                        Size = new Size(DateWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = (item.IssuanceDate == DateTime.MinValue ? "-" : item.IssuanceDate.ToString("dd-MM-yyyy"))
                    };
                    pn.Controls.Add(issuanceDate);
                    var  fio= new Label
                    {
                        Size = new Size(FioWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = (item.MotherLastName + " " + item.MotherFirstname + " " + item.MotherMiddlename)
                    };
                    pn.Controls.Add(fio);
                    var status = new Label
                    {
                        Size = new Size(StatusWidth, SmallElementHeight),
                        //Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = ((CertificateStatus)item.StatusId).GetDisplayName()
                    };
                    pn.Controls.Add(status);


                  


                    var editButton = new Button
                    {
                        Size = new Size(ButtonWidth, ButtonHeight),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Name = item.Id.ToString(),
                        BackgroundImage = Properties.Resources.penEdit
                    };
                    editButton.Click += EditCertificateButton_Click;
                    pn.Controls.Add(editButton);
                    pn.Controls.Add(splitter);
                }
                CountLabel.Text = $"{(currentPage - 1) * elementOnForm + 1}-{(currentPage - 1) * elementOnForm + ((currentPage == totalCountPage && Certificates.Count % elementOnForm != 0) ? Certificates.Count % elementOnForm : elementOnForm)} из {Certificates.Count}";
                return totalCountPage;
            }
            else
            {
                CountLabel.Text = "0-0 из 0";
                return 1;
            }
        }
        private void EditCertificateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var button = sender as Button;
            var result = new EditCertificate(int.Parse(button.Name)).ShowDialog();

            this.Show();
            ReloadList();


        }
        private void CurrentPageInitNewsList(int pageNum)
        {

            MaxCountPage = InitCertificatesList(pageNum);
            CurrentPageTextBox.Text = pageNum.ToString();
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            BlockPageButtons();
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

                MaxCountPage = InitCertificatesList(CurrentPage);
                PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
                BlockPageButtons();
            }
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
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var searchModel = new CertificatesSearchViewModel(this);
            Certificates = _CertificateBirthController.GetListCertificate(searchModel , CertificatesStatus);
            CurrentPageTextBox.Text = "1";
            MaxCountPage = InitCertificatesList(CurrentPage);
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            BlockPageButtons();
           // ReloadList();
        }

        private void AddCertificateButton_Click(object sender, EventArgs e)
        {
            var form = new ListPeople();
            var result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                new EditCertificate(form.ReturnPeopleId, true).ShowDialog();
                this.Show();
                ReloadList();
            }
        }
        private void HideButton()
        {
            if (!CurrentUser.HasPermission(false, PermissionsApp.CerBirthCreate))
            {
                AddCertificateButton.Hide();
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

        
        public int ReturnButton { get; private set; }
        private void CertificatesButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.DialogResult = DialogResult.Abort;
            //returnValue = 1;
            var form = new ButtonList("Свидетельства", (int)SwitchButtonsType.CertificatesList);
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
        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Reports;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
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
            this.DialogResult = DialogResult.OK;
        }

        private void BlankButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Blanks;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }
    }
}
