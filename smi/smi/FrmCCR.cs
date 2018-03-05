﻿using smiBLL;
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
                dtpDataConsulta.Value = Convert.ToDateTime(ccr.dataconsulta);
                txtIdade.Text = ccr.age.ToString();
                cbxUnidIdade.SelectedValue = ccr.ageunit;
                txtNidCpnMae.Text = ccr.mot_nid_cpn;
                txtNidTarvMae.Text = ccr.mot_nid_tarv;
                cbxHIVLact.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.mot_hiv_lact));
                cbxMaeLacTarv.SelectedItem = ccr.mot_hiv_tarv;
                cbxContactTB.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.tb));
                cbxDesnuAguda.SelectedItem = ccr.desnutricao_aguda;
                cbxExpHIV.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.exposicaoHIV));
                txtOutrCondRisc.Text = ccr.outracondicaorisco;
                cbxNutIdademen6.SelectedItem = ccr.aleitmaternomenor6m;
                cbxNutIdademaior6.SelectedItem = ccr.aleitmaternomaior6m;
                txtATPU.Text = ccr.atpu.ToString();
                cbxCBS.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.csb_nut_sup));
                cbxRecuperada.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.recuperada));
                cbxColhPCRMen2Mes.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.pcr_under2m));
                cbxColhPCRMaior2Mes.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.pcr_above2m));
                cbxResPCRMen2Mes.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.pcrpos_under2m));
                cbxResPCRMai2Mes.SelectedItem = Functions.ConvertBoolToComboValue(Convert.ToBoolean(ccr.pcrpos_above2m));
                cbxRestesRapMaior9mes.SelectedItem = ccr.resultadotesterapido;
                cbxResDefen.SelectedItem = ccr.resulttrapido_nexp;
                if (ccr.pisoniazidainicio != null) dtpDataIniIson.Value = Convert.ToDateTime(ccr.pisoniazidainicio);
                cbxIsoniazStatus.SelectedItem = ccr.pisoniazida;
                cbxCTZ.SelectedItem = ccr.ctz;
                cbxProfARV.SelectedItem = ccr.profiaxia_arv;
                cbxRestesRapCrinExpHIV.SelectedItem = ccr.resulttrapido_nexp;
                cbxSaidaCri.SelectedItem = ccr.saidaccr;
                txtNidCriTarv.Text = ccr.chd_nid_tarv;
                txtObs.Text = ccr.obs;
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
                txtMaeTarv5mesesCri.Text = ccrseg.mothTarv5moth;
                cbxAME5Meses.SelectedItem = ccrseg.ame5m;
                cbxAleitMist5Meses.SelectedItem = ccrseg.am5m;
                cbxRecuperada.SelectedItem = ccrseg.recuperada;
                cbxTransfInternam.SelectedItem = ccrseg.transinter;
                cbxARV5Meses.SelectedItem = ccrseg.arv5m;
                cbxPCRMen2Meses.SelectedItem = ccrseg.pcrmen2m;
                cbxPCRMaior2Meses.SelectedItem = ccrseg.pcrmai2m;
                cbxPCRposMenor2Meses.SelectedItem = ccrseg.pcrposmen2m;
                cbxPCRposMaior2Meses.SelectedItem = ccrseg.pcrposmai2m;
                cbxTB.SelectedItem = ccrseg.tb;
                cbxDAG.SelectedItem = ccrseg.dag;
                cbxDAM.SelectedItem = ccrseg.dam;
                cbxCE.SelectedItem = ccrseg.ce9m;
                cbxPNCTL.SelectedItem = ccrseg.pnctl;
                cbxTPIComp.SelectedItem = ccrseg.tpi;
                cbxAbandono.SelectedItem = ccrseg.abandono9;
                cbxObito.SelectedItem = ccrseg.obito9;
                cbxCE18Meses.SelectedItem = ccrseg.ce18m;
                cbxResDef18Meses.SelectedItem = ccrseg.resultado18;
                cbxTransCCS18Meses.SelectedItem = ccrseg.transferidaCCS;
                cbxTransConsIntgrCI18Meses.SelectedItem = ccrseg.transferidaCI;
                cbxTransfOutrUniSanit.SelectedItem = ccrseg.transferidaUS;
                cbxAbandono18Meses.SelectedItem = ccrseg.abandono18;
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
                clCCR cl_ccr = new clCCR();
                clCCR ccr = new clCCR();
                clCCRSeg ccrseg = new clCCRSeg();

                if (cbxNrConsultaMain.SelectedIndex >= 0)
                {
                    SaveCCRDataToDatabase(cl_ccr);
                    SaveCCRSegDataToDatabase(ccrseg);

                }
                if (string.IsNullOrWhiteSpace(txtNidCCR.Text))
                {
                    MessageBox.Show("O Compo NID CPN não esta preenchido. deve Preencher o campo primeiro");
                }
                else
                {

                    ccrseg = ccrseg.GetEntityList().Where(c => c.idchild == child.id).FirstOrDefault();
                    BindCCRSegControls(ccrseg);

                    if (cbxNrConsultaMain.SelectedIndex >= 0)
                    {
                        ccr = ccr.GetEntityList().Where(c => c.idchild == child.id).ToList().Where(c => c.nr_consulta == Convert.ToInt32(Functions.ConvertComboConsultToNumb(cbxNrConsultaMain.SelectedItem.ToString()))).FirstOrDefault();
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
                    obj_ccr.mot_hiv_lact = Functions.ConvertComboValueToBool(cbxHIVLact.SelectedText);
                if (cbxMaeLacTarv.SelectedIndex >= 0)
                    obj_ccr.mot_hiv_tarv = Functions.ConvertComboValueToBool(cbxMaeLacTarv.SelectedText);
                if (cbxContactTB.SelectedIndex >= 0)
                    obj_ccr.contactotb = Functions.ConvertComboValueToBool(cbxContactTB.SelectedText);
                if (cbxDesnuAguda.SelectedIndex >= 0)
                    obj_ccr.desnutricao_aguda = cbxDesnuAguda.SelectedText;
                if (cbxExpHIV.SelectedIndex >= 0)
                    obj_ccr.exposicaoHIV = Functions.ConvertComboValueToBool(cbxExpHIV.SelectedText);
                if (!string.IsNullOrWhiteSpace(txtOutrCondRisc.Text))
                    obj_ccr.outracondicaorisco = txtOutrCondRisc.Text;
                if (Functions.IsDate(dtpDataIniIson.Text))
                    obj_ccr.pisoniazidainicio = dtpDataIniIson.Value;
                if (cbxIsoniazStatus.SelectedIndex >= 0)
                    obj_ccr.pisoniazida = cbxIsoniazStatus.SelectedText;
                if (cbxNutIdademen6.SelectedIndex >= 0)
                    obj_ccr.aleitmaternomenor6m = cbxNutIdademen6.SelectedText;
                if (cbxNutIdademaior6.SelectedIndex >= 0)
                    obj_ccr.aleitmaternomaior6m = Functions.ConvertComboValueToBool(cbxNutIdademaior6.SelectedText);
                if (Functions.IsNumber(txtATPU.Text))
                    obj_ccr.atpu = Convert.ToInt32(txtATPU.Text);
                if (cbxCBS.SelectedIndex >= 0)
                    obj_ccr.csb_nut_sup = Functions.ConvertComboValueToBool(cbxCBS.SelectedText);
                if (cbxRecuperada.SelectedIndex >= 0)
                    obj_ccr.recuperada = Functions.ConvertComboValueToBool(cbxRecuperada.SelectedText);
                if (cbxCTZ.SelectedIndex >= 0)
                    obj_ccr.ctz = cbxCTZ.SelectedText;
                if (cbxProfARV.SelectedIndex >= 0)
                    obj_ccr.profiaxia_arv = Functions.ConvertComboValueToBool(cbxProfARV.SelectedText);
                if (cbxColhPCRMen2Mes.SelectedIndex >= 0)
                    obj_ccr.colheitapcrmenor2mes = cbxColhPCRMen2Mes.SelectedText;
                if (cbxColhPCRMaior2Mes.SelectedIndex >= 0)
                    obj_ccr.colheitapcmaior2mes = cbxColhPCRMaior2Mes.SelectedText;
                if (cbxResPCRMen2Mes.SelectedIndex >= 0)
                    obj_ccr.resultadopcrmenor2meses = cbxResPCRMen2Mes.SelectedText;
                if (cbxResPCRMai2Mes.SelectedIndex >= 0)
                    obj_ccr.resultadopcrmaior2meses = cbxResPCRMai2Mes.SelectedText;
                if (cbxRestesRapMaior9mes.SelectedIndex >= 0)
                    obj_ccr.resultadotesterapido = cbxRestesRapMaior9mes.SelectedText;
                if (cbxResDefen.SelectedIndex >= 0)
                    obj_ccr.resultadofinal = cbxResDefen.SelectedText;
                if (cbxRestesRapCrinExpHIV.SelectedIndex >= 0)
                    obj_ccr.resulttrapido_nexp = cbxRestesRapCrinExpHIV.SelectedText;
                if (cbxSaidaCri.SelectedIndex >= 0)
                    obj_ccr.saidaccr = cbxSaidaCri.SelectedText;
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
                    obj_ccr_seg.ce18m = Functions.ConvertComboValueToBool(cbxCE18Meses.SelectedText);
                if (cbxResDef18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.resultado18 = Functions.ConvertComboValueToBool(cbxResDef18Meses.SelectedText);
                if (cbxTransCCS18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.transferidaCCS = Functions.ConvertComboValueToBool(cbxTransCCS18Meses.SelectedText);
                if (cbxTransConsIntgrCI18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.transferidaCI = Functions.ConvertComboValueToBool(cbxTransConsIntgrCI18Meses.SelectedText);
                if (cbxTransfOutrUniSanit.SelectedIndex >= 0)
                    obj_ccr_seg.transferidaUS = Functions.ConvertComboValueToBool(cbxTransfOutrUniSanit.SelectedText);
                if (cbxAbandono18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.abandono18 = Functions.ConvertComboValueToBool(cbxAbandono18Meses.SelectedText);
                if (cbxObito18Meses.SelectedIndex >= 0)
                    obj_ccr_seg.obito18 = Functions.ConvertComboValueToBool(cbxObito18Meses.SelectedText);
                if (string.IsNullOrWhiteSpace(txtMaeTarv5mesesCri.Text))
                    obj_ccr_seg.mothTarv5moth = txtMaeTarv5mesesCri.Text;
                if (cbxAME5Meses.SelectedIndex >= 0)
                    obj_ccr_seg.ame5m = Functions.ConvertComboValueToBool(cbxAME5Meses.SelectedText);
                if (cbxAleitMist5Meses.SelectedIndex >= 0)
                    obj_ccr_seg.am5m = Functions.ConvertComboValueToBool(cbxAleitMist5Meses.SelectedText);
                if (cbxRecuperada.SelectedIndex >= 0)
                    obj_ccr_seg.recuperada = Functions.ConvertComboValueToBool(cbxRecuperada.SelectedText);
                if (cbxTransfInternam.SelectedIndex >= 0)
                    obj_ccr_seg.transinter = Functions.ConvertComboValueToBool(cbxTransfInternam.SelectedText);
                if (cbxARV5Meses.SelectedIndex >= 0)
                    obj_ccr_seg.arv5m = Functions.ConvertComboValueToBool(cbxARV5Meses.SelectedText);
                if (cbxPCRMen2Meses.SelectedIndex >= 0)
                    obj_ccr_seg.pcrmen2m = Functions.ConvertComboValueToBool(cbxPCRMen2Meses.SelectedText);
                if (cbxPCRMaior2Meses.SelectedIndex >= 0)
                    obj_ccr_seg.pcrmai2m = Functions.ConvertComboValueToBool(cbxPCRMaior2Meses.SelectedText);
                if (cbxPCRposMenor2Meses.SelectedIndex >= 0)
                    obj_ccr_seg.pcrposmen2m = Functions.ConvertComboValueToBool(cbxPCRposMenor2Meses.SelectedText);
                if (cbxPCRposMaior2Meses.SelectedIndex >= 0)
                    obj_ccr_seg.pcrposmai2m = Functions.ConvertComboValueToBool(cbxPCRposMaior2Meses.SelectedText);
                if (cbxTB.SelectedIndex >= 0)
                    obj_ccr_seg.tb = Functions.ConvertComboValueToBool(cbxTB.SelectedText);
                if (cbxDAM.SelectedIndex >= 0)
                    obj_ccr_seg.dam = Functions.ConvertComboValueToBool(cbxDAM.SelectedText);
                if (cbxDAG.SelectedIndex >= 0)
                    obj_ccr_seg.dag = Functions.ConvertComboValueToBool(cbxDAG.SelectedText);
                if (cbxCE.SelectedIndex >= 0)
                    obj_ccr_seg.ce9m = Functions.ConvertComboValueToBool(cbxCE.SelectedText);
                if (cbxPNCTL.SelectedIndex >= 0)
                    obj_ccr_seg.pnctl = Functions.ConvertComboValueToBool(cbxPNCTL.SelectedText);
                if (cbxTPIComp.SelectedIndex >= 0)
                    obj_ccr_seg.tpi = Functions.ConvertComboValueToBool( cbxTPIComp.SelectedText);
                if (cbxAbandono.SelectedIndex >= 0)
                    obj_ccr_seg.abandono9 = Functions.ConvertComboValueToBool( cbxAbandono.SelectedText);
                if (cbxObito.SelectedIndex >= 0)
                    obj_ccr_seg.obito9 = Functions.ConvertComboValueToBool(cbxObito.SelectedText);

                obj_ccr_seg.UpdateEntity();





            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

