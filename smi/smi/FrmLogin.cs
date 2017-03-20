using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // required for MySQL connection after addition of MySQL References
using smiDAL;

namespace smi
{
    public partial class frmLogin : Form
    {
        private string conn;
        private MySqlConnection connect;
        public frmLogin()
        {
            InitializeComponent();
        }
        public static class Variaveis
        {

            public static string Usuario;

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

        private bool validate_login(string user, string pass)
        {
            
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from usuario where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
                
            }
            else
            {
                connect.Close();
                return false;
            }
        }

        private void cmdSubmeter_Click(object sender, EventArgs e)
        {
            string rolename = "";
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            //Para buscar o "role"
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from usuario where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (user == "" || pass == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                // return;
                this.Close();
            }
            bool r = validate_login(user, pass);
            if (r)
            {
                this.Hide();
                if (login.Read())
                {
                    rolename = (string)login["systemrole"];
                }
                if (rolename=="ADMIN")
                {
                FrmHome frm = new FrmHome();
                frm.Show();
                }
                else
                {
                 //   FrmHome frm = new FrmHome();
                  //  frm.Show();
                }
               // MessageBox.Show("Correct Login Credentials");
            }
            else
            {
                this.txtPassword.Text = "";
                this.txtUsername.Clear();
                MessageBox.Show("Incorrect Login Credentials");
            }
             
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
       
    }
}
