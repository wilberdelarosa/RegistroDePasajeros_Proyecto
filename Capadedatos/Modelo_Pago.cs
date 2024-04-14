using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capadedatos
{
    public class Modelo_Pago
    {
        //Campos

        private int idpago;
        private DateOnly fecha;
        private int idpasajero;
        private string nombre_pasajero;

        private int monto;
        private string tipo_pago;
        private int impuesto;
        private int total;
        private string estado;

        public int Idpago { get => idpago; set => idpago = value; }
        public DateOnly Fecha { get => fecha; set => fecha = value; }
        public int Idpasajero { get => idpasajero; set => idpasajero = value; }
        public string Nombre_Pasajero { get => nombre_pasajero; set => nombre_pasajero = value; }

        public int Monto { get => monto; set => monto = value; }
        public string Tipo_pago { get => tipo_pago; set => tipo_pago = value; }
        public int Impuesto { get => impuesto; set => impuesto = value; }

      

        public int Total { get => total; set => total = value; }

        public string Estado { get => estado; set => estado = value; }


        public Modelo_Pago() { }


    }
}
