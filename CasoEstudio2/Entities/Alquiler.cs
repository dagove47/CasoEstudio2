using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasoEstudio2.Entities
{
    public class Alquiler
    {
        public long IdAlquiler { get; set; }
        public long IdCasa { get; set; }
        public string UsuarioAlquiler { get; set; }

        public decimal Precio { get; set; }

        public DateTime FechaAlquiler { get; set; }
    }
}
