using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Extensions;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Controllers;
using Demography.WinForms.MapperConfig;
using Demography.WinForms.Models;
using Demography.WinForms.Utility;
using FastReport;

namespace Demography.WinForms.Views.CertificateBirth
{
    public partial class EditCertificate : Form
    {
        #region GetValueFromForm
        /// <summary>
        /// левый верхний блок52
        /// </summary>
        public string Series { get { return SeriesTextBox.Text; } set { SeriesTextBox.Text = value; } }
        public string Number { get { return NumberTextBox.Text; } set { NumberTextBox.Text = value; } }
        public DateTime? CreateDate { get { return CreateDateTimePicker.Value; } set { CreateDateTimePicker.NullableValue(value); } }
        public int? UserId { get { return (int?)UserIdComboBox.SelectedValue; } set { if (value.HasValue) { UserIdComboBox.SelectedValue = value; } else { UserIdComboBox.SelectedIndex = 0; } } }
        public string UserPostId { get { return UserPostIdComboBox.SelectedValue.ToString(); } set { if (string.IsNullOrEmpty(value)) { UserPostIdComboBox.SelectedValue = value; } else { UserPostIdComboBox.SelectedIndex = 0; } } }
        public int? BirthAcceptId { get { return (int?)BirthAcceptComboBox.SelectedValue; } set { if (value.HasValue) { BirthAcceptComboBox.SelectedValue = value; } else { BirthAcceptComboBox.SelectedIndex = 0; } } }
        public int? DirectorId { get { return (int?)DirectorIdСomboBox.SelectedValue; } set { if (value.HasValue) { DirectorIdСomboBox.SelectedValue = value; } else { DirectorIdСomboBox.SelectedIndex = 0; } } }
        public int? StatusId { get { return (int?)StatusIdComboBox.SelectedValue; } set { if (value.HasValue) { StatusIdComboBox.SelectedValue = value; } else { StatusIdComboBox.SelectedIndex = 0; } } }
        /// <summary>
        /// Правый верхний
        /// </summary>

        public string RecipientLastname { get { return RecipientLastnameTextBox.Text; } set { RecipientLastnameTextBox.Text = value; } }
        public string RecipientFirstname { get { return RecipientFirstnameTextBox.Text; } set { RecipientFirstnameTextBox.Text = value; } }
        public string RecipientMiddlename { get { return RecipientMiddlenameTextBox.Text; } set { RecipientMiddlenameTextBox.Text = value; } }
        public int? RecipientRelationshipTypeId { get { return (int?)RelationshipTypeIdComboBox.SelectedValue; } set { if (value.HasValue) { RelationshipTypeIdComboBox.SelectedValue = value; } else { RelationshipTypeIdComboBox.SelectedIndex = 0; } } }
        public int? RecipientDocTypeId { get { return (int?)RecipientDocTypeIdComboBox.SelectedValue; } set { if (value.HasValue) { RecipientDocTypeIdComboBox.SelectedValue = value; } else { RecipientDocTypeIdComboBox.SelectedIndex = 0; } } }
        public string RecipientDocSeries { get { return RecipientDocSeriesTextBox.Text; } set { RecipientDocSeriesTextBox.Text = value; } }
        public string RecipientDocNumber { get { return RecipientDocNumberTextBox.Text; } set { RecipientDocNumberTextBox.Text = value; } }
        public string RecipientDocOrgName { get { return RecipientDocIssuerTextBox.Text; } set { RecipientDocIssuerTextBox.Text = value; } }
        /// <summary>
        /// Ребенок
        /// </summary>


        public string LastName { get { return LastnameTextBox.Text; } set { LastnameTextBox.Text = value; } }
        public DateTime? Birthdate { get { return BirthDateTimePicker.NullableValue(); } set { BirthDateTimePicker.NullableValue(value); } }
        public int? SexId { get { return (int?)SexIdComboBox.SelectedValue; } set { if (value.HasValue) { SexIdComboBox.SelectedValue = value; } else { SexIdComboBox.SelectedIndex = 0; } } }
        public int? WeightChild { get { if (int.TryParse(WeightChildTextBox.Text, out var weight)) { return weight; } else { return null; }; } set { WeightChildTextBox.Text = value.HasValue ? value.ToString() : null; } }
        public int? LengthBodyChild { get { if (int.TryParse(LengthBodyChildTextBox.Text, out var Length)) { return Length; } else { return null; }; } set { LengthBodyChildTextBox.Text = value.HasValue ? value.ToString() : null; } }
        public bool ChildbirthOneFetalUnderAccount { get { return ChildbirthOneFetalUnderAccountCheckBox.Checked; } set { ChildbirthOneFetalUnderAccountCheckBox.Checked = value; } }
        public int? ChildBirthPolycarpousUnderAccount { get { if (int.TryParse(ChildBirthPolycarpousUnderAccountTextBox.Text, out var temp)) { return temp; } else { return null; }; } set { ChildBirthPolycarpousUnderAccountTextBox.Text = value.HasValue ? value.ToString() : null; } }

        public int? ChildrenBorn { get { if (int.TryParse(ChildrenBornTextBox.Text, out var temp)) { return temp; } else { return null; }; } set { ChildrenBornTextBox.Text = value.HasValue ? value.ToString() : null; } }

        public string Locality { get { return LocalityTextBox.Text; } set { LocalityTextBox.Text = value; } }
        public string Region { get { return RegionTextBox.Text; } set { RegionTextBox.Text = value; } }
        public int? Location { get { return (int?)LocationComboBox.SelectedValue; } set { if (value.HasValue) { LocationComboBox.SelectedValue = value; } else { LocationComboBox.SelectedIndex = 0; } } }
        /// <summary>
        /// Мать
        /// </summary>
        public string MotherFirstName { get { return MotherFirstnameTextBox.Text; } set { MotherFirstnameTextBox.Text = value; } }
        public string MotherLastName { get { return MotherLastnameTextBox.Text; } set { MotherLastnameTextBox.Text = value; } }
        public string MotherMiddleName { get { return MotherMiddlenameTextBox.Text; } set { MotherMiddlenameTextBox.Text = value; } }
        public int? ClinicId { get { return (int?)ClinicComboBox.SelectedValue; } set { if (value.HasValue) { ClinicComboBox.SelectedValue = value; } else { ClinicComboBox.SelectedIndex = 0; } } }

        public int? FirstTournoutDoctor { get { if (int.TryParse(FirstTournoutDoctorTextBox.Text, out var temp)) { return temp; } else { return null; }; } set { FirstTournoutDoctorTextBox.Text = value.HasValue ? value.ToString() : null; } }

        public int? ChildUnderAccount { get { if (int.TryParse(ChildUnderAccountTextBox.Text, out var temp)) { return temp; } else { return null; }; } set { ChildUnderAccountTextBox.Text = value.HasValue ? value.ToString() : null; } }


        public DateTime? MotherBirthdate { get { return MotherBirthdateTimePicker.NullableValue(); } set { MotherBirthdateTimePicker.NullableValue(value); } }
        public int? MotherEducationId { get { return (int?)MotherEducationIdComboBox.SelectedValue; } set { if (value.HasValue) { MotherEducationIdComboBox.SelectedValue = value; } else { MotherEducationIdComboBox.SelectedIndex = 0; } } }
        public int? MotherEmploymentId { get { return (int?)MotherEmploymentIdComboBox.SelectedValue; } set { if (value.HasValue) { MotherEmploymentIdComboBox.SelectedValue = value; } else { MotherEmploymentIdComboBox.SelectedIndex = 0; } } }
        public int? PlaceChildbirthId { get { return (int?)PlaceChildbirthIdComboBox.SelectedValue; } set { if (value.HasValue) { PlaceChildbirthIdComboBox.SelectedValue = value; } else { PlaceChildbirthIdComboBox.SelectedIndex = 0; } } }
        public int? MotherFamilyStatusId { get { return (int?)MotherFamilyStatusIdComboBox.SelectedValue; } set { if (value.HasValue) { MotherFamilyStatusIdComboBox.SelectedValue = value; } else { MotherFamilyStatusIdComboBox.SelectedIndex = 0; } } }

        public string MotherCountry { get { return MotherCountryTextBox.Text; } set { MotherCountryTextBox.Text = value; } }
        public string MotherLocality { get { return MotherLocalityTextBox.Text; } set { MotherLocalityTextBox.Text = value; } }
        public string MotherDistrict { get { return MotherDistrictTextBox.Text; } set { MotherDistrictTextBox.Text = value; } }
        public string MotherRegion { get { return MotherRegionTextBox.Text; } set { MotherRegionTextBox.Text = value; } }
        public string MotherStreet { get { return MotherStreetTextBox.Text; } set { MotherStreetTextBox.Text = value; } }
        public int? MotherLocation { get { return (int?)MotherLocationComboBox.SelectedValue; } set { if (value.HasValue) { MotherLocationComboBox.SelectedValue = value; } else { MotherLocationComboBox.SelectedIndex = 0; } } }
        public string MotherHouse { get { return MotherHouseTextBox.Text; } set { MotherHouseTextBox.Text = value; } }
        public string MotherFlat { get { return MotherFlatTextBox.Text; } set { MotherFlatTextBox.Text = value; } }
        public bool MotherIsForeigner { get { return MotherForeignerСheckBox.Checked; } set { MotherForeignerСheckBox.Checked = value; } }
        public bool MotherIsHomeless { get { return MotherHomelessCheckBox.Checked; } set { MotherHomelessCheckBox.Checked = value; } }


        public int? PeopleId { get { if (int.TryParse(PeopleIdLabel.Text, out var temp)) { return temp; } else { return null; }; } set { PeopleIdLabel.Text = value.HasValue ? value.ToString() : null; } }
        public int? CertificateId { get { if (int.TryParse(CertificateIdLabel.Text, out var temp)) { return temp; } else { return null; }; } set { CertificateIdLabel.Text = value.HasValue ? value.ToString() : null; } }
        public bool IsCreate { get; set; }

        #endregion

        private ListController _listController;
        private PeopleController _peopleController;
        private ClinicController _clinicController;
        private CertificateBirthController _certificateController;
        private CertificateConfig _certificateConfig;
        public EditCertificate(int id, bool isCreate = false)
        {
            InitializeComponent();
            _listController = new ListController();
            _peopleController = new PeopleController();
            _certificateConfig = new CertificateConfig();
            _clinicController = new ClinicController();
            _certificateController = new CertificateBirthController();
            IsCreate = isCreate;
            InitForm();

            if (isCreate)
            {
                CertificateId = 0;
                PeopleId = id;
                FillOnlyPeople();
            }
            else
            {
                CertificateId = id;
                FillFromCertificate();
            }
            HideButtonForRole();

        }
        private void FillOnlyPeople()
        {
            var model = _certificateConfig.PeopleToCertificateEditViewModel(_peopleController.GetById(PeopleId.Value).AsNoTracking().FirstOrDefault());
            DirectorId = _clinicController.GetDirector();
            MotherBirthdate = model.MotherBirthdate;
            MotherCountry = model.MotherCountry;
            MotherDistrict = model.MotherDistrict;
            MotherFirstName = model.MotherFirstName;
            MotherMiddleName = model.MotherMiddleName;
            MotherLastName = model.MotherLastName;
            MotherFlat = model.MotherFlat;
            MotherHouse = model.MotherHouse;
            MotherIsForeigner = model.MotherIsForeigner;
            MotherIsHomeless = model.MotherIsHomeless;
            MotherLocality = model.MotherLocality;
            MotherLocation = model.MotherLocation;
            MotherRegion = model.MotherRegion;
            MotherStreet = model.MotherStreet;

        }
        private void FillFromCertificate()
        {
            var certificate = _certificateController.GetById(CertificateId.Value).AsNoTracking().FirstOrDefault();
            // _certificateController.Reload(certificate);

            var model = _certificateConfig.CertificateBirthToCertificateEditViewModel(certificate);

            MotherBirthdate = model.MotherBirthdate;
            MotherCountry = model.MotherCountry;
            MotherDistrict = model.MotherDistrict;
            MotherFirstName = model.MotherFirstName;
            MotherMiddleName = model.MotherMiddleName;
            MotherLastName = model.MotherLastName;
            MotherFlat = model.MotherFlat;
            MotherHouse = model.MotherHouse;
            MotherIsForeigner = model.MotherIsForeigner;
            MotherIsHomeless = model.MotherIsHomeless;
            MotherLocality = model.MotherLocality;
            MotherLocation = model.MotherLocation;
            MotherRegion = model.MotherRegion;
            MotherStreet = model.MotherStreet;
            MotherEducationId = model.MotherEducationId;
            MotherEmploymentId = model.MotherEmploymentId;
            MotherFamilyStatusId = model.MotherFamilyStatusId;
            PlaceChildbirthId = model.PlaceChildbirthId;
            ChildUnderAccount = model.ChildUnderAccount;
            FirstTournoutDoctor = model.FirstTournoutDoctor;


            RecipientDocNumber = model.RecipientDocNumber;
            RecipientDocOrgName = model.RecipientDocOrgName;
            RecipientDocSeries = model.RecipientDocSeries;
            RecipientDocTypeId = model.RecipientDocTypeId;
            RecipientFirstname = model.RecipientFirstname;
            RecipientLastname = model.RecipientLastname;
            RecipientMiddlename = model.RecipientMiddlename;
            RecipientRelationshipTypeId = model.RecipientRelationshipTypeId;

            UserId = model.UserId;
            UserPostId = model.UserPostId;
            StatusId = model.StatusId;
            CreateDate = model.CreateDate;
            Series = model.Series;
            Number = model.Number;
            DirectorId = model.DirectorId;
            ClinicId = model.ClinicId;
            BirthAcceptId = model.BirthAcceptId;
            CertificateId = model.CertificateId;



            LastName = model.LastName;
            SexId = model.SexId;
            Birthdate = model.Birthdate;
            WeightChild = model.WeightChild;
            LengthBodyChild = model.LengthBodyChild;
            ChildrenBorn = model.ChildrenBorn;
            ChildbirthOneFetalUnderAccount = model.ChildbirthOneFetalUnderAccount;
            ChildBirthPolycarpousUnderAccount = model.ChildBirthPolycarpousUnderAccount;
            Locality = model.Locality;
            Location = model.Location;
            PeopleId = model.PeopleId;
            Region = model.Region;
            IsCreate = model.IsCreate;

            SetRemarks();
        }
        private void SetRemarks()
        {
            var remarks = _certificateController.GetRemarks(CertificateId.Value);
            foreach (var control in MainPanel.Controls)
            {
                var con = control as Control;
                if (remarks.Where(x => x.FieldName == con.Name).Any())
                {
                    var message = remarks.Where(x => x.FieldName == con.Name).FirstOrDefault().Note;
                    con.BackColor = Color.Red;
                    FormToolTip.SetToolTip(con, message);
                    FormToolTip.InitialDelay = 100;
                    FormToolTip.ReshowDelay = 100;
                }
            }
        }
        private void DropRemBut()
        {
            foreach (var control in MainPanel.Controls)
            {
                var con = control as Control;
                if (con.Tag == "rembut")
                {
                    con.Visible = false;
                }
            }
        }
        private void InitRemBut()
        {
            foreach (var control in MainPanel.Controls)
            {
                var con = control as Control;
                if (con.Tag == "rembut")
                {
                    con.Click += Con_Click; ;
                }
            }
        }
        private void UnlockRemBut()
        {
            foreach (var control in MainPanel.Controls)
            {
                var con = control as Control;
                if (con.Tag == "rembut")
                {
                    con.Enabled = true;
                }
            }
        }
        private void LockAllElem()
        {
            foreach (var control in MainPanel.Controls)
            {
                var con = control as Control;
                con.Enabled = false;
            }
        }

        private void Con_Click(object sender, EventArgs e)
        {

            var button = sender as Button;
            var form = new AddRemark(CertificateId.Value, button.Name.Replace("_", ""));
            var result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                ToPrintButton.Visible = false;
                foreach (var control in MainPanel.Controls)
                {
                    var con = control as Control;
                    if (con.Name == button.Name.Replace("_", ""))
                    {
                        con.BackColor = Color.Red;
                    }
                }
            }
        }

        private void InitForm()
        {
            ChildbirthOneFetalUnderAccount = true;

            _listController.DropDownListPositionsForUserId(UserPostIdComboBox, CurrentUser.Id);
            _listController.DropDownListUsers(UserIdComboBox);
            _listController.InitDropDownListEnum<ProfessionAcceptType>(BirthAcceptComboBox);
            _listController.DropDownListUsers(DirectorIdСomboBox);
            _listController.DropDownListClinics(ClinicComboBox);
            _listController.InitDropDownListEnum<CertificateStatus>(StatusIdComboBox);

            _listController.DropDownListDocType(RecipientDocTypeIdComboBox);

            _listController.InitDropDownListEnum<FamilyRelationshipType>(RelationshipTypeIdComboBox);

            _listController.InitDropDownListEnum<SexChild>(SexIdComboBox);
            _listController.InitDropDownListEnum<LocalityType>(LocationComboBox);

            _listController.InitDropDownListEnum<PlaceChildBirthType>(PlaceChildbirthIdComboBox);
            _listController.InitDropDownListEnum<FamilyStatusType>(MotherFamilyStatusIdComboBox);
            _listController.DropDownListEducation(MotherEducationIdComboBox);
            _listController.DropDownListEmployment(MotherEmploymentIdComboBox);
            _listController.InitDropDownListEnum<LocalityType>(MotherLocationComboBox);
            UserId = (int?)CurrentUser.Id;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void ChildbirthOneFetalUnderAccountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var Check = (CheckBox)sender;
            if (Check.Checked == true)
            {
                ChildBirthPolycarpousUnderAccount = null;
                ChildrenBorn = null;
                ChildBirthPolycarpousUnderAccountTextBox.Enabled = false;
                ChildrenBornTextBox.Enabled = false;
            }
            else
            {
                ChildBirthPolycarpousUnderAccountTextBox.Enabled = true;
                ChildrenBornTextBox.Enabled = true;
            }
        }
        private bool ValidateForm(CertificateEditViewModel model)
        {
            ErrorProvider.Clear();
            var isValid = true;
            if (string.IsNullOrEmpty(model.Number))
            {
                isValid = false;
                ErrorProvider.SetError(NumberTextBox, "Обязательное поле");
            }
            else if (_certificateController.IsExistNumber(model.Number, model.CertificateId.Value))
            {

                isValid = false;
                ErrorProvider.SetError(NumberTextBox, "Свидетельство с данным номером уже существует");
            }
            else if (!_certificateController.NumberInRange(model.Number))
            {
                isValid = false;
                ErrorProvider.SetError(NumberTextBox, "Бланка с данным номером нет в учете");
            }
            if (string.IsNullOrEmpty(model.RecipientFirstname))
            {
                isValid = false;
                ErrorProvider.SetError(RecipientFirstnameTextBox, "Обязательное поле");
            }
            if (string.IsNullOrEmpty(model.RecipientLastname))
            {
                isValid = false;
                ErrorProvider.SetError(RecipientLastnameTextBox, "Обязательное поле");
            }
            if (string.IsNullOrEmpty(model.RecipientDocSeries))
            {
                ErrorProvider.SetError(RecipientDocSeriesTextBox, "Обязательное поле");
                isValid = false;
            }
            else if (model.RecipientDocSeries.Length > 10)
            {
                ErrorProvider.SetError(RecipientDocSeriesTextBox, "Длина должна быть не более 10 символов");
                isValid = false;
            }
            if (string.IsNullOrEmpty(model.RecipientDocNumber))
            {
                ErrorProvider.SetError(RecipientDocNumberTextBox, "Обязательное поле");
                isValid = false;
            }
            else if (model.RecipientDocNumber.Length > 30)
            {
                ErrorProvider.SetError(RecipientDocNumberTextBox, "Длина должна быть не более 30 символов");
                isValid = false;
            }
            if (model.RecipientDocOrgName.Length > 250)
            {
                ErrorProvider.SetError(RecipientDocIssuerTextBox, "Длина должна быть не более 250 символов");
                isValid = false;
            }
            if (model.ChildUnderAccount == null)
            {
                ErrorProvider.SetError(ChildUnderAccountTextBox, "Обязательное поле");
                isValid = false;
            }
            else if (model.ChildUnderAccount > 30)
            {
                ErrorProvider.SetError(ChildUnderAccountTextBox, "Укажите меньше");
                isValid = false;
            }
            if (model.FirstTournoutDoctor == null)
            {
                ErrorProvider.SetError(FirstTournoutDoctorTextBox, "обязательное поле");
                isValid = false;
            }
            else if (model.FirstTournoutDoctor > 43)
            {
                ErrorProvider.SetError(RecipientDocIssuerTextBox, "При 43 неделях беременность можно считать законченной");
                isValid = false;
            }
            if (!model.MotherIsForeigner && !model.MotherIsHomeless)
            {
                if (string.IsNullOrEmpty(model.MotherCountry))
                {
                    ErrorProvider.SetError(MotherCountryTextBox, "Обязательное поле");
                    isValid = false;
                }

                if (string.IsNullOrEmpty(model.MotherRegion))
                {
                    ErrorProvider.SetError(MotherRegionTextBox, "Обязательное поле");
                    isValid = false;
                }

                if (string.IsNullOrEmpty(model.MotherStreet))
                {
                    ErrorProvider.SetError(MotherStreetTextBox, "Обязательное поле");
                    isValid = false;
                }

                if (string.IsNullOrEmpty(model.MotherHouse))
                {
                    ErrorProvider.SetError(MotherHouseTextBox, "Обязательное поле");
                    isValid = false;
                }


                if (model.Location == null)
                {
                    ErrorProvider.SetError(LocationComboBox, "Обязательное поле");
                    isValid = false;
                }
            }
            if (string.IsNullOrEmpty(model.LastName))
            {
                ErrorProvider.SetError(LastnameTextBox, "Обязательное поле");
                isValid = false;
            }
            if (model.WeightChild == null)
            {
                ErrorProvider.SetError(WeightChildTextBox, "Обязательное поле");
                isValid = false;
            }
            else if (model.WeightChild > 9000)
            {
                ErrorProvider.SetError(WeightChildTextBox, "Введите значение до 9000");
                isValid = false;
            }
            else if (model.WeightChild < 350)
            {
                ErrorProvider.SetError(WeightChildTextBox, "укажите значение от 350");
                isValid = false;
            }
            if (model.LengthBodyChild == null)
            {
                ErrorProvider.SetError(LengthBodyChildTextBox, "Обязательное поле");
                isValid = false;
            }
            else if (model.LengthBodyChild > 100)
            {
                ErrorProvider.SetError(LengthBodyChildTextBox, "Введите значение до 100");
                isValid = false;
            }
            else if (model.LengthBodyChild < 10)
            {
                ErrorProvider.SetError(LengthBodyChildTextBox, "Введите значение больше 10");
                isValid = false;
            }
            return isValid;
        }
        private void HideButtonForRole()
        {

            if (!CurrentUser.HasPermission(false, PermissionsApp.RemarkAdd))
            {

                DropRemBut();
            }
            if (CurrentUser.IsAdmin)
            {
                SaveButton.Hide();
                PrintButton.Show();
                ExpertiseButton.Hide();
                RemarkDeletedButton.Hide();
                ToPrintButton.Hide();

                LockAllElem();
            }
            else if (CurrentUser.HasRoles(RoleApp.DoctorCertBirth, false))
            {
                if (StatusId == (int)CertificateStatus.Created)
                {
                    SaveButton.Show();

                    PrintButton.Hide();
                    ExpertiseButton.Show();
                    RemarkDeletedButton.Hide();
                    ToPrintButton.Hide();
                }
                else if (StatusId == (int)CertificateStatus.Issued)
                {
                    SaveButton.Hide();

                    PrintButton.Hide();
                    ExpertiseButton.Hide();
                    RemarkDeletedButton.Hide();
                    ToPrintButton.Hide();
                    LockAllElem();
                }
                else if (StatusId == (int)CertificateStatus.Print)
                {
                    SaveButton.Hide();

                    PrintButton.Show();
                    ExpertiseButton.Hide();
                    RemarkDeletedButton.Hide();
                    ToPrintButton.Hide();
                    LockAllElem();
                }
                else if (StatusId == (int)CertificateStatus.Return)
                {
                    SaveButton.Show();

                    PrintButton.Hide();
                    ExpertiseButton.Hide();
                    RemarkDeletedButton.Show();
                    ToPrintButton.Hide();
                }
            }
            else if (CurrentUser.HasRoles(RoleApp.CheckingCertificateBirth, false))
            {

                SaveButton.Hide();
                PrintButton.Hide();
                ExpertiseButton.Hide();
                RemarkDeletedButton.Hide();
                ToPrintButton.Show();


                LockAllElem();
                UnlockRemBut();
                InitRemBut();
            }

            else if (CurrentUser.HasRoles(RoleApp.Medstatistic, false))
            {
                SaveButton.Hide();
                PrintButton.Hide();
                ExpertiseButton.Hide();
                RemarkDeletedButton.Hide();
                ToPrintButton.Hide();

            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var model = new CertificateEditViewModel(this);
            if (ValidateForm(model))
            {
                var certificate = CertificateId != 0 ? _certificateController.GetById(CertificateId.Value).FirstOrDefault() : new Domain.Classes.CertificateBirth();
                _certificateController.AddOrUpdate(_certificateConfig.CertificateEditToCertihicateBirth(certificate, model));
                this.Close();
            }
        }

        private void ChildUnderAccountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FirstToutnoutDoctorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void WeightChildTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void LengthBodyChildTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var certificate = _certificateController.GetById((int)CertificateId).FirstOrDefault();
            if (!CurrentUser.IsAdmin)
            {
                _certificateController.Reload(certificate);
                certificate.IssuanceDate = DateTime.Now;
                _certificateController.AddOrUpdate(certificate);
            }
            var form = new PrintCertificate((int)CertificateId, CurrentUser.IsAdmin);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void RemarkDeletedButton_Click(object sender, EventArgs e)
        {
            var model = new CertificateEditViewModel(this);
            if (ValidateForm(model))
            {
                var certificate = CertificateId != 0 ? _certificateController.GetById(CertificateId.Value).FirstOrDefault() : new Domain.Classes.CertificateBirth();
                _certificateController.AddOrUpdate(_certificateConfig.CertificateEditToCertihicateBirth(certificate, model));
                _certificateController.ClearRemarks(CertificateId.Value);
                _certificateController.ChangeStatus(CertificateId.Value, (int)CertificateStatus.Expertise);
                this.Close();
            }
           
        }

        private void ExpertiseButton_Click(object sender, EventArgs e)
        {
            var model = new CertificateEditViewModel(this);
            if (ValidateForm(model))
            {
                var certificate = CertificateId != 0 ? _certificateController.GetById(CertificateId.Value).FirstOrDefault() : new Domain.Classes.CertificateBirth();
                certificate = _certificateConfig.CertificateEditToCertihicateBirth(certificate, model);
                certificate.StatusId = (int)CertificateStatus.Expertise;
                _certificateController.AddOrUpdate(certificate);
                this.Close();
            }
        }

        private void ToPrintButton_Click(object sender, EventArgs e)
        {
            _certificateController.ChangeStatus((int)CertificateId, (int)CertificateStatus.Print);
            this.Close();
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ChildBirthPolycarpousUnderAccountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ChildrenBornTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
