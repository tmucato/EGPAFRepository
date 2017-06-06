using smiGlobal;
using System;
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
            if (GlobalVariables.USER_IS_LOGGED_IN == true)
            {
                this.Enabled = true;
            }
            else
            {
                this.Enabled = false;
                GlobalVariables.MAIN_FORM = this;
                frmLogin frmlogin = new frmLogin();
                frmlogin.Show();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cPNLivroDeConsultaPreNatalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCPN frm = new frmCPN();
            frm.Show();
        }

        private void criancaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cPNLivroDeConsultaPreNatalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void maeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmMother frm = new FrmMother();
            frm.Show();
        }

        private void criancaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
