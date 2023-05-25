﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReceptenVoorHuisgenoten2.Data;

#nullable disable

namespace ReceptenVoorHuisgenoten2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230524094347_InitialCreate3")]
    partial class InitialCreate3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasKey("ID");

                    b.ToTable("Ingredienten");
                });

            modelBuilder.Entity("BusinessLogic.Logic.Recept", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("IngredientRecept", b =>
                {
                    b.Property<int>("IngredientenID")
                        .HasColumnType("int");

                    b.Property<int>("ReceptenID")
                        .HasColumnType("int");

                    b.HasKey("IngredientenID", "ReceptenID");

                    b.HasIndex("ReceptenID");

                    b.ToTable("IngredientRecept");
                });

            modelBuilder.Entity("IngredientRecept", b =>
                {
                    b.HasOne("BusinessLogic.Logic.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessLogic.Logic.Recept", null)
                        .WithMany()
                        .HasForeignKey("ReceptenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
