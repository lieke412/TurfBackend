﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReceptenVoorHuisgenoten2.Data;

#nullable disable

namespace ReceptenVoorHuisgenoten2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessLogic.Logic.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReceptID");

                    b.ToTable("Ingredienten");
                });

            modelBuilder.Entity("BusinessLogic.Logic.Recept", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Duur")
                        .HasColumnType("int");

                    b.Property<int>("Moeilijkheid")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Recepten");
                });

            modelBuilder.Entity("BusinessLogic.Logic.Ingredient", b =>
                {
                    b.HasOne("BusinessLogic.Logic.Recept", null)
                        .WithMany("Ingredienten")
                        .HasForeignKey("ReceptID");
                });

            modelBuilder.Entity("BusinessLogic.Logic.Recept", b =>
                {
                    b.Navigation("Ingredienten");
                });
#pragma warning restore 612, 618
        }
    }
}
