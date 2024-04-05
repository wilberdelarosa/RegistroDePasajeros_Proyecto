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
    public class CN_Pais
    {
        private CD_Pais cdPais;

        public CN_Pais()
        {
            cdPais = new CD_Pais();
        }

        public List<Modelo_Pais> ObtenerPaises()
        {
            // Llamada a la capa de datos para obtener la lista de países
            return cdPais.ObtenerPaises();
        }

        // Aquí podrías añadir otros métodos de negocio relacionados con 'Pais'
        // como agregar, actualizar o eliminar un país si la aplicación lo requiere.
    }




}

