﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HakemOtomasyonTD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HakemOtomasyonDBEntities : DbContext
    {
        public HakemOtomasyonDBEntities()
            : base("name=HakemOtomasyonDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hakem> Hakemler { get; set; }
        public virtual DbSet<SporSalonu> SporSalonlari { get; set; }
        public virtual DbSet<Takim> Takimlar { get; set; }
        public virtual DbSet<Fikstur> Fiksturler { get; set; }
    }
}