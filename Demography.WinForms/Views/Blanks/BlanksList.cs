using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Extensions;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Controllers;
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

namespace Demography.WinForms.Views.Blanks
{
    public partial class BlanksList : Form
    {
        #region Constants
        private const int ElementWidth = 200;

        private const int StatusWidth = 150;
        private const int DateWidth = 145;
        private const int FioWidth = 250;
        private const int PanelWidth = 1175;
        private const int PanelHeight = 105;
        private const int ButtonWidth = 45;
        private const int ButtonHeight = 45;
        private const int SmallElementHeight = 100;
        private const int SplitterHeight = 1;
        #endregion
        private int CurrentPage { get { return int.Parse(CurrentPageTextBox.Text); } }
        private int MaxCountPage;
        public DateTime? DateOn { get { return CreateDateOnDateTimePicker.NullableValue(); } set { CreateDateOnDateTimePicker.NullableValue(value); } }
        public DateTime? DateWith { get { return CreateDateWithDateTimePicker.NullableValue(); } set { CreateDateWithDateTimePicker.NullableValue(value); } }
        private List<Domain.Classes.BlankIncome> Blanks { get; set; } 
        private BlankController _blankController { get; set; }
        public BlanksList()
        {
            InitializeComponent();
            _blankController = new BlankController();
            ReloadList();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var searchModel = new BlankSearchViewModel(this);
            Blanks = _blankController.GetListIncomes(searchModel).ToList() ;
            CurrentPageTextBox.Text = "1";
            MaxCountPage = InitCertificatesList(CurrentPage);
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            BlockPageButtons();
            if(!CurrentUser.HasRoles(RoleApp.Medstatistic,false))
            {
                AddIncomeButton.Visible = false;
            }
           

        }
        private void ReloadList()
        {
            FilterButton_Click(null, null);

            ButtonsWithProfileAndPermission();
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
        private int InitCertificatesList(int currentPage)
        {
            var elementOnForm = 25;
            BlanksFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            BlanksFlowLayoutPanel.AutoScroll = true;
            BlanksFlowLayoutPanel.WrapContents = false;
            //6 пикселей на элемент
            BlanksFlowLayoutPanel.Controls.Clear();
            if (Blanks.Count > 0)
            {
                var totalCountPage = Blanks.Count % elementOnForm == 0 ? Blanks.Count / elementOnForm : Blanks.Count / elementOnForm + 1;
                foreach (var item in Blanks.GetRange(elementOnForm * (currentPage - 1), (currentPage == totalCountPage && Blanks.Count % elementOnForm != 0) ? Blanks.Count % elementOnForm : elementOnForm))

                {
                    var pn = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.LeftToRight,
                        Size = new Size(PanelWidth, PanelHeight)
                    };
                    BlanksFlowLayoutPanel.Controls.Add(pn);

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
                        Text = item.NumberFirst
                    };
                    pn.Controls.Add(number);
                    var createdDate = new Label
                    {
                        Size = new Size(ElementWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = (item.CreateDate == null ? "-" : item.CreateDate.ToString("dd-MM-yyyy"))
                    };
                    pn.Controls.Add(createdDate);
                    
                    var count = new Label
                    {
                        Size = new Size(ElementWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = item.Count.ToString()
                    };
                    pn.Controls.Add(count);
                    var fio = new Label
                    {
                        Size = new Size(FioWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = item.User?.NameShort
                    };
                    pn.Controls.Add(fio);
                    
                 
                    pn.Controls.Add(splitter);
                }
                CountLabel.Text = $"{(currentPage - 1) * elementOnForm + 1}-{(currentPage - 1) * elementOnForm + ((currentPage == totalCountPage && Blanks.Count % elementOnForm != 0) ? Blanks.Count % elementOnForm : elementOnForm)} из {Blanks.Count}";
                return totalCountPage;
            }
            else
            {
                CountLabel.Text = "0-0 из 0";
                return 1;
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

        private void UsedListButton_Click(object sender, EventArgs e)
        {
            new ExpenseBlanks().ShowDialog();
        }

        private void AddIncomeButton_Click(object sender, EventArgs e)
        {
            new AddBlank().ShowDialog();
            ReloadList();
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void BlankButton_Click(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Profile;
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
