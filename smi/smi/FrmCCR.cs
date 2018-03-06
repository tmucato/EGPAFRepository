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
    public partial class FrmCCR : Form
    {
        public FrmCCR()
        {
            InitializeComponent();
        }

        private void btnBuscarMain_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrWhiteSpace(txtNidCCR.Text))
                {
                    string nidcpn = txtNidCCR.Text;
                    clChild child = new clChild();

                    List<clChild> List_Child = child.GetEntityList().Where(c => c.nid_ccr == nidcpn).ToList();
                    if (List_Child.Count > 0)
                    {
                        child = List_Child.FirstOrDefault();
                        BindChildControls(child);
                        clCCR ccr = new clCCR();
                        List<clCCR> list_ccr = ccr.GetEntityList().Where(c => c.idchild == child.id).ToList();
                        clCCRSeg ccrseg = new clCCRSeg();
                        if (list_ccr.Count <= 0)
                        {
                            for (int i = 1; i < 7; i++)
                            {
                                ccr = new clCCR();
                                ccr.idchild = child.id;
                                ccr.nr_consulta = i;
                                ccr.InsertEntity();
                                if (i == 1)
                                {
                                    ccrseg.idchild = child.id;
                                    ccrseg.idccr = ccr.id;
                                    ccrseg.InsertEntity();
                                }
                            }
                        }

                        ccrseg = ccrseg.GetEntityList().Where(c => c.idchild == child.id).FirstOrDefault();
                        BindCCRSegControls(ccrseg);

                        if (cbxNrConsultaMain.SelectedIndex >= 0)
                        {
                            ccr = list_ccr.Where(c => c.nr_consulta == Convert.ToInt32(Functions.ConvertComboConsultToNumb(cbxNrConsultaMain.SelectedItem.ToString()))).FirstOrDefault();
                            BindCCRControls(ccr);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não encontrado paciente com o NID da CCR inserido");
                    }

                }
                else
                {
                    MessageBox.Show("Por Favor Insira o NID da CCR");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BindCCRControls(clCCR ccr)
        {
            try
            {

                lblIdCCR.Text = ccr.id.ToString();
                cbxNrConsulta.SelectedItem = Functions.ConvertNumbComboConsult(ccr.nr_consulta);
                if (ccr.dataconsulta != null)
                    dtpDataConsulta.Value = Convert.ToDateTime(ccr.dataconsulta);
                txtIdade.Text = ccr.age.ToString();
                if (string.IsNullOrWhiteSpace(ccr.ageunit))
                    cbxUnidIdade.SelectedValue = ccr.ageunit;
                if (string.IsNullOrWhiteSpace(ccr.mot_nid_cpn))
                    txtNidCpnMae.Text = ccr.mot_nid_cpn;
                if (string.IsNullOrWhiteSpace(ccr.mot_nid_tarv))
                    txtNidTarvMae.Text = ccr.mot_nid_tarv;
                if (ccr.mot_hiv_lact != null)
                    cbxHIVLact.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.mot_hiv_lact));
                if (ccr.mot_hiv_tarv != null)
                    cbxMaeLacTarv.SelectedItem = ccr.mot_hiv_tarv;
                if (ccr.tb != null)
                    cbxContactTB.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.tb));
                if (ccr.desnutricao_aguda != null)
                    cbxDesnuAguda.SelectedItem = ccr.desnutricao_aguda;
                if (ccr.exposicaoHIV != null)
                    cbxExpHIV.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.exposicaoHIV));
                if (string.IsNullOrWhiteSpace(ccr.outracondicaorisco))
                    txtOutrCondRisc.Text = ccr.outracondicaorisco;
                if (ccr.aleitmaternomenor6m != null)
                    cbxNutIdademen6.SelectedItem = ccr.aleitmaternomenor6m;
                if (ccr.aleitmaternomaior6m != null)
                    cbxNutIdademaior6.SelectedItem = ccr.aleitmaternomaior6m;
                if (Functions.IsNumber(ccr.atpu.ToString()))
                    txtATPU.Text = ccr.atpu.ToString();
                if (ccr.csb_nut_sup != null)
                    cbxCBS.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.csb_nut_sup));
                if (ccr.recuperada != null)
                    cbxRecuperada.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.recuperada));
                if (ccr.pcr_under2m != null)
                    cbxColhPCRMen2Mes.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.pcr_under2m));
                if (ccr.pcr_above2m != null)
                    cbxColhPCRMaior2Mes.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.pcr_above2m));
                if (ccr.pcrpos_under2m != null)
                    cbxResPCRMen2Mes.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.pcrpos_under2m));
                if (ccr.pcrpos_above2m != null)
                    cbxResPCRMai2Mes.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.pcrpos_above2m));
                if (string.IsNullOrWhiteSpace(ccr.resultadotesterapido))
                    cbxRestesRapMaior9mes.SelectedItem = ccr.resultadotesterapido;
                if (string.IsNullOrWhiteSpace(ccr.resulttrapido_nexp))
                    cbxResDefen.SelectedItem = ccr.resulttrapido_nexp;
                if (ccr.pisoniazidainicio != null)
                    dtpDataIniIson.Value = Convert.ToDateTime(ccr.pisoniazidainicio);
                if (ccr.pisoniazida != null)
                    cbxIsoniazStatus.SelectedItem = ccr.pisoniazida;
                if (ccr.ctz != null)
                    cbxCTZ.SelectedItem = ccr.ctz;
                if (ccr.profiaxia_arv != null)
                    cbxProfARV.SelectedItem = ccr.profiaxia_arv;
                if (string.IsNullOrWhiteSpace(ccr.resulttrapido_nexp))
                    cbxRestesRapCrinExpHIV.SelectedItem = ccr.resulttrapido_nexp;
                if (string.IsNullOrWhiteSpace(ccr.saidaccr))
                    cbxSaidaCri.SelectedItem = ccr.saidaccr;
                if (string.IsNullOrWhiteSpace(ccr.chd_nid_tarv))
                    txtNidCriTarv.Text = ccr.chd_nid_tarv;
                if (string.IsNullOrWhiteSpace(ccr.obs))
                    txtObs.Text = ccr.obs;
                if (string.IsNullOrWhiteSpace(ccr.providername))
                    txtNomeProfSaude.Text = ccr.providername;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BindCCRSegControls(clCCRSeg ccrseg)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ccrseg.mothTarv5moth))
                    txtMaeTarv5mesesCri.Text = ccrseg.mothTarv5moth;
                if (ccrseg.ame5m != null)
                    cbxAME5Meses.SelectedItem = ccrseg.ame5m;
                if (ccrseg.am5m != null)
                    cbxAleitMist5Meses.SelectedItem = ccrseg.am5m;
                if (ccrseg.recuperada != null)
                    cbxRecuperada.SelectedItem = ccrseg.recuperada;
                if (ccrseg.transinter != null)
                    cbxTransfInternam.SelectedItem = ccrseg.transinter;
                if (ccrseg.arv5m != null)
                    cbxARV5Meses.SelectedItem = ccrseg.arv5m;
                if (ccrseg.pcrmen2m != null)
                    cbxPCRMen2Meses.SelectedItem = ccrseg.pcrmen2m;
                if (ccrseg.pcrmai2m != null)
                    cbxPCRMaior2Meses.SelectedItem = ccrseg.pcrmai2m;
                if (ccrseg.pcrposmen2m != null)
                    cbxPCRposMenor2Meses.SelectedItem = ccrseg.pcrposmen2m;
                if (ccrseg.pcrposmai2m != null)
                    cbxPCRposMaior2Meses.SelectedItem = ccrseg.pcrposmai2m;
                if (ccrseg.tb != null)
                    cbxTB.SelectedItem = ccrseg.tb;
                if (ccrseg.dag != null)
                    cbxDAG.SelectedItem = ccrseg.dag;
                if (ccrseg.dam != null)
                    cbxDAM.SelectedItem = ccrseg.dam;
                if (ccrseg.ce9m != null)
                    cbxCE.SelectedItem = ccrseg.ce9m;
                if (ccrseg.pnctl != null)
                    cbxPNCTL.SelectedItem = ccrseg.pnctl;
                if (ccrseg.tpi != null)
                    cbxTPIComp.SelectedItem = ccrseg.tpi;
                if (ccrseg.abandono9 != null)
                    cbxAbandono.SelectedItem = ccrseg.abandono9;
                if (ccrseg.obito9 != null)
                    cbxObito.SelectedItem = ccrseg.obito9;
                if (ccrseg.ce18m != null)
                    cbxCE18Meses.SelectedItem = ccrseg.ce18m;
                if (ccrseg.resultado18 != null)
                    cbxResDef18Meses.SelectedItem = ccrseg.resultado18;
                if (ccrseg.transferidaCCS != null)
                    cbxTransCCS18Meses.SelectedItem = ccrseg.transferidaCCS;
                if (ccrseg.transferidaCI != null)
                    cbxTransConsIntgrCI18Meses.SelectedItem = ccrseg.transferidaCI;
                if (ccrseg.transferidaUS != null)
                    cbxTransfOutrUniSanit.SelectedItem = ccrseg.transferidaUS;
                if (ccrseg.abandono18 != null)
                    cbxAbandono18Meses.SelectedItem = ccrseg.abandono18;
                if (ccrseg.obito18 != null)
                    cbxObito18Meses.SelectedItem = ccrseg.obito18;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BindChildControls(clChild child)
        {
            try
            {
                txtNidCCRID.Text = child.nid_ccr;
                txtNome.Text = child.name;
                txtResidencia.Text = child.residence;
                txtTelefone.Text = child.phone;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnProximaPagina_Click(object sender, EventArgs e)
        {
            this.tabCCR.SelectedIndex = 1;
        }

        private void btnAnteriorPage_Click(object sender, EventArgs e)
        {
            this.tabCCR.SelectedIndex = 0;
        }


        private void cbxNrConsultaMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                clChild child = new clChild();
                List<clCCR> list_ccr = new List<clCCR>();
                clCCR ccr = new clCCR();
                clCCRSeg ccrseg = new clCCRSeg();
                string nid_ccr = txtNidCCR.Text;

                if (cbxNrConsulta.SelectedIndex >= 0)
                {
                    SaveCCRDataToDatabase(ccr);
                    SaveCCRSegDataToDatabase(ccrseg);

                }
                if (string.IsNullOrWhiteSpace(txtNidCCR.Text))
                {
                    MessageBox.Show("O Compo NID CPN não esta preenchido. deve Preencher o campo primeiro");
                }
                else
                {
                    int child_id = child.GetEntityList().Where(c => c.nid_ccr == nid_ccr).FirstOrDefault().id;
                    ccrseg = ccrseg.GetEntityList().Where(c => c.idchild == child_id).FirstOrDefault();
                    list_ccr = ccr.GetEntityList().Where(cp => cp.idchild == child_id).ToList();
                    BindCCRSegControls(ccrseg);


                    if (cbxNrConsultaMain.SelectedIndex >= 0)
                    {
                        int rnConsl = Convert.ToInt32(Functions.ConvertComboConsultToNumb(cbxNrConsultaMain.SelectedItem.ToString()));
                        ccr = list_ccr.Where(c => c.nr_consulta == rnConsl && c.idchild == child_id).FirstOrDefault();
                        BindCCRControls(ccr);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SaveCCRDataToDatabase(clCCR obj_ccr)
        {
            try
            {
                obj_ccr.id = Convert.ToInt32(lblIdCCR.Text);
                if (Functions.IsDate(dtpDataConsulta.Text))
                    obj_ccr.dataconsulta = dtpDataConsulta.Value;
                if (Functions.IsNumber(txtIdade.Text))
                    obj_ccr.age = Convert.ToInt32(txtIdade.Text);
                if (cbxUnidIdade.SelectedIndex >= 0)
                    obj_ccr.ageunit = cbxUnidIdade.SelectedText;
                if (!string.IsNullOrWhiteSpace(txtNidCpnMae.Text))
                    obj_ccr.mot_nid_cpn = txtNidCpnMae.Text;
                if (!string.IsNullOrWhiteSpace(txtNidTarvMae.Text))
                    obj_ccr.mot_nid_tarv = txtNidTarvMae.Text;
                if (cbxHIVLact.SelectedIndex >= 0)
                    obj_ccr.mot_hiv_lact = Functions.ConvertComboValueToBool(cbxHIVLact.SelectedItem.ToString());
                if (cbxMaeLacTarv.SelectedIndex >= 0)
                    obj_ccr.mot_hiv_tarv = Functions.ConvertComboValueToBool(cbxMaeLacTarv.SelectedItem.ToString());
                if (cbxContactTB.SelectedIndex >= 0)
                    obj_ccr.contactotb = Functions.ConvertComboValueToBool(cbxContactTB.SelectedItem.ToString());
                if (cbxDesnuAguda.SelectedIndex >= 0)
                    obj_ccr.desnutricao_aguda = cbxDesnuAguda.SelectedItem.ToString();
                if (cbxExpHIV.SelectedIndex >= 0)
                    obj_ccr.exposicaoHIV = Functions.ConvertComboValueToBool(cbxExpHIV.SelectedItem.ToString());
                if (!string.IsNullOrWhiteSpace(txtOutrCondRisc.Text))
                    obj_ccr.outracondicaorisco = txtOutrCondRisc.Text;
                if (Functions.IsDate(dtpDataIniIson.Text))
                    obj_ccr.pisoniazidainicio = dtpDataIniIson.Value;
                if (cbxIsoniazStatus.SelectedIndex >= 0)
                    obj_ccr.pisoniazida = cbxIsoniazStatus.SelectedText;
                if (cbxNutIdademen6.SelectedIndex >= 0)
                    obj_ccr.aleitmaternomenor6m = cbxNutIdademen6.SelectedText;
                if (cbxNutIdademaior6.SelectedIndex >= 0)
                    obj_ccr.aleitmaternomaior6m = Functions.ConvertComboValueToBool(cbxNutIdademaior6.SelectedItem.ToString());
                if (Functions.IsNumber(txtATPU.Text))
                    obj_ccr.atpu = Convert.ToInt32(txtATPU.Text);
                if (cbxCBS.SelectedIndex >= 0)
                    obj_ccr.csb_nut_sup = Functions.ConvertComboValueToBool(cbxCBS.SelectedItem.ToString());
                if (cbxRecuperada.SelectedIndex >= 0)
                    obj_ccr.recuperada = Functions.ConvertComboValueToBool(cbxRecuperada.SelectedItem.ToString());
                if (cbxCTZ.SelectedIndex >= 0)
                    obj_ccr.ctz = cbxCTZ.SelectedText;
                if (cbxProfARV.SelectedIndex >= 0)
                    obj_ccr.profiaxia_arv = Functions.ConvertComboValueToBool(cbxProfARV.SelectedItem.ToString());
                if (cbxColhPCRMen2Mes.SelectedIndex >= 0)
                    obj_ccr.colheitapcrmenor2mes = cbxColhPCRMen2Mes.SelectedItem.ToString();
                if (cbxColhPCRMaior2Mes.SelectedIndex >= 0)
                    obj_ccr.colheitapcmaior2mes = cbxColhPCRMaior2Mes.SelectedItem.ToString();
                if (cbxResPCRMen2Mes.SelectedIndex >= 0)
                    obj_ccr.resultadopcrmenor2meses = cbxResPCRMen2Mes.SelectedItem.ToString();
                if (cbxResPCRMai2Mes.SelectedIndex >= 0)
                    obj_ccr.resultadopcrmaior2meses = cbxResPCRMai2Mes.SelectedItem.ToString();
                if (cbxRestesRapMaior9mes.SelectedIndex >= 0)
                    obj_ccr.resultadotesterapido = cbxRestesRapMaior9mes.SelectedItem.ToString();
                if (cbxResDefen.SelectedIndex >= 0)
                    obj_ccr.resultadofinal = cbxResDefen.SelectedItem.ToString();
                if (cbxRestesRapCrinExpHIV.SelectedIndex >= 0)
                    obj_ccr.resulttrapido_nexp = cbxRestesRapCrinExpHIV.SelectedItem.ToString();
                if (cbxSaidaCri.SelectedIndex >= 0)
                    obj_ccr.saidaccr = cbxSaidaCri.SelectedItem.ToString();
                if (string.IsNullOrWhiteSpace(txtNidCriTarv.Text))
                    obj_ccr.chd_nid_tarv = txtNidCriTarv.Text;
                if (string.IsNullOrWhiteSpace(txtObs.Text))
                    obj_ccr.obs = txtObs.Text;
                if (string.IsNullOrWhiteSpace(txtNomeProfSaude.Text))
                    obj_ccr.providername = txtNomeProfSaude.Text;
                obj_ccr.UpdateEntity();



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SaveCCRSegDataToDatabase(clCCRSeg obj_ccr_seg)
        {
            try
            {

                if (cbxCE18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.ce18m = Functions.ConvertComboValueToBool(cbxCE18Meses.SelectedItem.ToString());
                if (cbxResDef18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.resultado18 = Functions.ConvertComboValueToBool(cbxResDef18Meses.SelectedItem.ToString());
                if (cbxTransCCS18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.transferidaCCS = Functions.ConvertComboValueToBool(cbxTransCCS18Meses.SelectedItem.ToString());
                if (cbxTransConsIntgrCI18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.transferidaCI = Functions.ConvertComboValueToBool(cbxTransConsIntgrCI18Meses.SelectedItem.ToString());
                if (cbxTransfOutrUniSanit.SelectedIndex >= 0)
                    obj_ccr_seg.transferidaUS = Functions.ConvertComboValueToBool(cbxTransfOutrUniSanit.SelectedItem.ToString());
                if (cbxAbandono18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.abandono18 = Functions.ConvertComboValueToBool(cbxAbandono18Meses.SelectedItem.ToString());
                if (cbxObito18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.obito18 = Functions.ConvertComboValueToBool(cbxObito18Meses.SelectedItem.ToString());
                if (string.IsNullOrWhiteSpace(txtMaeTarv5mesesCri.Text))
                    obj_ccr_seg.mothTarv5moth = txtMaeTarv5mesesCri.Text;
                if (cbxAME5Meses.SelectedIndex >= 0)
                    obj_ccr_seg.ame5m = Functions.ConvertComboValueToBool(cbxAME5Meses.SelectedItem.ToString());
                if (cbxAleitMist5Meses.SelectedIndex >= 0)
                    obj_ccr_seg.am5m = Functions.ConvertComboValueToBool(cbxAleitMist5Meses.SelectedItem.ToString());
                if (cbxRecuperada.SelectedIndex >= 0)
                    obj_ccr_seg.recuperada = Functions.ConvertComboValueToBool(cbxRecuperada.SelectedItem.ToString());
                if (cbxTransfInternam.SelectedIndex >= 0)
                    obj_ccr_seg.transinter = Functions.ConvertComboValueToBool(cbxTransfInternam.SelectedItem.ToString());
                if (cbxARV5Meses.SelectedIndex >= 0)
                    obj_ccr_seg.arv5m = Functions.ConvertComboValueToBool(cbxARV5Meses.SelectedItem.ToString());
                if (cbxPCRMen2Meses.SelectedIndex >= 0)
                    obj_ccr_seg.pcrmen2m = Functions.ConvertComboValueToBool(cbxPCRMen2Meses.SelectedItem.ToString());
                if (cbxPCRMaior2Meses.SelectedIndex >= 0)
                    obj_ccr_seg.pcrmai2m = Functions.ConvertComboValueToBool(cbxPCRMaior2Meses.SelectedItem.ToString());
                if (cbxPCRposMenor2Meses.SelectedIndex >= 0)
                    obj_ccr_seg.pcrposmen2m = Functions.ConvertComboValueToBool(cbxPCRposMenor2Meses.SelectedItem.ToString());
                if (cbxPCRposMaior2Meses.SelectedIndex >= 0)
                    obj_ccr_seg.pcrposmai2m = Functions.ConvertComboValueToBool(cbxPCRposMaior2Meses.SelectedItem.ToString());
                if (cbxTB.SelectedIndex >= 0)
                    obj_ccr_seg.tb = Functions.ConvertComboValueToBool(cbxTB.SelectedItem.ToString());
                if (cbxDAM.SelectedIndex >= 0)
                    obj_ccr_seg.dam = Functions.ConvertComboValueToBool(cbxDAM.SelectedItem.ToString());
                if (cbxDAG.SelectedIndex >= 0)
                    obj_ccr_seg.dag = Functions.ConvertComboValueToBool(cbxDAG.SelectedItem.ToString());
                if (cbxCE.SelectedIndex >= 0)
                    obj_ccr_seg.ce9m = Functions.ConvertComboValueToBool(cbxCE.SelectedItem.ToString());
                if (cbxPNCTL.SelectedIndex >= 0)
                    obj_ccr_seg.pnctl = Functions.ConvertComboValueToBool(cbxPNCTL.SelectedItem.ToString());
                if (cbxTPIComp.SelectedIndex >= 0)
                    obj_ccr_seg.tpi = Functions.ConvertComboValueToBool(cbxTPIComp.SelectedItem.ToString());
                if (cbxAbandono.SelectedIndex >= 0)
                    obj_ccr_seg.abandono9 = Functions.ConvertComboValueToBool(cbxAbandono.SelectedItem.ToString());
                if (cbxObito.SelectedIndex >= 0)
                    obj_ccr_seg.obito9 = Functions.ConvertComboValueToBool(cbxObito.SelectedItem.ToString());

                obj_ccr_seg.UpdateEntity();

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
                clCCR ccr = new clCCR();
                clChild child = new clChild();
                List<clCCR> list_ccr = new List<clCCR>();
                clCCRSeg ccrseg = new clCCRSeg();

                if (!string.IsNullOrWhiteSpace(txtNidCCR.Text))
                {
                    string nid_ccr = txtNidCCR.Text;
                    int child_id = child.GetEntityList().Where(c => c.nid_ccr == nid_ccr).FirstOrDefault().id;
                    ccrseg = ccrseg.GetEntityList().Where(c => c.idchild == child_id).FirstOrDefault();
                    SaveCCRSegDataToDatabase(ccrseg);
                    if (cbxNrConsultaMain.SelectedIndex >= 0)
                    {
                        int rnConsl = Convert.ToInt32(Functions.ConvertComboConsultToNumb(cbxNrConsultaMain.SelectedItem.ToString()));
                        ccr = list_ccr.Where(c => c.nr_consulta == rnConsl && c.idchild == child_id).FirstOrDefault();
                        SaveCCRDataToDatabase(ccr);
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

