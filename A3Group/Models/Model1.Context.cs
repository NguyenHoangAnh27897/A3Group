﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A3Group.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class a3groupEntities2 : DbContext
    {
        public a3groupEntities2()
            : base("name=a3groupEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<A3Group_About> A3Group_About { get; set; }
        public virtual DbSet<A3Group_Blogs> A3Group_Blogs { get; set; }
        public virtual DbSet<A3Group_Contact> A3Group_Contact { get; set; }
        public virtual DbSet<A3Group_Differences> A3Group_Differences { get; set; }
        public virtual DbSet<A3Group_Features> A3Group_Features { get; set; }
        public virtual DbSet<A3Group_Quotes> A3Group_Quotes { get; set; }
        public virtual DbSet<A3Group_Services> A3Group_Services { get; set; }
        public virtual DbSet<A3Group_Sliders> A3Group_Sliders { get; set; }
        public virtual DbSet<A3Group_Team> A3Group_Team { get; set; }
        public virtual DbSet<A3Group_Works> A3Group_Works { get; set; }
        public virtual DbSet<A3Group_Prices> A3Group_Prices { get; set; }
    }
}
