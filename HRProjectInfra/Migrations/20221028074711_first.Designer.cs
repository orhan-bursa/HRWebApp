﻿// <auto-generated />
using System;
using HRProjectInfra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRProjectInfrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221028074711_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRProjectDomain.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
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

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "92777eed-2f34-45af-8f32-e33d1ff9c3d9",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(2022, 10, 28, 10, 47, 11, 280, DateTimeKind.Local).AddTicks(3269),
                            CompanyId = 1,
                            ConcurrencyStamp = "dd69d520-7aab-4cff-96cf-fcd76fc808ac",
                            CreateDate = new DateTime(2022, 10, 28, 10, 47, 11, 280, DateTimeKind.Local).AddTicks(3724),
                            Email = "bursaorhan@outlook.com",
                            EmailConfirmed = true,
                            Gender = 1,
                            LockoutEnabled = false,
                            Name = "Orhan",
                            NormalizedUserName = "ORHANB",
                            PasswordHash = "AQAAAAEAACcQAAAAEN19VcDSvqC2hEkglFf66i/V/sGLYEB11L8cOcunCPZvvlwTfhESlyv8dfwoQ8YO/w==",
                            PhoneNumber = "05069806185",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a2535a67-2096-4cda-937e-c5ffce88a62d",
                            Status = 1,
                            Surname = "Bursa",
                            TwoFactorEnabled = false,
                            UserName = "orhanb"
                        },
                        new
                        {
                            Id = "92777eed-2f34-45af-8f32-e33d1ff9c3d8",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(2022, 10, 28, 10, 47, 11, 291, DateTimeKind.Local).AddTicks(5483),
                            CompanyId = 1,
                            ConcurrencyStamp = "0998dc10-d0e7-423b-a35a-1d1d1bce28bd",
                            CreateDate = new DateTime(2022, 10, 28, 10, 47, 11, 291, DateTimeKind.Local).AddTicks(5494),
                            Email = "esinankocaaga@gmail.com",
                            EmailConfirmed = true,
                            Gender = 1,
                            LockoutEnabled = false,
                            Name = "Sinan",
                            NormalizedUserName = "SINANK",
                            PasswordHash = "AQAAAAEAACcQAAAAEFORryVVQR/uLmtXOe8EFCVAEtD+/6YNgU2gJ+YH4l6EDQ79Os6hMR+6nMYMFRpFog==",
                            PhoneNumber = "07340725825",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1f48bbf2-6afe-453d-99f7-92b2f513aa00",
                            Status = 1,
                            Surname = "Kocaaga",
                            TwoFactorEnabled = false,
                            UserName = "sinank"
                        },
                        new
                        {
                            Id = "92777eed-2f34-45af-8f32-e33d1ff9c3d7",
                            AccessFailedCount = 0,
                            BirthDate = new DateTime(2022, 10, 28, 10, 47, 11, 298, DateTimeKind.Local).AddTicks(699),
                            CompanyId = 1,
                            ConcurrencyStamp = "0fd86204-09e9-4fbe-ab71-752099830630",
                            CreateDate = new DateTime(2022, 10, 28, 10, 47, 11, 298, DateTimeKind.Local).AddTicks(702),
                            Email = "kocaagaece@gmail.com",
                            EmailConfirmed = true,
                            Gender = 2,
                            LockoutEnabled = false,
                            Name = "Ece",
                            NormalizedUserName = "ECEK",
                            PasswordHash = "AQAAAAEAACcQAAAAENBI2dn9j7TxYv6ETKbKxbsnxDvTC5NLyOrX48lC+yXj+FniDKjFEtWpSbU6dVwOVQ==",
                            PhoneNumber = "05369372279",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "54938771-4f46-43ae-8f4b-e2232cb6bbf0",
                            Status = 1,
                            Surname = "Kocaaga",
                            TwoFactorEnabled = false,
                            UserName = "ecek"
                        });
                });

            modelBuilder.Entity("HRProjectDomain.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TaxNumber")
                        .HasColumnType("int");

                    b.Property<string>("TaxOffice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Istanbul",
                            CompanyName = "BilgeAdam",
                            ContactPerson = "Enis Keskin",
                            CreateDate = new DateTime(2022, 10, 28, 10, 47, 11, 279, DateTimeKind.Local).AddTicks(8691),
                            NumberOfEmployees = 5,
                            PhoneNumber = "02122123434",
                            Status = 1,
                            TaxNumber = 123456789,
                            TaxOffice = "Sarıyer",
                            WebSite = "www.bilgeadam.com"
                        });
                });

            modelBuilder.Entity("HRProjectDomain.Entities.Leave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<int>("LeaveType")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfDays")
                        .HasColumnType("int");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Leaves");
                });

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HRProjectDomain.Entities.AppUser", b =>
                {
                    b.HasOne("HRProjectDomain.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("HRProjectDomain.Entities.Leave", b =>
                {
                    b.HasOne("HRProjectDomain.Entities.AppUser", "User")
                        .WithMany("Leaves")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
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
                    b.HasOne("HRProjectDomain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HRProjectDomain.Entities.AppUser", null)
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

                    b.HasOne("HRProjectDomain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HRProjectDomain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRProjectDomain.Entities.AppUser", b =>
                {
                    b.Navigation("Leaves");
                });
#pragma warning restore 612, 618
        }
    }
}
