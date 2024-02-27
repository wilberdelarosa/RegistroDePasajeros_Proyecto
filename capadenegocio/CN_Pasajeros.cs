using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capadedatos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace capadenegocio
{
    public class CN_Pasajeros
    {
        private CD_pasajeros objetoCD = new CD_pasajeros();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
       
    }
}
