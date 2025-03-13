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
    public partial class Frm_Players : Form
    {
        int id;
        bool lEstado = false;
        public Frm_Players(int id_login)
        {
            id = id_login;
            InitializeComponent();   
        }
        #region "Mis metodos"
        private void FormatoDVG()
        {
            dgvListadoPlayers.Columns[0].Width = 163;
            dgvListadoPlayers.Columns[0].HeaderText = "ID";

            dgvListadoPlayers.Columns[1].Width = 163;
            dgvListadoPlayers.Columns[1].HeaderText = "NAME";

            dgvListadoPlayers.Columns[2].Width = 163;
            dgvListadoPlayers.Columns[2].HeaderText = "GOALS";

            dgvListadoPlayers.Columns[3].Width = 163;
            dgvListadoPlayers.Columns[3].HeaderText = "ASSISTS";

            dgvListadoPlayers.AllowUserToAddRows = false;
            dgvListadoPlayers.AllowUserToDeleteRows = false;
            dgvListadoPlayers.ReadOnly = true;
        }
        private void cargarJugadores()
        {
            D_Players datosPlayer = new D_Players();
            DataTable dataTable = datosPlayer.listadoPlayers(this.id);

            if (dataTable.Rows.Count > 0)
            {
                this.dgvListadoPlayers.DataSource = dataTable;
                this.FormatoDVG();
            }
            else
            {
                MessageBox.Show("No se encontraron jugadores.");
            }
        }
        private void estadoTexto(bool estado)
        {
            txtNamePlayers.Enabled = !estado;
            btnSavePlayer.Visible = !estado;
            btnCancelPlayers.Visible = !estado;;

            lEstado = !lEstado;
        }
        private void limpiarTexto()
        {
            this.txtNamePlayers.Text = "";
        }
        #endregion
        private void Frm_Players_Load(object sender, EventArgs e)
        {
            txtNamePlayers.Enabled = false;
            btnSavePlayer.Visible = false;
            btnCancelPlayers.Visible = false;
            txtAssistsPlayers.Enabled = false;
            txtGoalsPlayers.Enabled = false;
            lblAssistPlayers.Enabled = false;
            lblGoalsPlayers.Enabled = false;

            this.cargarJugadores();
            this.selectItem();
        }
        private void btnNewPlayerPlayers_Click(object sender, EventArgs e)
        {
            this.estadoTexto(lEstado);
        }

        private void btnCancelPlayers_Click(object sender, EventArgs e)
        {
            this.limpiarTexto();
            this.estadoTexto(lEstado);
        }

        private void btnSavePlayer_Click(object sender, EventArgs e)
        {
            string rpta = "";
            
            E_Player player = new E_Player();
            D_Players d_Players = new D_Players();

            this.estadoTexto(lEstado);
            if(txtNamePlayers.Text == string.Empty)
            {
                MessageBox.Show("Data entry is missing.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                player.name = txtNamePlayers.Text;
                player.id_user = id;

                rpta = d_Players.registerPlayer(player);
            }

            this.limpiarTexto();

            if (rpta == "OK")
            {
                MessageBox.Show("Player registered !.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This player couldn't been registered.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void btnReloadPlayers_Click(object sender, EventArgs e)
        {
            this.cargarJugadores();
        }

        private void btnEliminarPlayers_Click(object sender, EventArgs e)
        {
            
        }
        private void selectItem()
        {
            int idPlayer;
            if (string.IsNullOrEmpty(Convert.ToString(dgvListadoPlayers.CurrentRow.Cells["NAME"].Value)))
            {
                MessageBox.Show("Empty.",
                                "Aviso de sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                idPlayer = Convert.ToInt32(dgvListadoPlayers.CurrentRow.Cells["ID"].Value);
                this.txtNamePlayers.Text = Convert.ToString(dgvListadoPlayers.CurrentRow.Cells["NAME"].Value);
                this.txtGoalsPlayers.Text = Convert.ToString(dgvListadoPlayers.CurrentRow.Cells["GOALS"].Value);
                this.txtAssistsPlayers.Text = Convert.ToString(dgvListadoPlayers.CurrentRow.Cells["ASSISTS"].Value);
            }
        }
    }
}
