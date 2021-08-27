using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Controllers;
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

namespace Demography.WinForms.Views.Report
{
    public partial class ReportView : Form
    {
        public int ReturnButton { get; private set; }
        private ReportController _reportController { get; set; }
        public ReportView()
        {
            InitializeComponent();
            _reportController = new ReportController();
            var model = _reportController.GetReport();

            AllMotherLabel.Text = model.AllMother;
            AllBoysLabel.Text = model.AllBoys;
            AllGerlsLabel.Text = model.AllGirls;

            Before16BoysLabel.Text = model.Before16Boys;
            Before16GirlsLabel.Text = model.Before16Girls;
            Before16MotherLabel.Text = model.Before16Mother;

            Between1720MotherLabel.Text = model.Between1720Mother;
            Between1720BoysLabel.Text = model.Between1720Boys;
            Between1720GirlsLabel.Text = model.Between1720Girls;

            Between2125MotherLabel.Text = model.Between2125Mother;
            Between2125BoysLabel.Text = model.Between2125Boys;
            Between2125GirlsLabel.Text = model.Between2125Girls;

            Between2635MotherLabel.Text = model.Between2635Mother;
            Between2635BoysLabel.Text = model.Between2635Boys;
            Between2635GirlsLabel.Text = model.Between2635Girls;

            Between3645MotherLabel.Text = model.Between3645Mother;
            Between3645BoysLabel.Text = model.Between3645Boys;
            Between3645GirlsLabel.Text = model.Between3645Girls;

            After45MotherLabel.Text = model.After45Mother;
            After45BoysLabel.Text = model.After45Boys;
            After45GirlsLabel.Text = model.After45Girls;
            ButtonsWithProfileAndPermission();
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

        private void BlankButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Blanks;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Profile;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReturnButton = (int)SwitchButtonsType.Reports;
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }
    }
}
