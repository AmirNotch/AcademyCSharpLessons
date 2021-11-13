﻿// <auto-generated />
using System;
using AcademyCSharpLesson02._11._2021.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcademyCSharpLesson02._11._2021.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20211113104713_newMigration")]
    partial class newMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("AcademyCSharpLesson02._11._2021.Models.QuotesCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("QuotesCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Бизнес"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Продуктивность"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Шуточные"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Жизненные"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Рабочие"
                        });
                });

            modelBuilder.Entity("AcademyCSharpLesson02._11._2021.Models.QuotesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuotesCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("QuotesCategoryId");

                    b.ToTable("QuotesModels");
                });

            modelBuilder.Entity("AcademyCSharpLesson02._11._2021.Models.QuotesModel", b =>
                {
                    b.HasOne("AcademyCSharpLesson02._11._2021.Models.QuotesCategory", "QuotesCategory")
                        .WithMany("Quotes")
                        .HasForeignKey("QuotesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuotesCategory");
                });

            modelBuilder.Entity("AcademyCSharpLesson02._11._2021.Models.QuotesCategory", b =>
                {
                    b.Navigation("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}