using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using smiDAL;
using smiBLL;
using Microsoft.VisualBasic;

namespace smi
{
    public partial class FrmMother : Form
    {

        public FrmMother()
        {
            InitializeComponent();
        }

        private void FrmMother_Load(object sender, EventArgs e)
        {
            clMother mother = new clMother();
            dgvMother.AutoGenerateColumns = false;
            dgvMother.DataSource = mother.getMotherDataTable();
            dgvMother.Refresh();
        }


        private void dgvMother_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Grid = (DataGridView)sender;
            clMother obj_mother = new clMother();

            if (Grid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                int motherID = (int)Grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                BindBindFormControls(obj_mother.GetEntityList().Where(m => m.id == motherID).FirstOrDefault());
            }
        }


        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFormContrls();
            }
            catch (Exception ex)
            {
                Logger.LogError("Error cleaning mother form", ex);
                MessageBox.Show("Error ao limpar form Mae");
            }

        }

        private void BindBindFormControls(clMother obj_mother)
        {
            txtID.Text = obj_mother.id.ToString();
            txtNid_cpn.Text = obj_mother.nid_cpn;
            txtNid_tarv.Text = obj_mother.nid_tarv;
            txtName.Text = obj_mother.name;
            txtResidence.Text = obj_mother.residence;
            txtPhone.Text = obj_mother.phone;
            txtDob.Text = obj_mother.dob.ToString("dd/MM/yyyy");

        }

        /// <summary>
        /// Clear all control on tre form
        /// </summary>
        private void ClearFormContrls()
        {
            try
            {
                dgvMother.ClearSelection();
                txtID.Clear();
                txtNid_cpn.Clear();
                txtNid_tarv.Clear();
                txtName.Clear();
                txtResidence.Clear();
                txtPhone.Clear();
                txtDob.Clear();
                txtNid_cpn.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate_fields())
                {
                    clMother obj_mother = new clMother();

                    obj_mother.nid_cpn = txtNid_cpn.Text;
                    obj_mother.nid_tarv = txtNid_tarv.Text;
                    obj_mother.name = txtName.Text;
                    obj_mother.residence = txtResidence.Text;
                    obj_mother.phone = txtPhone.Name;
                    obj_mother.dob = Convert.ToDateTime(txtDob.Text);

                    if (string.IsNullOrWhiteSpace(txtID.Text))
                    {
                        
                        obj_mother.InsertEntity();
                    }
                    else
                    {
                        obj_mother.id = Convert.ToInt32(txtID.Text);
                        obj_mother.UpdateEntity();
                    }

                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error sumiting mother form", ex);
                MessageBox.Show("Error inserindo Mãe");
            }
        }

        private bool validate_fields()
        {
            bool result = false;

            try
            {
                if (String.IsNullOrWhiteSpace(txtNid_cpn.Text))
                {
                    MessageBox.Show("O campo do NID CPN encontra-se vazio");
                }

                if (string.IsNullOrWhiteSpace(txtNid_tarv.Text))
                {
                    MessageBox.Show("O campo do NID TARV encontra-se vazio");
                }
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("O campo do Nome encontra-se vazio");
                }
                if (string.IsNullOrWhiteSpace(txtResidence.Text))
                {
                    MessageBox.Show("O campo do residencia encontra-se vazio");
                }
                if (!Functions.IsNumber(txtPhone.Text))
                {
                    MessageBox.Show("O numero de telefone invalido");
                }
                if (!Functions.IsDate(txtDob.Text))
                {
                    MessageBox.Show("O data de nascimento inserida é invalida");
                }
                result = true;

            }
            catch (Exception ex)
            {
                Logger.LogError("Error sumiting mother form", ex);
                MessageBox.Show("Error inserindo mae");
            }

            return result;

        }


        private void cmdMotApagar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(txtID.Text))
                {
                    int motherID = Convert.ToInt32(txtID.Text);
                    clMother obj_mother = new clMother();
                    obj_mother = obj_mother.GetEntityList().Where(m => m.id == motherID).FirstOrDefault();
                    obj_mother.DeleteEntity();
                }
                else
                {
                    MessageBox.Show("Nenhuma Mãe selecionada para ser apagada");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error deleting mother form", ex);
                MessageBox.Show("Error apagando Mãe do sistema");
            }
        }


        private void cmdProcurar_Click(object sender, EventArgs e)
        {
            string searchValueTxt = txtSearched.Text.Trim().ToUpper();
            string strgrdvalue = "";
            int rowIndex = -1;

            int selectIndex = cbProcurar.SelectedIndex;

            switch (selectIndex)
            {
                case 0:


                    //long searchValueInt = Convert.ToInt64(txtSearched.Text);
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            strgrdvalue = dgvMother.Rows[row].Cells[0].Value.ToString().Trim().ToUpper();
                            if (strgrdvalue == searchValueTxt)
                            {
                                rowIndex = row;
                                dgvMother.Rows[rowIndex].Selected = true;
                                dgvMother.CurrentCell = dgvMother.Rows[rowIndex].Cells[0];
                                rowIndex++;
                                valueResulet = false;
                                break;
                            }
                            row++;
                        }
                        if (valueResulet != false)
                        {
                            MessageBox.Show("ID : " + txtSearched.Text.Trim(), "Nao encontrado");
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                case 1:
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            // if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["nid_cpn"].Value.ToString().Equals(searchValueTxt))
                            strgrdvalue = dgvMother.Rows[row].Cells[1].Value.ToString().ToUpper();
                            if (strgrdvalue == searchValueTxt)
                            {
                                rowIndex = row;
                                dgvMother.Rows[rowIndex].Selected = true;
                                dgvMother.CurrentCell = dgvMother.Rows[rowIndex].Cells[1];
                                rowIndex++;
                                valueResulet = false;
                                break;
                            }
                            row++;
                        }
                        if (valueResulet != false)
                        {
                            MessageBox.Show("NID de PTV : " + txtSearched.Text, "Nao encontrado");
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                case 2:
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            // if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["nid_tarv"].Value.ToString().Equals(searchValueTxt))
                            strgrdvalue = dgvMother.Rows[row].Cells[2].Value.ToString().ToUpper();
                            if (strgrdvalue == searchValueTxt)
                            {
                                rowIndex = row;
                                dgvMother.Rows[rowIndex].Selected = true;
                                dgvMother.CurrentCell = dgvMother.Rows[rowIndex].Cells[2];
                                rowIndex++;
                                valueResulet = false;
                                break;
                            }
                            row++;
                        }
                        if (valueResulet != false)
                        {
                            MessageBox.Show("NID de TARV : " + txtSearched.Text, "Nao encontrado");
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                case 3:
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            //if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["name"].Value.ToString().Equals(searchValueTxt))
                            strgrdvalue = dgvMother.Rows[row].Cells[3].Value.ToString().ToUpper();
                            if (strgrdvalue == searchValueTxt)
                            {
                                rowIndex = row;
                                dgvMother.Rows[rowIndex].Selected = true;
                                dgvMother.CurrentCell = dgvMother.Rows[rowIndex].Cells[3];
                                rowIndex++;
                                valueResulet = false;
                                break;

                            }
                            row++;
                        }
                        if (valueResulet != false)
                        {
                            MessageBox.Show("Nome : " + txtSearched.Text, "Nao encontrado");
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                case 4:
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            //if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["name"].Value.ToString().Equals(searchValueTxt))
                            strgrdvalue = dgvMother.Rows[row].Cells[5].Value.ToString().ToUpper();
                            if (strgrdvalue == searchValueTxt)
                            {
                                rowIndex = row;
                                dgvMother.Rows[rowIndex].Selected = true;
                                dgvMother.CurrentCell = dgvMother.Rows[rowIndex].Cells[5];
                                rowIndex++;
                                valueResulet = false;
                                break;
                            }
                            row++;
                        }
                        if (valueResulet != false)
                        {
                            MessageBox.Show("Contacto : " + txtSearched.Text, "Nao encontrado");
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
            }

        }

    }
}
