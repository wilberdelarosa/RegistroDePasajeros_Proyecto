using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capadedatos
{
    public class UserBE
    {
        // Propiedad para el ID del usuario.
        public int Id { get; set; }

        // Propiedad para el nombre de usuario.
        public string Usuario { get; set; }

        // Propiedad para el hash de la contraseña.
        public byte[] PasswordHash { get; set; }

        // Propiedad para el salt de la contraseña.
        public byte[] Salt { get; set; }
    }
}
