﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Contacts", (string)null);
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

                    b.HasData(
                        new
                        {
                            Ddd = 11,
                            RegionName = "São Paulo – SP"
                        },
                        new
                        {
                            Ddd = 12,
                            RegionName = "São José dos Campos – SP"
                        },
                        new
                        {
                            Ddd = 13,
                            RegionName = "Santos – SP"
                        },
                        new
                        {
                            Ddd = 14,
                            RegionName = "Bauru – SP"
                        },
                        new
                        {
                            Ddd = 15,
                            RegionName = "Sorocaba – SP"
                        },
                        new
                        {
                            Ddd = 16,
                            RegionName = "Ribeirão Preto – SP"
                        },
                        new
                        {
                            Ddd = 17,
                            RegionName = "São José do Rio Preto – SP"
                        },
                        new
                        {
                            Ddd = 18,
                            RegionName = "Presidente Prudente – SP"
                        },
                        new
                        {
                            Ddd = 19,
                            RegionName = "Campinas – SP"
                        },
                        new
                        {
                            Ddd = 21,
                            RegionName = "Rio de Janeiro – RJ"
                        },
                        new
                        {
                            Ddd = 22,
                            RegionName = "Campos dos Goytacazes – RJ"
                        },
                        new
                        {
                            Ddd = 24,
                            RegionName = "Volta Redonda – RJ"
                        },
                        new
                        {
                            Ddd = 27,
                            RegionName = "Vitória / Vila Velha – ES"
                        },
                        new
                        {
                            Ddd = 28,
                            RegionName = "Cachoeiro de Itapemirim – ES"
                        },
                        new
                        {
                            Ddd = 31,
                            RegionName = "Belo Horizonte – MG"
                        },
                        new
                        {
                            Ddd = 32,
                            RegionName = "Juiz de Fora – MG"
                        },
                        new
                        {
                            Ddd = 33,
                            RegionName = "Governador Valadares – MG"
                        },
                        new
                        {
                            Ddd = 34,
                            RegionName = "Uberlândia – MG"
                        },
                        new
                        {
                            Ddd = 35,
                            RegionName = "Poços de Caldas – MG"
                        },
                        new
                        {
                            Ddd = 37,
                            RegionName = "Divinópolis – MG"
                        },
                        new
                        {
                            Ddd = 38,
                            RegionName = "Montes Claros – MG"
                        },
                        new
                        {
                            Ddd = 41,
                            RegionName = "Curitiba – PR"
                        },
                        new
                        {
                            Ddd = 42,
                            RegionName = "Ponta Grossa – PR"
                        },
                        new
                        {
                            Ddd = 43,
                            RegionName = "Londrina – PR"
                        },
                        new
                        {
                            Ddd = 44,
                            RegionName = "Maringá – PR"
                        },
                        new
                        {
                            Ddd = 45,
                            RegionName = "Foz do Iguaçú – PR"
                        },
                        new
                        {
                            Ddd = 46,
                            RegionName = "Pato Branco / Francisco Beltrão – PR"
                        },
                        new
                        {
                            Ddd = 47,
                            RegionName = "Joinville – SC"
                        },
                        new
                        {
                            Ddd = 48,
                            RegionName = "Florianópolis – SC"
                        },
                        new
                        {
                            Ddd = 49,
                            RegionName = "Chapecó – SC"
                        },
                        new
                        {
                            Ddd = 51,
                            RegionName = "Porto Alegre – RS"
                        },
                        new
                        {
                            Ddd = 53,
                            RegionName = "Pelotas – RS"
                        },
                        new
                        {
                            Ddd = 54,
                            RegionName = "Caxias do Sul – RS"
                        },
                        new
                        {
                            Ddd = 55,
                            RegionName = "Santa Maria – RS"
                        },
                        new
                        {
                            Ddd = 61,
                            RegionName = "Brasília – DF"
                        },
                        new
                        {
                            Ddd = 62,
                            RegionName = "Goiânia – GO"
                        },
                        new
                        {
                            Ddd = 63,
                            RegionName = "Palmas – TO"
                        },
                        new
                        {
                            Ddd = 64,
                            RegionName = "Rio Verde – GO"
                        },
                        new
                        {
                            Ddd = 65,
                            RegionName = "Cuiabá – MT"
                        },
                        new
                        {
                            Ddd = 66,
                            RegionName = "Rondonópolis – MT"
                        },
                        new
                        {
                            Ddd = 67,
                            RegionName = "Campo Grande – MS"
                        },
                        new
                        {
                            Ddd = 68,
                            RegionName = "Rio Branco – AC"
                        },
                        new
                        {
                            Ddd = 69,
                            RegionName = "Porto Velho – RO"
                        },
                        new
                        {
                            Ddd = 71,
                            RegionName = "Salvador – BA"
                        },
                        new
                        {
                            Ddd = 73,
                            RegionName = "Ilhéus – BA"
                        },
                        new
                        {
                            Ddd = 74,
                            RegionName = "Juazeiro – BA"
                        },
                        new
                        {
                            Ddd = 75,
                            RegionName = "Feira de Santana – BA"
                        },
                        new
                        {
                            Ddd = 77,
                            RegionName = "Barreiras – BA"
                        },
                        new
                        {
                            Ddd = 79,
                            RegionName = "Aracaju – SE"
                        },
                        new
                        {
                            Ddd = 81,
                            RegionName = "Recife – PE"
                        },
                        new
                        {
                            Ddd = 82,
                            RegionName = "Maceió – AL"
                        },
                        new
                        {
                            Ddd = 83,
                            RegionName = "João Pessoa – PB"
                        },
                        new
                        {
                            Ddd = 84,
                            RegionName = "Natal – RN"
                        },
                        new
                        {
                            Ddd = 85,
                            RegionName = "Fortaleza – CE"
                        },
                        new
                        {
                            Ddd = 86,
                            RegionName = "Teresina – PI"
                        },
                        new
                        {
                            Ddd = 87,
                            RegionName = "Petrolina – PE"
                        },
                        new
                        {
                            Ddd = 88,
                            RegionName = "Juazeiro do Norte – CE"
                        },
                        new
                        {
                            Ddd = 89,
                            RegionName = "Picos – PI"
                        },
                        new
                        {
                            Ddd = 91,
                            RegionName = "Belém – PA"
                        },
                        new
                        {
                            Ddd = 92,
                            RegionName = "Manaus – AM"
                        },
                        new
                        {
                            Ddd = 93,
                            RegionName = "Santarém – PA"
                        },
                        new
                        {
                            Ddd = 94,
                            RegionName = "Marabá – PA"
                        },
                        new
                        {
                            Ddd = 95,
                            RegionName = "Boa Vista – RR"
                        },
                        new
                        {
                            Ddd = 96,
                            RegionName = "Macapá – AP"
                        },
                        new
                        {
                            Ddd = 97,
                            RegionName = "Coari – AM"
                        },
                        new
                        {
                            Ddd = 98,
                            RegionName = "São Luís – MA"
                        },
                        new
                        {
                            Ddd = 99,
                            RegionName = "Imperatriz – MA"
                        });
                });

            modelBuilder.Entity("Core.Entities.Contacts", b =>
                {
                    b.HasOne("Core.Entities.Regions", "Region")
                        .WithMany("Contacts")
                        .HasForeignKey("RegionDdd")
                        .OnDelete(DeleteBehavior.Restrict);

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
