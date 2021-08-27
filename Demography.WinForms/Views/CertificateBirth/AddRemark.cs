using Demography.WinForms.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demography.WinForms.Views.CertificateBirth
{
    public partial class AddRemark : Form
    {
        private string RemarkText { get { return RemarkRichTextBox.Text; }}
        private int CertificateId { get; set; }
        private string FieldName { get; set; }
        public string Text { get; set; }
        private CertificateBirthController _certificateBirthController;
        public AddRemark(int certificateId,string fieldName)
        {
            InitializeComponent();
            _certificateBirthController = new CertificateBirthController();
            CertificateId = certificateId;
            FieldName = fieldName;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _certificateBirthController.AddRemark(CertificateId, FieldName, RemarkText);
            Text = RemarkText;
            DialogResult = DialogResult.Yes;

        }
    }
}
