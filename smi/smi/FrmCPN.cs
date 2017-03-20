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


namespace smi
{
    
    public partial class frmCPN : Form
    {
        public int RotateAngle { get; set; }  // to rotate your text
        public string NewText { get; set; }   // to draw text
        public string g_nidcpn { get; set; }
        private string conn;
        private MySqlConnection connect;
        //private String ConnectionString;
        private DataViewManager dsView;
        private DataSet ds;
        private DataSet ds_mother;
        private DataSet ds_livro;
        public static class Variaveis
        {
            public static string Usuario;
            public static string g_nid_cpn;
        }
        public frmCPN()
        {
            InitializeComponent();
            // Setup DB-Connection
            MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=WakaBanga2;database=smi;Persist Security Info=True");
            con.Open();

            // Create the DataSet
            ds = new DataSet("cpn");
            dsView = ds.DefaultViewManager;

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cpn", con);
            da.TableMappings.Add("Table", "cpn");
            da.Fill(ds);
            
            

            // Fill the Dataset with cpn, map Default Tablename
            // "Table" to "cpn".
            MySqlDataAdapter da1 = new MySqlDataAdapter("SELECT nid_cpn FROM mother", con);
            DataSet ds_mother = new DataSet();
            da1.Fill(ds_mother);
            cbxNidCPN.DataSource = ds_mother.Tables[0];
            cbxNidCPN.DisplayMember = "nid_cpn";
            //cbxNidCPN.ValueMember = "";
            //cbxNidCPN.DataBind();
            cbxNidCPN.Enabled = true;

            // Fill the Dataset with livro, map Default Tablename
            // "Table" to "livro".
            MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT nlivro FROM livro", con);
            DataSet ds_livro = new DataSet();
           // da2.TableMappings.Add("Table", "mother");
            da2.Fill(ds_livro);
            cbxLivro.DataSource = ds_livro.Tables[0];
            cbxLivro.DisplayMember = "nlivro";
            //cbxLivro.ValueMember = "nlivro";
           // cbxLivro.DataBind();
            cbxLivro.Enabled = true;


            // Grid Databinding
            grdCPN.DataSource = dsView;
            grdCPN.DataMember = "cpn";
            

            // Text Columns Databinding
            txtID.DataBindings.Add("Text", dsView, "cpn.id");
            cbxNidCPN.DataBindings.Add("Text", dsView, "cpn.nid_cpn");
            txtNidTarv.DataBindings.Add("Text", dsView, "cpn.nid_tarv");
            txtName.DataBindings.Add("Text", dsView, "cpn.name");
            txtResidence.DataBindings.Add("Text", dsView, "cpn.residence");
            txtPhone.DataBindings.Add("Text", dsView, "cpn.phone");

            txtIDmother.DataBindings.Add("Text", dsView, "cpn.idmother");
            txtYear.DataBindings.Add("Text", dsView, "cpn.nyear");
            cbxLivro.DataBindings.Add("Text", dsView, "cpn.nlivro");
           // txtID.DataBindings.Add("Text", dsView, "cpn.id");
           // txtID.DataBindings.Add("Text", dsView, "cpn.id");
            //dtpDOB.DataBindings.Add("Value", dsView, "mother.dob");
            Binding vdateBinding1 = new Binding("Text", dsView, "cpn.visdate1");
            vdateBinding1.Format += new ConvertEventHandler(this.textBox_FormatDate);
            vdateBinding1.Parse += new ConvertEventHandler(this.textBox_ParseDate);
            txtVisdate1.DataBindings.Add(vdateBinding1);

            Binding vdateBinding2 = new Binding("Text", dsView, "cpn.visdate2");
            vdateBinding2.Format += new ConvertEventHandler(this.textBox_FormatDate);
            vdateBinding2.Parse += new ConvertEventHandler(this.textBox_ParseDate);
            txtVisdate2.DataBindings.Add(vdateBinding2);

            Binding vdateBinding3 = new Binding("Text", dsView, "cpn.visdate3");
            vdateBinding3.Format += new ConvertEventHandler(this.textBox_FormatDate);
            vdateBinding3.Parse += new ConvertEventHandler(this.textBox_ParseDate);
            txtVisdate3.DataBindings.Add(vdateBinding3);

            Binding vdateBinding4 = new Binding("Text", dsView, "cpn.visdate4");
            vdateBinding4.Format += new ConvertEventHandler(this.textBox_FormatDate);
            vdateBinding4.Parse += new ConvertEventHandler(this.textBox_ParseDate);
            txtVisdate4.DataBindings.Add(vdateBinding4);

            Binding vdateBinding5 = new Binding("Text", dsView, "cpn.visdate5");
            vdateBinding5.Format += new ConvertEventHandler(this.textBox_FormatDate);
            vdateBinding5.Parse += new ConvertEventHandler(this.textBox_ParseDate);
            txtVisdate5.DataBindings.Add(vdateBinding5);

            Binding vdateBinding6 = new Binding("Text", dsView, "cpn.visdate6");
            vdateBinding6.Format += new ConvertEventHandler(this.textBox_FormatDate);
            vdateBinding6.Parse += new ConvertEventHandler(this.textBox_ParseDate);
            txtVisdate6.DataBindings.Add(vdateBinding6);

            rbAG1.DataBindings.Add("Checked", dsView, "cpn.agegroup1");
            rbAG2.DataBindings.Add("Checked", dsView, "cpn.agegroup2");
            rbAG3.DataBindings.Add("Checked", dsView, "cpn.agegroup3");
            rbAG4.DataBindings.Add("Checked", dsView, "cpn.agegroup4");

            txtGestage1.DataBindings.Add("Text", dsView, "cpn.gestationalage1");
            txtGestage2.DataBindings.Add("Text", dsView, "cpn.gestationalage2");
            txtGestage3.DataBindings.Add("Text", dsView, "cpn.gestationalage3");
            txtGestage4.DataBindings.Add("Text", dsView, "cpn.gestationalage4");
            txtGestage5.DataBindings.Add("Text", dsView, "cpn.gestationalage5");
            txtGestage6.DataBindings.Add("Text", dsView, "cpn.gestationalage6");

            chkGageless12.DataBindings.Add("Checked", dsView, "cpn.gageless12");

            chkPpres1.DataBindings.Add("Checked", dsView, "cpn.partnerpresence1");
            chkPpres2.DataBindings.Add("Checked", dsView, "cpn.partnerpresence2");
            chkPpres3.DataBindings.Add("Checked", dsView, "cpn.partnerpresence3");
            chkPpres4.DataBindings.Add("Checked", dsView, "cpn.partnerpresence4");
            chkPpres5.DataBindings.Add("Checked", dsView, "cpn.partnerpresence5");
            chkPpres6.DataBindings.Add("Checked", dsView, "cpn.partnerpresence6");

            cbxWgyno2.DataBindings.Add("Text", dsView, "cpn.weightgainyno2");
            cbxWgyno3.DataBindings.Add("Text", dsView, "cpn.weightgainyno3");
            cbxWgyno4.DataBindings.Add("Text", dsView, "cpn.weightgainyno4");
            cbxWgyno5.DataBindings.Add("Text", dsView, "cpn.weightgainyno5");
            cbxWgyno6.DataBindings.Add("Text", dsView, "cpn.weightgainyno6");

            txtWeight1.DataBindings.Add("Text", dsView, "cpn.weight1");
            txtWeight2.DataBindings.Add("Text", dsView, "cpn.weight2");
            txtWeight3.DataBindings.Add("Text", dsView, "cpn.weight3");
            txtWeight4.DataBindings.Add("Text", dsView, "cpn.weight4");
            txtWeight5.DataBindings.Add("Text", dsView, "cpn.weight5");
            txtWeight6.DataBindings.Add("Text", dsView, "cpn.weight6");

            chkDag1.DataBindings.Add("Checked", dsView, "cpn.dag1");
            chkDag2.DataBindings.Add("Checked", dsView, "cpn.dag2");
            chkDag3.DataBindings.Add("Checked", dsView, "cpn.dag3");
            chkDag4.DataBindings.Add("Checked", dsView, "cpn.dag4");
            chkDag5.DataBindings.Add("Checked", dsView, "cpn.dag5");
            chkDag6.DataBindings.Add("Checked", dsView, "cpn.dag6");

            chkDam1.DataBindings.Add("Checked", dsView, "cpn.dam1");
            chkDam2.DataBindings.Add("Checked", dsView, "cpn.dam2");
            chkDam3.DataBindings.Add("Checked", dsView, "cpn.dam3");
            chkDam4.DataBindings.Add("Checked", dsView, "cpn.dam4");
            chkDam5.DataBindings.Add("Checked", dsView, "cpn.dam5");
            chkDam6.DataBindings.Add("Checked", dsView, "cpn.dam6");

            txtSupnuttr1.DataBindings.Add("Text", dsView, "cpn.supnutr1");
            txtSupnuttr2.DataBindings.Add("Text", dsView, "cpn.supnutr2");
            txtSupnuttr3.DataBindings.Add("Text", dsView, "cpn.supnutr3");
            txtSupnuttr4.DataBindings.Add("Text", dsView, "cpn.supnutr4");
            txtSupnuttr5.DataBindings.Add("Text", dsView, "cpn.supnutr5");
            txtSupnuttr6.DataBindings.Add("Text", dsView, "cpn.supnutr6");

            cbxResultcured2.DataBindings.Add("Text", dsView, "cpn.resultcured2");
            cbxResultcured3.DataBindings.Add("Text", dsView, "cpn.resultcured3");
            cbxResultcured4.DataBindings.Add("Text", dsView, "cpn.resultcured4");
            cbxResultcured5.DataBindings.Add("Text", dsView, "cpn.resultcured5");
            cbxResultcured6.DataBindings.Add("Text", dsView, "cpn.resultcured6");

            cbxReceiveddesparasitante1.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante1");
            cbxReceiveddesparasitante2.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante2");
            cbxReceiveddesparasitante3.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante3");
            cbxReceiveddesparasitante4.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante4");
            cbxReceiveddesparasitante5.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante5");
            cbxReceiveddesparasitante6.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante6");

            cbxsalferr_acfolico1.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico1");
            cbxsalferr_acfolico2.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico2");
            cbxsalferr_acfolico3.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico3");
            cbxsalferr_acfolico4.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico4");
            cbxsalferr_acfolico5.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico5");
            cbxsalferr_acfolico6.DataBindings.Add("Text", dsView, "cpn.salferr_acfolico6");

            cbxta1.DataBindings.Add("Text", dsView, "cpn.ta1");
            cbxta2.DataBindings.Add("Text", dsView, "cpn.ta2");
            cbxta3.DataBindings.Add("Text", dsView, "cpn.ta3");
            cbxta4.DataBindings.Add("Text", dsView, "cpn.ta4");
            cbxta5.DataBindings.Add("Text", dsView, "cpn.ta5");
            cbxta6.DataBindings.Add("Text", dsView, "cpn.ta6");

            cbxHgb1.DataBindings.Add("Text", dsView, "cpn.hgb1");
            cbxHgb2.DataBindings.Add("Text", dsView, "cpn.hgb2");
            cbxHgb3.DataBindings.Add("Text", dsView, "cpn.hgb3");
            cbxHgb4.DataBindings.Add("Text", dsView, "cpn.hgb4");
            cbxHgb5.DataBindings.Add("Text", dsView, "cpn.hgb5");
            cbxHgb6.DataBindings.Add("Text", dsView, "cpn.hgb6");

            cbxProteinuria1.DataBindings.Add("Text", dsView, "cpn.proteinuria1");
            cbxProteinuria2.DataBindings.Add("Text", dsView, "cpn.proteinuria2");
            cbxProteinuria3.DataBindings.Add("Text", dsView, "cpn.proteinuria3");
            cbxProteinuria4.DataBindings.Add("Text", dsView, "cpn.proteinuria4");
            cbxProteinuria5.DataBindings.Add("Text", dsView, "cpn.proteinuria5");
            cbxProteinuria6.DataBindings.Add("Text", dsView, "cpn.proteinuria6");

            cbxGlicosuria1.DataBindings.Add("Text", dsView, "cpn.glicosuria1");
            cbxGlicosuria2.DataBindings.Add("Text", dsView, "cpn.glicosuria2");
            cbxGlicosuria3.DataBindings.Add("Text", dsView, "cpn.glicosuria3");
            cbxGlicosuria4.DataBindings.Add("Text", dsView, "cpn.glicosuria4");
            cbxGlicosuria5.DataBindings.Add("Text", dsView, "cpn.glicosuria5");
            cbxGlicosuria6.DataBindings.Add("Text", dsView, "cpn.glicosuria6");

            chkits_ulceragenital1.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital1");
            chkits_ulceragenital2.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital2");
            chkits_ulceragenital3.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital3");
            chkits_ulceragenital4.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital4");
            chkits_ulceragenital5.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital5");
            chkits_ulceragenital6.DataBindings.Add("Checked", dsView, "cpn.its_ulceragenital6");

            chkits_leucorreia1.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia1");
            chkits_leucorreia2.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia2");
            chkits_leucorreia3.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia3");
            chkits_leucorreia4.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia4");
            chkits_leucorreia5.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia5");
            chkits_leucorreia6.DataBindings.Add("Checked", dsView, "cpn.its_leucorreia6");

            cbxits_syndromictreatment1.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment1");
            cbxits_syndromictreatment2.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment2");
            cbxits_syndromictreatment3.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment3");
            cbxits_syndromictreatment4.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment4");
            cbxits_syndromictreatment5.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment5");
            cbxits_syndromictreatment6.DataBindings.Add("Text", dsView, "cpn.its_syndromictreatment6");

            cbxits_syphilistesting1.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting1");
            cbxits_syphilistesting2.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting2");
            cbxits_syphilistesting3.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting3");
            cbxits_syphilistesting4.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting4");
            cbxits_syphilistesting5.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting5");
            cbxits_syphilistesting6.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting6");

            cbxits_wsyphilistreat1.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat1");
            cbxits_wsyphilistreat2.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat2");
            cbxits_wsyphilistreat3.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat3");
            cbxits_wsyphilistreat4.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat4");
            cbxits_wsyphilistreat5.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat5");
            cbxits_wsyphilistreat6.DataBindings.Add("Text", dsView, "cpn.its_wsyphilistreat6");

            cbxits_psyphilistreat1.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat1");
            cbxits_psyphilistreat2.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat2");
            cbxits_psyphilistreat3.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat3");
            cbxits_psyphilistreat4.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat4");
            cbxits_psyphilistreat5.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat5");
            cbxits_psyphilistreat6.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat6");

            chkCons_more4.DataBindings.Add("Checked", dsView, "cpn.cons_more4");
            chkPartnerpreence.DataBindings.Add("Checked", dsView, "cpn.partnerpreence");
            cbxWeightgainyno.DataBindings.Add("Text", dsView, "cpn.weightgainyno");

            chkDag.DataBindings.Add("Checked", dsView, "cpn.dag");
            chkDam.DataBindings.Add("Checked", dsView, "cpn.dam");
            cbxSupnutr.DataBindings.Add("Text", dsView, "cpn.supnutr");
            cbxResultcured.DataBindings.Add("Text", dsView, "cpn.resultcured");
            cbxResultabandon.DataBindings.Add("Text", dsView, "cpn.resultabandon");
            cbxReceiveddesparasitante.DataBindings.Add("Text", dsView, "cpn.receiveddesparasitante");
            chkSalferr_more3.DataBindings.Add("Checked", dsView, "cpn.salferr_more3");
            chkIts_diag.DataBindings.Add("Checked", dsView, "cpn.its_diag");

            cbxIts_treatment.DataBindings.Add("Text", dsView, "cpn.its_treatment");
            cbxIts_syphilistesting.DataBindings.Add("Text", dsView, "cpn.its_syphilistesting");
            cbxIts_psyphilistreat.DataBindings.Add("Text", dsView, "cpn.its_psyphilistreat");
            chkIts_wsyphilistreat.DataBindings.Add("Checked", dsView, "cpn.its_wsyphilistreat");
       }

        private void cbxNidCPN_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxNidCPN.SelectedIndex != -1)
            {
                
              //Para estabelecer a conexao
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * from mother where nid_cpn='" + this.cbxNidCPN.Text +"'";
                cmd.Connection = connect;
                MySqlDataReader datamother = cmd.ExecuteReader();
                if (datamother.Read())
                    {
                        this.txtNidTarv.Text = (string)datamother["nid_tarv"];
                        this.txtIDmother.Text = datamother["id"].ToString();
                        this.txtName.Text = (string)datamother["name"];
                        this.txtResidence.Text = (string)datamother["residence"];
                        this.txtPhone.Text = (string)datamother["phone"];
                    }
           }
        }

        private void db_connection()
        {
            try
            {
                conn = "server=localhost;User Id=root;password=WakaBanga2;database=smi;Persist Security Info=True;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
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

        private void chkDag1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDag1.Checked)
            {
                // Do something when CheckBox is checked
                chkDam1.Checked = false;
            }
            
        }

        private void chkDam1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDam1.Checked)
            {
                // Do something when CheckBox is checked
                chkDag1.Checked = false;
            }
           
        }

        private void chkDag2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDag2.Checked)
            {
                // Do something when CheckBox is checked
                chkDam2.Checked = false;
            }
        }

        private void chkDam2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDam2.Checked)
            {
                // Do something when CheckBox is checked
                chkDag2.Checked = false;
            }
        }

        private void chkDag3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDag3.Checked)
            {
                // Do something when CheckBox is checked
                chkDam3.Checked = false;
            }
        }

        private void chkDam3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDam3.Checked)
            {
                // Do something when CheckBox is checked
                chkDag3.Checked = false;
            }
        }

        private void chkDag4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDag4.Checked)
            {
                // Do something when CheckBox is checked
                chkDam4.Checked = false;
            }
        }

        private void chkDam4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDam4.Checked)
            {
                // Do something when CheckBox is checked
                chkDag4.Checked = false;
            }
        }

        private void chkDag5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDag5.Checked)
            {
                // Do something when CheckBox is checked
                chkDam5.Checked = false;
            }
        }

        private void chkDam5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDam5.Checked)
            {
                // Do something when CheckBox is checked
                chkDag5.Checked = false;
            }
        }

        private void chkDag6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDag6.Checked)
            {
                // Do something when CheckBox is checked
                chkDam6.Checked = false;
            }
        }

        private void chkDam6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDam6.Checked)
            {
                // Do something when CheckBox is checked
                chkDag6.Checked = false;
            }
        }

        private void cmdProcurar_Click(object sender, EventArgs e)
        {
             string searchValueTxt = txtSearched.Text.Trim().ToUpper();
                 string strgrdvalue="";
                  int rowIndex = -1;
                
                 int selectIndex = cbProcurar.SelectedIndex;

                 switch (selectIndex)
                 {
                     case 0:
         
                        //long searchValueInt = Convert.ToInt64(txtSearched.Text);
                         grdCPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdCPN.Rows.Count - 1)
                             {
                                 strgrdvalue = grdCPN.Rows[row].Cells[0].Value.ToString().Trim().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdCPN.Rows[rowIndex].Selected = true;
                                     grdCPN.CurrentCell = grdCPN.Rows[rowIndex].Cells[0];
                                     rowIndex++;
                                     valueResulet = false;
                                     break;
                                 }
                                 row++;
                             }
                             if (valueResulet != false)
                             {
                                 MessageBox.Show("ID : " + txtSearched.Text.Trim() , "Nao encontrado");
                                 return;
                             }
                         }
                         catch (Exception exc)
                         {
                             MessageBox.Show(exc.Message);
                         }
                         break;
                     case 1:
                         grdCPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdCPN.Rows.Count - 1)
                             {
                                // if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["nid_cpn"].Value.ToString().Equals(searchValueTxt))
                                 strgrdvalue = grdCPN.Rows[row].Cells[8].Value.ToString().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdCPN.Rows[rowIndex].Selected = true;
                                     grdCPN.CurrentCell = grdCPN.Rows[rowIndex].Cells[8];
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
                         grdCPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdCPN.Rows.Count - 1)
                             {
                                // if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["nid_tarv"].Value.ToString().Equals(searchValueTxt))
                                 strgrdvalue = grdCPN.Rows[row].Cells[9].Value.ToString().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdCPN.Rows[rowIndex].Selected = true;
                                     grdCPN.CurrentCell = grdCPN.Rows[rowIndex].Cells[9];
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
                         grdCPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdCPN.Rows.Count - 1)
                             {
                                 //if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["name"].Value.ToString().Equals(searchValueTxt))
                                 strgrdvalue = grdCPN.Rows[row].Cells[289].Value.ToString().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdCPN.Rows[rowIndex].Selected = true;
                                     grdCPN.CurrentCell = grdCPN.Rows[rowIndex].Cells[289];
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
                         grdCPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdCPN.Rows.Count - 1)
                             {
                                 //if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["name"].Value.ToString().Equals(searchValueTxt))
                                 strgrdvalue = grdCPN.Rows[row].Cells[10].Value.ToString().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdCPN.Rows[rowIndex].Selected = true;
                                     grdCPN.CurrentCell = grdCPN.Rows[rowIndex].Cells[10];
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
                     case 5:
                         grdCPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdCPN.Rows.Count - 1)
                             {
                                 //if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["name"].Value.ToString().Equals(searchValueTxt))
                                 strgrdvalue = grdCPN.Rows[row].Cells[12].Value.ToString().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdCPN.Rows[rowIndex].Selected = true;
                                     grdCPN.CurrentCell = grdCPN.Rows[rowIndex].Cells[12];
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

        private void cmdNew_Click(object sender, EventArgs e)
        {
            grdCPN.Focus();
            grdCPN.ClearSelection();
            int nRowIndex = grdCPN.Rows.Count - 1;

            grdCPN.Rows[nRowIndex].Selected = true;
            grdCPN.Rows[nRowIndex].Cells[0].Selected = true;
            //grdMother.CurrentCell = grdMother.Rows[nRowIndex].Cells[0];
            //grdMother.CurrentCell.RowIndex;

            txtID.Clear();
            cbxNidCPN.Text = "";
            txtNidTarv.Clear();
            txtName.Clear();
            txtResidence.Clear();
            txtPhone.Clear();

            txtIDmother.Clear();
            txtYear.Clear();
            cbxLivro.Text="";
            txtVisdate1.Clear();
            txtVisdate2.Clear();
            txtVisdate3.Clear();
            txtVisdate4.Clear();
            txtVisdate5.Clear();
            txtVisdate6.Clear();

            rbAG1.Checked=false;
            rbAG2.Checked = false;
            rbAG3.Checked = false;
            rbAG4.Checked = false;

            txtGestage1.Text = "";
            txtGestage2.Text = "";
            txtGestage3.Text = "";
            txtGestage4.Text = "";
            txtGestage5.Text = "";
            txtGestage6.Text = "";
           

            chkGageless12.Checked = false;

            chkPpres1.Checked = false;
            chkPpres2.Checked = false;
            chkPpres3.Checked = false;
            chkPpres4.Checked = false;
            chkPpres5.Checked = false;
            chkPpres6.Checked = false;

            txtWeight1.Clear();
            txtWeight2.Clear();
            txtWeight3.Clear();
            txtWeight4.Clear();
            txtWeight5.Clear();
            txtWeight6.Clear();

            cbxWgyno2.Text = "";
            cbxWgyno3.Text = "";
            cbxWgyno4.Text = "";
            cbxWgyno5.Text = "";
            cbxWgyno6.Text = "";

            chkDag1.Checked = false;
            chkDag2.Checked = false;
            chkDag3.Checked = false;
            chkDag4.Checked = false;
            chkDag5.Checked = false;
            chkDag6.Checked = false;

            chkDam1.Checked = false;
            chkDam2.Checked = false;
            chkDam3.Checked = false;
            chkDam4.Checked = false;
            chkDam5.Checked = false;
            chkDam6.Checked = false;

            txtSupnuttr1.Clear();
            txtSupnuttr2.Clear();
            txtSupnuttr3.Clear();
            txtSupnuttr4.Clear();
            txtSupnuttr5.Clear();
            txtSupnuttr6.Clear();

            cbxResultcured2.Text = "";
            cbxResultcured3.Text = "";
            cbxResultcured4.Text = "";
            cbxResultcured5.Text = "";
            cbxResultcured6.Text = "";

            cbxReceiveddesparasitante1.Text = "";
            cbxReceiveddesparasitante2.Text = "";
            cbxReceiveddesparasitante3.Text = "";
            cbxReceiveddesparasitante4.Text = "";
            cbxReceiveddesparasitante5.Text = "";
            cbxReceiveddesparasitante6.Text = "";

            cbxsalferr_acfolico1.Text = "";
            cbxsalferr_acfolico2.Text = "";
            cbxsalferr_acfolico3.Text = "";
            cbxsalferr_acfolico4.Text = "";
            cbxsalferr_acfolico5.Text = "";
            cbxsalferr_acfolico6.Text = "";

            cbxta1.Text = "";
            cbxta2.Text = "";
            cbxta3.Text = "";
            cbxta4.Text = "";
            cbxta5.Text = "";
            cbxta6.Text = "";

            cbxHgb1.Text = "";
            cbxHgb2.Text = "";
            cbxHgb3.Text = "";
            cbxHgb4.Text = "";
            cbxHgb5.Text = "";
            cbxHgb6.Text = "";

            cbxProteinuria1.Text = "";
            cbxProteinuria2.Text = "";
            cbxProteinuria3.Text = "";
            cbxProteinuria4.Text = "";
            cbxProteinuria5.Text = "";
            cbxProteinuria6.Text = "";

            cbxGlicosuria1.Text = "";
            cbxGlicosuria2.Text = "";
            cbxGlicosuria3.Text = "";
            cbxGlicosuria4.Text = "";
            cbxGlicosuria5.Text = "";
            cbxGlicosuria6.Text = "";

            chkits_ulceragenital1.Checked = false;
            chkits_ulceragenital2.Checked = false;
            chkits_ulceragenital3.Checked = false;
            chkits_ulceragenital4.Checked = false;
            chkits_ulceragenital5.Checked = false;
            chkits_ulceragenital6.Checked = false;

            chkits_leucorreia1.Checked = false;
            chkits_leucorreia2.Checked = false;
            chkits_leucorreia3.Checked = false;
            chkits_leucorreia4.Checked = false;
            chkits_leucorreia5.Checked = false;
            chkits_leucorreia6.Checked = false;

            cbxits_syndromictreatment1.Text = "";
            cbxits_syndromictreatment2.Text = "";
            cbxits_syndromictreatment3.Text = "";
            cbxits_syndromictreatment4.Text = "";
            cbxits_syndromictreatment5.Text = "";
            cbxits_syndromictreatment6.Text = "";

            cbxits_syphilistesting1.Text = "";
            cbxits_syphilistesting2.Text = "";
            cbxits_syphilistesting3.Text = "";
            cbxits_syphilistesting4.Text = "";
            cbxits_syphilistesting5.Text = "";
            cbxits_syphilistesting6.Text = "";

            cbxits_wsyphilistreat1.Text = "";
            cbxits_wsyphilistreat2.Text = "";
            cbxits_wsyphilistreat3.Text = "";
            cbxits_wsyphilistreat4.Text = "";
            cbxits_wsyphilistreat5.Text = "";
            cbxits_wsyphilistreat6.Text = "";

            cbxits_psyphilistreat1.Text = "";
            cbxits_psyphilistreat2.Text = "";
            cbxits_psyphilistreat3.Text = "";
            cbxits_psyphilistreat4.Text = "";
            cbxits_psyphilistreat5.Text = "";
            cbxits_psyphilistreat6.Text = "";

            chkCons_more4.Checked=false;
            chkPartnerpreence.Checked=false;
            cbxWeightgainyno.Text="";

            chkDag.Checked=false;
            chkDam.Checked=false;
            cbxSupnutr.Text="";
            cbxResultcured.Text="";
            cbxResultabandon.Text="";
            cbxReceiveddesparasitante.Text="";
            chkSalferr_more3.Checked=false;
            chkIts_diag.Checked=false;

            cbxIts_treatment.Text="";
            cbxIts_syphilistesting.Text="";
            cbxIts_psyphilistreat.Text="";
            chkIts_wsyphilistreat.Checked=false;



            cmdNew.Enabled = false;
        }
        private void loadData()
        {
            try
            {
                db_connection();
                string Query = "select * from cpn;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connect);
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                grdCPN.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Clone();
                }
            }
            connect.Close();
            cmdNew.Enabled = true;
        }

        private void cmdMotApagar_Click(object sender, EventArgs e)
        {
            DialogResult myResult;
            myResult = MessageBox.Show("Pretende mesmo apagar?", "Confirmacao!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                // confirm delete
                db_connection();
                MySqlCommand cmd = new MySqlCommand("delete from mother where id='" + Convert.ToInt64(this.txtID.Text) + "';", connect);
                int success = cmd.ExecuteNonQuery();
                //      MessageBox.Show(“Deleted”);
                connect.Close();
                loadData();
            }
            else
            {
                //No delete
            }
        }

        private void cmdMotSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                db_connection();
                //string nidcpn = txtNid_cpn.Text;
               
                MessageBox.Show(Convert.ToInt64(this.txtYear.Text).ToString());
                MessageBox.Show(Convert.ToDateTime(this.txtVisdate1.Text).ToString("yyyy-MM-dd"));
                if (this.txtID.Text != "") 
                //update
                {
                    //MyReader.Close();
                    //This is my update query in which i am taking input from the user through windows forms and update the record.  
                    //-----------------------------------------------

                    string Query3 = "UPDATE cpn SET nid_cpn='" + this.cbxNidCPN.Text.ToUpper() + "'";
                    Query3 += ",nyear=" + Convert.ToInt64(this.txtYear.Text);
                    if (this.txtVisdate1.Text != "")
                    {
                        Query3 += ",visdate1='" + Convert.ToDateTime(txtVisdate1.Text).ToString("yyyy-MM-dd")+"'";
                    }
                    if (this.txtVisdate2.Text != "")
                    {
                        Query3 += ",visdate2='" + Convert.ToDateTime(txtVisdate2.Text).ToString("yyyy-MM-dd") + "'";
                    }
                    if (this.txtVisdate3.Text != "")
                    {
                        Query3 += ",visdate3='" + Convert.ToDateTime(txtVisdate3.Text).ToString("yyyy-MM-dd") + "'";
                    }
                    if (this.txtVisdate4.Text != "")
                    {
                        Query3 += ",visdate4='" + Convert.ToDateTime(txtVisdate4.Text).ToString("yyyy-MM-dd") + "'";
                    }
                    if (this.txtVisdate5.Text != "")
                    {
                        Query3 += ",visdate5='" + Convert.ToDateTime(txtVisdate5.Text).ToString("yyyy-MM-dd") + "'";
                    }
                    if (this.txtVisdate6.Text != "")
                    {
                        Query3 += ",visdate6='" + Convert.ToDateTime(txtVisdate6.Text).ToString("yyyy-MM-dd") + "'";
                    }
                    Query3 += ",nid_tarv='" + this.txtNidTarv.Text.ToUpper() + "'";
                    Query3 += ",name='" + this.txtName.Text.ToUpper() + "'";
                    Query3 += ",residence='" + this.txtResidence.Text.ToUpper() + "'";
                    Query3 += ",phone='" + this.txtPhone.Text.ToUpper() + "'";
                    Query3 += ",idmother=" + Convert.ToInt64(this.txtIDmother.Text);
                    Query3 += ",nlivro='" + this.cbxLivro.Text.ToUpper() + "'";
                    Query3 += ",agegroup1=" + Convert.ToByte(this.rbAG1.Checked ? "1" : "0");
                    Query3 += ",agegroup2=" + Convert.ToByte(this.rbAG2.Checked ? "1" : "0");
                    Query3 += ",agegroup3=" + Convert.ToByte(this.rbAG3.Checked ? "1" : "0");
                    Query3 += ",agegroup4=" + Convert.ToByte(this.rbAG4.Checked ? "1" : "0");
                    Query3 += ",gestationalage1=" + Convert.ToInt32(this.txtGestage1.Text == "" ? null : this.txtGestage1.Text);
                    Query3 += ",gestationalage2=" + Convert.ToInt32(this.txtGestage2.Text == "" ? null : this.txtGestage2.Text);
                    Query3 += ",gestationalage3=" + Convert.ToInt32(this.txtGestage3.Text == "" ? null : this.txtGestage3.Text);
                    Query3 += ",gestationalage4=" + Convert.ToInt32(this.txtGestage4.Text == "" ? null : this.txtGestage4.Text);
                    Query3 += ",gestationalage5=" + Convert.ToInt32(this.txtGestage5.Text == "" ? null : this.txtGestage5.Text);
                    Query3 += ",gestationalage6=" + Convert.ToInt32(this.txtGestage6.Text == "" ? null : this.txtGestage6.Text);
                    Query3 += ",gageless12=" + Convert.ToInt32(this.chkGageless12.Checked ? "1" : "0").ToString();

                    Query3 += ",partnerpresence1=" + Convert.ToInt32(this.chkPpres1.Checked ? "1" : "0").ToString();
                    Query3 += ",partnerpresence2=" + Convert.ToInt32(this.chkPpres2.Checked ? "1" : "0").ToString();
                    Query3 += ",partnerpresence3=" + Convert.ToInt32(this.chkPpres3.Checked ? "1" : "0").ToString();
                    Query3 += ",partnerpresence4=" + Convert.ToInt32(this.chkPpres4.Checked ? "1" : "0").ToString();
                    Query3 += ",partnerpresence5=" + Convert.ToInt32(this.chkPpres5.Checked ? "1" : "0").ToString();
                    Query3 += ",partnerpresence6=" + Convert.ToInt32(this.chkPpres6.Checked ? "1" : "0").ToString();

                    Query3 += ",weight1=" + Convert.ToInt32(this.txtWeight1.Text == "" ? null : this.txtWeight1.Text).ToString();
                    Query3 += ",weight2=" + Convert.ToInt32(this.txtWeight2.Text == "" ? null : this.txtWeight2.Text).ToString();
                    Query3 += ",weight3=" + Convert.ToInt32(this.txtWeight3.Text == "" ? null : this.txtWeight3.Text).ToString();
                    Query3 += ",weight4=" + Convert.ToInt32(this.txtWeight4.Text == "" ? null : this.txtWeight4.Text).ToString();
                    Query3 += ",weight5=" + Convert.ToInt32(this.txtWeight5.Text == "" ? null : this.txtWeight5.Text).ToString();
                    Query3 += ",weight6=" + Convert.ToInt32(this.txtWeight6.Text == "" ? null : this.txtWeight6.Text).ToString();

                    Query3 += ",weightgainyno2='" + this.cbxWgyno2.Text.ToUpper() + "'";
                    Query3 += ",weightgainyno3='" + this.cbxWgyno3.Text.ToUpper() + "'";
                    Query3 += ",weightgainyno4='" + this.cbxWgyno4.Text.ToUpper() + "'";
                    Query3 += ",weightgainyno5='" + this.cbxWgyno5.Text.ToUpper() + "'";
                    Query3 += ",weightgainyno6='" + this.cbxWgyno6.Text.ToUpper() + "'";

                    Query3 += ",dag1=" + Convert.ToInt32(this.chkDag1.Checked ? "1" : "0").ToString();
                    Query3 += ",dag2=" + Convert.ToInt32(this.chkDag2.Checked ? "1" : "0").ToString();
                    Query3 += ",dag3=" + Convert.ToInt32(this.chkDag3.Checked ? "1" : "0").ToString();
                    Query3 += ",dag4=" + Convert.ToInt32(this.chkDag4.Checked ? "1" : "0").ToString();
                    Query3 += ",dag5=" + Convert.ToInt32(this.chkDag5.Checked ? "1" : "0").ToString();
                    Query3 += ",dag6=" + Convert.ToInt32(this.chkDag6.Checked ? "1" : "0").ToString();

                    Query3 += ",dam1=" + Convert.ToInt32(this.chkDam1.Checked ? "1" : "0").ToString();
                    Query3 += ",dam2=" + Convert.ToInt32(this.chkDam2.Checked ? "1" : "0").ToString();
                    Query3 += ",dam3=" + Convert.ToInt32(this.chkDam3.Checked ? "1" : "0").ToString();
                    Query3 += ",dam4=" + Convert.ToInt32(this.chkDam4.Checked ? "1" : "0").ToString();
                    Query3 += ",dam5=" + Convert.ToInt32(this.chkDam5.Checked ? "1" : "0").ToString();
                    Query3 += ",dam6=" + Convert.ToInt32(this.chkDam6.Checked ? "1" : "0").ToString();

                    Query3 += ",supnutr1=" + Convert.ToInt32(this.txtSupnuttr1.Text == "" ? null : this.txtSupnuttr1.Text).ToString();
                    Query3 += ",supnutr2=" + Convert.ToInt32(this.txtSupnuttr2.Text == "" ? null : this.txtSupnuttr2.Text).ToString();
                    Query3 += ",supnutr3=" + Convert.ToInt32(this.txtSupnuttr3.Text == "" ? null : this.txtSupnuttr3.Text).ToString();
                    Query3 += ",supnutr4=" + Convert.ToInt32(this.txtSupnuttr4.Text == "" ? null : this.txtSupnuttr4.Text).ToString();
                    Query3 += ",supnutr5=" + Convert.ToInt32(this.txtSupnuttr5.Text == "" ? null : this.txtSupnuttr5.Text).ToString();
                    Query3 += ",supnutr6=" + Convert.ToInt32(this.txtSupnuttr6.Text == "" ? null : this.txtSupnuttr6.Text).ToString();

                    Query3 += ",resultcured2='" + this.cbxResultcured2.Text.ToUpper() + "'";
                    Query3 += ",resultcured3='" + this.cbxResultcured3.Text.ToUpper() + "'";
                    Query3 += ",resultcured4='" + this.cbxResultcured4.Text.ToUpper() + "'";
                    Query3 += ",resultcured5='" + this.cbxResultcured5.Text.ToUpper() + "'";
                    Query3 += ",resultcured6='" + this.cbxResultcured6.Text.ToUpper() + "'";

                    Query3 += ",receiveddesparasitante1='" + this.cbxReceiveddesparasitante1.Text.ToUpper() + "'";
                    Query3 += ",receiveddesparasitante2='" + this.cbxReceiveddesparasitante2.Text.ToUpper() + "'";
                    Query3 += ",receiveddesparasitante3='" + this.cbxReceiveddesparasitante3.Text.ToUpper() + "'";
                    Query3 += ",receiveddesparasitante4='" + this.cbxReceiveddesparasitante4.Text.ToUpper() + "'";
                    Query3 += ",receiveddesparasitante5='" + this.cbxReceiveddesparasitante5.Text.ToUpper() + "'";
                    Query3 += ",receiveddesparasitante6='" + this.cbxReceiveddesparasitante6.Text.ToUpper() + "'";

                    Query3 += ",salferr_acfolico1='" + this.cbxsalferr_acfolico1.Text.ToUpper() + "'";
                    Query3 += ",salferr_acfolico2='" + this.cbxsalferr_acfolico2.Text.ToUpper() + "'";
                    Query3 += ",salferr_acfolico3='" + this.cbxsalferr_acfolico3.Text.ToUpper() + "'";
                    Query3 += ",salferr_acfolico4='" + this.cbxsalferr_acfolico4.Text.ToUpper() + "'";
                    Query3 += ",salferr_acfolico5='" + this.cbxsalferr_acfolico5.Text.ToUpper() + "'";
                    Query3 += ",salferr_acfolico6='" + this.cbxsalferr_acfolico6.Text.ToUpper() + "'";

                    Query3 += ",ta1='" + this.cbxta1.Text.ToUpper() + "'";
                    Query3 += ",ta2='" + this.cbxta2.Text.ToUpper() + "'";
                    Query3 += ",ta3='" + this.cbxta3.Text.ToUpper() + "'";
                    Query3 += ",ta4='" + this.cbxta4.Text.ToUpper() + "'";
                    Query3 += ",ta5='" + this.cbxta5.Text.ToUpper() + "'";
                    Query3 += ",ta6='" + this.cbxta6.Text.ToUpper() + "'";

                    Query3 += ",hgb1='" + this.cbxHgb1.Text.ToUpper() + "'";
                    Query3 += ",hgb2='" + this.cbxHgb2.Text.ToUpper() + "'";
                    Query3 += ",hgb3='" + this.cbxHgb3.Text.ToUpper() + "'";
                    Query3 += ",hgb4='" + this.cbxHgb4.Text.ToUpper() + "'";
                    Query3 += ",hgb5='" + this.cbxHgb5.Text.ToUpper() + "'";
                    Query3 += ",hgb6='" + this.cbxHgb6.Text.ToUpper() + "'";

                    Query3 += ",proteinuria1='" + this.cbxProteinuria1.Text.ToUpper() + "'";
                    Query3 += ",proteinuria2='" + this.cbxProteinuria2.Text.ToUpper() + "'";
                    Query3 += ",proteinuria3='" + this.cbxProteinuria3.Text.ToUpper() + "'";
                    Query3 += ",proteinuria4='" + this.cbxProteinuria4.Text.ToUpper() + "'";
                    Query3 += ",proteinuria5='" + this.cbxProteinuria5.Text.ToUpper() + "'";
                    Query3 += ",proteinuria6='" + this.cbxProteinuria6.Text.ToUpper() + "'";

                    Query3 += ",glicosuria1='" + this.cbxGlicosuria1.Text.ToUpper() + "'";
                    Query3 += ",glicosuria2='" + this.cbxGlicosuria2.Text.ToUpper() + "'";
                    Query3 += ",glicosuria3='" + this.cbxGlicosuria3.Text.ToUpper() + "'";
                    Query3 += ",glicosuria4='" + this.cbxGlicosuria4.Text.ToUpper() + "'";
                    Query3 += ",glicosuria5='" + this.cbxGlicosuria5.Text.ToUpper() + "'";
                    Query3 += ",glicosuria6='" + this.cbxGlicosuria6.Text.ToUpper() + "'";

                    Query3 += ",its_ulceragenital1=" + Convert.ToInt32(this.chkits_ulceragenital1.Checked ? "1" : "0").ToString();
                    Query3 += ",its_ulceragenital2=" + Convert.ToInt32(this.chkits_ulceragenital2.Checked ? "1" : "0").ToString();
                    Query3 += ",its_ulceragenital3=" + Convert.ToInt32(this.chkits_ulceragenital3.Checked ? "1" : "0").ToString();
                    Query3 += ",its_ulceragenital4=" + Convert.ToInt32(this.chkits_ulceragenital4.Checked ? "1" : "0").ToString();
                    Query3 += ",its_ulceragenital5=" + Convert.ToInt32(this.chkits_ulceragenital5.Checked ? "1" : "0").ToString();
                    Query3 += ",its_ulceragenital6=" + Convert.ToInt32(this.chkits_ulceragenital6.Checked ? "1" : "0").ToString();

                    Query3 += ",its_leucorreia1=" + Convert.ToInt32(this.chkits_leucorreia1.Checked ? "1" : "0").ToString();
                    Query3 += ",its_leucorreia2=" + Convert.ToInt32(this.chkits_leucorreia2.Checked ? "1" : "0").ToString();
                    Query3 += ",its_leucorreia3=" + Convert.ToInt32(this.chkits_leucorreia3.Checked ? "1" : "0").ToString();
                    Query3 += ",its_leucorreia4=" + Convert.ToInt32(this.chkits_leucorreia4.Checked ? "1" : "0").ToString();
                    Query3 += ",its_leucorreia5=" + Convert.ToInt32(this.chkits_leucorreia5.Checked ? "1" : "0").ToString();
                    Query3 += ",its_leucorreia6=" + Convert.ToInt32(this.chkits_leucorreia6.Checked ? "1" : "0").ToString();

                    Query3 += ",its_syndromictreatment1='" + this.cbxits_syndromictreatment1.Text.ToUpper() + "'";
                    Query3 += ",its_syndromictreatment2='" + this.cbxits_syndromictreatment2.Text.ToUpper() + "'";
                    Query3 += ",its_syndromictreatment3='" + this.cbxits_syndromictreatment3.Text.ToUpper() + "'";
                    Query3 += ",its_syndromictreatment4='" + this.cbxits_syndromictreatment4.Text.ToUpper() + "'";
                    Query3 += ",its_syndromictreatment5='" + this.cbxits_syndromictreatment5.Text.ToUpper() + "'";
                    Query3 += ",its_syndromictreatment6='" + this.cbxits_syndromictreatment6.Text.ToUpper() + "'";

                    Query3 += ",its_syphilistesting1='" + this.cbxits_syphilistesting1.Text.ToUpper() + "'";
                    Query3 += ",its_syphilistesting2='" + this.cbxits_syphilistesting2.Text.ToUpper() + "'";
                    Query3 += ",its_syphilistesting3='" + this.cbxits_syphilistesting3.Text.ToUpper() + "'";
                    Query3 += ",its_syphilistesting4='" + this.cbxits_syphilistesting4.Text.ToUpper() + "'";
                    Query3 += ",its_syphilistesting5='" + this.cbxits_syphilistesting5.Text.ToUpper() + "'";
                    Query3 += ",its_syphilistesting6='" + this.cbxits_syphilistesting6.Text.ToUpper() + "'";

                    Query3 += ",its_wsyphilistreat1='" + this.cbxits_wsyphilistreat1.Text.ToUpper() + "'";
                   Query3 += ",its_wsyphilistreat2='" + this.cbxits_wsyphilistreat2.Text.ToUpper() + "'";
                   Query3 += ",its_wsyphilistreat3='" + this.cbxits_wsyphilistreat3.Text.ToUpper() + "'";
                   Query3 += ",its_wsyphilistreat4='" + this.cbxits_wsyphilistreat4.Text.ToUpper() + "'";
                   Query3 += ",its_wsyphilistreat5='" + this.cbxits_wsyphilistreat5.Text.ToUpper() + "'";
                   Query3 += ",its_wsyphilistreat6='" + this.cbxits_wsyphilistreat6.Text.ToUpper() + "'";

                   Query3 += ",its_psyphilistreat1='" + this.cbxits_psyphilistreat1.Text.ToUpper() + "'";
                   Query3 += ",its_psyphilistreat2='" + this.cbxits_psyphilistreat2.Text.ToUpper() + "'";
                   Query3 += ",its_psyphilistreat3='" + this.cbxits_psyphilistreat3.Text.ToUpper() + "'";
                   Query3 += ",its_psyphilistreat4='" + this.cbxits_psyphilistreat4.Text.ToUpper() + "'";
                   Query3 += ",its_psyphilistreat5='" + this.cbxits_psyphilistreat5.Text.ToUpper() + "'";
                   Query3 += ",its_psyphilistreat6='" + this.cbxits_psyphilistreat6.Text.ToUpper() + "'";
                   Query3 += ",cons_more4=" + Convert.ToInt32(this.chkCons_more4.Checked ? "1" : "0").ToString();
                   Query3 += ",partnerpreence=" + Convert.ToInt32(this.chkPartnerpreence.Checked ? "1" : "0").ToString();
                   Query3 += ",weightgainyno='" + this.cbxWeightgainyno.Text.ToUpper() + "'";
                   Query3 += ",dag=" + Convert.ToInt32(this.chkDag.Checked ? "1" : "0").ToString();
                   Query3 += ",dam=" + Convert.ToInt32(this.chkDam.Checked ? "1" : "0").ToString();
                   Query3 += ",supnutr='" + this.cbxSupnutr.Text.ToUpper() + "'";
                   Query3 += ",resultcured='" + this.cbxResultcured.Text.ToUpper() + "'";
                   Query3 += ",resultabandon='" + this.cbxResultabandon.Text.ToUpper() + "'";
                   Query3 += ",receiveddesparasitante='" + this.cbxReceiveddesparasitante.Text.ToUpper() + "'";
                   Query3 += ",salferr_more3=" + Convert.ToInt32(this.chkSalferr_more3.Checked ? "1" : "0").ToString();
                   Query3 += ",its_diag=" + Convert.ToInt32(this.chkIts_diag.Checked ? "1" : "0").ToString();
                   Query3 += ",its_treatment='" + this.cbxIts_treatment.Text.ToUpper() + "'";
                   Query3 += ",its_syphilistesting='" + this.cbxIts_syphilistesting.Text.ToUpper() + "'";
                   Query3 += ",its_psyphilistreat='" + this.cbxIts_psyphilistreat.Text.ToUpper()+"'" ;
                   Query3 += ",its_wsyphilistreat=" + Convert.ToInt32(this.chkIts_wsyphilistreat.Checked ? "1" : "0").ToString();
                   Query3 += " WHERE id=" + Convert.ToInt32(this.txtID.Text).ToString() + " ;";
                          

                    MySqlCommand MyCommand2 = new MySqlCommand(Query3, connect);
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();
                    //MessageBox.Show("Data Updated");
                    while (MyReader2.Read())
                    {
                    }
                    connect.Close();//Connection closed here 
                    grdCPN.CurrentCell = grdCPN.Rows[1].Cells[1];
                    loadData();

                }
                else
                //insert
                {
                    string Query1 = "insert into cpn(nid_cpn,nyear,";
                    if (this.txtVisdate1.Text != "")
                    {
                        Query1 += "visdate1,";
                    }
                    if (this.txtVisdate2.Text != "")
                    {
                        Query1 += "visdate2,";
                    }
                    if (this.txtVisdate3.Text != "")
                    {
                        Query1 += "visdate3,";
                    }
                    if (this.txtVisdate4.Text != "")
                    {
                        Query1 += "visdate4,";
                    }
                    if (this.txtVisdate5.Text != "")
                    {
                        Query1 += "visdate5,";
                    }
                    if (this.txtVisdate6.Text != "")
                    {
                        Query1 += "visdate6,";
                    }
                    Query1 += "nid_tarv,name,residence,phone,idmother,nlivro,agegroup1,agegroup2,agegroup3,agegroup4,";
                    Query1 += "gestationalage1,gestationalage2,gestationalage3,gestationalage4,gestationalage5,gestationalage6,gageless12,";
                    Query1 += "partnerpresence1,partnerpresence2,partnerpresence3,partnerpresence4,partnerpresence5,partnerpresence6,";
                    Query1 += "weight1,weight2,weight3,weight4,weight5,weight6,weightgainyno2,weightgainyno3,weightgainyno4,weightgainyno5,weightgainyno6,";
                    Query1 += "dag1,dag2,dag3,dag4,dag5,dag6,dam1,dam2,dam3,dam4,dam5,dam6,";
                    Query1 += "supnutr1,supnutr2,supnutr3,supnutr4,supnutr5,supnutr6,";
                    Query1 += "resultcured2,resultcured3,resultcured4,resultcured5,resultcured6,";
                    Query1 += "receiveddesparasitante1,receiveddesparasitante2,receiveddesparasitante3,receiveddesparasitante4,receiveddesparasitante5,receiveddesparasitante6,";
                    Query1 += "salferr_acfolico1,salferr_acfolico2,salferr_acfolico3,salferr_acfolico4,salferr_acfolico5,salferr_acfolico6,";
                    Query1 += "ta1,ta2,ta3,ta4,ta5,ta6,";
                    Query1 += "hgb1,hgb2,hgb3,hgb4,hgb5,hgb6,";
                    Query1 += "proteinuria1,proteinuria2,proteinuria3,proteinuria4,proteinuria5,proteinuria6,";
                    Query1 += "glicosuria1,glicosuria2,glicosuria3,glicosuria4,glicosuria5,glicosuria6,";
                    Query1 += "its_ulceragenital1,its_ulceragenital2,its_ulceragenital3,its_ulceragenital4,its_ulceragenital5,its_ulceragenital6,";
                    Query1 += "its_leucorreia1,its_leucorreia2,its_leucorreia3,its_leucorreia4,its_leucorreia5,its_leucorreia6,";
                    Query1 += "its_syndromictreatment1,its_syndromictreatment2,its_syndromictreatment3,its_syndromictreatment4,its_syndromictreatment5,its_syndromictreatment6,";
                    Query1 += "its_syphilistesting1,its_syphilistesting2,its_syphilistesting3,its_syphilistesting4,its_syphilistesting5,its_syphilistesting6,";
                    Query1 += "its_wsyphilistreat1,its_wsyphilistreat2,its_wsyphilistreat3,its_wsyphilistreat4,its_wsyphilistreat5,its_wsyphilistreat6,";
                    Query1 += "its_psyphilistreat1,its_psyphilistreat2,its_psyphilistreat3,its_psyphilistreat4,its_psyphilistreat5,its_psyphilistreat6,";
                    Query1 += "cons_more4,partnerpreence,weightgainyno,dag,dam,supnutr,";
                    Query1 += "resultcured,resultabandon,receiveddesparasitante,salferr_more3,its_diag,its_treatment,";
                    Query1 += "its_syphilistesting,its_psyphilistreat,its_wsyphilistreat";
                   
                    Query1 += ")";
                    Query1 += " values('";
                    Query1 += this.cbxNidCPN.Text.ToUpper() + "'," + Convert.ToInt64(this.txtYear.Text) + ",";
                    if (this.txtVisdate1.Text != "")
                    {
                        Query1 += "'" + Convert.ToDateTime(txtVisdate1.Text).ToString("yyyy-MM-dd") + "',";
                    }
                    if (this.txtVisdate2.Text != "")
                    {
                        Query1 += "'" + Convert.ToDateTime(txtVisdate2.Text).ToString("yyyy-MM-dd") + "',";
                    }
                    if (this.txtVisdate3.Text != "")
                    {
                        Query1 += "'" + Convert.ToDateTime(txtVisdate3.Text).ToString("yyyy-MM-dd") + "',";
                    }
                    if (this.txtVisdate4.Text != "")
                    {
                        Query1 += "'" + Convert.ToDateTime(txtVisdate4.Text).ToString("yyyy-MM-dd") + "',";
                    }
                    if (this.txtVisdate5.Text != "")
                    {
                        Query1 += "'" + Convert.ToDateTime(txtVisdate5.Text).ToString("yyyy-MM-dd") + "',";
                    }
                    if (this.txtVisdate5.Text != "")
                    {
                        Query1 += "'" + Convert.ToDateTime(txtVisdate6.Text).ToString("yyyy-MM-dd") + "',";
                    }
                    Query1 += "'" + this.txtNidTarv.Text.ToUpper() + "',";
                    Query1 += "'" + this.txtName.Text.ToUpper() + "',";
                    Query1 += "'" + this.txtResidence.Text.ToUpper() + "',";
                    Query1 += "'" + this.txtPhone.Text.ToUpper() + "',";
                    Query1 +=  Convert.ToInt64(this.txtIDmother.Text) + ",";
                    Query1 += "'" + this.cbxLivro.Text.ToUpper() + "',";

                    Query1 += Convert.ToInt32(this.rbAG1.Checked ? "1" : "0") + ",";
                    Query1 += Convert.ToInt32(this.rbAG2.Checked ? "1" : "0") + ",";
                    Query1 +=  Convert.ToInt32(this.rbAG3.Checked ? "1" : "0") + ",";
                    Query1 += Convert.ToInt32(this.rbAG4.Checked ? "1" : "0") + ",";

                    Query1 += Convert.ToInt32(this.txtGestage1.Text == "" ? null : this.txtGestage1.Text) + ",";
                    Query1 += Convert.ToInt32(this.txtGestage2.Text == "" ? null : this.txtGestage2.Text) + ",";
                    Query1 += Convert.ToInt32(this.txtGestage3.Text == "" ? null : this.txtGestage3.Text) + ",";
                    Query1 += Convert.ToInt32(this.txtGestage4.Text == "" ? null : this.txtGestage4.Text) + ",";
                    Query1 += Convert.ToInt32(this.txtGestage5.Text == "" ? null : this.txtGestage5.Text) + ",";
                    Query1 += Convert.ToInt32(this.txtGestage6.Text == "" ? null : this.txtGestage6.Text) + ",";
                    Query1 += Convert.ToInt32(this.chkGageless12.Checked ? "1" : "0").ToString() + ",";

                     Query1 += Convert.ToInt32(this.chkPpres1.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkPpres2.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkPpres3.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkPpres4.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkPpres5.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkPpres6.Checked ? "1" : "0").ToString() + ",";

                    Query1 += Convert.ToInt32(this.txtWeight1.Text == "" ? null : this.txtWeight1.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtWeight2.Text == "" ? null : this.txtWeight2.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtWeight3.Text == "" ? null : this.txtWeight3.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtWeight4.Text == "" ? null : this.txtWeight4.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtWeight5.Text == "" ? null : this.txtWeight5.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtWeight6.Text == "" ? null : this.txtWeight6.Text).ToString() + ",";

                    Query1 += "'" + this.cbxWgyno2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxWgyno3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxWgyno4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxWgyno5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxWgyno6.Text.ToUpper() + "',";

                    Query1 += Convert.ToInt32(this.chkDag1.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDag2.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDag3.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDag4.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDag5.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDag6.Checked ? "1" : "0").ToString() + ",";

                    Query1 += Convert.ToInt32(this.chkDam1.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDam2.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDam3.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDam4.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDam5.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkDam6.Checked ? "1" : "0").ToString() + ",";

                    Query1 += Convert.ToInt32(this.txtSupnuttr1.Text == "" ? null : this.txtSupnuttr1.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtSupnuttr2.Text == "" ? null : this.txtSupnuttr2.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtSupnuttr3.Text == "" ? null : this.txtSupnuttr3.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtSupnuttr4.Text == "" ? null : this.txtSupnuttr4.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtSupnuttr5.Text == "" ? null : this.txtSupnuttr5.Text).ToString() + ",";
                    Query1 += Convert.ToInt32(this.txtSupnuttr6.Text == "" ? null : this.txtSupnuttr6.Text).ToString() + ",";

                    Query1 += "'" + this.cbxResultcured2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxResultcured3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxResultcured4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxResultcured5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxResultcured6.Text.ToUpper() + "',";

                    Query1 += "'" + this.cbxReceiveddesparasitante1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxReceiveddesparasitante2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxReceiveddesparasitante3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxReceiveddesparasitante4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxReceiveddesparasitante5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxReceiveddesparasitante6.Text.ToUpper() + "',";

                    Query1 += "'" + this.cbxsalferr_acfolico1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxsalferr_acfolico2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxsalferr_acfolico3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxsalferr_acfolico4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxsalferr_acfolico5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxsalferr_acfolico6.Text.ToUpper() + "',";


                    Query1 += "'" + this.cbxta1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxta2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxta3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxta4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxta5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxta6.Text.ToUpper() + "',";

                    Query1 += "'" + this.cbxHgb1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxHgb2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxHgb3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxHgb4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxHgb5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxHgb6.Text.ToUpper() + "',";

                    Query1 += "'" + this.cbxProteinuria1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxProteinuria2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxProteinuria3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxProteinuria4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxProteinuria5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxProteinuria6.Text.ToUpper() + "',";

                    Query1 += "'" + this.cbxGlicosuria1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxGlicosuria2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxGlicosuria3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxGlicosuria4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxGlicosuria5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxGlicosuria6.Text.ToUpper() + "',";

                    Query1 += Convert.ToInt32(this.chkits_ulceragenital1.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_ulceragenital2.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_ulceragenital3.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_ulceragenital4.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_ulceragenital5.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_ulceragenital6.Checked ? "1" : "0").ToString() + ",";

                    Query1 +=Convert.ToInt32(this.chkits_leucorreia1.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_leucorreia2.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_leucorreia3.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_leucorreia4.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_leucorreia5.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkits_leucorreia6.Checked ? "1" : "0").ToString() + ",";

                    Query1 += "'" + this.cbxits_syndromictreatment1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syndromictreatment2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syndromictreatment3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syndromictreatment4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syndromictreatment5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syndromictreatment6.Text.ToUpper() + "',";

                    Query1 += "'" + this.cbxits_syphilistesting1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syphilistesting2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syphilistesting3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syphilistesting4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syphilistesting5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_syphilistesting6.Text.ToUpper() + "',";

                    Query1 += "'" + this.cbxits_wsyphilistreat1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_wsyphilistreat2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_wsyphilistreat3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_wsyphilistreat4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_wsyphilistreat5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_wsyphilistreat6.Text.ToUpper() + "',";

                    Query1 += "'" + this.cbxits_psyphilistreat1.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_psyphilistreat2.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_psyphilistreat3.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_psyphilistreat4.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_psyphilistreat5.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxits_psyphilistreat6.Text.ToUpper() + "',";
                    Query1 +=  Convert.ToInt32(this.chkCons_more4.Checked ? "1" : "0").ToString() + ",";
                    Query1 +=  Convert.ToInt32(this.chkPartnerpreence.Checked ? "1" : "0").ToString() + ",";
                    Query1 += "'" + this.cbxWeightgainyno.Text.ToUpper() + "',";
                    Query1 += Convert.ToInt32(this.chkDag.Checked ? "1" : "0").ToString() + ",";
                     Query1 += Convert.ToInt32(this.chkDam.Checked ? "1" : "0").ToString() + ",";
                     Query1 += "'" + this.cbxSupnutr.Text.ToUpper() + "',";
                     Query1 += "'" + this.cbxResultcured.Text.ToUpper() + "',";
                     Query1 += "'" + this.cbxResultabandon.Text.ToUpper() + "',";
                     Query1 += "'" + this.cbxReceiveddesparasitante.Text.ToUpper() + "',";
                    Query1 += Convert.ToInt32(this.chkSalferr_more3.Checked ? "1" : "0").ToString() + ",";
                    Query1 += Convert.ToInt32(this.chkIts_diag.Checked ? "1" : "0").ToString() + ",";
                    Query1 += "'" + this.cbxIts_treatment.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxIts_syphilistesting.Text.ToUpper() + "',";
                    Query1 += "'" + this.cbxIts_psyphilistreat.Text.ToUpper() + "',";
                    Query1 += "'" + Convert.ToInt32(this.chkIts_wsyphilistreat.Checked ? "1" : "0").ToString() + "'";
                    Query1 += ");"; 
                    MessageBox.Show(Query1);
                   MySqlCommand MyCommand1 = new MySqlCommand(Query1, connect);
                   MySqlDataReader MyReader1;
                   MyReader1 = MyCommand1.ExecuteReader(); 
                    
                    connect.Close();
                    //grdCPN.CurrentCell = grdCPN.Rows[1].Cells[1];
                    Variaveis.g_nid_cpn = this.cbxNidCPN.Text.ToUpper();
                    g_nidcpn = this.cbxNidCPN.Text.ToUpper();

                    frmCPN2 frm = new frmCPN2();
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            frmCPN2 frm = new frmCPN2();
            frm.Show();
        }


    }
}
