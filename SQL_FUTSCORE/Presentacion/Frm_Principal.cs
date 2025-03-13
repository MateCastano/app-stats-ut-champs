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
    public partial class Frm_Principal : Form
    {
        int id;
        bool lEstado = false;
        public Frm_Principal(int id_login)
        {
            id = id_login;
            InitializeComponent();

        }
        #region "Mis metodos"
        private void FormatoDVG()
        {
            dgvPlayersPrincipal.Columns[0].Visible = false;

            dgvPlayersPrincipal.Columns[1].Width = 240;
            dgvPlayersPrincipal.Columns[1].HeaderText = "NAME";

            dgvPlayersPrincipal.Columns[2].Width = 240;
            dgvPlayersPrincipal.Columns[2].HeaderText = "GOALS";

            dgvPlayersPrincipal.Columns[3].Width = 240;
            dgvPlayersPrincipal.Columns[3].HeaderText = "ASSISTS";

            dgvPlayersPrincipal.AllowUserToAddRows = false;
            dgvPlayersPrincipal.AllowUserToDeleteRows = false;
            dgvPlayersPrincipal.ReadOnly = true;
        }

        private void cargarJugadores()
        {
            D_Players datosPlayer = new D_Players();
            DataTable dataTable = datosPlayer.listadoPlayers(this.id);

            if (dataTable.Rows.Count > 0)
            {
                this.dgvPlayersPrincipal.DataSource = dataTable;
                this.FormatoDVG();
            }
            else
            {
                MessageBox.Show("No se encontraron jugadores.");
            }
        }

        private void estadoBotones(bool estado)
        {
            this.txtLossesPrincipal.Enabled = !estado;
            this.txtWinsPrincipal.Enabled = !estado;
            this.btnCancelarPrincipal.Visible = !estado;
            this.btnGuardarPrincipal.Visible = !estado;
            this.btnResetRecordPrincipal.Visible = !estado;

            lEstado = !lEstado;
        }
        #endregion
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            E_Record eRecord = new E_Record();

            eRecord.id_user = id;
            D_Record dRecord = new D_Record();

            this.txtLossesPrincipal.Text = dRecord.getLosses(eRecord);
            this.txtWinsPrincipal.Text = dRecord.getWins(eRecord);
            this.txtLossesPrincipal.Enabled = lEstado;
            this.txtWinsPrincipal.Enabled = lEstado;
            this.btnCancelarPrincipal.Visible = lEstado;
            this.btnGuardarPrincipal.Visible = lEstado;
            this.btnResetRecordPrincipal.Visible = lEstado;

            this.cargarJugadores();
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            Frm_Players frm_Players = new Frm_Players(id);
            frm_Players.ShowDialog();
        }
        #region Record
        private void btnRecordPrincipal_Click(object sender, EventArgs e)
        {
            this.estadoBotones(lEstado);
        }

        private void btnCancelarPrincipal_Click(object sender, EventArgs e)
        {
            D_Record dRecord = new D_Record();
            E_Record eRecord = new E_Record();

            eRecord.id_user = id;

            this.estadoBotones(lEstado);

            this.txtWinsPrincipal.Text = dRecord.getWins(eRecord);
            this.txtLossesPrincipal.Text = dRecord.getLosses(eRecord);
        }
        private void btnResetRecordPrincipal_Click(object sender, EventArgs e)
        {
            D_Record dRecord = new D_Record();
            E_Record eRecord = new E_Record();

            eRecord.id_user = id;

            this.estadoBotones(lEstado);

            dRecord.setRecord(id, 0, 0);

            this.txtWinsPrincipal.Text = dRecord.getWins(eRecord);
            this.txtLossesPrincipal.Text = dRecord.getLosses(eRecord);

            MessageBox.Show("Record updated !",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
        #endregion
        private void btnGuardarPrincipal_Click(object sender, EventArgs e)
        {
            string rpta = "";

            D_Record dRecord = new D_Record();
            E_Record eRecord = new E_Record();

            eRecord.id_user = id;

            this.estadoBotones(lEstado);

            if(txtLossesPrincipal.Text == string.Empty || txtWinsPrincipal.Text == string.Empty)
            {
                MessageBox.Show("Data entry is missing.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                rpta = dRecord.setRecord(id, Convert.ToInt32(txtWinsPrincipal.Text), Convert.ToInt32(txtLossesPrincipal.Text));
            }

            if (rpta == "OK")
            {
                MessageBox.Show("Record updated !",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This record couldn't been updated.",
                                "System warning.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearchPrincipal_Click(object sender, EventArgs e)
        {
            D_Players player = new D_Players();

            DataTable table = player.listadoPlayersSearch(this.txtSearchPrincipal.Text);

            if (table.Rows.Count > 0)
            {
                this.dgvPlayersPrincipal.DataSource = table;
                this.FormatoDVG();
            }
            else
            {
                MessageBox.Show("No se encontraron jugadores.");
            }
        }

        private void reloadPrincipal_Click(object sender, EventArgs e)
        {
            this.cargarJugadores();
        }
    }
}
