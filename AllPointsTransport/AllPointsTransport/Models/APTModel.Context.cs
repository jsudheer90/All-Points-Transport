﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AllPointsTransport.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AllPointsTransportEntities : DbContext
    {
        public AllPointsTransportEntities()
            : base("name=AllPointsTransportEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<APTUserRole> APTUserRoles { get; set; }
        public virtual DbSet<APTUser> APTUsers { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<DriverPay> DriverPays { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Payroll> Payrolls { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<RowColor> RowColors { get; set; }
        public virtual DbSet<RowColorsDriver> RowColorsDrivers { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<ScreenMaster> ScreenMasters { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<TaskManagement> TaskManagements { get; set; }
        public virtual DbSet<TemplatesDriverPay> TemplatesDriverPays { get; set; }
        public virtual DbSet<TemplatesWO> TemplatesWOes { get; set; }
        public virtual DbSet<TemplatesWOLineItem> TemplatesWOLineItems { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
        public virtual DbSet<WOLineItem> WOLineItems { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
    }
}
