using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using smiBLL;

namespace smi
{
    public partial class FrmMother : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FrmMother()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMother_Load(object sender, EventArgs e)
        {
            BinddgvMother();
        }

        /// <summary>
        /// 
        /// </summary>
        private void BinddgvMother()
        {
            try
            {
                clMother mother = new clMother();
                dgvMother.AutoGenerateColumns = false;
                dgvMother.DataSource = mother.GetEntityDatatable();
                dgvMother.Refresh();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdNew_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFormContrls();
                BinddgvMother();
            }
            catch (Exception ex)
            {
                Logger.LogError("Error cleaning mother form", ex);
                MessageBox.Show("Error ao limpar form Mae");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    BinddgvMother();
                }
                else
                {
                    MessageBox.Show("Nenhuma registo selecionada para ser apagada");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error deleting mother form", ex);
                MessageBox.Show("Error apagando registo do sistema");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj_mother"></param>
        private void BindFormMotherControls(clMother obj_mother)
        {
            try
            {
                txtID.Text = obj_mother.id.ToString();
                txtNid_cpn.Text = obj_mother.nid_cpn;
                txtNid_tarv.Text = obj_mother.nid_tarv;
                txtName.Text = obj_mother.name;
                txtResidence.Text = obj_mother.residence;
                txtPhone.Text = obj_mother.phone;
                dtpBithDate.Value = obj_mother.dob;
            }
            catch (Exception ex)
            {
                Logger.LogError("Error binding mother form", ex);
                throw ex;
            }


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
                dtpBithDate.ResetText();
                txtNid_cpn.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    obj_mother.phone = txtPhone.Text;
                    obj_mother.dob = dtpBithDate.Value;

                    if (string.IsNullOrWhiteSpace(txtID.Text))
                    {
                        obj_mother.InsertEntity();
                    }
                    else
                    {
                        obj_mother.id = Convert.ToInt32(txtID.Text);
                        obj_mother.UpdateEntity();
                    }
                    BinddgvMother();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error sumiting mother form", ex);
                MessageBox.Show("Error inserindo Mãe");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool validate_fields()
        {
            bool result = false;

            try
            {
                if (String.IsNullOrWhiteSpace(txtNid_cpn.Text))
                {
                    MessageBox.Show("O campo do NID CPN encontra-se vazio");
                    return result;
                }
                if (string.IsNullOrWhiteSpace(txtNid_tarv.Text))
                {
                    MessageBox.Show("O campo do NID TARV encontra-se vazio");
                    return result;
                }
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("O campo do Nome encontra-se vazio");
                    return result;
                }
                if (string.IsNullOrWhiteSpace(txtResidence.Text))
                {
                    MessageBox.Show("O campo do residencia encontra-se vazio");
                    return result;
                }
                if (!Functions.IsNumber(txtPhone.Text))
                {
                    MessageBox.Show("O numero de telefone invalido");
                    return result;
                }
                if (!Functions.IsDate(dtpBithDate.Text))
                {
                    MessageBox.Show("O data de nascimento inserida é invalida");
                    return result;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdProcurar_Click(object sender, EventArgs e)
        {
            string searchValueTxt = txtSearched.Text.Trim().ToUpper();
            string strgrdvalue = "";
            int rowIndex = -1;

            int selectIndex = cbProcurar.SelectedIndex;

            switch (selectIndex)
            {
                /// Serch by ID Mother
                case 0:


                    //long searchValueInt = Convert.ToInt64(txtSearched.Text);
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            strgrdvalue = dgvMother.Rows[row].Cells[6].Value.ToString().Trim().ToUpper();
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
                /// Search NID CPN
                case 1:
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            // if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["nid_cpn"].Value.ToString().Equals(searchValueTxt))
                            strgrdvalue = dgvMother.Rows[row].Cells[0].Value.ToString().ToUpper();
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
                            MessageBox.Show("NID de CPN : " + txtSearched.Text, "Nao encontrado");
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                ///Search by NID TARV
                case 2:
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            // if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["nid_tarv"].Value.ToString().Equals(searchValueTxt))
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
                            MessageBox.Show("NID de TARV : " + txtSearched.Text, "Nao encontrado");
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                /// Sreach by Name
                case 3:
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            //if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["name"].Value.ToString().Equals(searchValueTxt))
                            strgrdvalue = dgvMother.Rows[row].Cells[2].Value.ToString().ToUpper();
                            if (strgrdvalue.Trim().ToLower() == searchValueTxt.Trim().ToLower())
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
                            MessageBox.Show("Nome : " + txtSearched.Text, "Nao encontrado");
                            return;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    break;
                /// Search by Phone contact
                case 4:
                    dgvMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        bool valueResulet = true;
                        int row = 0;
                        while (row < dgvMother.Rows.Count - 1)
                        {
                            //if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["name"].Value.ToString().Equals(searchValueTxt))
                            strgrdvalue = dgvMother.Rows[row].Cells[4].Value.ToString().ToUpper();
                            if (strgrdvalue == searchValueTxt)
                            {
                                rowIndex = row;
                                dgvMother.Rows[rowIndex].Selected = true;
                                dgvMother.CurrentCell = dgvMother.Rows[rowIndex].Cells[4];
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


        private void dgvMother_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var Grid = (DataGridView)sender;
                clMother obj_mother = new clMother();

                if (e.RowIndex >= 0)
                {
                    int motherID = (int)Grid.Rows[e.RowIndex].Cells[6].Value;
                    BindFormMotherControls(obj_mother.GetEntityList().Where(m => m.id == motherID).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error loading mother data to form", ex);
                MessageBox.Show("Error carregando informacao da mãe no sistema");
            }
        }
    }
}
