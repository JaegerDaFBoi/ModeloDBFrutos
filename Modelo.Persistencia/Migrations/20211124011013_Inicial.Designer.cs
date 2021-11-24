﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo.Persistencia;

#nullable disable

namespace Modelo.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211124011013_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Modelo.Dominio.Administrador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentoAdmin")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreAdmin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("Modelo.Dominio.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Documento")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoCliente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Modelo.Dominio.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CantidadPedido")
                        .HasColumnType("int");

                    b.Property<int>("IdFacturaId")
                        .HasColumnType("int");

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdFacturaId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Modelo.Dominio.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdClienteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Modelo.Dominio.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAdministradorId")
                        .HasColumnType("int");

                    b.Property<int>("IdProveedorId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PrecioCompra")
                        .HasColumnType("real");

                    b.Property<float>("PrecioVenta")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("IdAdministradorId");

                    b.HasIndex("IdProveedorId");

                    b.ToTable("Articulos");
                });

            modelBuilder.Entity("Modelo.Dominio.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentoProveedor")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Modelo.Dominio.Compra", b =>
                {
                    b.HasOne("Modelo.Dominio.Factura", "IdFactura")
                        .WithMany()
                        .HasForeignKey("IdFacturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Dominio.Inventario", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdFactura");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Modelo.Dominio.Factura", b =>
                {
                    b.HasOne("Modelo.Dominio.Cliente", "IdCliente")
                        .WithMany()
                        .HasForeignKey("IdClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdCliente");
                });

            modelBuilder.Entity("Modelo.Dominio.Inventario", b =>
                {
                    b.HasOne("Modelo.Dominio.Administrador", "IdAdministrador")
                        .WithMany()
                        .HasForeignKey("IdAdministradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Dominio.Proveedor", "IdProveedor")
                        .WithMany()
                        .HasForeignKey("IdProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdAdministrador");

                    b.Navigation("IdProveedor");
                });
#pragma warning restore 612, 618
        }
    }
}
