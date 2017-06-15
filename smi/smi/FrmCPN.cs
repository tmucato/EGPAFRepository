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
                                cpn = list_cpn.Where(c => c.nr_consulta == Convert.ToInt32(cbxNrConsultaMain.SelectedText)).FirstOrDefault();
                                BindCPNControls(cpn);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 6; i++)
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
                        }
                    }
                    else
                    {



                    }



                }






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BindCPNControls(clCPN cpn)
        {
            throw new NotImplementedException();
        }

        private void BindCPNFinalControls(clCPNFinal cnp_fin)
        {
            throw new NotImplementedException();
        }

        private void btnGravarMain_Click(object sender, EventArgs e)
        {

        }

        private void btnAnteriorPage3_Click(object sender, EventArgs e)
        {
            this.tabCPN.SelectedIndex = 1;
        }
    }
}
