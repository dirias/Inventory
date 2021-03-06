﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventaryContext))]
    partial class InventaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.CategoryEntity", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "ASH",
                            CategoryName = "Aseo Hogar"
                        },
                        new
                        {
                            CategoryId = "AHJ",
                            CategoryName = "Jardín"
                        },
                        new
                        {
                            CategoryId = "FRD",
                            CategoryName = "Mueblería"
                        },
                        new
                        {
                            CategoryId = "LKS",
                            CategoryName = "Personal"
                        },
                        new
                        {
                            CategoryId = "DEW",
                            CategoryName = "Hogar"
                        },
                        new
                        {
                            CategoryId = "JTK",
                            CategoryName = "Salud"
                        },
                        new
                        {
                            CategoryId = "VFA",
                            CategoryName = "Video Juegos"
                        },
                        new
                        {
                            CategoryId = "CDA",
                            CategoryName = "Computadoras"
                        },
                        new
                        {
                            CategoryId = "YTH",
                            CategoryName = "Perfumería"
                        });
                });

            modelBuilder.Entity("Entities.InOutEntity", b =>
                {
                    b.Property<string>("InOutId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InOutDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InOutQuantity")
                        .HasColumnType("int");

                    b.Property<bool>("IsInput")
                        .HasColumnType("bit");

                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("InOutId");

                    b.HasIndex("StorageId");

                    b.ToTable("InOuts");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.Property<string>("StorageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartialQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StorageId");

                    b.HasIndex("ProductId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Entities.WarehouseEntity", b =>
                {
                    b.Property<string>("WarehouseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WarehouseAddress")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("WarehouseName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("WarehouseId");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            WarehouseId = "82f5dd17-f963-4679-ac46-d7df208371d4",
                            WarehouseAddress = "932 Pallet Street, La Grange (Dutchess), NY 12540",
                            WarehouseName = "Main Warehouse"
                        },
                        new
                        {
                            WarehouseId = "67811a3a-32be-4fce-990e-9cc69834c6d7",
                            WarehouseAddress = "4447 Dane Street, Yakima, WA 98908",
                            WarehouseName = "Second Warehouse"
                        },
                        new
                        {
                            WarehouseId = "226edd07-6f8a-4272-b5bb-95865f9218c4",
                            WarehouseAddress = "3003 Arrowood Drive, Jacksonville, FL 32257",
                            WarehouseName = "Third Warehouse"
                        });
                });

            modelBuilder.Entity("Entities.InOutEntity", b =>
                {
                    b.HasOne("Entities.StorageEntity", "Storage")
                        .WithMany("InputOutputs")
                        .HasForeignKey("StorageId");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.HasOne("Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.HasOne("Entities.ProductEntity", "Product")
                        .WithMany("Storages")
                        .HasForeignKey("ProductId");

                    b.HasOne("Entities.WarehouseEntity", "Warehouse")
                        .WithMany("storages")
                        .HasForeignKey("WarehouseId");
                });
#pragma warning restore 612, 618
        }
    }
}
