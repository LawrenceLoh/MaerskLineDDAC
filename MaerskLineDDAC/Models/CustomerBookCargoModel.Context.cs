﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaerskLineDDAC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MaerskLineEntities : DbContext
    {
        public MaerskLineEntities()
            : base("name=MaerskLineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
    }
}
