﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopEase.Data;

#nullable disable

namespace ShopEase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250211224915_AddStaffIDasID")]
    partial class AddStaffIDasID
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("StaffClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("StaffLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("StaffRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("StaffTokens", (string)null);
                });

            modelBuilder.Entity("ShopEase.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AdminPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AdminSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("ShopEase.Models.Aisle", b =>
                {
                    b.Property<int>("AisleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AisleID"));

                    b.Property<string>("AisleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreSection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AisleID");

                    b.ToTable("Aisle");
                });

            modelBuilder.Entity("ShopEase.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ShopEase.Models.CustomerRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AisleID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StaffID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AisleID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("StaffID");

                    b.ToTable("CustomerRequest");
                });

            modelBuilder.Entity("ShopEase.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackID"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RequestID")
                        .HasColumnType("int");

                    b.HasKey("FeedbackID");

                    b.HasIndex("RequestID");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("ShopEase.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AvailabilityStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffID")
                        .HasColumnType("int")
                        .HasColumnName("StaffID");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Staff", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Available",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "john.doe@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "John",
                            NormalizedUserName = "JOHN.DOE",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Floor Assistant",
                            SecurityStamp = "SECSTAMP-0001",
                            StaffID = 1,
                            Surname = "Doe",
                            TwoFactorEnabled = false,
                            UserName = "john.doe"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Unavailable",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "sikholwe.mdekazi@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Sikholwe",
                            NormalizedUserName = "SIKHOLE.MDEKAZI",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Floor Assistant",
                            SecurityStamp = "SECSTAMP-0002",
                            StaffID = 2,
                            Surname = "Mdekazi",
                            TwoFactorEnabled = false,
                            UserName = "sikholwe.mdekazi"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Available",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "michael.brown@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Michael",
                            NormalizedUserName = "MICHAEL.BROWN",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Store Manager",
                            SecurityStamp = "SECSTAMP-0003",
                            StaffID = 3,
                            Surname = "Brown",
                            TwoFactorEnabled = false,
                            UserName = "michael.brown"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Available",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "emily.davis@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Emily",
                            NormalizedUserName = "EMILY.DAVIS",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Cashier",
                            SecurityStamp = "SECSTAMP-0004",
                            StaffID = 4,
                            Surname = "Davis",
                            TwoFactorEnabled = false,
                            UserName = "emily.davis"
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Busy",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "david.wilson@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "David",
                            NormalizedUserName = "DAVID.WILSON",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Stock Associate",
                            SecurityStamp = "SECSTAMP-0005",
                            StaffID = 5,
                            Surname = "Wilson",
                            TwoFactorEnabled = false,
                            UserName = "david.wilson"
                        },
                        new
                        {
                            Id = 6,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Available",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "sophia.martinez@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Sophia",
                            NormalizedUserName = "SOPHIA.MARTINEZ",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Floor Assistant",
                            SecurityStamp = "SECSTAMP-0006",
                            StaffID = 6,
                            Surname = "Martinez",
                            TwoFactorEnabled = false,
                            UserName = "sophia.martinez"
                        },
                        new
                        {
                            Id = 7,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Available",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "james.anderson@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "James",
                            NormalizedUserName = "JAMES.ANDERSON",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Security",
                            SecurityStamp = "SECSTAMP-0007",
                            StaffID = 7,
                            Surname = "Anderson",
                            TwoFactorEnabled = false,
                            UserName = "james.anderson"
                        },
                        new
                        {
                            Id = 8,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Busy",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "olivia.taylor@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Olivia",
                            NormalizedUserName = "OLIVIA.TAYLOR",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Floor Assistant",
                            SecurityStamp = "SECSTAMP-0008",
                            StaffID = 8,
                            Surname = "Taylor",
                            TwoFactorEnabled = false,
                            UserName = "olivia.taylor"
                        },
                        new
                        {
                            Id = 9,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Available",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "robert.thomas@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Robert",
                            NormalizedUserName = "ROBERT.THOMAS",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Floor Assistant",
                            SecurityStamp = "SECSTAMP-0009",
                            StaffID = 9,
                            Surname = "Thomas",
                            TwoFactorEnabled = false,
                            UserName = "robert.thomas"
                        },
                        new
                        {
                            Id = 10,
                            AccessFailedCount = 0,
                            AvailabilityStatus = "Available",
                            ConcurrencyStamp = "9C7D1A2B-1234-5678-90AB-CDEF12345678",
                            Email = "emma.harris@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Emma",
                            NormalizedUserName = "EMMA.HARRIS",
                            PasswordHash = "AQAAAAIAAYagAAAAEC0IoxMccfONAhn3G9Pz1Ckf4zATNne4fKdG7ykU6IoDzjiENNBkqN+xA2XBPxtiVQ==",
                            PhoneNumberConfirmed = false,
                            Role = "Customer Service",
                            SecurityStamp = "SECSTAMP-0010",
                            StaffID = 10,
                            Surname = "Harris",
                            TwoFactorEnabled = false,
                            UserName = "emma.harris"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ShopEase.Models.Staff", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ShopEase.Models.Staff", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopEase.Models.Staff", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ShopEase.Models.Staff", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopEase.Models.CustomerRequest", b =>
                {
                    b.HasOne("ShopEase.Models.Aisle", "Aisle")
                        .WithMany()
                        .HasForeignKey("AisleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopEase.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopEase.Models.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffID");

                    b.Navigation("Aisle");

                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("ShopEase.Models.Feedback", b =>
                {
                    b.HasOne("ShopEase.Models.CustomerRequest", "CustomerRequest")
                        .WithMany()
                        .HasForeignKey("RequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerRequest");
                });
#pragma warning restore 612, 618
        }
    }
}
