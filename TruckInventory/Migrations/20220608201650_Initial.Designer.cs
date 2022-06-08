﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TruckInventory.Models;

#nullable disable

namespace TruckInventory.Migrations
{
    [DbContext(typeof(TruckInventoryContext))]
    [Migration("20220608201650_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TruckInventory.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DispatcherId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DispatcherName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<string>("DriverId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EndPoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StartPoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });
#pragma warning restore 612, 618
        }
    }
}