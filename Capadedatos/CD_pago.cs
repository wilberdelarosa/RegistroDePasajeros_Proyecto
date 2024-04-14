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
    public class CD_Pago
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataAdapter leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private string? Estado;


      
        public List<Modelo_Pago> MostrarPagos()
        #region MOSTRAR TODO
        {
            List<Modelo_Pago> listaPagos = new List<Modelo_Pago>();

            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                using (var cmd = new SqlCommand("spMostrarPagos", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                        
                            var pago = new Modelo_Pago
                            {
                                Idpago = Convert.ToInt32(reader["idpago"]),
                                Fecha = DateOnly.FromDateTime(Convert.ToDateTime(reader["fecha"])),
                                Idpasajero = Convert.ToInt32(reader["idpasajero"]),
                                Nombre_Pasajero = reader["nombre_pasajero"].ToString(),
                                Monto = Convert.ToInt32(reader["monto"]),
                                Tipo_pago = reader["tipo_pago"].ToString(),
                                Impuesto = Convert.ToInt32(reader["impuesto"]),
                                Total = Convert.ToInt32(reader["total"]),
                                Estado = reader["estado"].ToString()

                          
                            };
                            listaPagos.Add(pago);
                            
                        }
                    }
                }
            }
            return listaPagos;
        }

        #endregion

   
        public void AddPago(Modelo_Pago pago)
        #region METODO AÑADIR PAGO A BASE DE DATOS
        {
            try
            {
                DateTime fechaSql = pago.Fecha.ToDateTime(new TimeOnly(0, 0));
                using (SqlConnection conn = new CD_Conexion().ObtenerConexion())
                {
                    conn.Open(); // Asegúrate de abrir la conexión dentro del bloque using.
                    using (SqlCommand cmd = new SqlCommand("spAgregarPago", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fecha", fechaSql);
                        cmd.Parameters.AddWithValue("@idpasajero", pago.Idpasajero);
                        cmd.Parameters.AddWithValue("@monto", pago.Monto);
                        cmd.Parameters.AddWithValue("@tipo_pago", pago.Tipo_pago);
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

        #endregion//

     
        public List<Modelo_Pago> GetPago()
        #region METODO TIPO LISTA OBTENER PASAJEROS
        {
            var listapago = new List<Modelo_Pago>();

            // La conexión se abre automáticamente al entrar al bloque using y se cierra al salir.
            using (var conn = conexion.AbrirConexion())
            {

                using (var cmd = new SqlCommand("spAgregarPago", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            // Asume que 'fecha' es de tipo DateTime en tu base de datos
                            var pago = new Modelo_Pago
                            {
                                Idpago = Convert.ToInt32(reader["idpago"]),
                                Fecha = DateOnly.FromDateTime(Convert.ToDateTime(reader["fecha"])),
                            Idpasajero = Convert.ToInt32(reader["idpasajero"]),
                                Monto = Convert.ToInt32(reader["monto"]),

                            };
                            listapago.Add(pago);


                        }
                    }
                }
            }

            return listapago;
        }
        #endregion

       
        public void UpdatePago(Modelo_Pago pago)
        #region METODO PARA ACTUALIAZAR LOS PAGO
        // Método para actualizar un pasajero existente
        {
            DateTime fechaSql = pago.Fecha.ToDateTime(new TimeOnly(0, 0));
            using (SqlConnection conn = new CD_Conexion().ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("spActualizarPago", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idPago", pago.Idpago);
                    cmd.Parameters.AddWithValue("@fecha", fechaSql);
                    cmd.Parameters.AddWithValue("@idpasajero", pago.Idpasajero);
                    cmd.Parameters.AddWithValue("@monto", pago.Monto);
                    cmd.Parameters.AddWithValue("@tipo_pago", pago.Tipo_pago);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

       
        public bool ValidarPagoPorIdYNombre(int idPasajero, string nombrePasajero)
        #region VALIDAR PAGO POR ID Y NOMBRE
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("spValidarPagoPorIdYNombre", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idPasajero", idPasajero);
                        cmd.Parameters.AddWithValue("@nombrePasajero", nombrePasajero);

                        // La ejecución del comando cambia aquí para adaptarse al nuevo enfoque
                        var resultado = cmd.ExecuteScalar(); // Ejecuta y espera un único resultado

                        if (resultado != null)
                        {
                            // Aquí se convierte el resultado a bool, suponiendo que el procedimiento almacenado devuelve un valor adecuado
                            return Convert.ToBoolean(resultado);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("SQL Error: " + ex.Message);
                throw; // Manejo adecuado de excepciones según las necesidades de tu aplicación.
            }

            // Si no hay un resultado claro o en caso de excepción, devuelve false.
            return false;
        }

        #endregion

   
        public DataTable BuscarPagosPorIdONombre(string criterio)
        #region BUSCAR PAGO POR ID O POR NOMBRE
        {
            DataTable dataTable = new DataTable();
            int.TryParse(criterio, out int idPasajero);

            using (SqlCommand cmd = new SqlCommand("spBuscarPagos", conexion.Conexion))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpasajero", idPasajero > 0 ? idPasajero : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@nombre", idPasajero <= 0 ? criterio : (object)DBNull.Value);

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

       
        public void RealizarReembolso(int idPago)
        #region METODO PARA REALIZAR REEMBOLSO
        {




            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("spRealizarReembolso", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idpago", idPago);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle exceptions
                throw new Exception("Error al realizar el reembolso: " + ex.Message);
            }















            /*
            try
            {
                // Usa la fecha acborrtual para el reembolso y convierte DateOnly a DateTime
                DateTime fechaSql = DateOnly.FromDateTime(DateTime.Now).ToDateTime(new TimeOnly(0, 0));
                using (SqlConnection conn = new CD_Conexion().ObtenerConexion())
                {
                    
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("spRealizarReembolso", conn)) // Asegúrate que el nombre del SP es correcto.
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@idpago", pagoReembolsado.Idpago); // Asume que necesitas el ID del pago original para realizar el reembolso.
                        cmd.Parameters.AddWithValue("@fecha", fechaSql); // Fecha actual como fecha de reembolso.
                        cmd.Parameters.AddWithValue("@idpasajero", pagoReembolsado.Idpasajero);
                        cmd.Parameters.AddWithValue("@monto", -pagoReembolsado.Monto); // Monto negativo para indicar reembolso.
                        cmd.Parameters.AddWithValue("@tipo_pago", pagoReembolsado.Tipo_pago);
                        cmd.Parameters.AddWithValue("@estado", "Reembolsado"); // Asume que hay una columna 'estado' en tu tabla de pago.

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine("SQL Error: " + ex.Message);
                throw;
            }*/
        }
        #endregion

        public DataTable BuscarPasajerosPorNombre(string nombre)
        #region METODO BUSCAR pago por pasajero

        {
            DataTable dataTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand("spBuscarPagos", conexion.Conexion))
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


        public Modelo_Pago ObtenerPagoPorId0(int id)
        #region OBTENER PAGO POR ID
        {
            Modelo_Pago pago = null;
            try
            {
                conexion.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("spObtenerDatosDePagoPorIdPasajero", conexion.Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idpasajero", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pago = new Modelo_Pago
                            {
                                Idpago = Convert.ToInt32(reader["idpago"]),
                                Fecha = DateOnly.FromDateTime(Convert.ToDateTime(reader["fecha"])),
                                Idpasajero = Convert.ToInt32(reader["idpasajero"]),
                                Nombre_Pasajero = reader["nombre_pasajero"].ToString(),
                                Monto = Convert.ToInt32(reader["monto"]),
                                Tipo_pago = reader["tipo_pago"].ToString(),
                                Impuesto = Convert.ToInt32(reader["impuesto"]),
                                Total = Convert.ToInt32(reader["total"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el pago por ID", ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return pago;
        }
        #endregion



















    }



}




/*
           













            #region METODO PARA OBTENER PASAJEROS POR ID
            
        public List<Modelo_Pago> ObtenerPagoPorId(int idPasajero)
            {
                List<Modelo_Pago> listaPagos = new List<Modelo_Pago>();

                // Obtener la conexión a través del método ObtenerConexion
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open(); // Asegúrate de abrir la conexión
                    using (var cmd = new SqlCommand("spBuscarPagos", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idpasajero", idPasajero);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Aquí mapeas los datos a tu objeto Pago
                            }
                        }
                    }
                    // No es necesario cerrar la conexión explícitamente, el 'using' lo hará por ti
                }
                return listaPagos;
        }*/