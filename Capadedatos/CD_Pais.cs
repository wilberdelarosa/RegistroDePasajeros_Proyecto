using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capadedatos
{
    public class CD_Pais
    { 
         private CD_Conexion conexion = new CD_Conexion();

    // Método para obtener todos los países
    public List<Modelo_Pais> ObtenerPaises()
    {
        List<Modelo_Pais> lista = new List<Modelo_Pais>();
        SqlCommand cmd = new SqlCommand("SELECT * FROM pais", conexion.Conexion);
        conexion.AbrirConexion();
        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                lista.Add(new Modelo_Pais()
                {
                    Idpais = Convert.ToInt32(reader["idpais"]),
                    Nombre = reader["nombre"].ToString(),
                });
            }
        }
        conexion.CerrarConexion();

        return lista;
    }
   
    }
}
