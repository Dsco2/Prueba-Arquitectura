﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(ContextoPrincipal))]
    partial class ContextoPrincipalModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Negocio.Mercadeo.Entidades.ArticuloPorLista", b =>
                {
                    b.Property<int>("IdArticulo");

                    b.Property<int>("IdListaEscolar");

                    b.Property<int>("Cantidad");

                    b.HasKey("IdArticulo", "IdListaEscolar");

                    b.HasIndex("IdListaEscolar");

                    b.ToTable("ArticulosPorLista","mkt");
                });

            modelBuilder.Entity("Negocio.Mercadeo.Entidades.ListaEscolar", b =>
                {
                    b.Property<int>("IdListaEscolar")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Anio");

                    b.HasKey("IdListaEscolar");

                    b.ToTable("ListasEscolares","mkt");
                });

            modelBuilder.Entity("Negocio.Productos.Entidades.Articulo", b =>
                {
                    b.Property<int>("IdArticulo")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("FechaBorrado");

                    b.Property<string>("Nombre");

                    b.Property<decimal>("Precio");

                    b.HasKey("IdArticulo");

                    b.ToTable("Articulos","prods");
                });

            modelBuilder.Entity("Negocio.Productos.Entidades.Marca", b =>
                {
                    b.Property<int>("IdMarca")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .HasMaxLength(45);

                    b.HasKey("IdMarca");

                    b.ToTable("Marcas","prods");
                });

            modelBuilder.Entity("Negocio.Productos.Entidades.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AgotarPorInventario");

                    b.Property<string>("Descripcion");

                    b.Property<bool>("Disponible");

                    b.Property<int>("IdMarca");

                    b.Property<bool>("ListaFavor");

                    b.Property<string>("Nombre")
                        .HasMaxLength(60);

                    b.Property<string>("NombreBuscador")
                        .HasMaxLength(200);

                    b.Property<double>("Peso");

                    b.Property<int>("SecuenciaIdRemision");

                    b.Property<int>("SecuenciaPagina");

                    b.Property<bool>("TieneImagen");

                    b.Property<string>("UrlImagen");

                    b.HasKey("IdProducto");

                    b.HasIndex("IdMarca");

                    b.ToTable("Productos","prods");
                });

            modelBuilder.Entity("Negocio.Mercadeo.Entidades.ArticuloPorLista", b =>
                {
                    b.HasOne("Negocio.Productos.Entidades.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("IdArticulo")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Negocio.Mercadeo.Entidades.ListaEscolar", "ListaEscolar")
                        .WithMany()
                        .HasForeignKey("IdListaEscolar")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Negocio.Productos.Entidades.Producto", b =>
                {
                    b.HasOne("Negocio.Productos.Entidades.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
