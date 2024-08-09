﻿// <auto-generated />
using EnterprisePatterns.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnterprisePatterns.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20240422092841_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("EnterprisePatterns.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Shopping Spree"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Holiday Shopping"
                        });
                });

            modelBuilder.Entity("EnterprisePatterns.Entities.OrderLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderLines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 1,
                            OrderId = 1,
                            Product = "Shoes"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 2,
                            OrderId = 1,
                            Product = "Shirt"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 1,
                            OrderId = 1,
                            Product = "Pants"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 5,
                            OrderId = 1,
                            Product = "Socks"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 1,
                            OrderId = 2,
                            Product = "Sunglasses"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 2,
                            OrderId = 2,
                            Product = "Sunscreen"
                        });
                });

            modelBuilder.Entity("EnterprisePatterns.Entities.OrderLine", b =>
                {
                    b.HasOne("EnterprisePatterns.Entities.Order", null)
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnterprisePatterns.Entities.Order", b =>
                {
                    b.Navigation("OrderLines");
                });
#pragma warning restore 612, 618
        }
    }
}
