﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RCLScanner
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class zzPODScanDBEntities : DbContext
    {
        public zzPODScanDBEntities()
            : base("name=zzPODScanDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ScanClientConfig> ScanClientConfigs { get; set; }
        public virtual DbSet<ScanEventLog> ScanEventLogs { get; set; }
        public virtual DbSet<ScanGlobalConfig> ScanGlobalConfigs { get; set; }
    }
}
