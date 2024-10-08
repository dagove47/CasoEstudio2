﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CasoEstudio2.baseDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CasoEstudioKNEntities : DbContext
    {
        public CasoEstudioKNEntities()
            : base("name=CasoEstudioKNEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CasasSistema> CasasSistema { get; set; }
    
        public virtual int sp_AlquilarCasa(Nullable<long> idCasa, string usuarioAlquiler)
        {
            var idCasaParameter = idCasa.HasValue ?
                new ObjectParameter("IdCasa", idCasa) :
                new ObjectParameter("IdCasa", typeof(long));
    
            var usuarioAlquilerParameter = usuarioAlquiler != null ?
                new ObjectParameter("UsuarioAlquiler", usuarioAlquiler) :
                new ObjectParameter("UsuarioAlquiler", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AlquilarCasa", idCasaParameter, usuarioAlquilerParameter);
        }
    
        public virtual ObjectResult<sp_ConsultarCasas_Result> sp_ConsultarCasas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ConsultarCasas_Result>("sp_ConsultarCasas");
        }
    
        public virtual ObjectResult<sp_ConsultarCasasDisponibles_Result> sp_ConsultarCasasDisponibles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ConsultarCasasDisponibles_Result>("sp_ConsultarCasasDisponibles");
        }
    
        public virtual ObjectResult<ConsultarCasas_Result> ConsultarCasas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarCasas_Result>("ConsultarCasas");
        }
    
        public virtual int AlquilarCasa(Nullable<long> idCasa, string usuarioAlquiler)
        {
            var idCasaParameter = idCasa.HasValue ?
                new ObjectParameter("IdCasa", idCasa) :
                new ObjectParameter("IdCasa", typeof(long));
    
            var usuarioAlquilerParameter = usuarioAlquiler != null ?
                new ObjectParameter("UsuarioAlquiler", usuarioAlquiler) :
                new ObjectParameter("UsuarioAlquiler", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AlquilarCasa", idCasaParameter, usuarioAlquilerParameter);
        }
    
        public virtual ObjectResult<ConsultarCasasDisponibles_Result> ConsultarCasasDisponibles()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarCasasDisponibles_Result>("ConsultarCasasDisponibles");
        }
    }
}
