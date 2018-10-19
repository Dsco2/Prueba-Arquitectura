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

                    b.Property<int>("IdLista");

                    b.Property<int>("Cantidad");

                    b.Property<int?>("ListaEscolarIdListaEscolar");

                    b.HasKey("IdArticulo", "IdLista");

                    b.HasIndex("ListaEscolarIdListaEscolar");

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

                    b.Property<string>("Nombre");

                    b.Property<decimal>("Precio");

                    b.HasKey("IdArticulo");

                    b.ToTable("Articulos","prods");
                });

            modelBuilder.Entity("Negocio.Mercadeo.Entidades.ArticuloPorLista", b =>
                {
                    b.HasOne("Negocio.Productos.Entidades.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("IdArticulo")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Negocio.Mercadeo.Entidades.ListaEscolar", "ListaEscolar")
                        .WithMany()
                        .HasForeignKey("ListaEscolarIdListaEscolar");
                });
#pragma warning restore 612, 618
        }
    }
}
