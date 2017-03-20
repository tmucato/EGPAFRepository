using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using smiDAL;

namespace smi
{
    public partial class frmCPN2 : Form
    {
        private string conn;
        private MySqlConnection con;
        //private String ConnectionString;
        private DataViewManager dsView;
        private DataSet ds;
        //private DataSet ds_mother;
       // private DataSet ds_livro;
        public frmCPN2()
        {
            InitializeComponent();
            // Setup DB-Connection
            con = Connection.GetSMIDataBaseConnection();
            con.Open();

            // Create the DataSet
            ds = new DataSet("cpn");
            dsView = ds.DefaultViewManager;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cpn", con);
            da.TableMappings.Add("Table", "cpn");
            da.Fill(ds);



           
           // MySqlDataAdapter da1 = new MySqlDataAdapter("SELECT nid_cpn FROM cpn", con);
            //DataSet ds_2 = new DataSet();
            //da1.Fill(ds_2);
            txtNid_CPN.Text = frmCPN.Variaveis.g_nid_cpn;
            //txtNid_CPN.DisplayMember = "nid_cpn";
            //cbxNidCPN.ValueMember = "";
            //cbxNidCPN.DataBind();
             txtNid_CPN.Enabled = true;

            // Fill the Dataset with livro, map Default Tablename
            // "Table" to "livro".
           // MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT nlivro FROM livro", con);
           // DataSet ds_livro = new DataSet();
            // da2.TableMappings.Add("Table", "mother");
            //da2.Fill(ds_livro);
            //cbxLivro.DataSource = ds_livro.Tables[0];
           // cbxLivro.DisplayMember = "nlivro";
            //cbxLivro.ValueMember = "nlivro";
            // cbxLivro.DataBind();
            //cbxLivro.Enabled = true;


            // Grid Databinding
            grdCPN2.DataSource = dsView;
            grdCPN2.DataMember = "cpn";

    

            chkserostatusdesc.DataBindings.Add("Checked", dsView, "cpn.serostatusdesc");
            chkserostatusneg.DataBindings.Add("Checked", dsView, "cpn.serostatusneg");
            chkserostatuspos.DataBindings.Add("Checked", dsView, "cpn.serostatuspos");

            cbxcpnhivtest1.DataBindings.Add("Text", dsView, "cpn.cpnhivtest1");
            cbxcpnhivtest2.DataBindings.Add("Text", dsView, "cpn.cpnhivtest2");
            cbxcpnhivtest3.DataBindings.Add("Text", dsView, "cpn.cpnhivtest3");
            cbxcpnhivtest4.DataBindings.Add("Text", dsView, "cpn.cpnhivtest4");
            cbxcpnhivtest5.DataBindings.Add("Text", dsView, "cpn.cpnhivtest5");
            cbxcpnhivtest6.DataBindings.Add("Text", dsView, "cpn.cpnhivtest6");

            cbxpartnerhivtest1.DataBindings.Add("Text", dsView, "cpn.partnerhivtest1");
            cbxpartnerhivtest2.DataBindings.Add("Text", dsView, "cpn.partnerhivtest2");
            cbxpartnerhivtest3.DataBindings.Add("Text", dsView, "cpn.partnerhivtest3");
            cbxpartnerhivtest4.DataBindings.Add("Text", dsView, "cpn.partnerhivtest4");
            cbxpartnerhivtest5.DataBindings.Add("Text", dsView, "cpn.partnerhivtest5");
            cbxpartnerhivtest6.DataBindings.Add("Text", dsView, "cpn.partnerhivtest6");

            chkctz.DataBindings.Add("Checked", dsView, "cpn.ctz");

            cbxctz_init_cont1.DataBindings.Add("Text", dsView, "cpn.ctz_init_cont1");
            cbxctz_init_cont2.DataBindings.Add("Text", dsView, "cpn.ctz_init_cont2");
            cbxctz_init_cont3.DataBindings.Add("Text", dsView, "cpn.ctz_init_cont3");
            cbxctz_init_cont4.DataBindings.Add("Text", dsView, "cpn.ctz_init_cont4");
            cbxctz_init_cont5.DataBindings.Add("Text", dsView, "cpn.ctz_init_cont5");
            cbxctz_init_cont6.DataBindings.Add("Text", dsView, "cpn.ctz_init_cont6");

            chktarv.DataBindings.Add("Checked", dsView, "cpn.tarv");

            chknvp1.DataBindings.Add("Checked", dsView, "cpn.nvp1");
            chknvp2.DataBindings.Add("Checked", dsView, "cpn.nvp2");
            chknvp3.DataBindings.Add("Checked", dsView, "cpn.nvp3");
            chknvp4.DataBindings.Add("Checked", dsView, "cpn.nvp4");
            chknvp5.DataBindings.Add("Checked", dsView, "cpn.nvp5");
            chknvp6.DataBindings.Add("Checked", dsView, "cpn.nvp6");

            chkazt_nvp1.DataBindings.Add("Checked", dsView, "cpn.azt_nvp1");
            chkazt_nvp2.DataBindings.Add("Checked", dsView, "cpn.azt_nvp2");
            chkazt_nvp3.DataBindings.Add("Checked", dsView, "cpn.azt_nvp3");
            chkazt_nvp4.DataBindings.Add("Checked", dsView, "cpn.azt_nvp4");
            chkazt_nvp5.DataBindings.Add("Checked", dsView, "cpn.azt_nvp5");
            chkazt_nvp6.DataBindings.Add("Checked", dsView, "cpn.azt_nvp6");

            chktarv_init_visit1.DataBindings.Add("Checked", dsView, "cpn.tarv_init_visit1");
            chktarv_init_visit2.DataBindings.Add("Checked", dsView, "cpn.tarv_init_visit2");
            chktarv_init_visit3.DataBindings.Add("Checked", dsView, "cpn.tarv_init_visit3");
            chktarv_init_visit4.DataBindings.Add("Checked", dsView, "cpn.tarv_init_visit4");
            chktarv_init_visit5.DataBindings.Add("Checked", dsView, "cpn.tarv_init_visit5");
            chktarv_init_visit6.DataBindings.Add("Checked", dsView, "cpn.tarv_init_visit6");

            chkarv_cont2.DataBindings.Add("Checked", dsView, "cpn.arv_cont2");
            chkarv_cont3.DataBindings.Add("Checked", dsView, "cpn.arv_cont3");
            chkarv_cont4.DataBindings.Add("Checked", dsView, "cpn.arv_cont4");
            chkarv_cont5.DataBindings.Add("Checked", dsView, "cpn.arv_cont5");
            chkarv_cont6.DataBindings.Add("Checked", dsView, "cpn.arv_cont6");

            cbxtip1.DataBindings.Add("Text", dsView, "cpn.tip1");
            cbxtip2.DataBindings.Add("Text", dsView, "cpn.tip2");
            cbxtip3.DataBindings.Add("Text", dsView, "cpn.tip3");
            cbxtip4.DataBindings.Add("Text", dsView, "cpn.tip4");
            cbxtip5.DataBindings.Add("Text", dsView, "cpn.tip5");
            cbxtip6.DataBindings.Add("Text", dsView, "cpn.tip6");

            cbxbednet1.DataBindings.Add("Text", dsView, "cpn.bednet1");
            cbxbednet2.DataBindings.Add("Text", dsView, "cpn.bednet2");
            cbxbednet3.DataBindings.Add("Text", dsView, "cpn.bednet3");
            cbxbednet4.DataBindings.Add("Text", dsView, "cpn.bednet4");
            cbxbednet5.DataBindings.Add("Text", dsView, "cpn.bednet5");
            cbxbednet6.DataBindings.Add("Text", dsView, "cpn.bednet6");

            cbxtdr_htz1.DataBindings.Add("Text", dsView, "cpn.tdr_htz1");
            cbxtdr_htz2.DataBindings.Add("Text", dsView, "cpn.tdr_htz2");
            cbxtdr_htz3.DataBindings.Add("Text", dsView, "cpn.tdr_htz3");
            cbxtdr_htz4.DataBindings.Add("Text", dsView, "cpn.tdr_htz4");
            cbxtdr_htz5.DataBindings.Add("Text", dsView, "cpn.tdr_htz5");
            cbxtdr_htz6.DataBindings.Add("Text", dsView, "cpn.tdr_htz6");

            cbxresult_tdr_htz1.DataBindings.Add("Text", dsView, "cpn.result_tdr_htz1");
            cbxresult_tdr_htz2.DataBindings.Add("Text", dsView, "cpn.result_tdr_htz2");
            cbxresult_tdr_htz3.DataBindings.Add("Text", dsView, "cpn.result_tdr_htz3");
            cbxresult_tdr_htz4.DataBindings.Add("Text", dsView, "cpn.result_tdr_htz4");
            cbxresult_tdr_htz5.DataBindings.Add("Text", dsView, "cpn.result_tdr_htz5");
            cbxresult_tdr_htz6.DataBindings.Add("Text", dsView, "cpn.result_tdr_htz6");

            cbxpos_malaria_treated1.DataBindings.Add("Text", dsView, "cpn.pos_malaria_treated1");
            cbxpos_malaria_treated2.DataBindings.Add("Text", dsView, "cpn.pos_malaria_treated2");
            cbxpos_malaria_treated3.DataBindings.Add("Text", dsView, "cpn.pos_malaria_treated3");
            cbxpos_malaria_treated4.DataBindings.Add("Text", dsView, "cpn.pos_malaria_treated4");
            cbxpos_malaria_treated5.DataBindings.Add("Text", dsView, "cpn.pos_malaria_treated5");
            cbxpos_malaria_treated6.DataBindings.Add("Text", dsView, "cpn.pos_malaria_treated6");

            cbxhpp1.DataBindings.Add("Text", dsView, "cpn.hpp1");
            cbxhpp2.DataBindings.Add("Text", dsView, "cpn.hpp2");
            cbxhpp3.DataBindings.Add("Text", dsView, "cpn.hpp3");
            cbxhpp4.DataBindings.Add("Text", dsView, "cpn.hpp4");
            cbxhpp5.DataBindings.Add("Text", dsView, "cpn.hpp5");
            cbxhpp6.DataBindings.Add("Text", dsView, "cpn.hpp6");

            chkvat_1_dose1.DataBindings.Add("Checked", dsView, "cpn.vat_1_dose1");
            chkvat_1_dose2.DataBindings.Add("Checked", dsView, "cpn.vat_1_dose2");
            chkvat_1_dose3.DataBindings.Add("Checked", dsView, "cpn.vat_1_dose3");
            chkvat_1_dose4.DataBindings.Add("Checked", dsView, "cpn.vat_1_dose4");
            chkvat_1_dose5.DataBindings.Add("Checked", dsView, "cpn.vat_1_dose5");
            chkvat_1_dose6.DataBindings.Add("Checked", dsView, "cpn.vat_1_dose6");

            chkvat_2_5_dose1.DataBindings.Add("Checked", dsView, "cpn.vat_2_5_dose1");
            chkvat_2_5_dose2.DataBindings.Add("Checked", dsView, "cpn.vat_2_5_dose2");
            chkvat_2_5_dose3.DataBindings.Add("Checked", dsView, "cpn.vat_2_5_dose3");
            chkvat_2_5_dose4.DataBindings.Add("Checked", dsView, "cpn.vat_2_5_dose4");
            chkvat_2_5_dose5.DataBindings.Add("Checked", dsView, "cpn.vat_2_5_dose5");
            chkvat_2_5_dose6.DataBindings.Add("Checked", dsView, "cpn.vat_2_5_dose6");

            cbxtb_isoniazid1.DataBindings.Add("Text", dsView, "cpn.tb_isoniazid1");
            cbxtb_isoniazid2.DataBindings.Add("Text", dsView, "cpn.tb_isoniazid2");
            cbxtb_isoniazid3.DataBindings.Add("Text", dsView, "cpn.tb_isoniazid3");
            cbxtb_isoniazid4.DataBindings.Add("Text", dsView, "cpn.tb_isoniazid4");
            cbxtb_isoniazid5.DataBindings.Add("Text", dsView, "cpn.tb_isoniazid5");
            cbxtb_isoniazid6.DataBindings.Add("Text", dsView, "cpn.tb_isoniazid6");

            cbxtb_treatment1.DataBindings.Add("Text", dsView, "cpn.tb_treatment1");
            cbxtb_treatment2.DataBindings.Add("Text", dsView, "cpn.tb_treatment2");
            cbxtb_treatment3.DataBindings.Add("Text", dsView, "cpn.tb_treatment3");
            cbxtb_treatment4.DataBindings.Add("Text", dsView, "cpn.tb_treatment4");
            cbxtb_treatment5.DataBindings.Add("Text", dsView, "cpn.tb_treatment5");
            cbxtb_treatment6.DataBindings.Add("Text", dsView, "cpn.tb_treatment6");

            txtobs1.DataBindings.Add("Text", dsView, "cpn.obs1");
            txtobs2.DataBindings.Add("Text", dsView, "cpn.obs2");
            txtobs3.DataBindings.Add("Text", dsView, "cpn.obs3");
            txtobs4.DataBindings.Add("Text", dsView, "cpn.obs4");
            txtobs5.DataBindings.Add("Text", dsView, "cpn.obs5");
            txtobs6.DataBindings.Add("Text", dsView, "cpn.obs6");

            txtprovidername1.DataBindings.Add("Text", dsView, "cpn.providername1");
            txtprovidername2.DataBindings.Add("Text", dsView, "cpn.providername2");
            txtprovidername3.DataBindings.Add("Text", dsView, "cpn.providername3");
            txtprovidername4.DataBindings.Add("Text", dsView, "cpn.providername4");
            txtprovidername5.DataBindings.Add("Text", dsView, "cpn.providername5");
            txtprovidername6.DataBindings.Add("Text", dsView, "cpn.providername6");

            //rbAG1.DataBindings.Add("Checked", dsView, "cpn.agegroup1");
            //rbAG2.DataBindings.Add("Checked", dsView, "cpn.agegroup2");
            //rbAG3.DataBindings.Add("Checked", dsView, "cpn.agegroup3");
            //rbAG4.DataBindings.Add("Checked", dsView, "cpn.agegroup4");

            //txtGestage1.DataBindings.Add("Text", dsView, "cpn.gestationalage1");
            //txtGestage2.DataBindings.Add("Text", dsView, "cpn.gestationalage2");
            //txtGestage3.DataBindings.Add("Text", dsView, "cpn.gestationalage3");
            //txtGestage4.DataBindings.Add("Text", dsView, "cpn.gestationalage4");
            //txtGestage5.DataBindings.Add("Text", dsView, "cpn.gestationalage5");
            //txtGestage6.DataBindings.Add("Text", dsView, "cpn.gestationalage6");

            //chkGageless12.DataBindings.Add("Checked", dsView, "cpn.gageless12");

            //chkPpres1.DataBindings.Add("Checked", dsView, "cpn.partnerpresence1");
            //chkPpres2.DataBindings.Add("Checked", dsView, "cpn.partnerpresence2");
            //chkPpres3.DataBindings.Add("Checked", dsView, "cpn.partnerpresence3");
            //chkPpres4.DataBindings.Add("Checked", dsView, "cpn.partnerpresence4");
            //chkPpres5.DataBindings.Add("Checked", dsView, "cpn.partnerpresence5");
            //chkPpres6.DataBindings.Add("Checked", dsView, "cpn.partnerpresence6");

            //cbxWgyno2.DataBindings.Add("Text", dsView, "cpn.weightgainyno2");
            //cbxWgyno3.DataBindings.Add("Text", dsView, "cpn.weightgainyno3");
            //cbxWgyno4.DataBindings.Add("Text", dsView, "cpn.weightgainyno4");
            //cbxWgyno5.DataBindings.Add("Text", dsView, "cpn.weightgainyno5");
            //cbxWgyno6.DataBindings.Add("Text", dsView, "cpn.weightgainyno6");

            //txtWeight1.DataBindings.Add("Text", dsView, "cpn.weight1");
            //txtWeight2.DataBindings.Add("Text", dsView, "cpn.weight2");
            //txtWeight3.DataBindings.Add("Text", dsView, "cpn.weight3");
            //txtWeight4.DataBindings.Add("Text", dsView, "cpn.weight4");
            //txtWeight5.DataBindings.Add("Text", dsView, "cpn.weight5");
            //txtWeight6.DataBindings.Add("Text", dsView, "cpn.weight6");

            //chkDag1.DataBindings.Add("Checked", dsView, "cpn.dag1");
            //chkDag2.DataBindings.Add("Checked", dsView, "cpn.dag2");
            //chkDag3.DataBindings.Add("Checked", dsView, "cpn.dag3");
            //chkDag4.DataBindings.Add("Checked", dsView, "cpn.dag4");
            //chkDag5.DataBindings.Add("Checked", dsView, "cpn.dag5");
            //chkDag6.DataBindings.Add("Checked", dsView, "cpn.dag6");

            //chkDam1.DataBindings.Add("Checked", dsView, "cpn.dam1");
            //chkDam2.DataBindings.Add("Checked", dsView, "cpn.dam2");
            //chkDam3.DataBindings.Add("Checked", dsView, "cpn.dam3");
            //chkDam4.DataBindings.Add("Checked", dsView, "cpn.dam4");
            //chkDam5.DataBindings.Add("Checked", dsView, "cpn.dam5");
            //chkDam6.DataBindings.Add("Checked", dsView, "cpn.dam6");

            //txtSupnuttr1.DataBindings.Add("Text", dsView, "cpn.supnutr1");
            //txtSupnuttr2.DataBindings.Add("Text", dsView, "cpn.supnutr2");
            //txtSupnuttr3.DataBindings.Add("Text", dsView, "cpn.supnutr3");
            //txtSupnuttr4.DataBindings.Add("Text", dsView, "cpn.supnutr4");
            //txtSupnuttr5.DataBindings.Add("Text", dsView, "cpn.supnutr5");
            //txtSupnuttr6.DataBindings.Add("Text", dsView, "cpn.supnutr6");

            //cbxResultcured2.DataBindings.Add("Text", dsView, "cpn.resultcured2");
            //cbxResultcured3.DataBindings.Add("Text", dsView, "cpn.resultcured3");
            //cbxResultcured4.DataBindings.Add("Text", dsView, "cpn.resultcured4");
            //cbxResultcured5.DataBindings.Add("Text", dsView, "cpn.resultcured5");
            //cbxResultcured6.DataBindings.Add("Text", dsView, "cpn.resultcured6");

            //cbxReceiveddesparasitante1.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante1");
            //cbxReceiveddesparasitante2.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante2");
            //cbxReceiveddesparasitante3.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante3");
            //cbxReceiveddesparasitante4.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante4");
            //cbxReceiveddesparasitante5.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante5");
            //cbxReceiveddesparasitante6.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante6");

            //cbxsalferr_acfolico1.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico1");
            //cbxsalferr_acfolico2.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico2");
            //cbxsalferr_acfolico3.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico3");
            //cbxsalferr_acfolico4.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico4");
            //cbxsalferr_acfolico5.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico5");
            //cbxsalferr_acfolico6.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico6");

            //cbxta1.DataBindings.Add("Text", dsView, "cpn.ta1");
            //cbxta2.DataBindings.Add("Text", dsView, "cpn.ta2");
            //cbxta3.DataBindings.Add("Text", dsView, "cpn.ta3");
            //cbxta4.DataBindings.Add("Text", dsView, "cpn.ta4");
            //cbxta5.DataBindings.Add("Text", dsView, "cpn.ta5");
            //cbxta6.DataBindings.Add("Text", dsView, "cpn.ta6");

            //cbxHgb1.DataBindings.Add("Text", dsView, "cpn.hgb1");
            //cbxHgb2.DataBindings.Add("Text", dsView, "cpn.hgb2");
            //cbxHgb3.DataBindings.Add("Text", dsView, "cpn.hgb3");
            //cbxHgb4.DataBindings.Add("Text", dsView, "cpn.hgb4");
            //cbxHgb5.DataBindings.Add("Text", dsView, "cpn.hgb5");
            //cbxHgb6.DataBindings.Add("Text", dsView, "cpn.hgb6");

            //cbxProteinuria1.DataBindings.Add("Text", dsView, "cpn.proteinuria1");
            //cbxProteinuria2.DataBindings.Add("Text", dsView, "cpn.proteinuria2");
            //cbxProteinuria3.DataBindings.Add("Text", dsView, "cpn.proteinuria3");
            //cbxProteinuria4.DataBindings.Add("Text", dsView, "cpn.proteinuria4");
            //cbxProteinuria5.DataBindings.Add("Text", dsView, "cpn.proteinuria5");
            //cbxProteinuria6.DataBindings.Add("Text", dsView, "cpn.proteinuria6");

            //cbxGlicosuria1.DataBindings.Add("Text", dsView, "cpn.glicosuria1");
            //cbxGlicosuria2.DataBindings.Add("Text", dsView, "cpn.glicosuria2");
            //cbxGlicosuria3.DataBindings.Add("Text", dsView, "cpn.glicosuria3");
            //cbxGlicosuria4.DataBindings.Add("Text", dsView, "cpn.glicosuria4");
            //cbxGlicosuria5.DataBindings.Add("Text", dsView, "cpn.glicosuria5");
            //cbxGlicosuria6.DataBindings.Add("Text", dsView, "cpn.glicosuria6");

            //chkits_ulceragenital1.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital1");
            //chkits_ulceragenital2.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital2");
            //chkits_ulceragenital3.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital3");
            //chkits_ulceragenital4.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital4");
            //chkits_ulceragenital5.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital5");
            //chkits_ulceragenital6.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital6");

            //chkits_leucorreia1.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia1");
            //chkits_leucorreia2.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia2");
            //chkits_leucorreia3.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia3");
            //chkits_leucorreia4.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia4");
            //chkits_leucorreia5.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia5");
            //chkits_leucorreia6.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia6");

            //cbxits_syndromictreatment1.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment1");
            //cbxits_syndromictreatment2.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment2");
            //cbxits_syndromictreatment3.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment3");
            //cbxits_syndromictreatment4.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment4");
            //cbxits_syndromictreatment5.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment5");
            //cbxits_syndromictreatment6.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment6");

            //cbxits_syphilistesting1.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting1");
            //cbxits_syphilistesting2.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting2");
            //cbxits_syphilistesting3.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting3");
            //cbxits_syphilistesting4.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting4");
            //cbxits_syphilistesting5.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting5");
            //cbxits_syphilistesting6.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting6");

            //cbxits_wsyphilistreat1.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat1");
            //cbxits_wsyphilistreat2.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat2");
            //cbxits_wsyphilistreat3.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat3");
            //cbxits_wsyphilistreat4.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat4");
            //cbxits_wsyphilistreat5.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat5");
            //cbxits_wsyphilistreat6.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat6");

            //cbxits_psyphilistreat1.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat1");
            //cbxits_psyphilistreat2.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat2");
            //cbxits_psyphilistreat3.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat3");
            //cbxits_psyphilistreat4.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat4");
            //cbxits_psyphilistreat5.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat5");
            //cbxits_psyphilistreat6.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat6");

            //chkCons_more4.DataBindings.Add("Checked", dsView, "cpn.cons_more4");
            //chkPartnerpreence.DataBindings.Add("Checked", dsView, "cpn.partnerpreence");
            //cbxWeightgainyno.DataBindings.Add("Text", dsView, "cpn.weightgainyno");

            //chkDag.DataBindings.Add("Checked", dsView, "cpn.dag");
            //chkDam.DataBindings.Add("Checked", dsView, "cpn.dam");
            //cbxSupnutr.DataBindings.Add("Text", dsView, "cpn.supnutr");
            //cbxResultcured.DataBindings.Add("Text", dsView, "cpn.resultcured");
            //cbxResultabandon.DataBindings.Add("Text", dsView, "cpn.resultabandon");
            //cbxReceiveddesparasitante.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante");
            //chkSalferr_more3.DataBindings.Add("Checked", dsView, "cpn.salferr_more3");
            //chkIts_diag.DataBindings.Add("Checked", dsView, "cpn.its_diag");

            //cbxIts_treatment.DataBindings.Add("Text", dsView, "cpn.its_treatment");
            //cbxIts_syphilistesting.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting");
            //cbxIts_psyphilistreat.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat");
            //chkIts_wsyphilistreat.DataBindings.Add("Checked", dsView, "cpn.its_wsyphilistreat");
        }
        private void db_connection()
        {
            try
            {
                conn = "server=localhost;User Id=root;password=WakaBanga2;database=smi;Persist Security Info=True;";
                con = new MySqlConnection(conn);
                con.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        private void textBox_FormatDate(object sender, ConvertEventArgs e)
        {
            // We only deal with converting to dates and strings
            if (e.DesiredType != typeof(DateTime)) return;
            if (e.Value.GetType() != typeof(string)) return;

            string value = (string)e.Value;

            try
            {
                e.Value = DateTime.Parse(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Parse the textbox contents and turn them back into a date
        private void textBox_ParseDate(object sender, ConvertEventArgs e)
        {

            // We only deal with converting to strings from dates
            if (e.DesiredType != typeof(string)) return;
            if (e.Value.GetType() != typeof(DateTime)) return;

            DateTime dt = (DateTime)e.Value;
            e.Value = dt.ToShortDateString();
        }

        

    }
}
