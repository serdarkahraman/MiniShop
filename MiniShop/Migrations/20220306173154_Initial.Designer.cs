﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniShop.Data.Configurations;

#nullable disable

namespace MiniShop.Migrations
{
    [DbContext(typeof(MiniShopContext))]
    [Migration("20220306173154_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("MiniShop.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerType")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "1",
                            Created = new DateTime(1989, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1435),
                            CustomerType = "Employee",
                            Email = "serdar@kahraman.com",
                            FirstName = "Serdar",
                            LastName = "Kahraman",
                            PhoneNumber = "05324480153"
                        },
                        new
                        {
                            Id = 2,
                            Address = "1",
                            Created = new DateTime(2019, 11, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1440),
                            CustomerType = "Affiliate",
                            Email = "sevgi@kahraman.com",
                            FirstName = "Sevgi",
                            LastName = "Kahraman",
                            PhoneNumber = "05324480154"
                        },
                        new
                        {
                            Id = 3,
                            Address = "1",
                            Created = new DateTime(2018, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1443),
                            CustomerType = "Customer",
                            Email = "alya@kahraman.com",
                            FirstName = "Alya",
                            LastName = "Kahraman",
                            PhoneNumber = "05324480155"
                        },
                        new
                        {
                            Id = 4,
                            Address = "1",
                            Created = new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1445),
                            CustomerType = "Customer",
                            Email = "alparslan@kahraman.com",
                            FirstName = "Alparslan",
                            LastName = "Kahraman",
                            PhoneNumber = "05324480156"
                        });
                });

            modelBuilder.Entity("MiniShop.Entities.DiscountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRatePercentage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DiscountType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsRatePercentage = true,
                            Name = "Affiliate Discount",
                            Rate = 10m,
                            Type = "Affiliate"
                        },
                        new
                        {
                            Id = 2,
                            IsRatePercentage = true,
                            Name = "Employee Discount",
                            Rate = 30m,
                            Type = "Employee"
                        },
                        new
                        {
                            Id = 3,
                            IsRatePercentage = true,
                            Name = "Customer Discount",
                            Rate = 5m,
                            Type = "Customer"
                        },
                        new
                        {
                            Id = 4,
                            IsRatePercentage = false,
                            Name = "Price Discount",
                            Rate = 5m,
                            Type = "Price"
                        });
                });

            modelBuilder.Entity("MiniShop.Entities.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderId")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoices");

                    b.HasData(
                        new
                        {
                            InvoiceId = 1,
                            Created = new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1861),
                            CustomerId = 1,
                            InvoiceNumber = "Ms01",
                            OrderId = 1,
                            OrderTotal = 0m,
                            Total = 100m
                        },
                        new
                        {
                            InvoiceId = 2,
                            Created = new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1863),
                            CustomerId = 2,
                            InvoiceNumber = "Ms02",
                            OrderId = 2,
                            OrderTotal = 0m,
                            Total = 200m
                        },
                        new
                        {
                            InvoiceId = 3,
                            Created = new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1864),
                            CustomerId = 3,
                            InvoiceNumber = "Ms03",
                            OrderId = 3,
                            OrderTotal = 0m,
                            Total = 300m
                        },
                        new
                        {
                            InvoiceId = 4,
                            Created = new DateTime(2022, 3, 6, 20, 31, 54, 206, DateTimeKind.Local).AddTicks(1865),
                            CustomerId = 4,
                            InvoiceNumber = "Ms04",
                            OrderId = 4,
                            OrderTotal = 0m,
                            Total = 400m
                        });
                });

            modelBuilder.Entity("MiniShop.Entities.InvoiceDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductPrice")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiscountPrice = 1m,
                            InvoiceId = 1,
                            ProductId = 1,
                            ProductName = "Ürün 1",
                            ProductPrice = 10m,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            DiscountPrice = 2m,
                            InvoiceId = 1,
                            ProductId = 2,
                            ProductName = "Ürün 2",
                            ProductPrice = 20m,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 3,
                            DiscountPrice = 3m,
                            InvoiceId = 2,
                            ProductId = 3,
                            ProductName = "Ürün 3",
                            ProductPrice = 30m,
                            Quantity = 3
                        },
                        new
                        {
                            Id = 4,
                            DiscountPrice = 4m,
                            InvoiceId = 3,
                            ProductId = 4,
                            ProductName = "Ürün 4",
                            ProductPrice = 40m,
                            Quantity = 4
                        });
                });

            modelBuilder.Entity("MiniShop.Entities.Invoice", b =>
                {
                    b.HasOne("MiniShop.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MiniShop.Entities.InvoiceDetail", b =>
                {
                    b.HasOne("MiniShop.Entities.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");
                });
#pragma warning restore 612, 618
        }
    }
}
