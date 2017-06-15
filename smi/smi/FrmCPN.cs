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
    public partial class FrmCPN : Form
    {
        public FrmCPN()
        {
            InitializeComponent();
        }

        private void btnAnteriorPage2_Click(object sender, EventArgs e)
        {
            this.tabCPN.SelectedIndex = 0;
        }

        private void btnProximoPage2_Click(object sender, EventArgs e)
        {
            this.tabCPN.SelectedIndex = 2;
        }

        private void btnProximoPage1_Click(object sender, EventArgs e)
        {
            this.tabCPN.SelectedIndex = 1;
        }

        private void btnBuscarMain_Click(object sender, EventArgs e)
        {
            clCPN cpn;
            clCPNFinal cpn_final;

            try
            {
                if (!string.IsNullOrWhiteSpace(txtNidCpnMain.Text))
                {
                    string NidCpn = txtNidCpnMain.Text;
                    clMother moth = new clMother();
                    List<clMother> List_moth;
                    List_moth = moth.GetEntityList().Where(m => m.nid_cpn == NidCpn).ToList();
                    if (List_moth.Count > 0)
                    {
                        moth = List_moth.FirstOrDefault();
                        BindMotherControls(moth);
                        cpn = new clCPN();
                        List<clCPN> list_cpn = new List<clCPN>();
                        list_cpn = cpn.GetEntityList().Where(c => c.idmother == moth.id).ToList();

                        if (list_cpn.Count > 0)
                        {
                            cpn_final = new clCPNFinal();
                            cpn_final = cpn_final.GetEntityList().Where(cf => cf.idmother == moth.id).FirstOrDefault();
                            BindCPNFinalControls(cpn_final);

                            if (cbxNrConsultaMain.SelectedIndex >= 0)
                            {
                                cpn = new clCPN();
                                cpn = list_cpn.Where(c => c.nr_consulta == Convert.ToInt32(Functions.ConvertComboConsultToNumb(cbxNrConsultaMain.SelectedItem.ToString()))).FirstOrDefault();
                                BindCPNControls(cpn);
                            }
                        }
                        else
                        {
                            for (int i = 1; i < 7; i++)
                            {
                                cpn = new clCPN();
                                cpn.idmother = moth.id;
                                cpn.nr_consulta = i;
                                cpn.InsertEntity();

                                if (i == 1)
                                {
                                    cpn_final = new clCPNFinal();
                                    cpn_final.idmother = moth.id;
                                    cpn_final.InsertEntity();
                                }
                            }
                            cpn_final = new clCPNFinal();
                            cpn_final = cpn_final.GetEntityList().Where(cf => cf.idmother == moth.id).FirstOrDefault();
                            BindCPNFinalControls(cpn_final);

                            if (cbxNrConsultaMain.SelectedIndex >= 0)
                            {
                                cpn = new clCPN();
                                cpn = list_cpn.Where(c => c.nr_consulta == Convert.ToInt32(cbxNrConsultaMain.SelectedText)).FirstOrDefault();
                                BindCPNControls(cpn);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não encontrada na base de dados uma mão com o NIC CPN igual a " + txtNidCpnMain.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BindMotherControls(clMother moth)
        {
            try
            {
                txtNidTarv.Text = moth.nid_tarv;
                txtNome.Text = moth.name;
                txtResidencia.Text = moth.residence;
                txtTelefone.Text = moth.phone;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BindCPNControls(clCPN cpn)
        {

            try
            {
                cbxNrConulta.SelectedItem = Functions.ConvertNumbComboConsult(cpn.nr_consulta);
                dtpDataConsulta.Value = cpn.visdate;
                txtIdadeGest.Text = cpn.gestationalage.ToString();
                if (cpn.partnerpresence != null)
                    cbxParPresent.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.partnerpresence));
                if (!string.IsNullOrWhiteSpace(cpn.agegroup))
                    cbxFaixaEtaria.SelectedItem = cpn.agegroup;
                if (cpn.gageless12 != null)
                    cbxIdaMen12Sem.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.gageless12));
                txtPeso.Text = cpn.weight.ToString();
                if (cpn.dam != null)
                    cbxDAM.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.dam));
                if (cpn.dag != null)
                    cbxDAG.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.dag));
                if (!string.IsNullOrWhiteSpace(cpn.resultcured))
                    cbxCurada.SelectedItem = cpn.resultcured;
                if (!string.IsNullOrWhiteSpace(cpn.weightgainyno))
                    cbxGanhoMaior15.SelectedItem = cpn.weightgainyno;
                txtRecSuplNutrQty.Text = cpn.supnutr.ToString();
                if (!string.IsNullOrWhiteSpace(cpn.receiveddesparasitante))
                    cbxRecDesparasitante.SelectedItem = cpn.receiveddesparasitante;
                if (!string.IsNullOrWhiteSpace(cpn.salferr_acfolico))
                    cbxSalFerrAcFol.SelectedItem = cpn.salferr_acfolico;
                if (!string.IsNullOrWhiteSpace(cpn.ta))
                    cbxtensaoArte.SelectedItem = cpn.ta;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void BindCPNFinalControls(clCPNFinal cnp_fin)
        {

        }

        private void btnGravarMain_Click(object sender, EventArgs e)
        {

        }

        private void btnAnteriorPage3_Click(object sender, EventArgs e)
        {
            this.tabCPN.SelectedIndex = 1;
        }

        private void cbxNrConsultaMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
