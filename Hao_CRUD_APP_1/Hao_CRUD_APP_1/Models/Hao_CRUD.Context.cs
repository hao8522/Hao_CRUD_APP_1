﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hao_CRUD_APP_1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Configuration;
    
    public partial class HAO_CRUD_APP2Entities : DbContext
    {
        //public HAO_CRUD_APP2Entities()
        //    : base("name=HAO_CRUD_APP2Entities")
        //{
        //}

        public HAO_CRUD_APP2Entities()
        {
            //base.Database.Connection.ConnectionString = @"Server=X230-PC\SQLEXPRESS;DataBase=HAO_CRUD_APP2;Uid=sa;Pwd=root";
            var connString = ConfigurationManager.ConnectionStrings["HAO_CRUD_APP2Entities"].ToString();

            base.Database.Connection.ConnectionString = connString;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSold> ProductSolds { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}