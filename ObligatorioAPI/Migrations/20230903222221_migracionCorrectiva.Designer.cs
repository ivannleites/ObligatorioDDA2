﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ObligatorioAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230903222221_migracionCorrectiva")]
    partial class migracionCorrectiva
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Carrito", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IDProducto")
                        .HasColumnType("int");

                    b.Property<int>("IDUsuario")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDProducto");

                    b.HasIndex("IDUsuario");

                    b.ToTable("Carrito");
                });

            modelBuilder.Entity("Domain.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Domain.Color", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("NombreColor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Colores");
                });

            modelBuilder.Entity("Domain.Compra", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<int>("IDPromocion")
                        .HasColumnType("int");

                    b.Property<int>("IDUsuario")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDPromocion");

                    b.HasIndex("IDUsuario");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Domain.DetalleCompra", b =>
                {
                    b.Property<int>("IDCompra")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("IDProducto")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.HasKey("IDCompra", "IDProducto");

                    b.HasIndex("IDProducto");

                    b.ToTable("DetalleCompras");
                });

            modelBuilder.Entity("Domain.Marca", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("NombreMarca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Domain.Producto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("IDCategoria")
                        .HasColumnType("int");

                    b.Property<int>("IDColor")
                        .HasColumnType("int");

                    b.Property<int>("IDMarca")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("IDCategoria");

                    b.HasIndex("IDColor");

                    b.HasIndex("IDMarca");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Domain.Promocion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Condicion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("Promociones");
                });

            modelBuilder.Entity("Domain.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DireccionEntrega")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("CorreoElectronico")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Domain.Carrito", b =>
                {
                    b.HasOne("Domain.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("IDProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IDUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Compra", b =>
                {
                    b.HasOne("Domain.Promocion", "Promocion")
                        .WithMany()
                        .HasForeignKey("IDPromocion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IDUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Promocion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.DetalleCompra", b =>
                {
                    b.HasOne("Domain.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("IDCompra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("IDProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Domain.Producto", b =>
                {
                    b.HasOne("Domain.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("IDCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Color", "Color")
                        .WithMany()
                        .HasForeignKey("IDColor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("IDMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Color");

                    b.Navigation("Marca");
                });
#pragma warning restore 612, 618
        }
    }
}
