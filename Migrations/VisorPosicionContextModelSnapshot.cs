﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisorPosicion5.Models;

#nullable disable

namespace VisorPosicion5.Migrations
{
    [DbContext(typeof(VisorPosicionContext))]
    partial class VisorPosicionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VisorPosicion5.Models.Operacion", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("AvailableAmount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Estado")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("FechaOperacion")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<decimal?>("TipoCambio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("TipoOperacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TransactionId")
                        .HasName("PK__Operacio__55433A6B9166A520");

                    b.ToTable("Operacion", (string)null);
                });

            modelBuilder.Entity("VisorPosicion5.Models.VentaCompraLink", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LinkID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LinkId"));

                    b.Property<decimal>("AmountLinked")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CompraTransactionId")
                        .HasColumnType("int");

                    b.Property<int>("VentaTransactionId")
                        .HasColumnType("int");

                    b.HasKey("LinkId")
                        .HasName("PK__VentaCom__2D1221554E0B3CC0");

                    b.ToTable("VentaCompraLink", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
