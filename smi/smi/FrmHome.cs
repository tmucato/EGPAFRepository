﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace smi
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaciente frm = new FrmPaciente();
            frm.Show();
        }

        private void cPNLivroDeConsultaPreNatalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCPN frm = new frmCPN();
            frm.Show();
        }

       
       
    }
}
