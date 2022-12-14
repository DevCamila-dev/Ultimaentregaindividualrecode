// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Viajar.Data;

#nullable disable

namespace Viajar.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221120002340_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Viajar.Model.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("estado_destino");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome_destino");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("pais_destino");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Valor_destino");

                    b.Property<string>("dataIda")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("dataIda_destino");

                    b.Property<string>("dataVolta")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("dataVolta_aluno");

                    b.HasKey("Id");

                    b.ToTable("destinos");
                });
#pragma warning restore 612, 618
        }
    }
}
