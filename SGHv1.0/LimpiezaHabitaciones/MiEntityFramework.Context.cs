﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGHv1._0.LimpiezaHabitaciones
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SGHEntities : DbContext
    {
        public SGHEntities()
            : base("name=SGHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmpleadoLimpieza> EmpleadoLimpieza { get; set; }
        public virtual DbSet<PlanillaLimpieza> PlanillaLimpieza { get; set; }
        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<VistaPlanillaLimpieza> VistaPlanillaLimpieza { get; set; }
        public virtual DbSet<HabitacionesLimpieza> HabitacionesLimpieza { get; set; }
    }
}