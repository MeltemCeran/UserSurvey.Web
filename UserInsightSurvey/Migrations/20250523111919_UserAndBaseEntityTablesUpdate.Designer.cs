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
    [Migration("20250523111919_UserAndBaseEntityTablesUpdate")]
    partial class UserAndBaseEntityTablesUpdate
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
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9731),
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 2,
                            Content = "WinForms",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9734),
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "WPF",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9735),
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 4,
                            Content = "Blazor",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9736),
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "Visual Studio",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9737),
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 6,
                            Content = "Rider",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9738),
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 7,
                            Content = "VS Code",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9738),
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 8,
                            Content = "Diğer",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9739),
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 9,
                            Content = "MVC",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9740),
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 10,
                            Content = "MVVM",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9741),
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 11,
                            Content = "Onion Architecture",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9741),
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 12,
                            Content = "Clean Architecture",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9742),
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 13,
                            Content = "SQL Server",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9743),
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 14,
                            Content = "PostgreSQL",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9744),
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 15,
                            Content = "MySQL",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9744),
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 16,
                            Content = "MongoDB",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9745),
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 17,
                            Content = "Azure",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9746),
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 18,
                            Content = "AWS",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9747),
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 19,
                            Content = "Google Cloud",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9747),
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 20,
                            Content = "Hiçbiri",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9748),
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 21,
                            Content = "Analiz",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9749),
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 22,
                            Content = "Tasarım",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9749),
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 23,
                            Content = "Kodlama",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9750),
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 24,
                            Content = "Test",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9752),
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 25,
                            Content = "Bakım",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9753),
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
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9520),
                            MultipleChoice = false,
                            QuestionType = 0
                        },
                        new
                        {
                            Id = 2,
                            Content = ".NET teknolojilerinden hangileriyle çalıştınız?",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9538),
                            MultipleChoice = true,
                            QuestionType = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "En çok kullandığınız IDE hangisidir?",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9555),
                            MultipleChoice = true,
                            QuestionType = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "Entity Framework ile ilgili deneyiminizi kısaca anlatır mısınız?",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9556),
                            MultipleChoice = false,
                            QuestionType = 0
                        },
                        new
                        {
                            Id = 5,
                            Content = "Aşağıdaki mimari desenlerden hangilerini projelerinizde kullandınız?",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9557),
                            MultipleChoice = true,
                            QuestionType = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = ".NET Core ile .NET Framework arasındaki temel fark nedir?",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9558),
                            MultipleChoice = false,
                            QuestionType = 0
                        },
                        new
                        {
                            Id = 7,
                            Content = "Hangi veritabanı sistemleriyle çalıştınız?",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9559),
                            MultipleChoice = true,
                            QuestionType = 2
                        },
                        new
                        {
                            Id = 8,
                            Content = "Bir web API projesinde en önemli gördüğünüz güvenlik önlemi nedir?",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9560),
                            MultipleChoice = false,
                            QuestionType = 0
                        },
                        new
                        {
                            Id = 9,
                            Content = "Aşağıdaki bulut servislerinden hangilerini kullandınız?",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9561),
                            MultipleChoice = true,
                            QuestionType = 2
                        },
                        new
                        {
                            Id = 10,
                            Content = "Yazılım geliştirme sürecinde en çok hangi aşamada zorlanıyorsunuz?",
                            CreatedDate = new DateTime(2025, 5, 23, 14, 19, 19, 452, DateTimeKind.Local).AddTicks(9563),
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
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("UserInsightSurvey.Data.Concrete.User", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
