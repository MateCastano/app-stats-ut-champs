using ProcesoCRUD.Datos;
using SQL_FUTSCORE.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_FUTSCORE.Datos
{
    public class D_Record
    {
        SqlConnection con = new SqlConnection();
        public D_Record(){}
        public string getWins(E_Record record)
        {
            string rpta = "";

            try
            {
                con = CConexion.getInstacia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usp_get_wins", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = record.id_user;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    rpta = reader["wins"].ToString(); // Suponiendo que la columna se llame 'wins'.
                }
            }
            catch (Exception ex)
            {
                return rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return rpta;
        }
        public string getLosses(E_Record record)
        {
            string rpta = "";

            try
            {
                con = CConexion.getInstacia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usp_get_losses", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = record.id_user;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    rpta = reader["losses"].ToString();
                }
            }
            catch (Exception ex)
            {
                return rpta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return rpta;
        }
        public string setRecord(int id, int nWins, int nLosses)
        {
            string rpta = "";
            try
            {
                con = CConexion.getInstacia().CrearConexion();

                SqlCommand cmd = new SqlCommand("usp_update_record", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_user", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@wins", SqlDbType.Int).Value = nWins;
                cmd.Parameters.Add("@losses", SqlDbType.Int).Value = nLosses;

                con.Open();
                rpta = cmd.ExecuteNonQuery() >= 1 ? "OK" : "Record couldn't been updated";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return rpta;
        }
    }
}
