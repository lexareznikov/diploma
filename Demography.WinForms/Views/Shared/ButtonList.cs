using Demography.Infrastructure.Domain;
using Demography.Infrastructure.Enums;
using Demography.Infrastructure.Utility;
using Demography.WinForms.Utility;
using Demography.WinForms.Views.CertificateBirth;
using Demography.WinForms.Views.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demography.WinForms.Views.Shared
{
    public partial class ButtonList : Form
    {
        public ButtonList( string textForm, int buttonType)
        {
            InitializeComponent();
            ButtonsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            ButtonsFlowLayoutPanel.AutoSize = true;
            if (buttonType == (int)SwitchButtonsType.Directories)
            {
                var users = new Button()
                {
                    Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204),
                    Name = "UsersButton",
                    Size = new Size(339, 74),
                    Text = "Пользователи",
                    UseVisualStyleBackColor = true
                };
                users.Click += ListUsersButton_Click;
                ButtonsFlowLayoutPanel.Controls.Add(users);
                var mo = new Button()
                {
                    Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204),
                    Name = "MOButton",
                    Size = new Size(339, 74),
                    Text = "Мед. организация",
                    UseVisualStyleBackColor = true
                };
                mo.Click += MoButton_Click;
                ButtonsFlowLayoutPanel.Controls.Add(mo);
                
            }
            else if (buttonType == (int)SwitchButtonsType.CertificatesList)
            {
                var certificatesBirth = new Button()
                {
                    Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204),
                    Name = "CertificatesBirthButton",
                    Size = new Size(339, 74),
                    Text = "Список родившихся",
                    UseVisualStyleBackColor = true
                };
                certificatesBirth.Click +=  ListCertificatesButton_Click;
                ButtonsFlowLayoutPanel.Controls.Add(certificatesBirth);
                if (CurrentUser.HasPermission(false,PermissionsApp.CerBirthEdit))
                {
                    var certificatesWithRemarks = new Button()
                    {
                        Font = new Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204),
                        Name = "CertificatesWithRemarksButton",
                        Size = new Size(339, 74),
                        Text = "Список родившихся с замечаниями",
                        UseVisualStyleBackColor = true
                    };
                    certificatesWithRemarks.Click += ListCertificatesRemarksButton_Click;
                    ButtonsFlowLayoutPanel.Controls.Add(certificatesWithRemarks);
                }
               
                this.Location = new Point(350, 3);
            }
            this.AutoSize = true;
            Text = textForm;
        }
        public int ReturnButton { get; private set; }
        private void ListCertificatesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Abort;
            ReturnButton = (int)SwitchButtonsType.CertificatesList;
            
        }
        private void ListCertificatesRemarksButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Abort;
            ReturnButton = (int)SwitchButtonsType.CertificatesRemarks;
            
        }

        private void ListUsersButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Abort;
            ReturnButton = (int)SwitchButtonsType.Users;
            
        }
        private void MoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Abort;
            ReturnButton = (int)SwitchButtonsType.MO;

        }
        private void ButtonList_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
