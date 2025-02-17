﻿// <auto-generated />
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210526185925_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("App.Models.StudentsInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("stuAge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("stuDayScholar")
                        .HasColumnType("TEXT");

                    b.Property<string>("stuFirstName")
                        .HasColumnType("TEXT");

                    b.Property<int>("stuGrade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("stuLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("stuOptionalLang")
                        .HasColumnType("TEXT");

                    b.Property<string>("stuPrefix")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StudentsInfo");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            stuAge = 11,
                            stuDayScholar = "Yes",
                            stuFirstName = "Amelia",
                            stuGrade = 6,
                            stuLastName = "Petter",
                            stuOptionalLang = "French",
                            stuPrefix = "Ms."
                        },
                        new
                        {
                            Id = 2L,
                            stuAge = 12,
                            stuDayScholar = "No",
                            stuFirstName = "Richard",
                            stuGrade = 7,
                            stuLastName = "Grey",
                            stuOptionalLang = "Spanish",
                            stuPrefix = "Mr."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
