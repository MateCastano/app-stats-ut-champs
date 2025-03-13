using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProcesoCRUD.Datos
{
    public class CConexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static CConexion con = null;

        private CConexion()
        {
            this.Base = "BD_FUTSCORE";
            this.Servidor = "****";
            this.Usuario = "****";
            this.Clave = "****";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor + ";Database=" + this.Base + ";User Id=" + this.Usuario + ";Password=" + this.Clave;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }
        public static CConexion getInstacia()
        {
            if (con == null)
            {
                con = new CConexion();
            }
            return con;
        }
    }
}
