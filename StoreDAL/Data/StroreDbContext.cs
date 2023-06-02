using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using StoreDAL.Data.InitDataFactory;
using StoreDAL.Entities;

namespace StoreDAL.Data
{
    public class StoreDbContext:DbContext
    {
        private AbstractDataFactory factory;

        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<OrderState> OrderStates { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTitle> ProductTitles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public StoreDbContext(DbContextOptions options, AbstractDataFactory factory) : base(options)
        {
            this.factory = factory; 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(factory.GetCategoryData());
            modelBuilder.Entity<Manufacturer>().HasData(factory.GetManufacturerData());
            modelBuilder.Entity<OrderState>().HasData(factory.GetOrderStateData());
            modelBuilder.Entity<UserRole>().HasData(factory.GetUserRoleData());
            modelBuilder.Entity<User>().HasData(factory.GetUserData());
            modelBuilder.Entity<ProductTitle>().HasData(factory.GetProductTitleData());
            modelBuilder.Entity<Product>().HasData(factory.GetProductData());
            modelBuilder.Entity<CustomerOrder>().HasData(factory.GetCustomerOrderData());
            modelBuilder.Entity<OrderDetail>().HasData(factory.GetOrderDetailData());
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    sqliteConnection.Open();
        //    optionsBuilder.UseSqlite(sqliteConnection);
        //}

    }
}
