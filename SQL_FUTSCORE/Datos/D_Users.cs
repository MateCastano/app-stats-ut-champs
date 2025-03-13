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
    public class D_Users
    {
        SqlConnection con = new SqlConnection();
        public string registerUser(Entidades.E_User user)
        {
            string rpta = "";
            try
            {
                con = CConexion.getInstacia().CrearConexion();
                SqlCommand command = new SqlCommand("usp_insert_user", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = user.username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = user.password;

                con.Open();
                rpta = command.ExecuteNonQuery() >= 1 ? "OK" : "User cannot be register";
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
        public int loginUser(Entidades.E_User user)
        {
            int rpta = 0;
            try
            {
                con = CConexion.getInstacia().CrearConexion();
                SqlCommand command = new SqlCommand("usp_login_user", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = user.username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = user.password;

                con.Open();
                int result = Convert.ToInt32(command.ExecuteScalar());

                if (result != 0) 
                {
                    rpta = result;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
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
