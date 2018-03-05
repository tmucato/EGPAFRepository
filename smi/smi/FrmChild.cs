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
            BinddgvChild();
        }

        private void BinddgvChild()
        {
            try
            {
                clChild child = new clChild();
                dgvChild.AutoGenerateColumns = false;
                dgvChild.DataSource = child.GetEntityDatatable();
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
                ClearFormContrls();
                txtID.Text = obj_child.id.ToString();
                txtName.Text = obj_child.name;
                txtNid_ccr.Text = obj_child.nid_ccr;
                txtNidMaeCpn.Text = obj_child.mot_nid_cpn;
                txtPhone.Text = obj_child.phone;
                txtResidence.Text = obj_child.residence;
                dtpBirthDate.Value = obj_child.dob;
                cbxGenero.SelectedText = obj_child.gender;

            }
            catch (Exception ex)
            {
                Logger.LogError("Error binding child form", ex);
                throw;
            }
        }






        private void ClearFormContrls()
        {
            try
            {
                dgvChild.ClearSelection();
                txtID.Clear();
                dtpBirthDate.ResetText();
                txtName.Clear();
                txtNidMaeCpn.Clear();
                txtNid_ccr.Clear();
                txtPhone.Clear();
                txtResidence.Clear();
                txtSearched.Clear();
                cbxGenero.Text = string.Empty;
                txtNid_ccr.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnChildNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFormContrls();
                BinddgvChild();

            }
            catch (Exception ex)
            {
                Logger.LogError("Error cleaning mother form", ex);
                MessageBox.Show("Error ao limpar form Mae");
            }
        }

        private void btnChildSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate_fields())
                {
                    clChild obj_child = new clChild();
                    obj_child.gender = cbxGenero.Text;
                    obj_child.dob = dtpBirthDate.Value;
                    obj_child.mot_nid_cpn = txtNidMaeCpn.Text;
                    obj_child.name = txtName.Text;
                    obj_child.nid_ccr = txtNid_ccr.Text;
                    obj_child.phone = txtPhone.Text;
                    obj_child.residence = txtResidence.Text;


                    if (string.IsNullOrWhiteSpace(txtID.Text))
                    {
                        obj_child.InsertEntity();
                    }
                    else
                    {
                        obj_child.id = Convert.ToInt32(txtID.Text);
                        obj_child.UpdateEntity();
                    }

                    BinddgvChild();
                    ClearFormContrls();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool validate_fields()
        {
            bool result = false;


            try
            {

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("O campo do Nome encontra-se vazio");
                    return result;
                }

                if (string.IsNullOrWhiteSpace(txtNidMaeCpn.Text))
                {
                    MessageBox.Show("O campo do Nid Mae CPN encontra-se vazio");
                    return result;
                }

                if (!Functions.IsValidMother(txtNidMaeCpn.Text))
                {
                    MessageBox.Show("O NID CPN da mãe não encontrado na Base de dados");
                    return result;
                }


                if (string.IsNullOrWhiteSpace(txtNid_ccr.Text))
                {
                    MessageBox.Show("O campo do Nid CCR encontra-se vazio");
                    return result;
                }

                if (!Functions.IsNumber(txtPhone.Text))
                {
                    MessageBox.Show("O campo do telefone encontra-se vazio");
                    return result;
                }


                if (string.IsNullOrWhiteSpace(txtResidence.Text))
                {
                    MessageBox.Show("O campo do residencia encontra-se vazio");
                    return result;
                }

                if (cbxGenero.SelectedIndex < 0)
                {
                    MessageBox.Show("O campo do genero encontra-se vazio");
                    return result;
                }

                if (!Functions.IsDate(dtpBirthDate.Text))
                {
                    MessageBox.Show("O campo do data de nascimento comtem uma data nao valida");
                    return result;
                }


                result = true;


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return result;
        }

        private void cmdChildApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text))
                {
                    int childID = Convert.ToInt32(txtID.Text);
                    clChild obj_child = new clChild();
                    obj_child = obj_child.GetEntityList().Where(c => c.id == childID).FirstOrDefault();
                    obj_child.DeleteEntity();
                    BinddgvChild();
                }
                else
                {
                    MessageBox.Show("Nenhuma registo selecionada para ser apagada");
                }
            }
            catch (Exception ex)
            {

                Logger.LogError("Error deleting child form", ex);
                MessageBox.Show("Error apagando registo do sistema");
            }
        }

        private void dgvChild_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var Grid = (DataGridView)sender;
                clChild obj_child = new clChild();
                if (e.RowIndex >= 0)
                {
                    int childID = (int)Grid.Rows[e.RowIndex].Cells[7].Value;
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
