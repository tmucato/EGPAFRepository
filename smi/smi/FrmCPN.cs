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
                if (!string.IsNullOrWhiteSpace(cpn.hgb))
                    cbxHemoglobina.SelectedItem = cpn.hgb;
                if (!string.IsNullOrWhiteSpace(cpn.proteinuria))
                    cbxlblProteinuria.SelectedItem = cpn.proteinuria;
                if (!string.IsNullOrWhiteSpace(cpn.glicosuria))
                    cbxGlicosuria.SelectedItem = cpn.glicosuria;
                if (cpn.its_ulceragenital != null)
                    cbxUlcera.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.its_ulceragenital));
                if (cpn.its_leucorreia != null)
                    cbxLeucorreia.SelectedItem = cpn.its_leucorreia;
                if (!string.IsNullOrWhiteSpace(cpn.its_syndromictreatment))
                    cbxSindromicoITS.SelectedItem = cpn.its_syndromictreatment;
                if (!string.IsNullOrWhiteSpace(cpn.its_syphilistesting))
                    cbxTesteSiflis.SelectedItem = cpn.its_syphilistesting;
                if (!string.IsNullOrWhiteSpace(cpn.its_syphilistratmentmulhr))
                    cbxtratSiflMulher.SelectedItem = cpn.its_syphilistratmentmulhr;
                if (!string.IsNullOrWhiteSpace(cpn.its_syphilistratmentparceir))
                    cbxtratSiflParceiro.SelectedItem = cpn.its_syphilistratmentparceir;
                if (!string.IsNullOrWhiteSpace(cpn.serostatusentcpn))
                    cbxSerEstad1CPN.SelectedItem = cpn.serostatusentcpn;
                if (!string.IsNullOrWhiteSpace(cpn.cpnhivtest))
                    cbxtesteHivCpn.SelectedItem = cpn.cpnhivtest;
                if (!string.IsNullOrWhiteSpace(cpn.partnerhivtest))
                    cbxTesteParceiro.SelectedItem = cpn.partnerhivtest;
                if (cpn.ctz != null)
                    cbxCTZEntrada.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.ctz));
                if (!string.IsNullOrWhiteSpace(cpn.ctz_init_cont))
                    cbxIniContCTZ.SelectedItem = cpn.ctz_init_cont;
                if (cpn.tarv_init_visit != null)
                    cbxEmTarvEntrada.SelectedItem = cpn.tarv_init_visit;
                if (cpn.tarv_init_visit != null)
                    cbxIniTarvVis.SelectedItem = cpn.tarv_init_visit;
                if (cpn.arv_cont != null)
                    cbxContARVVisita.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.arv_cont));
                if (cpn.nvp != null)
                    cbxNVPVisita.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.nvp));
                if (cpn.azt_nvp != null)
                    cbxIniBiproAZTNVP.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.azt_nvp));
                if (!string.IsNullOrWhiteSpace(cpn.tip))
                    cbxRecebeiTip.SelectedItem = cpn.tip;
                if (!string.IsNullOrWhiteSpace(cpn.bednet))
                    cbxRecRedeMosqu.SelectedItem = cpn.bednet;
                if (!string.IsNullOrWhiteSpace(cpn.tdr_htz))
                    cbxTDRHTZ.SelectedItem = cpn.tdr_htz;
                if (!string.IsNullOrWhiteSpace(cpn.result_tdr_htz))
                    cbxResultadoTDRHTZ.SelectedItem = cpn.result_tdr_htz;
                if (!string.IsNullOrWhiteSpace(cpn.pos_malaria_treated))
                    cbxMulhTesteMalPosTrat.SelectedItem = cpn.pos_malaria_treated;
                if (!string.IsNullOrWhiteSpace(cpn.tb_isoniazid))
                    cbxProfIson.SelectedItem = cpn.tb_isoniazid;
                if (!string.IsNullOrWhiteSpace(cpn.tb_treatment))
                    cbxTratTB.SelectedItem = cpn.tb_treatment;
                if (!string.IsNullOrWhiteSpace(cpn.hpp))
                    cbxHPP.SelectedItem = cpn.hpp;
                if (cpn.vat_1_dose != null)
                    cbxVat1Dose.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.vat_1_dose));
                if (cpn.vat_2_5_dose != null)
                    cbxVat2_5Dose.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn.vat_2_5_dose));
                txtObs.Text = cpn.obs;
                txtNomeProf.Text = cpn.providername;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void BindCPNFinalControls(clCPNFinal cpn_fin)
        {
            try
            {
                if (cpn_fin.cons_more4 != null)
                    cbxFinalMaisConsult.SelectedValue = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.cons_more4));
                if (cpn_fin.partnerpreence != null)
                    cbxFinalParcePrese.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.partnerpreence));
                if (!string.IsNullOrWhiteSpace(cpn_fin.weightgainyno))
                    cbxFinalGanho15.SelectedItem = cpn_fin.weightgainyno;
                if (cpn_fin.dag != null)
                    cbxFinalDAG.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.dag));
                if (cpn_fin.dam != null)
                    cbxFinalDAG.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.dam));
                if (!string.IsNullOrWhiteSpace(cpn_fin.supnutr))
                    cbxFinalRecSuplNutri.SelectedItem = cpn_fin.supnutr;
                if (!string.IsNullOrWhiteSpace(cpn_fin.resultcured))
                    cbxFinalCuradoDesntr.SelectedItem = cpn_fin.resultcured;
                if (!string.IsNullOrWhiteSpace(cpn_fin.resultabandon))
                    cbxFinalAbandDesnutr.SelectedItem = cpn_fin.resultabandon;
                if (!string.IsNullOrWhiteSpace(cpn_fin.receiveddesparasitante))
                    cbxFinalRecDespara.SelectedItem = cpn_fin.receiveddesparasitante;
                if (cpn_fin.salferr_more3 != null)
                    cbxFinalSalFerrMais3.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.salferr_more3));
                if (cpn_fin.its_diag != null)
                    cbxFinalDiagITS.SelectedItem = cpn_fin.its_diag;
                if (!string.IsNullOrWhiteSpace(cpn_fin.its_treatment))
                    cbxFinalTratITS.SelectedItem = cpn_fin.its_treatment;
                if (!string.IsNullOrWhiteSpace(cpn_fin.its_syphilistesting))
                    cbxFinalTestSiflis.SelectedItem = cpn_fin.its_syphilistesting;
                if (cpn_fin.its_wsyphilistreat != null)
                    cbxFinalTratSiflMulher.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.its_wsyphilistreat));
                if (!string.IsNullOrWhiteSpace(cpn_fin.its_psyphilistreat))
                    cbxFinalTratSiflParc.SelectedItem = cpn_fin.its_psyphilistreat;
                if (!string.IsNullOrWhiteSpace(cpn_fin.womanserostatus))
                    cbxFinalEstadoHIVMulher.SelectedItem = cpn_fin.womanserostatus;
                if (!string.IsNullOrWhiteSpace(cpn_fin.partnerserostatus))
                    cbxFinalEstadoHIVPar.SelectedItem = cpn_fin.partnerserostatus;
                if (cpn_fin.ctz_entr != null)
                    cbxFinalCTZEntrada.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.ctz_entr));
                if (cpn_fin.ctz_init != null)
                    cbxFinalIniCTZ.SelectedItem = cpn_fin.ctz_init;
                if (!string.IsNullOrWhiteSpace(cpn_fin.finalresult_arv))
                    cbxFinalResARV.SelectedItem = cpn_fin.finalresult_arv;
                if (!string.IsNullOrWhiteSpace(cpn_fin.tip))
                    cbxFinalTIP.SelectedItem = cpn_fin.tip;
                if (!string.IsNullOrWhiteSpace(cpn_fin.bednet))
                    cbxFinalRecRedeMosq.SelectedItem = cpn_fin.bednet;
                if (!string.IsNullOrWhiteSpace(cpn_fin.mal_diag_lab))
                    cbxFinalDigLabMal.SelectedItem = cpn_fin.mal_diag_lab;
                if (!string.IsNullOrWhiteSpace(cpn_fin.mal_treatment))
                    cbxFinalTratMal.SelectedItem = cpn_fin.mal_treatment;
                if (!string.IsNullOrWhiteSpace(cpn_fin.mp))
                    cbxFinalRecHPP.SelectedItem = cpn_fin.mp;
                if (cpn_fin.vat_1_dose != null)
                    cbxFinalVat1Dose.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.vat_1_dose));
                if (cpn_fin.vat_2_5_dose != null)
                    cbxFinalVat2_5Dose.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.vat_2_5_dose));
                if (cpn_fin.tb_isoniazid != null)
                    cbxFinalINH.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.tb_isoniazid));
                if (cpn_fin.tb_treatment != null)
                    cbxFinalINH.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(cpn_fin.tb_treatment));
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            try
            {
                clMother moth = new clMother();
                List<clCPN> list_cpn = new List<clCPN>();
                clCPNFinal cpn_final = new clCPNFinal();
                string nidcpn = txtNidCpnMain.Text;
                
                if (cbxNrConulta.SelectedIndex >= 0)
                {

                }
                
                if (string.IsNullOrWhiteSpace(txtNidCpnMain.Text))
                {
                    MessageBox.Show("O Compo NID CPN não esta preenchido. deve Preencher o campo primeiro");
                }
                else
                {          
                    int mother_id = moth.GetEntityList().Where(m => m.nid_cpn == nidcpn).FirstOrDefault().id;
                    cpn_final = cpn_final.GetEntityList().Where(cf => cf.idmother == mother_id).FirstOrDefault();
                    BindCPNFinalControls(cpn_final);

                    if (cbxNrConsultaMain.SelectedIndex >= 0)
                    {
                        clCPN cpn = new clCPN();
                        int rnConsl = Convert.ToInt32(Functions.ConvertComboConsultToNumb(cbxNrConsultaMain.SelectedItem.ToString()));
                        list_cpn = cpn.GetEntityList().Where(cp => cp.idmother == mother_id).ToList();
                        cpn = list_cpn.Where(c => c.nr_consulta == rnConsl).FirstOrDefault();
                        BindCPNControls(cpn);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
