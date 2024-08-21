using CasoEstudio2.baseDatos;  // Asegúrate de usar el espacio de nombres correcto
using CasoEstudio2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CasoEstudio2.Models
{
    public class CasasModel
    {
        public List<Consulta> ConsultarCasas()
        {
            using (var context = new CasoEstudioKNEntities())
            {
                // Ejecuta el procedimiento almacenado y convierte el resultado a la entidad Consulta
                return context.ConsultarCasas().Select(c => new Consulta
                {
                    IdCasa = c.IdCasa,
                    Descripcion = c.DescripcionCasa,
                    Precio = c.PrecioCasa,
                    Usuario = c.Usuario,
                    Estado = string.IsNullOrEmpty(c.Usuario) ? "Disponible" : "Reservada", // Directamente de la consulta
                    fecha = c.FechaAlquiler.HasValue ? c.FechaAlquiler.Value : (DateTime?)null // Manejo de fecha
                }).ToList();
            }
        }
        public List<Consulta> ObtenerCasasDisponibles()
        {
            using (var context = new CasoEstudioKNEntities())
            {
                // Ejecuta el procedimiento almacenado para obtener casas disponibles
                return context.ConsultarCasasDisponibles().Select(c => new Consulta
                {
                    IdCasa = c.IdCasa,
                    Descripcion = c.DescripcionCasa
                }).ToList();
            }
        }

        public bool AlquilarCasa(long idCasa, string usuarioAlquiler)
        {
            using (var context = new CasoEstudioKNEntities())
            {
                try
                {
                    // Ejecuta el procedimiento almacenado para alquilar la casa
                    context.AlquilarCasa(idCasa, usuarioAlquiler);
                    return true;
                }
                catch (Exception)
                {
                    // Manejar la excepción adecuadamente (puede ser logging o un mensaje de error)
                    return false;
                }
            }
        }
    }
}