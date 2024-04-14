using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capadedatos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Capadedatos.Modelo_Pasajeros;
using static capadenegocio.CN_Pasajeros;

namespace capadenegocio
{
    public class CN_Pasajeros
    {
        //private CD_pasajeros objetoCD = new CD_pasajeros();
        private CD_pasajeros cdPasajeros = new CD_pasajeros();



        #region METODO MOSTRAR DATOS DE PASAJEROS
        public DataTable MostrarDatosPasajeros()
        {
            DataTable tabla = new DataTable();
            tabla = cdPasajeros.Mostrar();
            return tabla;
        }

        #endregion

        #region METODO AGREGAR PASAJEROS
        public void AgregarPasajero(Modelo_Pasajeros pasajero)
        {
            // Validaciones de negocio
            ValidarPasajero(pasajero);

            cdPasajeros.AddPasajero(pasajero);
        }

        #endregion

        #region METODO OBTENER PASAJEROS DE LISTA
        public List<Modelo_Pasajeros> ObtenerPasajeros()
        {
            return cdPasajeros.GetPasajeros();
        }
        #endregion

        #region METODO ACTUALIZAR PASAJEROS
        public void ActualizarPasajero(Modelo_Pasajeros pasajero)
        {
            ValidarPasajero(pasajero);

            cdPasajeros.UpdatePasajero(pasajero);
        }
        #endregion

        #region ELIMINAR PASAJERO

        // Elimina un pasajero por su ID
        public void EliminarPasajero(int idPasajero)
        {
            // Aquí podrías agregar validaciones adicionales si es necesario
            if (idPasajero <= 0)
                throw new ArgumentException("El ID proporcionado no es válido.");
            

            cdPasajeros.DeletePasajero(idPasajero);
        }
        #endregion

        #region METODO VALIDAR PASAJEROS


        // Valida la información de un pasajero
        private void ValidarPasajero(Modelo_Pasajeros pasajero)
        {
            if (string.IsNullOrWhiteSpace(pasajero.Nombre))
                throw new ArgumentException("El nombre del pasajero es requerido.");

            if (string.IsNullOrWhiteSpace(pasajero.Apellido))
                throw new ArgumentException("El apellido del pasajero es requerido.");

           

            // Aquí puedes agregar más validaciones según las reglas de tu negocio
        }

        #endregion

        #region METODO BUSCAR PASAJEROS POR NOMBRE


        public DataTable BuscarPasajerosPorNombre(string nombre)
        {
            return cdPasajeros.BuscarPasajerosPorNombre(nombre);
        }
        #endregion


        #region METODO TENER PASAJERO POR ID


        public Modelo_Pasajeros ObtenerPasajeroPorId(int id)
        {
            return cdPasajeros.ObtenerPasajeroPorId(id);
        }

        #endregion

       
        public List<Modelo_Pasajeros> ObtenerPasajeroPago()
        {
            // Llamada a la capa de datos para obtener la lista de países
            return cdPasajeros.ObtenerPasajerosConIdYNombre();
        }

        public List<Modelo_Pasajeros> ObtenerPasajerosConIdYNombre0()
            {
                return cdPasajeros.ObtenerPasajerosConIdYNombre();
            }
        

    }
}
