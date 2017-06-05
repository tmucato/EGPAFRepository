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
using smiBLL;
using smiGlobal;

namespace smi
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private bool validate_login(string user, string pass)
        {
            Boolean result = false;
            try
            {
                clUsers clusr = new clUsers();
                List<clUsers> List_User = clusr.GetEntityList().Where(u => u.username.ToUpper() == user.ToUpper() && u.password.ToUpper() == pass.ToUpper()).ToList();
                if (List_User.Count > 0)
                    result = true;
                else
                    result = false;
            }
            catch (Exception ex)
            {
                Logger.LogError("Error getting list of mothers from database", ex);
                throw ex;
            }
            return result;
        }

        private void cmdSubmeter_Click(object sender, EventArgs e)
        {
            try
            {
                clUsers clusr = new clUsers();

                if (validate_fields())
                {
                    string user = txtUsername.Text;
                    string pass = txtPassword.Text;
                    if (validate_login(user, pass))
                    {
                        List<clUsers> List_User = clusr.GetEntityList().Where(u => u.username.ToUpper() == user.ToUpper() && u.password.ToUpper() == pass.ToUpper()).ToList();
                        string rolename = List_User.FirstOrDefault().systemrole;


                        if (rolename == AppConstants.SYSTEM_ROLE_DATA_CLERK)
                            GlobalVariables.USER_ROLE = AppConstants.SYSTEM_ROLE_DATA_CLERK;
                        else if (rolename == AppConstants.SYSTEM_ROLE_ADMIN)
                            GlobalVariables.USER_ROLE = AppConstants.SYSTEM_ROLE_ADMIN;
                        this.Close();
                        GlobalVariables.USER_IS_LOGGED_IN = true;
                        FrmHome frmHome = (FrmHome)GlobalVariables.MAIN_FORM;
                        frmHome.Enabled = true;
                        frmHome.Show();

                    }
                    else
                    {
                        this.txtPassword.Text = "";
                        this.txtUsername.Clear();
                        MessageBox.Show("Incorrect Login Credentials");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error submiting login form", ex);
                MessageBox.Show("Error ao tentar entrar no sistema");
            }


        }

        private bool validate_fields()
        {
            bool result = false;

            try
            {
                if (String.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("O Campo do utilizador encontra-se vazio");
                }
                else if (String.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("O Campo do password encontra-se vazio");
                }
                else
                {
                    result = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }


        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }



    }
}
