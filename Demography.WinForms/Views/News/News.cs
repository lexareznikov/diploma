using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Controllers;
using System;
using Demography.WinForms.Views.Account;
using Demography.WinForms.Views.Authorization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demography.WinForms.Views.Shared;
using Demography.WinForms.Views.CertificateBirth;
using Demography.WinForms.Utility;
using Demography.WinForms.Views.User;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using Demography.WinForms.Views.Blanks;

namespace Demography.WinForms.Views.News
{
    public partial class News : Form
    {
        #region Constants
        private const int ElementWidth = 1099;
        private const int DateWidth = 150;
        private const int PanelWidth = 1175;
        private const int PanelHeight = 230;
        private const int ButtonWidth = 45;
        private const int ButtonHeight = 45;
        private const int SmallElementHeight = 30;
        private const int RichTextHeight = 120;
        #endregion
        private NewsController _newsCotroller;
        private UserController _userController;
        private int MaxCountPage;
        private DispatcherTimer _timer;
        private int CurrentPage { get { return int.Parse(CurrentPageTextBox.Text); } }
        public News()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            _newsCotroller = new NewsController();
            _userController = new UserController();
            HideAllButtons();
            MaxCountPage = InitNewsList(NewsFlowLayoutPanel, CurrentPage);
            BlockPageButtons();
            ButtonsWithProfileAndPermission();
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 3);
            _timer.Tick += IdleTick;
            _timer.Start();
        }

        private void HideAllButtons()
        {
            ButtonFlowLayoutPanel.Controls.OfType<Button>().ToList().ForEach(x => x.Hide());
        }

        private void News_FormClosing(object sender, FormClosingEventArgs e)
        {
            _userController.SaveExitDate(CurrentUser.Id);
            Application.OpenForms["Authorization"].Show();
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

                MaxCountPage = InitNewsList(NewsFlowLayoutPanel, CurrentPage);
                BlockPageButtons();
                ButtonsWithProfileAndPermission();
            }
        }
        private void HideButtonsList()
        {
            var panels = NewsFlowLayoutPanel.Controls.OfType<FlowLayoutPanel>().ToList();
            var buttons = new List<Button>();
            foreach (var item in panels)
            {
                buttons.AddRange(item.Controls.OfType<Button>().ToList());

            }
            buttons.ForEach(x => x.Hide());
            AddNewsButton.Hide();
        }
        private void ShowButtonsForAdmin()
        {
            AddNewsButton.Show();
        }
        private void ButtonsWithProfileAndPermission()
        {
            ButtonsWithPermission();
            if (CurrentUser.HasRoles(RoleApp.Admin))
            {
                //AddEventsButtonList();
                ShowButtonsForAdmin();
            }
            else
            {
                HideButtonsList();
            }
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
        private void ReloadList()
        {

            CurrentPageInitNewsList(1);
            ButtonsWithProfileAndPermission();
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
        private void CurrentPageInitNewsList(int pageNum)
        {

            MaxCountPage = InitNewsList(NewsFlowLayoutPanel, pageNum);
            CurrentPageTextBox.Text = pageNum.ToString();
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            BlockPageButtons();
            ButtonsWithProfileAndPermission();
        }
        public int InitNewsList(FlowLayoutPanel flowLayoutPanel, int currentPage)
        {
            var elementOnForm = 10;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.WrapContents = false;
            //6 пикселей на элемент
            flowLayoutPanel.Controls.Clear();
            var newses = _newsCotroller.GetNews();
            var totalCountPage = newses.Count % elementOnForm == 0 ? newses.Count / elementOnForm : newses.Count / elementOnForm + 1;
            foreach (var item in newses.GetRange(elementOnForm * (currentPage - 1), (currentPage == totalCountPage && newses.Count % elementOnForm != 0) ? newses.Count % elementOnForm : elementOnForm))

            {
                var pn = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    Size = new Size(PanelWidth, PanelHeight)
                };
                flowLayoutPanel.Controls.Add(pn);


                var newShortTextBox = new Label
                {
                    Size = new Size(ElementWidth, SmallElementHeight),
                    Font = new Font("Microsoft Sans Serif", 18, FontStyle.Italic),
                    Text = item.NewsShort
                };
                pn.Controls.Add(newShortTextBox);

                var newsDate = new Label
                {
                    Size = new Size(DateWidth, SmallElementHeight),
                    Anchor = AnchorStyles.Right,
                    Font = new Font("Microsoft Sans Serif", 16),
                    Text = item.Date.ToString("yyyy/MM/dd")
                };
                pn.Controls.Add(newsDate);

                var editButton = new Button
                {
                    Size = new Size(ButtonWidth, ButtonHeight),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Name = item.Id.ToString(),
                    BackgroundImage = Properties.Resources.penEdit

                };
                editButton.Click += new EventHandler(EditNewsButton_Click);
                pn.Controls.Add(editButton);
                var deleteButton = new Button
                {
                    Size = new Size(ButtonWidth, ButtonHeight),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Name = item.Id.ToString(),
                    BackgroundImage = Properties.Resources.trashcan.ToBitmap()
                };

                deleteButton.Click += new EventHandler(DeleteNewsButton_Click);
                pn.Controls.Add(deleteButton);

                var newsFull = new RichTextBox
                {
                    Size = new Size(PanelWidth, RichTextHeight),
                    ReadOnly = true,
                    ScrollBars = RichTextBoxScrollBars.Vertical,
                    //Anchor = AnchorStyles.Right,
                    Font = new Font("Microsoft Sans Serif", 16),
                    Text = item.NewsFull
                };
                pn.Controls.Add(newsFull);
            }
            return totalCountPage;

        }
        private void CertificatesButton_Click(object sender, EventArgs e)
        {
            //new ButtonList("Свидетельства", (int)SwitchButtonsType.CertificatesList).ShowDialog();
            var form = new ButtonList("Свидетельства", (int)SwitchButtonsType.CertificatesList);
            var result = form.ShowDialog();
            if (result == DialogResult.Abort)
            {
                switch (form.ReturnButton)
                {
                    case (int)SwitchButtonsType.CertificatesList:
                        ListCertificateButton_Click(null, null);
                        break;
                    case (int)SwitchButtonsType.CertificatesRemarks:
                        ListCertificateRemarksButton_Click(null, null);
                        break;
                }
            }
        }
        private void RemovePageButton_Click(object sender, EventArgs e)
        {
            CurrentPageInitNewsList(CurrentPage - 1);
        }
        private void AddPageButton_Click(object sender, EventArgs e)
        {
            CurrentPageInitNewsList(CurrentPage + 1);
        }
        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            var form = new ButtonList("Справочники", (int)SwitchButtonsType.Directories);
            var result = form.ShowDialog();
            if (result == DialogResult.Abort)
            {
                switch (form.ReturnButton)
                {
                    case (int)SwitchButtonsType.MO:
                        MoButton_Click(null, null);
                        break;
                    case (int)SwitchButtonsType.Users:
                        ListUsersButton_Click(null, null);
                        break;
                   
                }
            }
        }
        private void DeleteNewsButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var result = new YesNot("Точно хотите удалить новость?").ShowDialog();
            if (result == DialogResult.Yes)
            {
                if (!_newsCotroller.DeleteNews(int.Parse(button.Name)))
                { new Okey("Не получилось удалить").ShowDialog(); }
                ReloadList();
            }

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void EditNewsButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var result = new AddNews(int.Parse(button.Name)).ShowDialog();
            if (result == DialogResult.OK)
                ReloadList();

        }
        private void AddNewsButton_Click(object sender, EventArgs e)
        {
            new AddNews().ShowDialog();
            ReloadList();
        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new Account.Account())
            {
                form.Owner = this;
                var result = form.ShowDialog();
                ButtonsWithProfileAndPermission();
                if (result == DialogResult.OK)
                {
                    this.Show();
                    var t = form.ReturnButton;
                    ReloadList();
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    switch (form.ReturnButton)
                    {
                        case (int)SwitchButtonsType.CertificatesList:
                            ListCertificateButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.CertificatesRemarks:
                            ListCertificateRemarksButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.MO:
                            MoButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Users:
                            ListUsersButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Blanks:
                            BlankButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Reports:
                            ReportButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Profile:
                            AccountButton_Click(null, null);
                            break;
                    }
                }

               
            }

        }
        private void MainButton_Click(object sender, EventArgs e)
        {
            ReloadList();
        }
        private void ListUsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new UsersList())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                    //  var t = form.ReturnButton;
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    switch (form.ReturnButton)
                    {
                        case (int)SwitchButtonsType.CertificatesList:
                            ListCertificateButton_Click(null, null);
                            break;
                      
                        case (int)SwitchButtonsType.CertificatesRemarks:
                            ListCertificateRemarksButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.MO:
                            MoButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Users:
                            ListUsersButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Blanks:
                            BlankButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Reports:
                            ReportButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Profile:
                            AccountButton_Click(null, null);
                            break;
                    }
                }
            }
        }
        private void MoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new Clinic())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                    //  var t = form.ReturnButton;
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    switch (form.ReturnButton)
                    {
                        case (int)SwitchButtonsType.CertificatesList:
                            ListCertificateButton_Click(null, null);
                            break;
                       
                        case (int)SwitchButtonsType.CertificatesRemarks:
                            ListCertificateRemarksButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.MO:
                            MoButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Users:
                            ListUsersButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Blanks:
                            BlankButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Reports:
                            ReportButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Profile:
                            AccountButton_Click(null, null);
                            break;
                    }
                }
            }
        }
        private void ListCertificateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new ListCertificate((int)ListCertificateType.All))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                    //  var t = form.ReturnButton;
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    switch (form.ReturnButton)
                    {
                        case (int)SwitchButtonsType.CertificatesList:
                            ListCertificateButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.CertificatesRemarks:
                            ListCertificateRemarksButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.MO:
                            MoButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Users:
                            ListUsersButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Blanks:
                            BlankButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Reports:
                            ReportButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Profile:
                            AccountButton_Click(null, null);
                            break;
                    }
                }
            }
        }
        private void ListCertificateRemarksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new ListCertificate((int)ListCertificateType.Remark))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                    //  var t = form.ReturnButton;
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    switch (form.ReturnButton)
                    {
                        case (int)SwitchButtonsType.CertificatesList:
                            ListCertificateButton_Click(null, null);
                            break;
                      
                        case (int)SwitchButtonsType.CertificatesRemarks:
                            ListCertificateRemarksButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.MO:
                            MoButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Users:
                            ListUsersButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Blanks:
                            BlankButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Reports:
                            ReportButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Profile:
                            AccountButton_Click(null, null);
                            break;
                    }
                }
            }
        }
        private void IdleTick(object sender, EventArgs e)
        {
            var idle = GetIdle();
            if (idle.Minutes >= 5)
            {

                var count = 0;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.GetType() != typeof(Authorization.Authorization) && f.GetType() != typeof(News))
                    {
                        count++;
                        f.Close();
                    }
                }
                if(count==0)
                {
                    this.Close();
                }

            }
        }

        TimeSpan GetIdle()
        {
            var lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);

            GetLastInputInfo(ref lastInputInfo);

            var lastInput = DateTime.Now.AddMilliseconds(
                -(Environment.TickCount - lastInputInfo.dwTime));
            return DateTime.Now - lastInput;
        }

        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [StructLayout(LayoutKind.Sequential)]
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        private void BlankButton_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            using (var form = new BlanksList())
            {
                form.Owner = this;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                    var t = form.ReturnButton;
                    ReloadList();
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    switch (form.ReturnButton)
                    {
                        case (int)SwitchButtonsType.CertificatesList:
                            ListCertificateButton_Click(null, null);
                            break;
                      
                        case (int)SwitchButtonsType.CertificatesRemarks:
                            ListCertificateRemarksButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.MO:
                            MoButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Users:
                            ListUsersButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Blanks:
                            BlankButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Reports:
                            ReportButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Profile:
                            AccountButton_Click(null, null);
                            break;
                    }
                }
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new Report.ReportView())
            {
                form.Owner = this;
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Show();
                    var t = form.ReturnButton;
                    ReloadList();
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    switch (form.ReturnButton)
                    {
                        case (int)SwitchButtonsType.CertificatesList:
                            ListCertificateButton_Click(null, null);
                            break;

                        case (int)SwitchButtonsType.CertificatesRemarks:
                            ListCertificateRemarksButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.MO:
                            MoButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Users:
                            ListUsersButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Blanks:
                            BlankButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Reports:
                            ReportButton_Click(null, null);
                            break;
                        case (int)SwitchButtonsType.Profile:
                            AccountButton_Click(null, null);
                            break;
                    }
                }
            }
        }
    }
}

//private void AddEventsButtonList()
//{
//    var panels = NewsFlowLayoutPanel.Controls.OfType<FlowLayoutPanel>().ToList();
//    var buttonsDelete = new List<Button>();
//    foreach (var item in panels)
//    {
//        buttonsDelete.Add(item.Controls.OfType<Button>().LastOrDefault());
//    }
//    buttonsDelete.ForEach(x => x.Click += new EventHandler(DeleteNewsButton_Click));
//    var buttonsEdit = new List<Button>();
//    foreach (var item in panels)
//    {
//        buttonsEdit.Add(item.Controls.OfType<Button>().FirstOrDefault());
//    }
//    buttonsEdit.ForEach(x => x.Click += new EventHandler(EditNewsButton_Click));
//}
