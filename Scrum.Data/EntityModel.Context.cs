﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scrum.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class scrumEntities : DbContext
    {
        public scrumEntities()
            : base("name=scrumEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Boss> Bosses { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Prepayment> Prepayments { get; set; }
        public virtual DbSet<Reciept> Reciepts { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TravelInfo> TravelInfoes { get; set; }
    }
}