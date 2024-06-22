﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240523005509_CreateContactsAndRegionsTable")]
    partial class CreateContactsAndRegionsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Contacts", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INT");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<int?>("RegionDdd")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("RegionDdd");

                    b.ToTable("Contects", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Regions", b =>
                {
                    b.Property<int>("Ddd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Ddd"));

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Ddd");

                    b.ToTable("Regions", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Contacts", b =>
                {
                    b.HasOne("Core.Entities.Regions", "Region")
                        .WithMany("Contacts")
                        .HasForeignKey("RegionDdd");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Core.Entities.Regions", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
