﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductStoreMVC.Context;

namespace ProductStoreMVC.Migrations
{
    [DbContext(typeof(MVCContext))]
    [Migration("20211110142410_addSqlite")]
    partial class addSqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("ProductStoreMVC.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StoreCompanyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StoreCompanyId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("ProductStoreMVC.Models.StoreCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StoreCompanies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Овощи"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Фрукты"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Хлеб"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Молочные продукты"
                        });
                });

            modelBuilder.Entity("ProductStoreMVC.Models.Store", b =>
                {
                    b.HasOne("ProductStoreMVC.Models.StoreCompany", "StoreCompany")
                        .WithMany("Stores")
                        .HasForeignKey("StoreCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoreCompany");
                });

            modelBuilder.Entity("ProductStoreMVC.Models.StoreCompany", b =>
                {
                    b.Navigation("Stores");
                });
#pragma warning restore 612, 618
        }
    }
}
