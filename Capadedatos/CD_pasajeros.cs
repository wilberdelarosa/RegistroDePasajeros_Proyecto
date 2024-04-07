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


        #region MOSTRAR TODO
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            tabla.Clear();

            comando.CommandText = "select * from pasajeros";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla; 


        }

        #endregion


        #region METODO AÑADIR PASAJEROS A BASE DE DATOS
        public void AddPasajero(Modelo_Pasajeros pasajero)
        {
            try
            {
                using (SqlConnection conn = new CD_Conexion().ObtenerConexion())
                {
                    conn.Open(); // Asegúrate de abrir la conexión dentro del bloque using.
                    using (SqlCommand cmd = new SqlCommand("spAgregarPasajero", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", pasajero.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", pasajero.Apellido);
                        cmd.Parameters.AddWithValue("@tipo_documento", pasajero.Tipo_documento);
                        cmd.Parameters.AddWithValue("@num_documento", pasajero.Num_documento);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", pasajero.Fecha_Nacimiento);
                        cmd.Parameters.AddWithValue("@idpais", pasajero.Idpais);
                        cmd.Parameters.AddWithValue("@telefono", pasajero.Telefono);
                        cmd.Parameters.AddWithValue("@email", pasajero.Email);

                        cmd.ExecuteNonQuery();
                        // No es necesario llamar a CerrarConexion aquí, el bloque using maneja el cierre de la conexión.
                    }
                }
            }
            catch (SqlException ex)

            {
                System.Diagnostics.Debug.WriteLine("SQL Error: " + ex.Message);
                throw;
            }

        }
        #endregion

        #region METODO TIPO LISTA OBTENER PASAJEROS
        public List<Modelo_Pasajeros> GetPasajeros()
        {
            var lista = new List<Modelo_Pasajeros>();

            // La conexión se abre automáticamente al entrar al bloque using y se cierra al salir.
            using (var conn = conexion.AbrirConexion())
            {
                using (var cmd = new SqlCommand("spConsultarPasajeros", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pasajero = new Modelo_Pasajeros
                            {
                                Id = Convert.ToInt32(reader["idpasajero"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Tipo_documento = reader["tipo_documento"].ToString(),
                                Num_documento = reader["num_documento"].ToString(),
                                Fecha_Nacimiento = reader["fecha_nacimiento"].ToString(), // Ajustar si es necesario
                                Idpais = Convert.ToInt32(reader["idpais"]),
                                Telefono = reader["telefono"].ToString(),
                                Email = reader["email"].ToString()
                            };
                            lista.Add(pasajero);
                        }
                    }
                }
            }

            return lista;
        }
        #endregion

        #region METODO PARA ACTUALIAZAR LOS PASAJEROS
        // Método para actualizar un pasajero existente
        public void UpdatePasajero(Modelo_Pasajeros pasajero)
        {
            using (SqlConnection conn = new CD_Conexion().ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("spActualizarPasajero", conn))
                {
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

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion


        #region METODO PARA ELIMINAR PASAJEROS
        // Método para eliminar un pasajero
        public void DeletePasajero(int id)
        {
            try
            {
                using (var conexion = new CD_Conexion().ObtenerConexion())
                {
                    conexion.Open();
                    using (var cmd = new SqlCommand("spEliminarPasajero", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idpasajero", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                System.Diagnostics.Debug.WriteLine("ELIMINAR - SQL Error: " + ex.Message);
            }
        }

        #endregion



        #region METODO BUSCAR PASAJEROS
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
        #endregion

        #region METODO PARA OBTENER PASAJEROS POR ID

        public Modelo_Pasajeros ObtenerPasajeroPorId(int id)
        {
            Modelo_Pasajeros pasajero = null;
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("spObtenerPasajeroPorId", conexion.Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idpasajero", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pasajero = new Modelo_Pasajeros
                            {
                                Id = Convert.ToInt32(reader["idpasajero"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Tipo_documento = reader["tipo_documento"].ToString(),
                                Num_documento = reader["num_documento"].ToString(),
                                Fecha_Nacimiento = Convert.ToDateTime(reader["fecha_nacimiento"]).ToString("yyyy-MM-dd"), // Ajustar según formato
                                Idpais = Convert.ToInt32(reader["idpais"]),
                                Telefono = reader["telefono"].ToString(),
                                Email = reader["email"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                throw new Exception("Error al obtener el pasajero por ID", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return pasajero;
        }

        #endregion



    }
}
