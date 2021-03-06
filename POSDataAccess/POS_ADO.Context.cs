﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class POSDBContext : DbContext
    {
        public POSDBContext()
            : base("name=POSDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Barcode> Barcodes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer_Sale> Customer_Sale { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Free_Product> Free_Product { get; set; }
        public virtual DbSet<Gift> Gifts { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Journal_Details> Journal_Details { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Main_Accounts> Main_Accounts { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product_Supplier> Product_Supplier { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Sub_Accounts> Sub_Accounts { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Support> Supports { get; set; }
    }
}
