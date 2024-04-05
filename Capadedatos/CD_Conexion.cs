using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Capadedatos
{
    public class CD_Conexion
    {

        public SqlConnection Conexion = new SqlConnection("Server=.;DataBase=pasajero;integrated Security=true");
        
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)

                Conexion.Open();

            return Conexion;

        }
        public SqlConnection CerrarConexion()
        {


            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;

        }
    }
}
