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
                List<clUsers> List_User;
                clUsers clusr = new clUsers();
                List_User = clusr.GetEntityList().Where(u => u.username == user && u.password == pass).ToList();
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
            clUsers clusr = new clUsers();

            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            if (validate_login(user, pass))
            {

                List<clUsers> List_User = clusr.GetEntityList().Where(u => u.username == user && u.password == pass).ToList();
                string rolename = List_User.FirstOrDefault().systemrole;
                if (rolename == AppConstants.SYSTEM_ROLE_ADMIN)
                {
                    FrmHome frm = new FrmHome();
                    frm.Show();
                }
                else
                {
                    //TODO: Redicecionar para formulario de user no admin
                }

                this.Hide();
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
