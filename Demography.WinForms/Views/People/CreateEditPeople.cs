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

namespace Demography.WinForms.Views.People
{
    public partial class CreateEditPeople : Form
    {
        #region GetValueFromForm
        public string OmsEnp { get { return OMCEnpTextBox.Text; } set { OMCEnpTextBox.Text = value; } }
        public string OmsNumber { get { return OMCNumberTextBox.Text; } set { OMCNumberTextBox.Text = value; } }
        public string OmsSeries { get { return OMCSeriesTextBox.Text; } set { OMCSeriesTextBox.Text = value; } }
        public string WorkPlace { get { return WorkPlaceTextBox.Text; } set { WorkPlaceTextBox.Text = value; } }
        public string Position { get { return PositionTextBox.Text; } set { PositionTextBox.Text = value; } }
        public string Snils { get { return SnilsMaskedTextBox.Text.Replace("-", "").Replace(" ", ""); } set { SnilsMaskedTextBox.Text = value; } }
        //6

        public string FirstName { get { return FirstNameTextBox.Text; } set { FirstNameTextBox.Text = value; } }
        public string LastName { get { return LastNameTextBox.Text; } set { LastNameTextBox.Text = value; } }
        public string MiddleName { get { return MiddleNameTextBox.Text; } set { MiddleNameTextBox.Text = value; } }
        public string BirthPlace { get { return BirthPlaceTextBox.Text; } set { BirthPlaceTextBox.Text = value; } }
        public string Phone { get { return PhoneTextBox.Text; } set { PhoneTextBox.Text = value; } }
        public DateTime? BirthDate { get { return BirthdayDateTimePicker.Value; } set { BirthdayDateTimePicker.NullableValue(value); } }
       // public int? SexId { get { return (int?)SexComboBox.SelectedValue; } set { if (value.HasValue) { SexComboBox.SelectedValue = value; } else { SexComboBox.SelectedIndex = 0; } } }
        //7


        public int? DocTypeId { get { return (int?)DocTypeComboBox.SelectedValue; } set { if (value.HasValue) { DocTypeComboBox.SelectedValue = value; } else { DocTypeComboBox.SelectedIndex = 0; } } }
        public string DocSeries { get { return DocSeriesTextBox.Text; } set { DocSeriesTextBox.Text = value; } }
        public string DocNumber { get { return DocNumberTextBox.Text; } set { DocNumberTextBox.Text = value; } }
        public DateTime? DocDateOn { get { return DocDateOnDateTimePicker.NullableValue(); } set { DocDateOnDateTimePicker.NullableValue(value); } }
        public DateTime? DocDateWith { get { return DocDateWithDateTimePicker.NullableValue(); } set { DocDateWithDateTimePicker.NullableValue(value); } }
        public string DocOrgName { get { return DocOrgNameTextBox.Text; } set { DocOrgNameTextBox.Text = value; } }
        public bool WithoutDoc { get { return WithoutDocCheckBox.Checked; } set { WithoutDocCheckBox.Checked = value; } }
        //7


        public string Country { get { return CountryTextBox.Text; } set { CountryTextBox.Text = value; } }
        public string Locality { get { return LocalityTextBox.Text; } set { LocalityTextBox.Text = value; } }
        public string District { get { return DistrictTextBox.Text; } set { DistrictTextBox.Text = value; } }
        public string Region { get { return RegionTextBox.Text; } set { RegionTextBox.Text = value; } }
        public string Street { get { return StreetTextBox.Text; } set { StreetTextBox.Text = value; } }
        public string House { get { return HouseTextBox.Text; } set { HouseTextBox.Text = value; } }
        public string Flat { get { return FlatTextBox.Text; } set { FlatTextBox.Text = value; } }
        public string Housing { get { return HousingTextBox.Text; } set { HousingTextBox.Text = value; } }
        public string Room { get { return RoomTextBox.Text; } set { RoomTextBox.Text = value; } }
        public string Build { get { return BuildTextBox.Text; } set { BuildTextBox.Text = value; } }
        public int? Location { get { return (int?)LocationComboBox.SelectedValue; } set { if (value.HasValue) { LocationComboBox.SelectedValue = value; } else { DocTypeComboBox.SelectedIndex = 0; } } }
        public bool IsForeigner { get { return ForeignerСheckBox.Checked; } set { ForeignerСheckBox.Checked = value; } }
        public bool IsHomeless { get { return HomelessCheckBox.Checked; } set { HomelessCheckBox.Checked = value; } }
        //13

        public int PeopleId { get { return int.Parse(IdLabel.Text); } set { IdLabel.Text = value.ToString(); } }

        #endregion
        public int ReturnPeopleId { get; private set; }

        private PeopleConfig _peopleconfig;
        private PeopleController _peopleController;
        private ListController _listController;
        public CreateEditPeople(int? id)
        {
            InitializeComponent();
            _peopleconfig = new PeopleConfig();
            _peopleController = new PeopleController();
            _listController = new ListController();
            PeopleId = id.GetValueOrDefault(0);
            InitForm(PeopleId);
        }

       
        private void FillForm(PeopleEditViewModel model)
        {
            WorkPlace = model.WorkPlace;
            OmsEnp = model.OmsEnp;
            OmsNumber = model.OmsNumber;
            OmsSeries = model.OmsSeries;
            Position = model.Position;

            FirstName = model.FirstName;
            LastName = model.LastName;
            MiddleName = model.MiddleName;
            BirthPlace = model.BirthPlace;
            Phone = model.Phone;
            Snils = model.Snils;
            BirthDate = model.BirthDate;
          //  SexId = model.SexId==0?null:model.SexId;
            if (model.DocTypeId == null)
            {
                WithoutDoc = true;
            }
            else
            {
                DocTypeId = model.DocTypeId;
                DocSeries = model.DocSeries;
                DocNumber = model.DocNumber;
                DocDateOn = model.DocDateOn;
                DocDateWith = model.DocDateWith;
                DocOrgName = model.DocOrgName;
            }
            Country = model.Country;
            Locality = model.Locality;
            District = model.District;
            Region = model.Region;
            Street = model.Street;
            House = model.House;
            Flat = model.Flat;
            Housing = model.Housing;
            Room = model.Room;
            Build = model.Build;
            Location = model.Location;
            IsForeigner = model.IsForeigner;
            IsHomeless = model.IsHomeless;
        }
        private void InitForm(int id)
        {

            var people = _peopleController.GetById(id).FirstOrDefault();
            if(people == null)
            {
                people = new Domain.Classes.People();
            }
            else
            {
                _peopleController.Reload(people);
            }
           // _listController.InitDropDownListEnum<SexPeople>(SexComboBox, true);
            _listController.InitDropDownListEnum<LocalityType>(LocationComboBox, true);
            _listController.DropDownListDocType(DocTypeComboBox, true);
            DocDateWithDateTimePicker.ValueChanged += (s, e) => { DocDateWithDateTimePicker.CustomFormat = (DocDateWithDateTimePicker.Checked) ? "dd/MM/yyyy" : " "; };
            DocDateOnDateTimePicker.ValueChanged += (s, e) => { DocDateOnDateTimePicker.CustomFormat = (DocDateOnDateTimePicker.Checked) ? "dd/MM/yyyy" : " "; };

            FillForm(_peopleconfig.PeopleToPeopleEditViewModel(people));
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private bool Validate(PeopleEditViewModel model)
        {
            errorProvider.Clear();
            var isValid = true;

            if (string.IsNullOrEmpty(model.FirstName))
            {
                errorProvider.SetError(FirstNameTextBox, "Обязательное поле");
                isValid = false;
            }
            if (string.IsNullOrEmpty(model.LastName))
            {
                errorProvider.SetError(LastNameTextBox, "Обязательное поле");
                isValid = false;
            }
            if (!model.IsForeigner && !model.IsHomeless)
            {
                if (string.IsNullOrEmpty(model.Country))
                {
                    errorProvider.SetError(CountryTextBox, "Обязательное поле");
                    isValid = false;
                }

                if (string.IsNullOrEmpty(model.Region))
                {
                    errorProvider.SetError(RegionTextBox, "Обязательное поле");
                    isValid = false;
                }

                if (string.IsNullOrEmpty(model.Street))
                {
                    errorProvider.SetError(StreetTextBox, "Обязательное поле");
                    isValid = false;
                }

                if (string.IsNullOrEmpty(model.House))
                {
                    errorProvider.SetError(HouseTextBox, "Обязательное поле");
                    isValid = false;
                }

                if (model.Location == null)
                {
                    errorProvider.SetError(LocationComboBox, "Обязательное поле");
                    isValid = false;
                }
            }
            if (!model.WithoutDoc)
            {


                if (model.DocTypeId == null)
                {
                    errorProvider.SetError(DocTypeComboBox, "Обязательное поле");
                    isValid = false;
                }
                if (string.IsNullOrEmpty(model.DocSeries))
                {
                    errorProvider.SetError(DocSeriesTextBox, "Обязательное поле");
                    isValid = false;
                }
                else if (model.DocSeries.Length > 10)
                {
                    errorProvider.SetError(DocSeriesTextBox, "Длина должна быть не более 10 символов");
                    isValid = false;
                }
                if (string.IsNullOrEmpty(model.DocNumber))
                {
                    errorProvider.SetError(DocNumberTextBox, "Обязательное поле");
                    isValid = false;
                }
                else if (model.DocNumber.Length > 30)
                {
                    errorProvider.SetError(DocNumberTextBox, "Длина должна быть не более 30 символов");
                    isValid = false;
                }
                if (model.DocOrgName.Length > 250)
                {
                    errorProvider.SetError(DocOrgNameTextBox, "Длина должна быть не более 250 символов");
                    isValid = false;
                }
            }
            return isValid;
        }
        private void SnilsMaskedTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (((MaskedTextBox)sender).Text.Replace(" ", "").Length == 2)
            {
                ((MaskedTextBox)sender).SelectionStart = 0;
            }
        }

        private void SaveAndFillButton_Click(object sender, EventArgs e)
        {
            var model = new PeopleEditViewModel(this);
            var people = _peopleController.GetById(PeopleId).FirstOrDefault();
            if (Validate(model))
            {
                if (people != null)
                {
                    _peopleController.Reload(people);
                }
                if (model.WithoutDoc && people?.Documents != null && people?.Documents.Count > 0)
                {
                    _peopleController.DeleteDoc(people.Id);
                }
                if ((model.IsForeigner || model.IsHomeless) && people.PlaceLiving != null)
                {
                    _peopleController.DeleteAddress(people.Id);
                }
                people = _peopleconfig.PeopleEditViewModelToPeople(model, people);
              
                _peopleController.AddOrUpdatePeople(people);
                ReturnPeopleId = people.Id;
                DialogResult = DialogResult.Yes;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var model = new PeopleEditViewModel(this);
            var people = _peopleController.GetById(PeopleId).FirstOrDefault();
            if (Validate(model))
            {
                if (people != null)
                {
                    _peopleController.Reload(people);
                }
                if (model.WithoutDoc && people?.Documents != null && people?.Documents.Count > 0)
                {
                    _peopleController.DeleteDoc(people.Id);
                }
                if ((model.IsForeigner || model.IsHomeless) && people.PlaceLiving != null)
                {
                    _peopleController.DeleteAddress(people.Id);
                }

                people = _peopleconfig.PeopleEditViewModelToPeople(model, people);
                _peopleController.AddOrUpdatePeople(people);
                DialogResult = DialogResult.OK;
            }
        }
        private void OMCSeriesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void OMCNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void OMCEnpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void DocTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            WithoutDoc = false;
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
