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

        private void maeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmMother frm = new FrmMother();
            frm.Show();
        }

        private void criancaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FrmChild frm = new FrmChild();
            frm.Show();
        }

        private void cPNLivroDeConsultaPreNatalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCPN cpn = new FrmCPN();
            cpn.Show();
        }

        private void cCRLivroDeConsultaDeCriançaEmRiscoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCCR ccr = new FrmCCR();
            ccr.Show();
        }

        private void administraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
        }

        private void ppPosPartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCPP cpp = new FrmCPP();
            cpp.Show();
        }

        private void pFPlaneamentoFamiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCPF cpf = new FrmCPF();
            cpf.Show();
        }
    }
}
