﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Project
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void tsbExitFrmOS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}