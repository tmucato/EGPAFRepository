using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using smiDAL;

namespace smi
{
    public partial class FrmMother : Form
    {
        private string conn;
        private MySqlConnection connect;
        //private String ConnectionString;
        private DataViewManager dsView;
        private DataSet ds;

       public FrmMother()
        {
            InitializeComponent();
            // Setup DB-Connection
            MySqlConnection con = Connection.GetSMIDataBaseConnection();
            con.Open();

            // Create the DataSet
            ds = new DataSet("mothers");

            // Fill the Dataset with mothers, map Default Tablename
            // "Table" to "mothers".
            MySqlDataAdapter da1 = new MySqlDataAdapter("SELECT * FROM mother", con);
            da1.TableMappings.Add("Table", "mother");
            da1.Fill(ds);

            dsView = ds.DefaultViewManager;

            // Grid Databinding
            grdMother.DataSource = dsView;
            grdMother.DataMember = "mother";

            // Text Columns Databinding
            txtID.DataBindings.Add("Text", dsView, "mother.id");
            txtNid_cpn.DataBindings.Add("Text", dsView, "mother.nid_cpn");
            txtNid_tarv.DataBindings.Add("Text", dsView, "mother.nid_tarv");
            txtName.DataBindings.Add("Text", dsView, "mother.name");
            txtResidence.DataBindings.Add("Text", dsView, "mother.residence");
            txtPhone.DataBindings.Add("Text", dsView, "mother.phone");
            //dtpDOB.DataBindings.Add("Value", dsView, "mother.dob");
            Binding dobBinding = new Binding("Text", dsView, "mother.dob");
            dobBinding.Format += new ConvertEventHandler(this.textBoxDOB_FormatDate);
            dobBinding.Parse += new ConvertEventHandler(this.textBoxDOB_ParseDate);
            txtDob.DataBindings.Add(dobBinding);

        }
      
         private void db_connection()
        {
            try
            {
               
                connect = Connection.GetSMIDataBaseConnection();
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        
             private void loadData()
             {
                 try
                 {
                     db_connection();
                     string Query = "select * from mother;";
                     MySqlCommand MyCommand2 = new MySqlCommand(Query, connect);
                      //For offline connection we weill use  MySqlDataAdapter class.  
                     MySqlDataAdapter MyAdapter = new MySqlDataAdapter();    
                      MyAdapter.SelectCommand = MyCommand2;  
                     DataTable dTable = new DataTable();  
                     MyAdapter.Fill(dTable);  
                     grdMother.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                 }   
                 catch(Exception)
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
                 btnNew.Enabled = true;
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

             private void cmdMotSubmit_Click_1(object sender, EventArgs e)
             {
                 try
                 {
                     db_connection();
                     string nidcpn = txtNid_cpn.Text;
                     string nidtarv = txtNid_tarv.Text;
                     string name = txtName.Text;
                     string residence = txtResidence.Text;
                     string phone = txtPhone.Text;
                     if (this.txtID.Text!="")
                     //update
                     {
                        //MyReader.Close();
                         //This is my update query in which i am taking input from the user through windows forms and update the record.  
                         string Query3 = "update mother set nid_cpn='" + this.txtNid_cpn.Text.ToUpper() + "',nid_tarv='" + this.txtNid_tarv.Text.ToUpper() + "',name='" + this.txtName.Text.ToUpper() + "',residence='" + this.txtResidence.Text.ToUpper() + "',phone='" + this.txtPhone.Text.ToUpper() + "',dob='" + Convert.ToDateTime(txtDob.Text).ToString("yyyy-MM-dd") + "' where id='" + Convert.ToInt64(this.txtID.Text) + "';";

                         MySqlCommand MyCommand2 = new MySqlCommand(Query3, connect);
                         MySqlDataReader MyReader2;
                         MyReader2 = MyCommand2.ExecuteReader();
                         MessageBox.Show("Data Updated");
                         while (MyReader2.Read())
                         {
                         }
                         connect.Close();//Connection closed here 
                         grdMother.CurrentCell = grdMother.Rows[1].Cells[1];
                     }
                     else
                     //insert
                     {
                        // MyReader.Close();
                         //This is my insert query in which i am taking input from the user through windows forms  
                        string Query2 = "insert into mother(nid_cpn,nid_tarv,name,residence,phone,dob) values('" + this.txtNid_cpn.Text.ToUpper() + "','" + this.txtNid_tarv.Text.ToUpper() + "','" + this.txtName.Text.ToUpper() + "','" + this.txtResidence.Text.ToUpper() + "','" + this.txtPhone.Text.ToUpper() + "','" + Convert.ToDateTime(txtDob.Text).ToString("yyyy-MM-dd") + "');";
                         //This is command class which will handle the query and connection object.  
                         MySqlCommand MyCommand2 = new MySqlCommand(Query2, connect);
                         MySqlDataReader MyReader3;
                         MyReader3 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                         MessageBox.Show("Save Data");
                        
                         while (MyReader3.Read())
                         {
                         }
                         connect.Close();
                         grdMother.CurrentCell = grdMother.Rows[1].Cells[1];
                     }

                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 loadData();
             }

             private void cmdNew_Click(object sender, EventArgs e)
             {
                 grdMother.Focus();
                 grdMother.ClearSelection();
                 int nRowIndex = grdMother.Rows.Count - 1;

                 grdMother.Rows[nRowIndex].Selected = true;
                 grdMother.Rows[nRowIndex].Cells[0].Selected = true;
                 //grdMother.CurrentCell = grdMother.Rows[nRowIndex].Cells[0];
                 //grdMother.CurrentCell.RowIndex;
                
                 txtID.Clear();
                 txtNid_cpn.Clear();
                 txtNid_tarv.Clear();
                 txtName.Clear();
                 txtResidence.Clear();
                 txtPhone.Clear();
                 txtDob.Clear();
                 txtNid_cpn.Focus();
                

                 btnNew.Enabled = false;
             }

             private void textBoxDOB_FormatDate(object sender, ConvertEventArgs e)
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
             private void textBoxDOB_ParseDate(object sender, ConvertEventArgs e)
             {

                 // We only deal with converting to strings from dates
                 if (e.DesiredType != typeof(string)) return;
                 if (e.Value.GetType() != typeof(DateTime)) return;

                 DateTime dt = (DateTime)e.Value;
                 e.Value = dt.ToShortDateString();
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
                         grdMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdMother.Rows.Count - 1)
                             {
                                 strgrdvalue = grdMother.Rows[row].Cells[0].Value.ToString().Trim().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdMother.Rows[rowIndex].Selected = true;
                                     grdMother.CurrentCell = grdMother.Rows[rowIndex].Cells[0];
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
                         grdMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdMother.Rows.Count - 1)
                             {
                                // if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["nid_cpn"].Value.ToString().Equals(searchValueTxt))
                                 strgrdvalue = grdMother.Rows[row].Cells[1].Value.ToString().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdMother.Rows[rowIndex].Selected = true;
                                     grdMother.CurrentCell = grdMother.Rows[rowIndex].Cells[1];
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
                         grdMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdMother.Rows.Count - 1)
                             {
                                // if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["nid_tarv"].Value.ToString().Equals(searchValueTxt))
                                 strgrdvalue = grdMother.Rows[row].Cells[2].Value.ToString().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdMother.Rows[rowIndex].Selected = true;
                                     grdMother.CurrentCell = grdMother.Rows[rowIndex].Cells[2];
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
                         grdMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdMother.Rows.Count - 1)
                             {
                                 //if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["name"].Value.ToString().Equals(searchValueTxt))
                                 strgrdvalue = grdMother.Rows[row].Cells[3].Value.ToString().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdMother.Rows[rowIndex].Selected = true;
                                     grdMother.CurrentCell = grdMother.Rows[rowIndex].Cells[3];
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
                         grdMother.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                         try
                         {
                             bool valueResulet = true;
                             int row = 0;
                             while (row < grdMother.Rows.Count - 1)
                             {
                                 //if (grdMother.Rows[grdMother.CurrentRow.Index].Cells["name"].Value.ToString().Equals(searchValueTxt))
                                 strgrdvalue = grdMother.Rows[row].Cells[5].Value.ToString().ToUpper();
                                 if (strgrdvalue == searchValueTxt)
                                 {
                                     rowIndex = row;
                                     grdMother.Rows[rowIndex].Selected = true;
                                     grdMother.CurrentCell = grdMother.Rows[rowIndex].Cells[5];
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
            
             
    

    }
}
