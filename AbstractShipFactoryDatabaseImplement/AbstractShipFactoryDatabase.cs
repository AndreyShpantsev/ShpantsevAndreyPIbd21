using System;
using AbstractShipFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;

namespace AbstractShipFactoryDatabaseImplement
{
    public class AbstractShipFactoryDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=WIN-4RJP400K9ST\SQLEXPRESS;Initial Catalog=AbstractShipFactoryDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Detail> Details { set; get; }
        public virtual DbSet<Ship> Ships { set; get; }
        public virtual DbSet<ShipDetail> ShipDetails { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Implementer> Implementers { set; get; }
    }
}