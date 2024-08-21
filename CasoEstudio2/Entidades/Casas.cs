using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasoEstudio2.Entidades
{
    public class Casas
    {
        public long IdCasa { get; set; }              // Id de la Casa
        public string DescripcionCasa { get; set; }   // Descripción de la Casa
        public decimal PrecioCasa { get; set; }       // Precio de la Casa
        public string UsuarioAlquiler { get; set; }   // Usuario que alquiló la Casa
        public string Estado { get; set; }            // Estado (Disponible o Reservada)
        public string FechaAlquiler { get; set; }     // Fecha del Alquiler (en formato dd/MM/yyyy)


    }
}