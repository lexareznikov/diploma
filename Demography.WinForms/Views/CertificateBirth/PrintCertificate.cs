using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Controllers;
using Devart.Data.PostgreSql;
using FastReport;
using FastReport.Export;
using FastReport.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demography.WinForms.Views.CertificateBirth
{
    public partial class PrintCertificate : Form
    {
        private FastReport.Report FReport;
        private int CertificateId {  get; set; }
        private CertificateBirthController _certificateBirthController;
        public PrintCertificate(int idcert,bool isCopy = true)
        {
            try
            {
                InitializeComponent();
                _certificateBirthController = new CertificateBirthController();
                CertificateId = idcert;
                var pgConnectionStringBuilder = new PgSqlConnectionStringBuilder
                {
                    UserId = "postgres",
                    Password = "sys123",
                    Host = "localhost",
                    Database = "demography_last_task",
                    DefaultCommandTimeout = 300,
                    Schema ="dem",
                    Charset = "utf8"
                };
               
                FReport = new FastReport.Report();

                FReport.Preview = preview1;
                var stream = new MemoryStream(isCopy? Properties.Resources.CertificateOfBirthcopy: Properties.Resources.CertificateOfBirth);
                
                FReport.Load(stream);
                FReport.Report.SetParameterValue("ConnectionString", pgConnectionStringBuilder.ConnectionString); 
                FReport.Report.SetParameterValue("CertificateId", CertificateId);
                FReport.Prepare();
                FReport.ShowPrepared();
                if(isCopy)
                {
                    PrintedButton.Hide();
                }
            }
            catch (Exception ex)
            {
                var t = ex.Message;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            preview1.Print();
        }



        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            preview1.ZoomOut();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            preview1.ZoomIn();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            preview1.First();
        }

        private void btnPrior_Click(object sender, EventArgs e)
        {
            preview1.Prior();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            preview1.Next();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            preview1.Last();
        }

        private void tbPageNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                preview1.PageNo = int.Parse(tbPageNo.Text);
            }
        }

        private void preview1_PageChanged(object sender, EventArgs e)
        {
            tbPageNo.Text = preview1.PageNo.ToString();
        }

        private void PrintedButton_Click(object sender, EventArgs e)
        {
            _certificateBirthController.ChangeStatus(CertificateId, (int)CertificateStatus.Issued);
            DialogResult = DialogResult.OK;
        }
    
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
