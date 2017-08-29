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

            clChild child = new clChild();
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNidCCR.Text))
                {
                    string nidcpn = txtNidCCR.Text;
                    List<clChild> List_Child = child.GetEntityList().Where(c => c.nid_ccr == nidcpn).ToList();
                    if (List_Child.Count > 0)
                    {
                        child = List_Child.FirstOrDefault();
                        BindChildControls(child);
                        clCCR ccr = new clCCR();
                        List<clCCR> list_ccr = ccr.GetEntityList().Where(c => c.idchild == child.id).ToList();

                        if (list_ccr.Count > 0)
                        {
                            clCCRSeg ccrseg = new clCCRSeg();
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
                            for (int i = 1; i < 7; i++)
                            {
                                ccr = new clCCR();
                                ccr.idchild = child.id;
                                ccr.nr_consulta = i;
                                ccr.InsertEntity();
                                if (i == 1)
                                {
                                    clCCRSeg ccrseg = new clCCRSeg();
                                    ccrseg.idchild = child.id;
                                    ccrseg.InsertEntity();
                                }
                            }

                        }
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BindCCRControls(clCCR ccr)
        {
            throw new NotImplementedException();
        }

        private void BindCCRSegControls(clCCRSeg ccrseg)
        {
            throw new NotImplementedException();
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


    }
}
