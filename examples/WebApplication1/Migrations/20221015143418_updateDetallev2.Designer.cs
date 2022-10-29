﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.CodeFirstEF;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DbContextTributario))]
    [Migration("20221015143418_updateDetallev2")]
    partial class updateDetallev2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.CodeFirstEF.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rut")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            IdCliente = 1,
                            IsActive = false,
                            Nombre = "Cliente Uno",
                            Rut = "1-1"
                        },
                        new
                        {
                            IdCliente = 2,
                            IsActive = false,
                            Nombre = "Cliente Dos",
                            Rut = "2-2"
                        },
                        new
                        {
                            IdCliente = 3,
                            IsActive = false,
                            Nombre = "Cliente Tres",
                            Rut = "3-3"
                        });
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.Detalle", b =>
                {
                    b.Property<int>("IdDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdDocumento")
                        .HasColumnType("int");

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDetalle");

                    b.HasIndex("IdDocumento");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.DocumentoTributario", b =>
                {
                    b.Property<int>("IdDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDocumento")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdDocumento");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdTipoDocumento");

                    b.ToTable("DocumentoTributarios");
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.ListaPrecio", b =>
                {
                    b.Property<int>("IdListaPrecio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<string>("Temporada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdListaPrecio");

                    b.HasIndex("IdProducto");

                    b.ToTable("ListaPrecios");
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.TipoDocumento", b =>
                {
                    b.Property<int>("IdTipoDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Timestamp")
                        .HasColumnType("time");

                    b.HasKey("IdTipoDocumento");

                    b.ToTable("TipoDocumentos");
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.Detalle", b =>
                {
                    b.HasOne("WebApplication1.CodeFirstEF.DocumentoTributario", "DocumentoTributario")
                        .WithMany("DetalleDocumentoTributarios")
                        .HasForeignKey("IdDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentoTributario");
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.DocumentoTributario", b =>
                {
                    b.HasOne("WebApplication1.CodeFirstEF.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.CodeFirstEF.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("IdTipoDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TipoDocumento");
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.ListaPrecio", b =>
                {
                    b.HasOne("WebApplication1.CodeFirstEF.Producto", "Producto")
                        .WithMany("ListaPrecioProductos")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.DocumentoTributario", b =>
                {
                    b.Navigation("DetalleDocumentoTributarios");
                });

            modelBuilder.Entity("WebApplication1.CodeFirstEF.Producto", b =>
                {
                    b.Navigation("ListaPrecioProductos");
                });
#pragma warning restore 612, 618
        }
    }
}
