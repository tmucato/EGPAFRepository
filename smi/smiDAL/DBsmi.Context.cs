﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace smiDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBsmiEntities : DbContext
    {
        public DBsmiEntities()
            : base("name=DBsmiEntities")
        {
        }

        public DBsmiEntities(string conStr) : base(conStr)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<mother> mothers { get; set; }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<child> children { get; set; }
        public DbSet<cpn_final> cpn_final { get; set; }
        public DbSet<cpn> cpns { get; set; }
        public DbSet<ccr> ccrs { get; set; }
        public DbSet<ccrseg> ccrsegs { get; set; }
    }
}
