using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capadedatos
{
    public class CD_User
    {
        private CD_Conexion conexion = new CD_Conexion();

        public UserBE GetUserFromDB(string username)
        {
            UserBE user = null;
            SqlConnection conn = conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT id, usuario, salt, password FROM usuarios WHERE usuario = @usuario", conn);
            cmd.Parameters.AddWithValue("@usuario", username);

            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UserBE()
                        {
                            Id = reader.GetInt32(0),
                            Usuario = reader.GetString(1),
                            Salt = (byte[])reader["salt"],
                            PasswordHash = (byte[])reader["password"]
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return user;
        }
        public bool SaveUser(UserBE user)
        {
            SqlConnection conn = conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO usuarios (usuario, salt, password) VALUES (@usuario, @salt, @password)", conn);
            cmd.Parameters.AddWithValue("@usuario", user.Usuario);
            cmd.Parameters.AddWithValue("@salt", user.Salt);
            cmd.Parameters.AddWithValue("@password", user.PasswordHash);

            try
            {
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

    }
}
