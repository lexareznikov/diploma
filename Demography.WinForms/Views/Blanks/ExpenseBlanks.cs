using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Extensions;
using Demography.WinForms.Controllers;
using Demography.WinForms.MapperConfig;
using Demography.WinForms.Models;
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
    public partial class ExpenseBlanks : Form
    {
        #region Constants
        private const int ElementWidth = 175;
        private const int DateWidth = 215;
        private const int EmailWidth = 250;
        private const int FioWidth = 450;
        private const int PanelWidth = 810;
        private const int PanelHeight = 105;
        private const int ButtonWidth = 45;
        private const int ButtonHeight = 45;
        private const int SmallElementHeight = 100;
        private const int SplitterHeight = 1;
        #endregion
        private int CurrentPage { get { return int.Parse(CurrentPageTextBox.Text); } }
        private int MaxCountPage;
        private BlankController _blankController { get; set; }
        private BlanksConfig _blanksConfig { get; set; }
        private List<ExpenseBlanksViewModel> Blanks { get; set; } = new List<ExpenseBlanksViewModel>();
        public ExpenseBlanks()
        {
            InitializeComponent();
            _blankController = new BlankController();
            _blanksConfig = new BlanksConfig();
            var certificates = _blankController.GetListBirth().ToList();
            foreach(var item in certificates)
            {
                Blanks.Add(_blanksConfig.CertificateToExpenseBlanksViewModel(item));
            }
            TextLabel.Text = $"Задействовано {Blanks.Count} из {_blankController.GetCount()} бланков";

            CurrentPageTextBox.Text = "1";
            MaxCountPage = InitListBlanks(CurrentPage);
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            BlockPageButtons();
        }

        private void RemovePageButton_Click(object sender, EventArgs e)
        {
            CurrentPageInitNewsList(CurrentPage - 1);
        }

        private void AddPageButton_Click(object sender, EventArgs e)
        {
            CurrentPageInitNewsList(CurrentPage + 1);
        }
        private int InitListBlanks(int currentPage)
        {
            var elementOnForm = 25;
            BlankFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            BlankFlowLayoutPanel.AutoScroll = true;
            BlankFlowLayoutPanel.WrapContents = false;
            //6 пикселей на элемент
            BlankFlowLayoutPanel.Controls.Clear();
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
                    BlankFlowLayoutPanel.Controls.Add(pn);

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


                    var status = new Label
                    {
                        Size = new Size(ElementWidth, SmallElementHeight),
                        //Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = ((CertificateStatus)item.StatusId).GetDisplayName()
                    };
                    pn.Controls.Add(status);
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
        private void CurrentPageInitNewsList(int pageNum)
        {

            MaxCountPage = InitListBlanks(pageNum);
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

                MaxCountPage = InitListBlanks(CurrentPage);
                PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
                BlockPageButtons();
            }
        }
    }
}
