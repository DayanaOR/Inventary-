using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<StorageEntity> Storage { get; set; }
        public DbSet<WarehouseEntity> Warehouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server= DESARROLLADOR06\\DBPLATZI; Database= InventaryDb; user Id=sa; password=123456; Trust Server Certificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData
                (
                    new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo hogar" },
                    new CategoryEntity { CategoryId = "PER", CategoryName = "Perfumeria" },
                    new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                    new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" },
                    new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                    new CategoryEntity { CategoryId = "BLZ", CategoryName = "Belleza" }
                );
            modelBuilder.Entity<WarehouseEntity>().HasData
                (
                    new WarehouseEntity
                    {
                        WarehouseId = Guid.NewGuid().ToString(),
                        WarehouseName = "Bodega Central",
                        WarehouseAddress = "Calle 26-98"
                    },
                     new WarehouseEntity
                     {
                         WarehouseId = Guid.NewGuid().ToString(),
                         WarehouseName = "Bodega Occidental",
                         WarehouseAddress = "Kra. 14-78"
                     },
                      new WarehouseEntity
                      {
                          WarehouseId = Guid.NewGuid().ToString(),
                          WarehouseName = "Bodega Oriental",
                          WarehouseAddress = "AV.112 #67-90"
                      }
                );
            modelBuilder.Entity<ProductEntity>().HasData
                (
                    new ProductEntity
                    {
                        ProductId = "CRD",
                        ProductName = "Crema Depilatoria",
                        ProductDescription = "Suave con la piel y de rapido uso",
                        CategoryId = "CMD"
                    },
                    new ProductEntity
                    {
                        ProductId = "CMC",
                        ProductName = "Crema Corporal",
                        ProductDescription = "ideal para piel reseca",
                        CategoryId = "CMC"
                    },
                    new ProductEntity
                    {
                        ProductId = "DST",
                        ProductName = "Desodorante",
                        ProductDescription = "Olor a lavanda, no mancha la ropa",
                        CategoryId = "CHC"
                    }
                );
        }
    }
}
