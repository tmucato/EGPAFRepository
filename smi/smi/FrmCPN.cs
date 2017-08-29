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


        private void btnGravarMain_Click(object sender, EventArgs e)
        {
            clCPN cpn = new clCPN();
            clMother moth = new clMother();
            List<clCPN> list_cpn = new List<clCPN>();
            clCPNFinal cpn_final = new clCPNFinal();

            try
            {
                string nidcpn = txtNidCpnMain.Text;
                int mother_id = moth.GetEntityList().Where(m => m.nid_cpn == nidcpn).FirstOrDefault().id;
                cpn_final = cpn_final.GetEntityList().Where(cf => cf.idmother == mother_id).FirstOrDefault();
                if (cbxNrConsultaMain.SelectedIndex >= 0)
                {
                    cpn = cpn.GetEntityList().Where(c => c.idmother == mother_id && c.nr_consulta == Convert.ToInt32(Functions.ConvertComboConsultToNumb(cbxNrConsultaMain.SelectedItem.ToString()))).FirstOrDefault();
                    SaveCPNDataToDataBase(cpn);
                }
                SaveCPNFinalDataToDataBase(cpn_final);

            }
            catch (Exception ex)
            {

                throw ex;
            }


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
                ClearCPNControls();
                lblIdCpn.Text = cpn.id.ToString();
                cbxNrConulta.SelectedItem = Functions.ConvertNumbComboConsult(cpn.nr_consulta);
                dtpDataConsulta.Value = cpn.visdate;
                txtNrLivro.Text = cpn.nlivro;
                txtIdadeGest.Text = cpn.gestationalage.ToString();
                txtAnoLivro.Text = cpn.nyear.ToString();
                lblIdMother.Text = cpn.idmother.ToString();
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
                    cbxProteinuria.SelectedItem = cpn.proteinuria;
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
                if (!string.IsNullOrWhiteSpace(cpn.its_wsyphilistreat))
                    cbxtratSiflMulher.SelectedItem = cpn.its_wsyphilistreat;
                if (!string.IsNullOrWhiteSpace(cpn.its_psyphilistreat))
                    cbxtratSiflParceiro.SelectedItem = cpn.its_psyphilistreat;
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

        private void ClearCPNControls()
        {

            try
            {
                lblIdCpn.Text = string.Empty;
                cbxNrConulta.SelectedIndex = -1;
                dtpDataConsulta.Value = DateTime.Now;
                txtNrLivro.Text = string.Empty;
                txtIdadeGest.Text = string.Empty;
                txtAnoLivro.Text = string.Empty;
                lblIdMother.Text = string.Empty;
                cbxParPresent.SelectedIndex = -1;
                cbxFaixaEtaria.SelectedIndex = -1;
                cbxIdaMen12Sem.SelectedIndex = -1;
                txtPeso.Text = string.Empty;
                cbxDAM.SelectedIndex = -1;
                cbxDAG.SelectedIndex = -1;
                cbxCurada.SelectedIndex = -1;
                cbxGanhoMaior15.SelectedIndex = -1;
                txtRecSuplNutrQty.Text = string.Empty;
                cbxRecDesparasitante.SelectedIndex = -1;
                cbxSalFerrAcFol.SelectedIndex = -1;
                cbxtensaoArte.SelectedIndex = -1;
                cbxHemoglobina.SelectedIndex = -1;
                cbxProteinuria.SelectedIndex = -1;
                cbxGlicosuria.SelectedIndex = -1;
                cbxUlcera.SelectedIndex = -1;
                cbxLeucorreia.SelectedIndex = -1;
                cbxSindromicoITS.SelectedIndex = -1;
                cbxTesteSiflis.SelectedIndex = -1;
                cbxtratSiflMulher.SelectedIndex = -1;
                cbxtratSiflParceiro.SelectedIndex = -1;
                cbxSerEstad1CPN.SelectedIndex = -1;
                cbxtesteHivCpn.SelectedIndex = -1;
                cbxTesteParceiro.SelectedIndex = -1;
                cbxCTZEntrada.SelectedIndex = -1;
                cbxIniContCTZ.SelectedIndex = -1;
                cbxEmTarvEntrada.SelectedIndex = -1;
                cbxIniTarvVis.SelectedIndex = -1;
                cbxContARVVisita.SelectedIndex = -1;
                cbxNVPVisita.SelectedIndex = -1;
                cbxIniBiproAZTNVP.SelectedIndex = -1;
                cbxRecebeiTip.SelectedIndex = -1;
                cbxRecRedeMosqu.SelectedIndex = -1;
                cbxTDRHTZ.SelectedIndex = -1;
                cbxResultadoTDRHTZ.SelectedIndex = -1;
                cbxMulhTesteMalPosTrat.SelectedIndex = -1;
                cbxProfIson.SelectedIndex = -1;
                cbxTratTB.SelectedIndex = -1;
                cbxHPP.SelectedIndex = -1;
                cbxVat1Dose.SelectedIndex = -1;
                cbxVat2_5Dose.SelectedIndex = -1;
                txtObs.Text = string.Empty;
                txtNomeProf.Text = string.Empty;
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

                ClearCPNFinalControls();

                lblIdMother.Text = cpn_fin.idmother.ToString();
                lblIdCpnFinal.Text = cpn_fin.id.ToString();
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

        private void ClearCPNFinalControls()
        {
            try
            {
                lblIdMother.Text = string.Empty;
                lblIdCpnFinal.Text = string.Empty;
                cbxFinalMaisConsult.SelectedIndex = -1;
                cbxFinalParcePrese.SelectedIndex = -1;
                cbxFinalGanho15.SelectedIndex = -1;
                cbxFinalDAG.SelectedIndex = -1;
                cbxFinalDAG.SelectedIndex = -1;
                cbxFinalRecSuplNutri.SelectedIndex = -1;
                cbxFinalCuradoDesntr.SelectedIndex = -1;
                cbxFinalAbandDesnutr.SelectedIndex = -1;
                cbxFinalRecDespara.SelectedIndex = -1;
                cbxFinalSalFerrMais3.SelectedIndex = -1;
                cbxFinalDiagITS.SelectedIndex = -1;
                cbxFinalTratITS.SelectedIndex = -1;
                cbxFinalTestSiflis.SelectedIndex = -1;
                cbxFinalTratSiflMulher.SelectedIndex = -1;
                cbxFinalTratSiflParc.SelectedIndex = -1;
                cbxFinalEstadoHIVMulher.SelectedIndex = -1;
                cbxFinalEstadoHIVPar.SelectedIndex = -1;
                cbxFinalCTZEntrada.SelectedIndex = -1;
                cbxFinalIniCTZ.SelectedIndex = -1;
                cbxFinalResARV.SelectedIndex = -1;
                cbxFinalTIP.SelectedIndex = -1;
                cbxFinalRecRedeMosq.SelectedIndex = -1;
                cbxFinalDigLabMal.SelectedIndex = -1;
                cbxFinalTratMal.SelectedIndex = -1;
                cbxFinalRecHPP.SelectedIndex = -1;
                cbxFinalVat1Dose.SelectedIndex = -1;
                cbxFinalVat2_5Dose.SelectedIndex = -1;
                cbxFinalINH.SelectedIndex = -1;
                cbxFinalINH.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }

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
                clCPN cpn = new clCPN();
                string nidcpn = txtNidCpnMain.Text;

                int mother_id = moth.GetEntityList().Where(m => m.nid_cpn == nidcpn).FirstOrDefault().id;
                cpn_final = cpn_final.GetEntityList().Where(cf => cf.idmother == mother_id).FirstOrDefault();

                int rnConsl = Convert.ToInt32(Functions.ConvertComboConsultToNumb(cbxNrConsultaMain.SelectedItem.ToString()));
                list_cpn = cpn.GetEntityList().Where(cp => cp.idmother == mother_id).ToList();
                cpn = list_cpn.Where(c => c.nr_consulta == rnConsl).FirstOrDefault();

                if (cbxNrConulta.SelectedIndex >= 0)
                {
                    SaveCPNDataToDataBase(cpn);
                    SaveCPNFinalDataToDataBase(cpn_final);
                }
                if (string.IsNullOrWhiteSpace(txtNidCpnMain.Text))
                {
                    MessageBox.Show("O Compo NID CPN não esta preenchido. deve Preencher o campo primeiro");
                }
                else
                {
                    BindCPNFinalControls(cpn_final);

                    if (cbxNrConsultaMain.SelectedIndex >= 0)
                    {
                        BindCPNControls(cpn);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SaveCPNFinalDataToDataBase(clCPNFinal cpnfin)
        {

            try
            {
                if (!string.IsNullOrWhiteSpace(lblIdCpnFinal.Text))
                    cpnfin.id = Convert.ToInt32(lblIdCpnFinal.Text);
                if (!string.IsNullOrWhiteSpace(lblIdMother.Text))
                    cpnfin.idmother = Convert.ToInt32(lblIdMother.Text);
                if (!string.IsNullOrWhiteSpace(lblNrLivro.Text))
                    cpnfin.nlivro = lblNrLivro.Text;
                if (cbxFinalMaisConsult.SelectedIndex >= 0)
                    cpnfin.cons_more4 = Functions.ConvertComboValueToBool(cbxFinalMaisConsult.SelectedItem.ToString());
                if (cbxFinalParcePrese.SelectedIndex >= 0)
                    cpnfin.partnerpreence = Functions.ConvertComboValueToBool(cbxFinalParcePrese.SelectedItem.ToString()); ;
                if (cbxFinalGanho15.SelectedIndex >= 0)
                    cpnfin.weightgainyno = cbxFinalGanho15.SelectedItem.ToString();
                if (cbxFinalDAG.SelectedIndex >= 0)
                    cpnfin.dag = Functions.ConvertComboValueToBool(cbxFinalDAG.SelectedItem.ToString());
                if (cbxFinalDAM.SelectedIndex >= 0)
                    cpnfin.dam = Functions.ConvertComboValueToBool(cbxFinalDAM.SelectedItem.ToString());
                if (cbxFinalRecSuplNutri.SelectedIndex >= 0)
                    cpnfin.supnutr = cbxFinalRecSuplNutri.SelectedItem.ToString();
                if (cbxFinalCuradoDesntr.SelectedIndex >= 0)
                    cpnfin.resultcured = cbxFinalCuradoDesntr.SelectedItem.ToString();
                if (cbxFinalAbandDesnutr.SelectedIndex >= 0)
                    cpnfin.resultabandon = cbxFinalAbandDesnutr.SelectedItem.ToString();
                if (cbxFinalRecDespara.SelectedIndex >= 0)
                    cpnfin.receiveddesparasitante = cbxFinalRecDespara.SelectedItem.ToString();
                if (cbxFinalSalFerrMais3.SelectedIndex >= 0)
                    cpnfin.salferr_more3 = Functions.ConvertComboValueToBool(cbxFinalSalFerrMais3.SelectedItem.ToString());
                if (cbxFinalDiagITS.SelectedIndex >= 0)
                    cpnfin.its_diag = Functions.ConvertComboValueToBool(cbxFinalDiagITS.SelectedItem.ToString());
                if (cbxFinalTratITS.SelectedIndex >= 0)
                    cpnfin.its_treatment = cbxFinalTratITS.SelectedItem.ToString();
                if (cbxFinalTestSiflis.SelectedIndex >= 0)
                    cpnfin.its_syphilistesting = cbxFinalTestSiflis.SelectedItem.ToString();
                if (cbxFinalTratSiflMulher.SelectedIndex >= 0)
                    cpnfin.its_wsyphilistreat = Functions.ConvertComboValueToBool(cbxFinalTratSiflMulher.SelectedItem.ToString());
                if (cbxFinalTratSiflParc.SelectedIndex >= 0)
                    cpnfin.its_psyphilistreat = cbxFinalTratSiflParc.SelectedItem.ToString();
                if (cbxFinalEstadoHIVMulher.SelectedIndex >= 0)
                    cpnfin.womanserostatus = cbxFinalEstadoHIVMulher.SelectedItem.ToString();
                if (cbxFinalEstadoHIVPar.SelectedIndex >= 0)
                    cpnfin.partnerserostatus = cbxFinalEstadoHIVPar.SelectedItem.ToString();
                if (cbxFinalCTZEntrada.SelectedIndex >= 0)
                    cpnfin.ctz_entr = Functions.ConvertComboValueToBool(cbxFinalCTZEntrada.SelectedItem.ToString());
                if (cbxFinalIniCTZ.SelectedIndex >= 0)
                    cpnfin.ctz_init = Functions.ConvertComboValueToBool(cbxFinalIniCTZ.SelectedItem.ToString());
                if (cbxFinalResARV.SelectedIndex >= 0)
                    cpnfin.finalresult_arv = cbxFinalResARV.SelectedItem.ToString();
                if (cbxFinalTIP.SelectedIndex >= 0)
                    cpnfin.tip = cbxFinalTIP.SelectedItem.ToString();
                if (cbxFinalRecRedeMosq.SelectedIndex >= 0)
                    cpnfin.bednet = cbxFinalRecRedeMosq.SelectedItem.ToString();
                if (cbxFinalDigLabMal.SelectedIndex >= 0)
                    cpnfin.mal_diag_lab = cbxFinalDigLabMal.SelectedItem.ToString();
                if (cbxFinalTratMal.SelectedIndex >= 0)
                    cpnfin.mal_treatment = cbxFinalTratMal.SelectedItem.ToString();
                if (cbxFinalRecHPP.SelectedIndex >= 0)
                    cpnfin.mp = cbxFinalRecHPP.SelectedItem.ToString();
                if (cbxFinalVat1Dose.SelectedIndex >= 0)
                    cpnfin.vat_1_dose = Functions.ConvertComboValueToBool(cbxFinalVat1Dose.SelectedItem.ToString());
                if (cbxFinalVat2_5Dose.SelectedIndex >= 0)
                    cpnfin.vat_2_5_dose = Functions.ConvertComboValueToBool(cbxFinalVat2_5Dose.SelectedItem.ToString());
                if (cbxFinalINH.SelectedIndex >= 0)
                    cpnfin.tb_isoniazid = Functions.ConvertComboValueToBool(cbxFinalINH.SelectedItem.ToString());
                if (cbxFinalTratTB.SelectedIndex >= 0)
                    cpnfin.tb_treatment = Functions.ConvertComboValueToBool(cbxFinalTratTB.SelectedItem.ToString());
                cpnfin.UpdateEntity();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SaveCPNDataToDataBase(clCPN cpn)
        {

            cpn.id = Convert.ToInt32(lblIdCpn.Text);
            if (cbxNrConulta.SelectedIndex >= 0)
                cpn.nr_consulta = Functions.ConvertComboConsultToNumb(cbxNrConulta.SelectedItem.ToString());
            cpn.idmother = Convert.ToInt32(lblIdMother.Text);

            cpn.nlivro = txtNrLivro.Text;
            if (Functions.IsNumber(txtAnoLivro.Text))
                cpn.nyear = Convert.ToInt32(txtAnoLivro.Text);
            cpn.visdate = dtpDataConsulta.Value;
            if (cbxFaixaEtaria.SelectedIndex >= 0)
                cpn.agegroup = cbxFaixaEtaria.SelectedItem.ToString();
            if (Functions.IsNumber(txtIdadeGest.Text))
                cpn.gestationalage = Convert.ToInt32(txtIdadeGest.Text);
            if (cbxIdaMen12Sem.SelectedIndex >= 0)
                cpn.gageless12 = Functions.ConvertComboValueToBool(cbxFaixaEtaria.SelectedItem.ToString());
            if (cbxParPresent.SelectedIndex >= 0)
                cpn.partnerpresence = Functions.ConvertComboValueToBool(cbxParPresent.SelectedItem.ToString());
            if (Functions.IsNumber(txtPeso.Text))
                cpn.weight = Convert.ToInt32(txtPeso.Text);
            if (cbxGanhoMaior15.SelectedIndex >= 0)
                cpn.weightgainyno = cbxGanhoMaior15.SelectedItem.ToString();
            if (cbxDAG.SelectedIndex >= 0)
                cpn.dag = Functions.ConvertComboValueToBool(cbxDAG.SelectedItem.ToString());
            if (cbxDAM.SelectedIndex >= 0)
                cpn.dam = Functions.ConvertComboValueToBool(cbxDAM.SelectedItem.ToString());
            if (Functions.IsNumber(txtRecSuplNutrQty.Text))
                cpn.supnutr = Convert.ToInt32(txtRecSuplNutrQty.Text);
            if (cbxCurada.SelectedIndex >= 0)
                cpn.resultcured = cbxCurada.SelectedItem.ToString();
            //Campo indisponivel ni livro.
            cpn.resultabandon = string.Empty;
            if (cbxRecDesparasitante.SelectedIndex >= 0)
                cpn.receiveddesparasitante = string.Empty;
            if (cbxSalFerrAcFol.SelectedIndex >= 0)
                cpn.salferr_acfolico = cbxSalFerrAcFol.SelectedItem.ToString();
            if (cbxtensaoArte.SelectedIndex >= 0)
                cpn.ta = cbxtensaoArte.SelectedItem.ToString();
            if (cbxHemoglobina.SelectedIndex >= 0)
                cpn.hgb = cbxHemoglobina.SelectedItem.ToString();
            if (cbxProteinuria.SelectedIndex >= 0)
                cpn.proteinuria = cbxProteinuria.SelectedItem.ToString();
            if (cbxGlicosuria.SelectedIndex >= 0)
                cpn.glicosuria = cbxGlicosuria.SelectedItem.ToString();
            if (cbxUlcera.SelectedIndex >= 0)
                cpn.its_ulceragenital = Functions.ConvertComboValueToBool(cbxUlcera.SelectedItem.ToString());
            if (cbxLeucorreia.SelectedIndex >= 0)
                cpn.its_leucorreia = Functions.ConvertComboValueToBool(cbxLeucorreia.SelectedItem.ToString());
            if (cbxSindromicoITS.SelectedIndex >= 0)
                cpn.its_syndromictreatment = cbxSindromicoITS.SelectedItem.ToString();
            if (cbxTesteSiflis.SelectedIndex >= 0)
                cpn.its_syphilistesting = cbxTesteSiflis.SelectedItem.ToString();
            if (cbxtratSiflMulher.SelectedIndex >= 0)
                cpn.its_wsyphilistreat = cbxtratSiflMulher.SelectedItem.ToString();
            if (cbxtratSiflParceiro.SelectedIndex >= 0)
                cpn.its_psyphilistreat = cbxtratSiflParceiro.SelectedItem.ToString();
            if (cbxSerEstad1CPN.SelectedIndex >= 0)
                cpn.serostatusentcpn = cbxSerEstad1CPN.SelectedItem.ToString();
            if (cbxtesteHivCpn.SelectedIndex >= 0)
                cpn.cpnhivtest = cbxtesteHivCpn.SelectedItem.ToString();
            if (cbxTesteParceiro.SelectedIndex >= 0)
                cpn.partnerhivtest = cbxTesteParceiro.SelectedItem.ToString();
            if (cbxCTZEntrada.SelectedIndex >= 0)
                cpn.ctz = Functions.ConvertComboValueToBool(cbxCTZEntrada.SelectedItem.ToString());
            if (cbxIniContCTZ.SelectedIndex >= 0)
                cpn.ctz_init_cont = cbxIniContCTZ.SelectedItem.ToString();
            if (cbxEmTarvEntrada.SelectedIndex >= 0)
                cpn.em_tarv_entrada = Functions.ConvertComboValueToBool(cbxEmTarvEntrada.SelectedItem.ToString());
            if (cbxNVPVisita.SelectedIndex >= 0)
                cpn.nvp = Functions.ConvertComboValueToBool(cbxNVPVisita.SelectedItem.ToString());
            if (cbxIniBiproAZTNVP.SelectedIndex >= 0)
                cpn.azt_nvp = Functions.ConvertComboValueToBool(cbxIniBiproAZTNVP.SelectedItem.ToString());
            if (cbxIniTarvVis.SelectedIndex >= 0)
                cpn.tarv_init_visit = Functions.ConvertComboValueToBool(cbxIniTarvVis.SelectedItem.ToString());
            if (cbxContARVVisita.SelectedIndex >= 0)
                cpn.arv_cont = Functions.ConvertComboValueToBool(cbxContARVVisita.SelectedItem.ToString());
            if (cbxRecebeiTip.SelectedIndex >= 0)
                cpn.tip = cbxRecebeiTip.SelectedItem.ToString();
            if (cbxRecRedeMosqu.SelectedIndex >= 0)
                cpn.bednet = cbxRecRedeMosqu.SelectedItem.ToString();
            if (cbxTDRHTZ.SelectedIndex >= 0)
                cpn.tdr_htz = cbxTDRHTZ.SelectedItem.ToString();
            if (cbxResultadoTDRHTZ.SelectedIndex >= 0)
                cpn.result_tdr_htz = cbxResultadoTDRHTZ.SelectedItem.ToString();
            if (cbxMulhTesteMalPosTrat.SelectedIndex >= 0)
                cpn.pos_malaria_treated = cbxMulhTesteMalPosTrat.SelectedItem.ToString();
            if (cbxHPP.SelectedIndex >= 0)
                cpn.hpp = cbxHPP.SelectedItem.ToString();
            if (cbxVat1Dose.SelectedIndex >= 0)
                cpn.vat_1_dose = Functions.ConvertComboValueToBool(cbxVat1Dose.SelectedItem.ToString());
            if (cbxVat2_5Dose.SelectedIndex >= 0)
                cpn.vat_2_5_dose = Functions.ConvertComboValueToBool(cbxVat2_5Dose.SelectedItem.ToString());
            if (cbxProfIson.SelectedIndex >= 0)
                cpn.tb_isoniazid = cbxProfIson.SelectedItem.ToString();
            if (cbxTratTB.SelectedIndex >= 0)
                cpn.tb_treatment = cbxTratTB.SelectedItem.ToString();
            cpn.obs = txtObs.Text;
            cpn.providername = txtNomeProf.Text;
            cpn.UpdateEntity();
            
        }
    }
}
