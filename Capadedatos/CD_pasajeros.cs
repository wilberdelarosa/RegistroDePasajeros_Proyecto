using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capadedatos
{
    public class CD_pasajeros
    {
        private CD_Conexion conexion = new CD_Conexion();
        private CD_Pais pais = new CD_Pais();

        SqlDataAdapter leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
       
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from pasajeros";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla; 


        }
        public void AddPasajero(Modelo_Pasajeros pasajero)
        {
            try
            {
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("spAgregarPasajero", conn);
                    //SqlCommand cmd = new SqlCommand("spAgregarPasajero", conexion.Conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //  un procedimiento almacenado con estos parámetros
                    cmd.Parameters.AddWithValue("@nombre", pasajero.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", pasajero.Apellido);
                    cmd.Parameters.AddWithValue("@tipo_documento", pasajero.Tipo_documento);
                    cmd.Parameters.AddWithValue("@num_documento", pasajero.Num_documento);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", pasajero.Fecha_Nacimiento);
                    cmd.Parameters.AddWithValue("@idpais", pasajero.Idpais); 
                    cmd.Parameters.AddWithValue("@telefono", pasajero.Telefono);
                    cmd.Parameters.AddWithValue("@email", pasajero.Email);

                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();
                }

            }
            catch (SqlException ex)
            {
                // Log o mostrar el mensaje de error SQL
                System.Diagnostics.Debug.WriteLine("SQL Error: " + ex.Message);
                throw; // O manejar según sea necesario
            }
            catch (Exception ex)
            {
                // Log o mostrar el mensaje de error general
                System.Diagnostics.Debug.WriteLine("General Error: " + ex.Message);
                throw; // O manejar según sea necesario
            }

        }
            public List<Modelo_Pasajeros> GetPasajeros()
        {
            List<Modelo_Pasajeros> lista = new List<Modelo_Pasajeros>();
            SqlCommand cmd = new SqlCommand("spConsultarPasajeros", conexion.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            conexion.AbrirConexion();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Modelo_Pasajeros()
                    {
                        //Id = Convert.ToInt32(reader["idpasajero"]),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Tipo_documento = reader["tipo_documento"].ToString(),
                        Num_documento = reader["num_documento"].ToString(),
                        Fecha_Nacimiento = reader["fecha_nacimiento"].ToString(),
                        //Fecha_Nacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]),
                        Idpais = Convert.ToInt32(reader["idpais"]),
                        Telefono = reader["telefono"].ToString(),
                        Email = reader["email"].ToString()
                    });
                }
            }
            conexion.CerrarConexion();

            return lista;
        }
        // Método para actualizar un pasajero existente
        public void UpdatePasajero(Modelo_Pasajeros pasajero)
        {
            SqlCommand cmd = new SqlCommand("spActualizarPasajero", conexion.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idpasajero", pasajero.Id);
            cmd.Parameters.AddWithValue("@nombre", pasajero.Nombre);
            cmd.Parameters.AddWithValue("@apellido", pasajero.Apellido);
            cmd.Parameters.AddWithValue("@tipo_documento", pasajero.Tipo_documento);
            cmd.Parameters.AddWithValue("@num_documento", pasajero.Num_documento);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", pasajero.Fecha_Nacimiento);
            cmd.Parameters.AddWithValue("@idpais", pasajero.Idpais);
            cmd.Parameters.AddWithValue("@telefono", pasajero.Telefono);
            cmd.Parameters.AddWithValue("@email", pasajero.Email);

            conexion.AbrirConexion();
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        // Método para eliminar un pasajero
        public void DeletePasajero(int id)
        {
            SqlCommand cmd = new SqlCommand("spEliminarPasajero", conexion.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idpasajero", id);

            conexion.AbrirConexion();
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }






        public DataTable BuscarPasajerosPorNombre(string nombre)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand("spBuscarPasajerosPorNombre", conexion.Conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);

                conexion.AbrirConexion();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                conexion.CerrarConexion();
            }
            return dataTable;
        }

































        /*
        public List<Modelo_Pasajeros> BuscarPasajerosPorNombre(string nombre)
        {
            
            List<Modelo_Pasajeros> lista = new List<Modelo_Pasajeros>();
         
            DataTable dataTable = new DataTable();
            using (var connection = conexion.AbrirConexion())
            {
               
                SqlCommand cmd = new SqlCommand("spBuscarPasajerosPorNombre", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Modelo_Pasajeros()
                        {
                            Id = Convert.ToInt32(reader["idpasajero"]),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            Tipo_documento = reader["tipo_documento"].ToString(),
                            Num_documento = reader["num_documento"].ToString(),
                            Fecha_Nacimiento = reader["fecha_nacimiento"].ToString(), // Ajusta según tu modelo
                            Idpais = Convert.ToInt32(reader["idpais"]),
                            Telefono = reader["telefono"].ToString(),
                            Email = reader["email"].ToString(),
                        });
                    }
                }
            }
            conexion.CerrarConexion();

            return lista;
        }*/

    }
}
