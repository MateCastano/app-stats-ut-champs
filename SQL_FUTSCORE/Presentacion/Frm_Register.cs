using SQL_FUTSCORE.Datos;
using SQL_FUTSCORE.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_FUTSCORE.Presentacion
{
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }
        int frmId = 0;
        private void btnRegisterRegister_Click(object sender, EventArgs e)
        {
            string rpta = "";

            if (txtPasswordRegister.Text == string.Empty ||
               txtUsernameRegister.Text == string.Empty)
            {
                MessageBox.Show("Data entry is missing.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                E_User user = new E_User();

                user.id = this.frmId;
                user.username = txtUsernameRegister.Text;
                user.password = txtPasswordRegister.Text;

                D_Users d_Users = new D_Users();
                rpta = d_Users.registerUser(user);
            }

            if (rpta == "OK")
            {
                MessageBox.Show("User registered !.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This user already exists.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {   
            Frm_Login frm_Login = new Frm_Login();
            this.Hide();
            frm_Login.ShowDialog();
            this.Close();
        }
    }
}
