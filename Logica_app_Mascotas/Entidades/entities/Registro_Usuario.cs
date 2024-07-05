using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logica_app_Mascotas
{
    public class Registro_Usuario
    {

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo_Electronico { get; set; }
        public string Password { get; set; }

        public string numeroverificacion { get; set; }
        
    }
}
