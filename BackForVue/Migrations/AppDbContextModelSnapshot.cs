﻿// <auto-generated />
using BackForVue.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackForVue.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BackForVue.Models.Employe", b =>
                {
                    b.Property<int>("NumEmp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<int>("Salaire")
                        .HasColumnType("int");

                    b.HasKey("NumEmp");

                    b.ToTable("Employes");
                });
#pragma warning restore 612, 618
        }
    }
}
