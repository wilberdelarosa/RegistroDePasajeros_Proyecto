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
        private CD_pasajeros cdPasajeros = new CD_pasajeros();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void AgregarPasajero(Modelo_Pasajeros pasajero)
        {
            // Validaciones de negocio
            ValidarPasajero(pasajero);

            // Convertir de Modelo_Pasajeros a la entidad de base de datos si es necesario
            // O simplemente pasar el modelo si ya coincide con la entidad de la base de datos

            // Si todo está correcto, procedemos a agregar el pasajero
            cdPasajeros.AddPasajero(pasajero);
        }
        // Obtiene todos los pasajeros, posiblemente aplicando algún filtro o transformación
        public List<Modelo_Pasajeros> ObtenerPasajeros()
        {
            return cdPasajeros.GetPasajeros();
        }

        // Actualiza un pasajero, aplicando las reglas de negocio necesarias
        public void ActualizarPasajero(Modelo_Pasajeros pasajero)
        {
            // Validaciones de negocio
            ValidarPasajero(pasajero);

            // Si todo está correcto, procedemos a actualizar el pasajero
            cdPasajeros.UpdatePasajero(pasajero);
        }

        // Elimina un pasajero por su ID
        public void EliminarPasajero(int id)
        {
            // Aquí podrías agregar validaciones adicionales si es necesario
            if (id <= 0)
                throw new ArgumentException("El ID proporcionado no es válido.");

            cdPasajeros.DeletePasajero(id);
        }

        // Valida la información de un pasajero
        private void ValidarPasajero(Modelo_Pasajeros pasajero)
        {
            if (string.IsNullOrWhiteSpace(pasajero.Nombre))
                throw new ArgumentException("El nombre del pasajero es requerido.");

            if (string.IsNullOrWhiteSpace(pasajero.Apellido))
                throw new ArgumentException("El apellido del pasajero es requerido.");

            // Aquí puedes agregar más validaciones según las reglas de tu negocio
        }



        public DataTable BuscarPasajerosPorNombre(string nombre)
        {
            return cdPasajeros.BuscarPasajerosPorNombre(nombre);
        }

















        // public List<Modelo_Pasajeros> BuscarPasajerosPorNombre(string nombre)
        //{
        //  return objetoCD.BuscarPasajerosPorNombre(nombre);
        // }



    }
}
