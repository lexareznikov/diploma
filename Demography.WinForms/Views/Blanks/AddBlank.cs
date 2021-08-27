using Demography.WinForms.Controllers;
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
    public partial class AddBlank : Form
    {
        #region GetValueFromForm
        public string Series { get { return SeriesTextBox.Text; } }
        public string Number { get { return NumberFirstTextBox.Text; } }

        public int Count { get { if (int.TryParse(CountTextBox.Text, out var ret)) { return ret; } else { return 1; } } }
        public DateTime IncomeDate { get { return IncomeDateTimePicker.Value.Date; } }
        #endregion
        private BlankController _blankController { get; set; }
        public AddBlank()
        {
            InitializeComponent();
            _blankController = new BlankController();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRangeBlanksButton_Click(object sender, EventArgs e)
        {
            var isValid = true;
            errorProvider.Clear();
            var model = new AddBlankViewModel(this);
            if (model.NumberFirst?.Length != 6)
            {
                isValid = false;
                errorProvider.SetError(NumberFirstTextBox, "Номер должен быть 6 символов");
            }
            else if (_blankController.BeforeLastNumber(model.NumberFirst))
            {
                isValid = false;
                errorProvider.SetError(NumberFirstTextBox, "Номер меньше ранее указанного");
            }
            if (IncomeDate.Date >= DateTime.Now.Date.AddDays(1))
            {
                isValid = false;
                errorProvider.SetError(IncomeDateTimePicker, "Дата не должна быть больше сегодняшнего дня");
            }
            if (model.Count == 0)
            {
                isValid = false;
                errorProvider.SetError(CountTextBox, "Количество должно быть больше 0");
            }

            if (isValid)
            {
                _blankController.AddIncome(model);
                this.Close();
            }
        }

        private void NumberFirstTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void CountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
