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
    }
}
