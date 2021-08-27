﻿using System;
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
    public partial class Okey : Form
    {
        public Okey(string message)
        {
            InitializeComponent();
            MessageRichTextBox.Text = message;
            MessageRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}