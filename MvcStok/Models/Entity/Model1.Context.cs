﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStok.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMvcStokEntities1 : DbContext
    {
        public DbMvcStokEntities1()
            : base("name=DbMvcStokEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblkategori> tblkategori { get; set; }
        public virtual DbSet<tblmusteri> tblmusteri { get; set; }
        public virtual DbSet<tblpersonel> tblpersonel { get; set; }
        public virtual DbSet<tblsatislar> tblsatislar { get; set; }
        public virtual DbSet<tblurunler> tblurunler { get; set; }
    }
}
