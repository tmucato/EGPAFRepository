using smiBLL;
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
    public partial class FrmChild : Form
    {
        public FrmChild()
        {
            InitializeComponent();
        }


        private void FrmChild_Load(object sender, EventArgs e)
        {
            BinddgvMother();
        }

        private void BinddgvMother()
        {
            try
            {
                clChild child = new clChild();
                dgvChild.AutoGenerateColumns = false;
                dgvChild.DataSource = child.getChidDataTable();
                dgvChild.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
