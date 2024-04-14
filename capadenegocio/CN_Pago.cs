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
    public class CN_Pago
    {
        private CD_Pago cdPago = new CD_Pago();


        public List<Modelo_Pago> MostrarDatosPagos()
        #region METODO MOSTRAR DATOS DE PAGOS 
        {
            Modelo_Pago tablapago = new Modelo_Pago();
            return cdPago.MostrarPagos();
        }

        #endregion

      
        public void AgregarPago(Modelo_Pago pago)
        #region METODO AGREGAR PAGO
        {
            // Aquí podrías incluir validaciones o lógica de negocio adicional antes de llamar a la capa de datos
            cdPago.AddPago(pago);
        }

        #endregion

        #region METODO OBTENER PAGO DE LISTA
        public List<Modelo_Pago> ObtenerPago()
        {
            return cdPago.GetPago();
        }
        #endregion

        public void ActualizarPago(Modelo_Pago pago)
        #region METODO ACTUALIZAR PAGO
        {

            cdPago.UpdatePago(pago);
        }
        #endregion
          
        public void RealizarReembolso0(int idPago)
        #region METODO REEMBOLSO
        // Elimina un pasajero por su ID
        {

            cdPago.RealizarReembolso(idPago);


        }
        #endregion

        #region METODO VALIDAR PAGO

        // Valida la información de un pasajero
        public bool ValidarPagoPorIdYNombre(int idPasajero, string nombrePasajero)
        {
            return cdPago.ValidarPagoPorIdYNombre(idPasajero, nombrePasajero);
        }

        #endregion

        #region METODO BUSCAR PAGGO POR NOMBRE


        public DataTable BuscarPasajerosPorNombre01(string nombre)
        {
            return cdPago.BuscarPasajerosPorNombre(nombre);
        }
        #endregion
       
        public Modelo_Pago ObtenerPagoPorId(int id)
        #region METODO TENER PAGO POR ID
        {
            return cdPago.ObtenerPagoPorId0(id);
        }

        public DataTable BuscarPagosPorIdONombre(string criterio)
        {
            return cdPago.BuscarPagosPorIdONombre(criterio);
        }

        #endregion

        

    }
}
