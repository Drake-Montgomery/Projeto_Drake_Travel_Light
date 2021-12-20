﻿// <auto-generated />
using System;
using Drake_Travel_Light.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Drake_Travel_Light.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Drake_Travel_Light.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("Cartão_De_Credito")
                        .HasColumnType("int");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero_voo")
                        .HasColumnType("int");

                    b.Property<int?>("VooId_Voo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VooId_Voo");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Drake_Travel_Light.Models.Voo", b =>
                {
                    b.Property<int>("Id_Voo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Voo"), 1L, 1);

                    b.Property<string>("Assento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_ida")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_volta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destino")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Voo");

                    b.ToTable("Voo");
                });

            modelBuilder.Entity("Drake_Travel_Light.Models.Cliente", b =>
                {
                    b.HasOne("Drake_Travel_Light.Models.Voo", "Voo")
                        .WithMany("Clientes")
                        .HasForeignKey("VooId_Voo");

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("Drake_Travel_Light.Models.Voo", b =>
                {
                    b.Navigation("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
