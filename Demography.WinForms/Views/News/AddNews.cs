using Demography.Infrastructure.Domain;
using Demography.WinForms.Controllers;
using Demography.WinForms.MapperConfig;
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

namespace Demography.WinForms.Views.News
{
    public partial class AddNews : Form
    {
        #region GetValueFromForm
        public string NameShortText { get { return NameShortTextBox.Text; } set { NameShortTextBox.Text = value; } }
        public string NewsFullText { get { return NewsFullRichTextBox.Text; } set { NewsFullRichTextBox.Text = value; } }
        public DateTime NewsDate { get { return DateTimePicker.Value.Date; } set { DateTimePicker.Value = value; } }
        #endregion
        private NewsController _newsController;
        private NewsConfig _newsConfig;
       
        public AddNews()
        {
            InitializeComponent();
            _newsConfig = new NewsConfig();
            _newsController = new NewsController();
        }

        public AddNews(int id)
        {
            InitializeComponent();
            _newsConfig = new NewsConfig();
            AddNewsButton.Hide();
            _newsController = new NewsController();
            var butt = new Button
            {
                Name = id.ToString(),
                Text = "Сохранить",
                Font = new Font("Microsoft Sans Serif", 16),
                Size = AddNewsButton.Size,
                Location = AddNewsButton.Location,
                BackColor = Color.FromKnownColor(KnownColor.Control)
                
            };
            butt.Click += SaveButtonClick;
            this.Controls.Add(butt);
            FillModel(id);
        }

       

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewsButton_Click(object sender, EventArgs e)
        {
           
            var model = new NewsViewModel(this);
            if (ValidateForm(model))
            {
                try
                {
                    var news = _newsConfig.NewsModelToNews(model);
                    if(_newsController.AddNews(news))
                    {
                        this.Close();
                    }
                    else
                    {
                        new Okey("Произошла ошибка, при добавлении новости").ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    new Okey(ex.Message).ShowDialog();
                }

            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            var model = new NewsViewModel(this);
            if (ValidateForm(model))
            {
                try
                {
                    var news = _newsConfig.NewsModelToNews(model,_newsController.GetById(int.Parse(button.Name)));
                    if (_newsController.AddNews(news))
                    {
                        DialogResult=DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        new Okey("Произошла ошибка, при обновлении новости").ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    new Okey(ex.Message).ShowDialog();
                }

            }
        }

        private void FillModel(int id)
        {
            var model = _newsConfig.NewsToNewsModel(_newsController.GetById(id));
            NewsDate = model.Date;
            NewsFullText = model.NewsFull;
            NameShortText = model.NameShort;
        }

        private bool ValidateForm(NewsViewModel model)
        {
            bool IsValidModel = true;
            if (model.Date <  DateTime.Today)
            {

                errorProvider.SetError(DateTimePicker, "Новость должна быть не раньше сегодняшнего числа");
                IsValidModel = false;

            }
            if (string.IsNullOrEmpty(model.NameShort))
            {

                errorProvider.SetError(NameShortTextBox, "Должено быть короткое название");
                IsValidModel = false;

            }
            if (model.NameShort.Length > 76)
            {

                errorProvider.SetError(NameShortTextBox, "Название большое (больше 76 символов)");
                IsValidModel = false;

            }
            if (string.IsNullOrEmpty(model.NewsFull))
            {

                errorProvider.SetError(NewsFullRichTextBox, "Должно быть подробное описание");
                IsValidModel = false;

            }
            return IsValidModel;
        }
    }
}
