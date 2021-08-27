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

namespace Demography.WinForms.Views
{
    public partial class Clinic : Form
    {
        #region GetValueFromForm
        public string FullNameClinic { get { return FullNameClinicTextBox.Text; } set { FullNameClinicTextBox.Text = value; } }
        public string ShortNameClinic { get { return ShortNameClinicTextBox.Text; } set { ShortNameClinicTextBox.Text = value; } }
        public string OGRN { get { return OGRNTextBox.Text; } set { OGRNTextBox.Text = value; } }
        public string INN { get { return INNTextBox.Text; } set { INNTextBox.Text = value; } }
        public string Okpo { get { return OKPOTextBox.Text; } set { OKPOTextBox.Text = value; } }
        public string Phone { get { return PhoneTextBox.Text; } set { PhoneTextBox.Text = value; } }
        public string Fax { get { return FaxTextBox.Text; } set { FaxTextBox.Text = value; } }
        public string Email { get { return EmailTextBox.Text; } set { EmailTextBox.Text = value; } }

        public string Country { get { return CountryTextBox.Text; } set { CountryTextBox.Text = value; } }
        public string Locality { get { return LocalityTextBox.Text; } set { LocalityTextBox.Text = value; } }
        public string District { get { return DistrictTextBox.Text; } set { DistrictTextBox.Text = value; } }
        public string Region { get { return RegionTextBox.Text; } set { RegionTextBox.Text = value; } }
        public string Street { get { return StreetTextBox.Text; } set { StreetTextBox.Text = value; } }
        public string House { get { return HouseTextBox.Text; } set { HouseTextBox.Text = value; } }
        public string Build { get { return BuildTextBox.Text; } set { BuildTextBox.Text = value; } }
        public int? DirectorId { get { return (int?)DirectorIdСomboBox.SelectedValue; } set { if (value.HasValue) { DirectorIdСomboBox.SelectedValue = value; } else { DirectorIdСomboBox.SelectedIndex = 0; } } }
        #endregion
        public int ReturnButton { get; private set; }
        private ClinicController _clinicController { get; set; }
        private ListController _listController { get; set; }
        private ClinicConfig _clinicConfig { get; set; }
        public Clinic()
        {
            InitializeComponent();
            _clinicController = new ClinicController();
            _clinicConfig = new ClinicConfig();
            _listController = new ListController();
            FillForm(_clinicConfig.ClinicToClinicViewModel(_clinicController.GetAll().FirstOrDefault()));
        }
        private void FillForm(ClinicViewModel model)
        {
            _listController.DropDownListUsers(DirectorIdСomboBox, true);
            FullNameClinic = model.FullNameClinic;
            ShortNameClinic = model.ShortNameClinic;
            OGRN = model.OGRN;
            INN = model.INN;
            Okpo = model.Okpo;
            Phone = model.Phone;
            Fax = model.Fax;
            Email = model.Email;
            Country = model.Country;
            Locality = model.Locality;
            District = model.District;
            Region = model.Region;
            Street = model.Street;
            House = model.House;
            Build = model.Build;
            DirectorId = model.DirectorId;
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var model = new ClinicViewModel(this);
            if (string.IsNullOrEmpty(model.FullNameClinic))
            {
                errorProvider.SetError(FullNameClinicTextBox, "Обязательное поле");
            }
            else
            {
                if (!model.DirectorId.HasValue)
                {
                    var result = new YesNot("Если вы не заполните поле \"Главный врач\", то система будет работать некорректно. Продолжить?").ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        var clinic = _clinicController.GetAll().FirstOrDefault();
                        _clinicController.Reload(clinic);
                        clinic = _clinicConfig.ClinicViewModelToClinic(clinic, model);
                        _clinicController.AddOrUpdate(clinic);
                        new Okey("Изменения сохранены").ShowDialog();
                    }
                }
                else
                {
                    var clinic = _clinicController.GetAll().FirstOrDefault();
                    _clinicController.Reload(clinic);
                    clinic = _clinicConfig.ClinicViewModelToClinic(clinic, model);
                    _clinicController.AddOrUpdate(clinic);
                    new Okey("Изменения сохранены").ShowDialog();
                }
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
