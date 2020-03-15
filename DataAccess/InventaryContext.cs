using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InOutEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DIDIER_IRIAS_ME\\IRIAS; Database=InventoryDb; User Id=sa; Password=admin123456;");
                //add-migration migrationName => Package Manager Console
                //update-database
                //add-migration addData and then update-database

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId="ASH",CategoryName="Aseo Hogar" },
                new CategoryEntity { CategoryId = "AHJ", CategoryName = "Jardín" },
                new CategoryEntity { CategoryId = "FRD", CategoryName = "Mueblería" },
                new CategoryEntity { CategoryId = "LKS", CategoryName = "Personal" },
                new CategoryEntity { CategoryId = "DEW", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "JTK", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VFA", CategoryName = "Video Juegos" },
                new CategoryEntity { CategoryId = "CDA", CategoryName = "Computadoras" },
                new CategoryEntity { CategoryId = "YTH", CategoryName = "Perfumería" }
                );
            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity() { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Main Warehouse", WarehouseAddress = "932 Pallet Street, La Grange (Dutchess), NY 12540" },
                new WarehouseEntity() { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Second Warehouse", WarehouseAddress = "4447 Dane Street, Yakima, WA 98908" },
                new WarehouseEntity() { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Third Warehouse", WarehouseAddress = "3003 Arrowood Drive, Jacksonville, FL 32257" }
            );
        }

    }
}
