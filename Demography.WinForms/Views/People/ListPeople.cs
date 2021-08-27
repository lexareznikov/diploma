using Demography.Infrastructure.Extensions;
using Demography.WinForms.Controllers;
using Demography.WinForms.Models;
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

namespace Demography.WinForms.Views.People
{
    public partial class ListPeople : Form
    {
        #region ValueFromForm
        public DateTime? BirthDate { get { return BirthDateDateTimePicker.NullableValue(); } }
        public string FirstName { get { return FirstNameTextBox.Text; } }
        public string LastName { get { return LastNameTextBox.Text; } }
        public string MiddleName { get { return MiddleNameTextBox.Text; } }
        public string Snils { get { return SnilsMaskedTextBox.Text.Replace("-", "").Replace(" ", ""); } }
        //public string NumberPolicy { get { return NumberPolicyTextBox.Text; } }
        #endregion

        #region Constants
        private const int ElementWidth =350;
        private const int DateWidth = 175;
        private const int FioWidth = 400;
        private const int PanelWidth = 1030;
        private const int PanelHeight = 105;
        private const int ButtonWidth = 45;
        private const int ButtonHeight = 45;
        private const int SmallElementHeight = 100;
        private const int SplitterHeight = 1;
        #endregion
        private List<Demography.Domain.Classes.People> Peoples;
        private int CurrentPage { get { return int.Parse(CurrentPageTextBox.Text); } }
        private int MaxCountPage;
        private PeopleController _peopleController;
        public int ReturnPeopleId { get; private set; }
        public ListPeople()
        {
            InitializeComponent();
            _peopleController = new PeopleController();
            InitForm();
        }
        private void InitForm()
        {
            FilterButton_Click(null, null);
            BlockPageButtons();
        }
        private void SnilsMaskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var searchModel = new PeopleSearchViewModel(this);
            Peoples = _peopleController.GetListPeople(searchModel);
            CurrentPageTextBox.Text = "1";
            MaxCountPage = InitListPeople(CurrentPage);
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            BlockPageButtons();
        }

        private void AddPeopleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CreateEditPeople(0);

            var result = form.ShowDialog();
            if(result == DialogResult.Cancel)
            {
                this.Show();
                InitForm();
            }
            else if(result == DialogResult.OK)
            {
                this.Show();
                InitForm();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
                ReturnPeopleId = form.ReturnPeopleId;
                DialogResult = DialogResult.Yes;
            }

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

                MaxCountPage = InitListPeople(CurrentPage);
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

             MaxCountPage = InitListPeople(pageNum);
            CurrentPageTextBox.Text = pageNum.ToString();
            PageMaxCountLabel.Text = "/" + MaxCountPage.ToString();
            BlockPageButtons();
        }

        private int InitListPeople(int currentPage)
        {
            var elementOnForm = 25;
            PeopleFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            PeopleFlowLayoutPanel.AutoScroll = true;
            PeopleFlowLayoutPanel.WrapContents = false;
            //6 пикселей на элемент
            PeopleFlowLayoutPanel.Controls.Clear();
            if (Peoples.Count > 0)
            {
                var totalCountPage = Peoples.Count % elementOnForm == 0 ? Peoples.Count / elementOnForm : Peoples.Count / elementOnForm + 1;
                foreach (var item in Peoples.GetRange(elementOnForm * (currentPage - 1), (currentPage == totalCountPage && Peoples.Count % elementOnForm != 0) ? Peoples.Count % elementOnForm : elementOnForm))

                {
                    var pn = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.LeftToRight,
                        Size = new Size(PanelWidth, PanelHeight)
                    };
                    PeopleFlowLayoutPanel.Controls.Add(pn);

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


                    var BirthDate = new Label
                    {
                        Size = new Size(DateWidth, SmallElementHeight),
                        // Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = item.BirthDate.HasValue? item.BirthDate.Value.ToString("dd-MM-yyyy"):null
                    };
                    pn.Controls.Add(BirthDate);


                    var addressPlaceLiving = new Label
                    {
                        Size = new Size(ElementWidth, SmallElementHeight),
                        //Anchor = AnchorStyles.Right,
                        Font = new Font("Microsoft Sans Serif", 16),
                        Text = item.PlaceLiving != null ? item.PlaceLiving.FullAddress : null
                    };
                    pn.Controls.Add(addressPlaceLiving);
                    var editButton = new Button
                    {
                        Size = new Size(ButtonWidth, ButtonHeight),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Name = item.Id.ToString(),
                        BackgroundImage = Properties.Resources.penEdit
                    };
                    editButton.Click += EditPeopleButton_Click;
                    pn.Controls.Add(editButton);
                    pn.Controls.Add(splitter);
                }
                CountLabel.Text = $"{(currentPage - 1) * elementOnForm + 1}-{(currentPage - 1) * elementOnForm + ((currentPage == totalCountPage && Peoples.Count % elementOnForm != 0) ? Peoples.Count % elementOnForm : elementOnForm)} из {Peoples.Count}";
                return totalCountPage;
            }
            else
            {
                CountLabel.Text = "0-0 из 0";
                return 1;
            }
        }
        private void EditPeopleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var button = sender as Button;
        
            var form = new CreateEditPeople(int.Parse(button.Name));

            var result = form.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Show();
                InitForm();
            }
            else if (result == DialogResult.OK)
            {
                this.Show();
                InitForm();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
                ReturnPeopleId = form.ReturnPeopleId;
                DialogResult = DialogResult.Yes;
            }

        }

        private void ListPeople_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
