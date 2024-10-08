﻿// <auto-generated />
using System;
using EventManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventManagementAPI.Migrations
{
    [DbContext(typeof(EventManagementContext))]
    [Migration("20240909103748_add1")]
    partial class add1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventManagementAPI.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                            Id = "e709ca82-8a7d-4a8e-8ad9-25d5a2b6fa7d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "17dda0d4-1d26-4a21-89d5-71742fc3deda",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEC5kuhCV3q/r44UYD/J8MAizmsW2RQBQ0bis5LPE+xNN6DheSjUAjtkn6J7OPLHQTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "298ee598-69bf-4014-959e-2fb181e84fa9",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("EventManagementAPI.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("181be618-605a-41f3-b1ef-b7130ae7c57e"),
                            CategoryType = "Music concerts"
                        },
                        new
                        {
                            CategoryId = new Guid("583c8ad7-05dc-40b4-aeea-c517c47f9507"),
                            CategoryType = "Seminars"
                        },
                        new
                        {
                            CategoryId = new Guid("fcb8989c-1568-40b3-a4f6-c9ec12954a59"),
                            CategoryType = "Workshops"
                        },
                        new
                        {
                            CategoryId = new Guid("a883f040-7b33-4fdc-9652-3566e1c02fba"),
                            CategoryType = "Exhibitions"
                        },
                        new
                        {
                            CategoryId = new Guid("098082f2-b7e1-46dd-bfae-e6e5e4961f65"),
                            CategoryType = "Festivals"
                        },
                        new
                        {
                            CategoryId = new Guid("dd65cb96-b4ad-401d-a95d-14a506c0c79b"),
                            CategoryType = "Music"
                        },
                        new
                        {
                            CategoryId = new Guid("c865b9bb-886c-4208-8ea4-4a479d3b0407"),
                            CategoryType = "Career Fairs"
                        },
                        new
                        {
                            CategoryId = new Guid("21423b8d-6457-49db-b09d-94f067223647"),
                            CategoryType = "Workshops"
                        });
                });

            modelBuilder.Entity("EventManagementAPI.Models.Event", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AgeLimit")
                        .HasColumnType("int");

                    b.Property<int>("CapacityAvailable")
                        .HasColumnType("int");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EconomyTicketCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("EventDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventDetails")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("EventDuration")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("EventPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("GeneralTicketCount")
                        .HasColumnType("int");

                    b.Property<Guid>("VenueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VipTicketCount")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("VenueId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventManagementAPI.Models.Payment", b =>
                {
                    b.Property<Guid>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NoOfTickets")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("RegistrationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("TicketTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PaymentId");

                    b.HasIndex("RegistrationId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("EventManagementAPI.Models.Registration", b =>
                {
                    b.Property<Guid>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("TicketTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RegistrationId");

                    b.HasIndex("EventId");

                    b.HasIndex("TicketTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("EventManagementAPI.Models.TicketType", b =>
                {
                    b.Property<Guid>("TicketTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Tickettype")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TicketTypeId");

                    b.ToTable("TicketTypes");

                    b.HasData(
                        new
                        {
                            TicketTypeId = new Guid("e0972fde-8415-4db0-a20e-c6fd9b44573e"),
                            Price = 0.0,
                            Tickettype = "General"
                        },
                        new
                        {
                            TicketTypeId = new Guid("b2726e35-db1d-43d5-aa53-039c33a092a1"),
                            Price = 0.0,
                            Tickettype = "VIP"
                        },
                        new
                        {
                            TicketTypeId = new Guid("7eb43497-4573-408b-8098-6c86be527677"),
                            Price = 0.0,
                            Tickettype = "Economic"
                        },
                        new
                        {
                            TicketTypeId = new Guid("e46688d3-2299-4023-98a7-a28cdb933604"),
                            Price = 0.0,
                            Tickettype = "General"
                        },
                        new
                        {
                            TicketTypeId = new Guid("00ba7f6f-6fe2-4407-bc69-868ead37b580"),
                            Price = 1000.0,
                            Tickettype = "VIP"
                        },
                        new
                        {
                            TicketTypeId = new Guid("5838cc5e-d73b-423a-92c8-541b10cd0385"),
                            Price = 500.0,
                            Tickettype = "Economy"
                        });
                });

            modelBuilder.Entity("EventManagementAPI.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EventManagementAPI.Models.Venue", b =>
                {
                    b.Property<Guid>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("VenueAddress1")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("VenueAddress2")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("VenueName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("VenueId");

                    b.ToTable("Venues");

                    b.HasData(
                        new
                        {
                            VenueId = new Guid("bcdfd5e4-5572-4c08-a4ee-c3d89abcf2a9"),
                            City = "New York",
                            MaxCapacity = 50,
                            Pincode = "10001",
                            State = "NY",
                            VenueAddress1 = "123 Main St",
                            VenueAddress2 = "",
                            VenueName = "Convention Center"
                        },
                        new
                        {
                            VenueId = new Guid("5efd1f9c-5e2c-4b1f-84a0-aecc7b3f0f03"),
                            City = "Los Angeles",
                            MaxCapacity = 200,
                            Pincode = "90001",
                            State = "CA",
                            VenueAddress1 = "456 Park Ave",
                            VenueAddress2 = "Near Central Park",
                            VenueName = "Open Grounds"
                        },
                        new
                        {
                            VenueId = new Guid("188a0e44-fd5f-4668-8685-d090063ea7c5"),
                            City = "Chicago",
                            MaxCapacity = 150,
                            Pincode = "60601",
                            State = "IL",
                            VenueAddress1 = "789 Broadway",
                            VenueAddress2 = "Suite 100",
                            VenueName = "Auditorium Hall"
                        },
                        new
                        {
                            VenueId = new Guid("51a49c80-d53f-4036-bd68-c722ce7d38ce"),
                            City = "New York",
                            MaxCapacity = 5000,
                            Pincode = "10001",
                            State = "NY",
                            VenueAddress1 = "123 Main St",
                            VenueAddress2 = "",
                            VenueName = "Convention Center"
                        },
                        new
                        {
                            VenueId = new Guid("bff2f017-8be7-49b7-9502-24823fd40241"),
                            City = "Los Angeles",
                            MaxCapacity = 2000,
                            Pincode = "90001",
                            State = "CA",
                            VenueAddress1 = "456 Park Ave",
                            VenueAddress2 = "Near Central Park",
                            VenueName = "Open Grounds"
                        },
                        new
                        {
                            VenueId = new Guid("1c52b2f5-c323-49da-83dd-24bcfe69a50f"),
                            City = "Chicago",
                            MaxCapacity = 1000,
                            Pincode = "60601",
                            State = "IL",
                            VenueAddress1 = "789 Broadway",
                            VenueAddress2 = "Suite 100",
                            VenueName = "Auditorium Hall"
                        });
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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "9498b13d-5afe-4201-b886-170d4406350f",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "59f2c5bc-d596-4fcd-a40f-607e325cc479",
                            Name = "user",
                            NormalizedName = "USER"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "e709ca82-8a7d-4a8e-8ad9-25d5a2b6fa7d",
                            RoleId = "9498b13d-5afe-4201-b886-170d4406350f"
                        });
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EventManagementAPI.Models.Event", b =>
                {
                    b.HasOne("EventManagementAPI.Models.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EventManagementAPI.Models.Venue", "Venue")
                        .WithMany()
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("EventManagementAPI.Models.Payment", b =>
                {
                    b.HasOne("EventManagementAPI.Models.Registration", "Registration")
                        .WithMany("Payments")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("EventManagementAPI.Models.Registration", b =>
                {
                    b.HasOne("EventManagementAPI.Models.Event", "Event")
                        .WithMany("Registrations")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventManagementAPI.Models.TicketType", "TicketType")
                        .WithMany()
                        .HasForeignKey("TicketTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventManagementAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("TicketType");

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
                    b.HasOne("EventManagementAPI.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EventManagementAPI.Data.ApplicationUser", null)
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

                    b.HasOne("EventManagementAPI.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EventManagementAPI.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventManagementAPI.Models.Category", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("EventManagementAPI.Models.Event", b =>
                {
                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("EventManagementAPI.Models.Registration", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
