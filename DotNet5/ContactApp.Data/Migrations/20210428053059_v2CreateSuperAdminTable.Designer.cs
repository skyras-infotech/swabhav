﻿// <auto-generated />
using System;
using ContactApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactApp.Data.Migrations
{
    [DbContext(typeof(ContactDBContext))]
    [Migration("20210428053059_v2CreateSuperAdminTable")]
    partial class v2CreateSuperAdminTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ContactApp.Domain.Address", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ContactID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ContactApp.Domain.Contact", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("MobileNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("MobileNumber")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ContactApp.Domain.SuperUser", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SuperUsers");
                });

            modelBuilder.Entity("ContactApp.Domain.Tenant", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CompanyStrength")
                        .HasColumnType("int");

                    b.Property<string>("TenantName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("TenantName")
                        .IsUnique()
                        .HasFilter("[TenantName] IS NOT NULL");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("ContactApp.Domain.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TenantID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("TenantID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ContactApp.Domain.Address", b =>
                {
                    b.HasOne("ContactApp.Domain.Contact", "Contacts")
                        .WithMany("Addresses")
                        .HasForeignKey("ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("ContactApp.Domain.Contact", b =>
                {
                    b.HasOne("ContactApp.Domain.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ContactApp.Domain.User", b =>
                {
                    b.HasOne("ContactApp.Domain.Tenant", "Tenant")
                        .WithMany("Users")
                        .HasForeignKey("TenantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("ContactApp.Domain.Contact", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("ContactApp.Domain.Tenant", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ContactApp.Domain.User", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}