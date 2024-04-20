using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capadedatos
{
    public class ModeloConsultaAvanzada
    {
        //Campos PASAJEROS

        private int idpasajero;
        private string nombre;
        private string apellido;
        private string tipo_documento;
        private string num_documento;
        private string pais;
        private DateOnly fecha_nacimiento;
        private string telefono;
        private string email;
        private bool isactive;
        //Campos PAGOS

        private int idpago;
        private DateOnly fecha;
        private string nombre_pasajero;
        private Decimal monto;
        private string tipo_pago;
        private Decimal impuesto;
        private Decimal total;
        private string estado;




        //propiedad de validacion PASAJEROS

        public int Idpasajero { get => idpasajero; set => idpasajero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Tipo_documento { get => tipo_documento; set => tipo_documento = value; }
        public string Num_documento { get => num_documento; set => num_documento = value; }
        public string Pais { get => pais; set => pais = value; }
        public DateOnly Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public bool IsActive { get => isactive; set => isactive = value; }


        //propiedad de validacion PAGO

        public int Idpago { get => idpago; set => idpago = value; }
        public DateOnly Fecha { get => fecha; set => fecha = value; }
        public string Nombre_pasajero { get => nombre_pasajero; set => nombre_pasajero = value; }
        public Decimal Monto { get => monto; set => monto = value; }
        public string Tipo_pago { get => tipo_pago; set => tipo_pago = value; }
        public Decimal Impuesto { get => impuesto; set => impuesto = value; }
        public Decimal Total { get => total; set => total = value; }
        public string Estado { get => estado; set => estado = value; }



        public ModeloConsultaAvanzada() { }

       
    }


}

