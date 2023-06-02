using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreDAL.Data.InitDataFactory;

namespace StoreDAL.Data
{
    public class StoreDbFactory
    {
        private AbstractDataFactory factory;
        public StoreDbFactory(AbstractDataFactory factory)
        {
              this.factory = factory; 
        }
        public StoreDbContext CreateContext()
        {
            var context= new StoreDbContext(this.CreateOptions(),factory);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            return context;
        }
        public DbContextOptions<StoreDbContext> CreateOptions()
        {
            return new DbContextOptionsBuilder<StoreDbContext>()
                .UseSqlite(CreateConnectionString())
                .Options;
        }
//            var projectDir = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName;
//            var dbPath = Path.Combine(projectDir, "../StoreDAL/DB", "store.db");
//            var conString = new SqliteConnectionStringBuilder{DataSource = dbPath, Mode = SqliteOpenMode.ReadWriteCreate}.ConnectionString;
        private static string CreateConnectionString()
        {
            var dbPath = "store.db";
            var conString = new SqliteConnectionStringBuilder { DataSource = dbPath, Mode = SqliteOpenMode.ReadWriteCreate }.ConnectionString;
            return conString;
        }

    }
}
