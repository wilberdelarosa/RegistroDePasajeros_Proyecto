using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capadedatos
{
    public class Modelo_Pasajeros
    {
        //Campos

        public int id;
        public string nombre;
        public string apellido;
        public string tipo_documento;
        public string num_documento;
        public int idpais;
        public string fecha_nacimiento;
        public string telefono;
        public string email;

        //propiedad de validacion


        public int Id

        { get => id; set => id = value; }
        public string Nombre

        { get => nombre; set => nombre = value; }
        public string Apellido

        { get => apellido; set => apellido = value; }
        public string Tipo_documento

        { get => tipo_documento; set => tipo_documento = value; }
        public string Num_documento
        { get => num_documento; set => num_documento = value; }
        public int Idpais { get => idpais; set => idpais = value; }
        public string Fecha_Nacimiento
        { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        public Modelo_Pasajeros() { }


    }
}
