using SQL_FUTSCORE.Datos;
using SQL_FUTSCORE.Entidades;
using SQL_FUTSCORE.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_FUTSCORE
{
    public partial class Frm_Login : Form
    {
        #region METHODS
        public Frm_Login()
        {
            InitializeComponent();
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            Frm_Register frm_register = new Frm_Register();
            this.Hide();
            frm_register.ShowDialog();
            this.Close();
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            int rpta = 0;

            if (txtPasswordLogin.Text == string.Empty ||
               txtUsernameLogin.Text == string.Empty)
            {
                MessageBox.Show("Data entry is missing.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                E_User user = new E_User();

                user.username = txtUsernameLogin.Text;
                user.password = txtPasswordLogin.Text;

                D_Users d_Users = new D_Users();
                rpta = d_Users.loginUser(user);
            }

            if (rpta >= 1)
            {
                Frm_Principal frm_p = new Frm_Principal(rpta);
                this.Hide();
                frm_p.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credentials are incorrect.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }
        #endregion
    }
}
