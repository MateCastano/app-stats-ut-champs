using ProcesoCRUD.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_FUTSCORE.Datos
{
    public class D_Players
    {
        SqlConnection con = new SqlConnection();
        public DataTable listadoPlayers(int id_login)
        {
            DataTable listado = new DataTable();
            SqlDataReader resultado;
            try
            {
                con = CConexion.getInstacia().CrearConexion();
                con.Open();
                SqlCommand command = new SqlCommand("usp_get_players_by_user", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id_login", SqlDbType.Int).Value = id_login;

                resultado = command.ExecuteReader();

                listado.Load(resultado);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return listado;
        }
        public DataTable listadoPlayersSearch(string search)
        {
            DataTable listado = new DataTable();
            SqlDataReader resultado;
            try
            {
                con = CConexion.getInstacia().CrearConexion();
                con.Open();
                SqlCommand command = new SqlCommand("usp_get_players_by_name", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = search;

                resultado = command.ExecuteReader();

                listado.Load(resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return listado;
        }
        public string registerPlayer(Entidades.E_Player player)
        {
            string rpta = "";
            try
            {
                con = CConexion.getInstacia().CrearConexion();
                SqlCommand command = new SqlCommand("usp_insert_player", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = player.name;
                command.Parameters.Add("@id_user", SqlDbType.Int).Value = player.id_user;

                con.Open();
                rpta = command.ExecuteNonQuery() >= 1 ? "OK" : "Player cannot be register";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
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
        public string deletePlayer(int idPlayer)
        {
            string rpta = "";

            try
            {
                con = CConexion.getInstacia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usp_delete_player", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = idPlayer;

                con.Open();

                rpta = cmd.ExecuteNonQuery() >= 1 ? "OK" : "Player cannot be delete.";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
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
