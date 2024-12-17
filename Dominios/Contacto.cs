using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
    public class Contacto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

        [DisplayName("Fecha de creacion")]
        public DateTime FechaCreacion { get; set; }
    }
}
