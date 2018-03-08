using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smi
{
    public partial class FrmCPP : Form
    {
        public FrmCPP()
        {
            InitializeComponent();
        }

        private void btnProximaPagina_Click(object sender, EventArgs e)
        {
            this.tabCPP.SelectedIndex = 1;
        }

        private void btnAnteriorPage_Click(object sender, EventArgs e)
        {
            this.tabCPP.SelectedIndex = 0;
        }

        private void btnBuscarMain_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrWhiteSpace(txtNidCCR.Text))
                {


                }








                }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cbxNrConsultaMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {










            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnGravarMain_Click(object sender, EventArgs e)
        {
            try
            {








            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
