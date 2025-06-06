﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserInsightSurvey.Context;

#nullable disable

namespace UserInsightSurvey.Migrations
{
    [DbContext(typeof(UserSurveyDbContext))]
    [Migration("20250525091030_UserAndAnswerTableSeedDataInit")]
    partial class UserAndAnswerTableSeedDataInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OptionId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "LINQ",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(680),
                            QuestionId = 1,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(704),
                            OptionId = 1,
                            QuestionId = 2,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(706),
                            OptionId = 3,
                            QuestionId = 2,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(707),
                            OptionId = 5,
                            QuestionId = 3,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 5,
                            Content = "Code First ile migration yönetimi deneyimim var.",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(708),
                            QuestionId = 4,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(710),
                            OptionId = 9,
                            QuestionId = 5,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(711),
                            OptionId = 12,
                            QuestionId = 5,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 8,
                            Content = ".NET Core platform bağımsızdır.",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(712),
                            QuestionId = 6,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(713),
                            OptionId = 13,
                            QuestionId = 7,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(715),
                            OptionId = 16,
                            QuestionId = 7,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 11,
                            Content = "JWT ile kimlik doğrulama kullanırım.",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(716),
                            QuestionId = 8,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(718),
                            OptionId = 17,
                            QuestionId = 9,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 308, DateTimeKind.Local).AddTicks(719),
                            OptionId = 23,
                            QuestionId = 10,
                            UserId = "252d1809-cd07-4ebd-87d1-83cefac3b78c"
                        });
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Options");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "ASP.NET Core",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8789),
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 2,
                            Content = "WinForms",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8794),
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "WPF",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8795),
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 4,
                            Content = "Blazor",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8797),
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "Visual Studio",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8798),
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 6,
                            Content = "Rider",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8799),
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 7,
                            Content = "VS Code",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8800),
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 8,
                            Content = "Diğer",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8801),
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 9,
                            Content = "MVC",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8803),
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 10,
                            Content = "MVVM",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8804),
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 11,
                            Content = "Onion Architecture",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8805),
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 12,
                            Content = "Clean Architecture",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8806),
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 13,
                            Content = "SQL Server",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8807),
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 14,
                            Content = "PostgreSQL",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8808),
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 15,
                            Content = "MySQL",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8809),
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 16,
                            Content = "MongoDB",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8810),
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 17,
                            Content = "Azure",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8811),
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 18,
                            Content = "AWS",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8867),
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 19,
                            Content = "Google Cloud",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8868),
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 20,
                            Content = "Hiçbiri",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8870),
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 21,
                            Content = "Analiz",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8871),
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 22,
                            Content = "Tasarım",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8872),
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 23,
                            Content = "Kodlama",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8874),
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 24,
                            Content = "Test",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8875),
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 25,
                            Content = "Bakım",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8876),
                            QuestionId = 10
                        });
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MultipleChoice")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "C# dilinde en çok kullandığınız özellik nedir?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8283),
                            MultipleChoice = false,
                            QuestionType = 0
                        },
                        new
                        {
                            Id = 2,
                            Content = ".NET teknolojilerinden hangileriyle çalıştınız?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8309),
                            MultipleChoice = true,
                            QuestionType = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "En çok kullandığınız IDE hangisidir?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8312),
                            MultipleChoice = true,
                            QuestionType = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "Entity Framework ile ilgili deneyiminizi kısaca anlatır mısınız?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8314),
                            MultipleChoice = false,
                            QuestionType = 0
                        },
                        new
                        {
                            Id = 5,
                            Content = "Aşağıdaki mimari desenlerden hangilerini projelerinizde kullandınız?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8316),
                            MultipleChoice = true,
                            QuestionType = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = ".NET Core ile .NET Framework arasındaki temel fark nedir?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8318),
                            MultipleChoice = false,
                            QuestionType = 0
                        },
                        new
                        {
                            Id = 7,
                            Content = "Hangi veritabanı sistemleriyle çalıştınız?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8320),
                            MultipleChoice = true,
                            QuestionType = 2
                        },
                        new
                        {
                            Id = 8,
                            Content = "Bir web API projesinde en önemli gördüğünüz güvenlik önlemi nedir?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8323),
                            MultipleChoice = false,
                            QuestionType = 0
                        },
                        new
                        {
                            Id = 9,
                            Content = "Aşağıdaki bulut servislerinden hangilerini kullandınız?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8324),
                            MultipleChoice = true,
                            QuestionType = 2
                        },
                        new
                        {
                            Id = 10,
                            Content = "Yazılım geliştirme sürecinde en çok hangi aşamada zorlanıyorsunuz?",
                            CreatedDate = new DateTime(2025, 5, 25, 12, 10, 29, 214, DateTimeKind.Local).AddTicks(8326),
                            MultipleChoice = true,
                            QuestionType = 1
                        });
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CvFilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "00bf48aa-21e6-4b81-9e8d-f26179a02769",
                            CvFilePath = "",
                            Email = "test@demo.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Test",
                            NormalizedEmail = "TEST@DEMO.COM",
                            NormalizedUserName = "TEST@DEMO.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEA/pjxfX1d4MJZwROT5hrv3ouVkl1ThceIXSKNpG8X/Q5aLIEv0gDW7gMfaEgvOl2w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3d9ca5ed-0808-4773-9562-d52466480b04",
                            Surname = "Kullanıcı",
                            TwoFactorEnabled = false,
                            UserName = "test@demo.com",
                            UserType = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UserInsightSurvey.Data.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UserInsightSurvey.Data.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserInsightSurvey.Data.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UserInsightSurvey.Data.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.Answer", b =>
                {
                    b.HasOne("UserInsightSurvey.Data.Concrete.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserInsightSurvey.Data.Concrete.User", "User")
                        .WithMany("Answers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.Option", b =>
                {
                    b.HasOne("UserInsightSurvey.Data.Concrete.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.Question", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Options");
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.User", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
