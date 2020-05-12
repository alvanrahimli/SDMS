﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SDMS.Data;

namespace SDMS.Migrations
{
    [DbContext(typeof(SDMSContext))]
    partial class SDMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("SDMS.Models.Absence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Absences");

                    b.HasData(
                        new
                        {
                            Id = new Guid("34b4f556-43cb-4f4e-8e02-ca377368e68b"),
                            CourseId = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"),
                            DateTime = new DateTime(2021, 3, 11, 22, 0, 38, 80, DateTimeKind.Local).AddTicks(2358),
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8")
                        },
                        new
                        {
                            Id = new Guid("2012d256-2218-4899-87fb-194f7ddb304d"),
                            CourseId = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"),
                            DateTime = new DateTime(2021, 3, 11, 22, 0, 38, 80, DateTimeKind.Local).AddTicks(3299),
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8")
                        },
                        new
                        {
                            Id = new Guid("6ba90822-dcf5-4d48-a532-bdcf7376e7ff"),
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            DateTime = new DateTime(2021, 3, 26, 22, 0, 38, 80, DateTimeKind.Local).AddTicks(3360),
                            StudentId = new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("RegistrtationStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = new Guid("91c86171-2a22-4da8-84fe-be29271ca353"),
                            Email = "admin1@sdms.az",
                            Password = new byte[] { 118, 154, 146, 167, 110, 72, 79, 210, 194, 40, 188, 53, 92, 240, 58, 113, 238, 249, 88, 81, 104, 52, 117, 142, 73, 119, 219, 182, 94, 84, 206, 42 },
                            RegistrtationStatus = 1
                        });
                });

            modelBuilder.Entity("SDMS.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AbsenceLimit")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Credit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("RequiredById")
                        .HasColumnType("TEXT");

                    b.Property<string>("SyllabusPath")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RequiredById");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"),
                            AbsenceLimit = 11,
                            Credit = 6,
                            Name = "Calculus I",
                            RequiredById = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            AbsenceLimit = 11,
                            Credit = 6,
                            Name = "Calculus II",
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb"),
                            AbsenceLimit = 6,
                            Credit = 5,
                            Name = "Probability and Statistics",
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("53f1918b-a53c-470a-b547-2137d40fc632"),
                            AbsenceLimit = 11,
                            Credit = 5,
                            Name = "System Engineering Conseption",
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("07af7773-9ead-4ab9-ac56-7a56929716aa"),
                            AbsenceLimit = 6,
                            Credit = 6,
                            Name = "Introduction to Programming",
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf"),
                            AbsenceLimit = 13,
                            Credit = 4,
                            Name = "Physics I",
                            RequiredById = new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393"),
                            SyllabusPath = "N/A"
                        },
                        new
                        {
                            Id = new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393"),
                            AbsenceLimit = 13,
                            Credit = 4,
                            Name = "Physics II",
                            SyllabusPath = "N/A"
                        });
                });

            modelBuilder.Entity("SDMS.Models.CourseSpeciality", b =>
                {
                    b.Property<Guid>("SpecialityId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.HasKey("SpecialityId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseSpecialities");

                    b.HasData(
                        new
                        {
                            SpecialityId = new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"),
                            CourseId = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50")
                        },
                        new
                        {
                            SpecialityId = new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"),
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1")
                        },
                        new
                        {
                            SpecialityId = new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"),
                            CourseId = new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb")
                        },
                        new
                        {
                            SpecialityId = new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"),
                            CourseId = new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb")
                        },
                        new
                        {
                            SpecialityId = new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"),
                            CourseId = new Guid("07af7773-9ead-4ab9-ac56-7a56929716aa")
                        },
                        new
                        {
                            SpecialityId = new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"),
                            CourseId = new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf")
                        },
                        new
                        {
                            SpecialityId = new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"),
                            CourseId = new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393")
                        },
                        new
                        {
                            SpecialityId = new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"),
                            CourseId = new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf")
                        },
                        new
                        {
                            SpecialityId = new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"),
                            CourseId = new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393")
                        });
                });

            modelBuilder.Entity("SDMS.Models.CurrentCourseStudent", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseTeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("CourseTeacherId");

                    b.HasIndex("StudentId");

                    b.ToTable("CurrentCourseStudents");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8"),
                            CourseTeacherId = new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("ScoreOver100")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Scores");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a6d4f569-09fc-4c25-bdc3-40d7f72cdfe7"),
                            CourseId = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"),
                            Date = new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8")
                        },
                        new
                        {
                            Id = new Guid("70b4c6c7-c1fa-410d-8b8a-82e8d186ab74"),
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            Date = new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8")
                        },
                        new
                        {
                            Id = new Guid("9275a2d1-61b5-4aab-a79b-6b8f8cae428d"),
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            Date = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8")
                        },
                        new
                        {
                            Id = new Guid("2f03324b-1152-4573-bac3-65c2e7adda41"),
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            Date = new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8")
                        },
                        new
                        {
                            Id = new Guid("939e6bf9-e0b5-4799-a699-9973d57f860d"),
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            Date = new DateTime(2020, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 93,
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8")
                        },
                        new
                        {
                            Id = new Guid("3ca2f92d-76eb-41c7-a86a-4b67e109d83e"),
                            CourseId = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"),
                            Date = new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 85,
                            StudentId = new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398")
                        },
                        new
                        {
                            Id = new Guid("624623e9-4534-47d3-8301-c805d969f00a"),
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            Date = new DateTime(2019, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ScoreOver100 = 100,
                            StudentId = new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Speciality", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e"),
                            Name = "System Engineering",
                            StartDate = new DateTime(2020, 5, 11, 22, 0, 38, 61, DateTimeKind.Local).AddTicks(7975)
                        },
                        new
                        {
                            Id = new Guid("100fb7d0-2873-4944-b345-98b61ccb081a"),
                            Name = "Information Technologies",
                            StartDate = new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SDMS.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("RegisterStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SpecialityId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8"),
                            CardNumber = "ALVA001",
                            Details = "BA Programs",
                            Email = "alvan@sdms.az",
                            Gender = 0,
                            Name = "Alvan Rahimli",
                            Password = new byte[] { 220, 121, 31, 195, 66, 161, 196, 242, 197, 217, 20, 142, 19, 132, 185, 44, 89, 244, 177, 222, 235, 28, 62, 173, 121, 184, 91, 151, 77, 250, 162, 156 },
                            RegisterStatus = 1,
                            Role = "student",
                            SpecialityId = new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e")
                        },
                        new
                        {
                            Id = new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398"),
                            CardNumber = "SAMI001",
                            Details = "BA Programs",
                            Email = "samir@sdms.az",
                            Gender = 0,
                            Name = "Samir Hasanov",
                            Password = new byte[] { 26, 138, 154, 79, 225, 90, 179, 124, 122, 92, 74, 150, 215, 163, 128, 13, 221, 243, 126, 213, 98, 60, 251, 224, 44, 198, 158, 237, 77, 194, 220, 152 },
                            RegisterStatus = 1,
                            Role = "student",
                            SpecialityId = new Guid("85ba20f5-cbf7-457f-9fa6-e5bea9491c3e")
                        });
                });

            modelBuilder.Entity("SDMS.Models.TakenCourseStudent", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CourseTeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("CourseTeacherId");

                    b.HasIndex("StudentId");

                    b.ToTable("TakenCourseStudents");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"),
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8"),
                            CourseTeacherId = new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a")
                        },
                        new
                        {
                            CourseId = new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb"),
                            StudentId = new Guid("a47b4b5c-7edf-4c84-9c54-e2c69a2220e8"),
                            CourseTeacherId = new Guid("36e8b3e3-6e85-4a58-99ad-96152aed2997")
                        },
                        new
                        {
                            CourseId = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"),
                            StudentId = new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398"),
                            CourseTeacherId = new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a")
                        },
                        new
                        {
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            StudentId = new Guid("ea339527-73b9-4a54-a9d6-7d17e013d398"),
                            CourseTeacherId = new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CVPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("RegisterStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a"),
                            CVPath = "N/A",
                            CardNumber = "ANAR001",
                            Details = "since 2017 teaching here. Test data LOL",
                            Email = "anar@sdms.az",
                            Gender = 0,
                            Name = "Anar Kazimov",
                            Password = new byte[] { 13, 163, 157, 63, 215, 56, 253, 36, 173, 144, 123, 128, 215, 160, 65, 146, 66, 160, 85, 207, 141, 30, 123, 20, 133, 166, 142, 100, 95, 123, 123, 212 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        },
                        new
                        {
                            Id = new Guid("36e8b3e3-6e85-4a58-99ad-96152aed2997"),
                            CVPath = "N/A",
                            CardNumber = "KONU001",
                            Details = "Cuuute teacher. doesn't know eng.",
                            Email = "konul@sdms.az",
                            Gender = 1,
                            Name = "Konul Jabbarova",
                            Password = new byte[] { 225, 95, 75, 32, 223, 30, 43, 41, 130, 26, 86, 69, 237, 49, 122, 22, 200, 149, 87, 68, 150, 95, 141, 191, 60, 121, 48, 214, 99, 239, 101, 71 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        },
                        new
                        {
                            Id = new Guid("10680bf9-a009-46d6-9cdd-4684a7eafef8"),
                            CVPath = "N/A",
                            CardNumber = "ULVI001",
                            Details = "Meeh, not bad",
                            Email = "ulviyye@sdms.az",
                            Gender = 1,
                            Name = "Ulviyye Memmedova",
                            Password = new byte[] { 168, 14, 103, 199, 215, 42, 209, 248, 3, 160, 5, 252, 245, 60, 173, 182, 25, 218, 195, 84, 47, 209, 215, 43, 123, 101, 136, 37, 83, 85, 162, 6 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        },
                        new
                        {
                            Id = new Guid("855416e2-8654-44df-ab29-0fef69914426"),
                            CVPath = "N/A",
                            CardNumber = "CEYH001",
                            Details = "Veery Cuuute teacher. doesn't know eng.",
                            Email = "ceyhun@sdms.az",
                            Gender = 0,
                            Name = "Ceyhun Naziyev",
                            Password = new byte[] { 195, 139, 238, 24, 37, 33, 11, 141, 87, 96, 116, 187, 225, 223, 196, 114, 171, 140, 193, 4, 160, 103, 124, 221, 126, 213, 181, 35, 99, 184, 54, 125 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        },
                        new
                        {
                            Id = new Guid("6fcbb37f-b951-4bec-a4f9-144ea24ca14e"),
                            CVPath = "N/A",
                            CardNumber = "ELED001",
                            Details = "Reis.",
                            Email = "eleddin@sdms.az",
                            Gender = 0,
                            Name = "Eleddin Memmedli",
                            Password = new byte[] { 47, 241, 100, 169, 13, 197, 122, 59, 242, 8, 3, 103, 181, 141, 173, 216, 176, 2, 209, 17, 102, 231, 236, 184, 248, 180, 21, 168, 107, 69, 177, 248 },
                            RegisterStatus = 1,
                            Role = "teacher"
                        });
                });

            modelBuilder.Entity("SDMS.Models.TeacherCourse", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherCourses");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"),
                            TeacherId = new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a")
                        },
                        new
                        {
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            TeacherId = new Guid("cfec2e96-5c77-47da-8739-5e0af5c4717a")
                        },
                        new
                        {
                            CourseId = new Guid("c9d907e4-6b04-417c-bac8-f31db716f6eb"),
                            TeacherId = new Guid("36e8b3e3-6e85-4a58-99ad-96152aed2997")
                        },
                        new
                        {
                            CourseId = new Guid("07af7773-9ead-4ab9-ac56-7a56929716aa"),
                            TeacherId = new Guid("10680bf9-a009-46d6-9cdd-4684a7eafef8")
                        },
                        new
                        {
                            CourseId = new Guid("1ea72f89-1ab5-4325-b1e7-f445724b65cf"),
                            TeacherId = new Guid("855416e2-8654-44df-ab29-0fef69914426")
                        },
                        new
                        {
                            CourseId = new Guid("0e3b7ec6-7b00-47df-a3e6-37a507855393"),
                            TeacherId = new Guid("855416e2-8654-44df-ab29-0fef69914426")
                        },
                        new
                        {
                            CourseId = new Guid("5fbd9471-6ad3-4ac8-bb9a-60a6e11b3c50"),
                            TeacherId = new Guid("6fcbb37f-b951-4bec-a4f9-144ea24ca14e")
                        },
                        new
                        {
                            CourseId = new Guid("55e90ef1-5030-4199-8c01-cd4eb19768e1"),
                            TeacherId = new Guid("6fcbb37f-b951-4bec-a4f9-144ea24ca14e")
                        });
                });

            modelBuilder.Entity("SDMS.Models.Absence", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SDMS.Models.Course", b =>
                {
                    b.HasOne("SDMS.Models.Course", "RequiredBy")
                        .WithMany("Prerequisites")
                        .HasForeignKey("RequiredById");

                    b.HasOne("SDMS.Models.Teacher", null)
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("SDMS.Models.CourseSpeciality", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany("CourseSpecialities")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Speciality", "Speciality")
                        .WithMany("CourseSpecialities")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SDMS.Models.CurrentCourseStudent", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany("CurrentCourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SDMS.Models.Teacher", "CourseTeacher")
                        .WithMany()
                        .HasForeignKey("CourseTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Student", "Student")
                        .WithMany("CurrentCourseStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SDMS.Models.Score", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SDMS.Models.Student", b =>
                {
                    b.HasOne("SDMS.Models.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SDMS.Models.TakenCourseStudent", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany("TakenCourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SDMS.Models.Teacher", "CourseTeacher")
                        .WithMany()
                        .HasForeignKey("CourseTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Student", "Student")
                        .WithMany("TakenCourseStudents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SDMS.Models.TeacherCourse", b =>
                {
                    b.HasOne("SDMS.Models.Course", "Course")
                        .WithMany("TeacherCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SDMS.Models.Teacher", "Teacher")
                        .WithMany("TeacherCourses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
