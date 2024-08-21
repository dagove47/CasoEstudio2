using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasoEstudio2.Entities
{
    public class Consulta
    {
        public long IdCasa { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public String Estado { get; set; }
        public string Usuario { get; set; }

        public DateTime? fecha { get; set; }

    }
}
