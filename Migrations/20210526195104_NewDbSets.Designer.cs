﻿// <auto-generated />
using System;
using App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210526195104_NewDbSets")]
    partial class NewDbSets
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("App.Models.ClassInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ScheduleInfoId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("departmentId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("teacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleInfoId");

                    b.HasIndex("departmentId");

                    b.HasIndex("teacherId");

                    b.ToTable("classInfos");
                });

            modelBuilder.Entity("App.Models.DepartmentInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("DepartmentInfos");

                    b.HasData(
                        new
                        {
                            Id = 1L
                        },
                        new
                        {
                            Id = 2L
                        });
                });

            modelBuilder.Entity("App.Models.ScheduleInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("studentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("studentId");

                    b.ToTable("scheduleInfos");
                });

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

            modelBuilder.Entity("App.Models.TeachersInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("DepartmentInfoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("teaAge")
                        .HasColumnType("INTEGER");

                    b.Property<string>("teaDaySubject")
                        .HasColumnType("TEXT");

                    b.Property<string>("teaFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("teaLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("teaOptionalLang")
                        .HasColumnType("TEXT");

                    b.Property<string>("teaPrefix")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentInfoId");

                    b.ToTable("TeachersInfos");
                });

            modelBuilder.Entity("App.Models.ClassInfo", b =>
                {
                    b.HasOne("App.Models.ScheduleInfo", null)
                        .WithMany("classes")
                        .HasForeignKey("ScheduleInfoId");

                    b.HasOne("App.Models.DepartmentInfo", "department")
                        .WithMany()
                        .HasForeignKey("departmentId");

                    b.HasOne("App.Models.TeachersInfo", "teacher")
                        .WithMany()
                        .HasForeignKey("teacherId");

                    b.Navigation("department");

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("App.Models.ScheduleInfo", b =>
                {
                    b.HasOne("App.Models.StudentsInfo", "student")
                        .WithMany()
                        .HasForeignKey("studentId");

                    b.Navigation("student");
                });

            modelBuilder.Entity("App.Models.TeachersInfo", b =>
                {
                    b.HasOne("App.Models.DepartmentInfo", null)
                        .WithMany("teachers")
                        .HasForeignKey("DepartmentInfoId");
                });

            modelBuilder.Entity("App.Models.DepartmentInfo", b =>
                {
                    b.Navigation("teachers");
                });

            modelBuilder.Entity("App.Models.ScheduleInfo", b =>
                {
                    b.Navigation("classes");
                });
#pragma warning restore 612, 618
        }
    }
}
