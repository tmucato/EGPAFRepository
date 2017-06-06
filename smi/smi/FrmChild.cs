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

        private void BindFormChildControls(clChild obj_child)
        {
            try
            {
                txtID.Text = obj_child.id.ToString();
                txtName.Text = obj_child.name;
                txtNid_ccr.Text = obj_child.nid_ccr;
                txtNidMaeCpn.Text = obj_child.mot_nid_cpn;
                txtPhone.Text = obj_child.phone;
                txtResidence.Text = obj_child.residence;
                txtDataNascimento.Text = obj_child.dob.ToString("dd/MM/yyyy");
                cbxGenero.SelectedText = obj_child.gender;

            }
            catch (Exception ex)
            {
                Logger.LogError("Error binding child form", ex);
                throw;
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {




        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {




        }

        private void cmdMotApagar_Click(object sender, EventArgs e)
        {





        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvChild_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var Grid = (DataGridView)sender;
                clChild obj_child = new clChild();

                if (Grid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
                {
                    int childID = (int)Grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    BindFormChildControls(obj_child.GetEntityList().Where(c => c.id == childID).FirstOrDefault());
                }


            }
            catch (Exception ex)
            {
                Logger.LogError("Error loading child data to form", ex);
                MessageBox.Show("Error carregando informacao da criança no sistema");

            }




        }
    }
}
