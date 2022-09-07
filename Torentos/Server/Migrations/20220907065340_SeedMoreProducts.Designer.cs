﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Torentos.Server.Data;

#nullable disable

namespace Torentos.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220907065340_SeedMoreProducts")]
    partial class SeedMoreProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Torentos.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Games",
                            Url = "games"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Music",
                            Url = "music"
                        });
                });

            modelBuilder.Entity("Torentos.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2791),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "What is League of Legends?League of Legends is a team-based strategy game where two teams of five powerful champions face off to destroy the other's base. Choose from over 140 champions to make epic plays, secure kills, and take down towers as you battle your way to victory.",
                            Image = "images/LeagueOfLegends.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Price = 9.99m,
                            Title = "League Of Legends",
                            Type = "images/VideoGame.png"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2831),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Cars 2 is an animated movie that explains the life of all cars.",
                            Image = "images/Cars2.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Price = 5.40m,
                            Title = "Cars 2",
                            Type = "images/Movie.png"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2835),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Back in Black is the seventh studio album by Australian rock band AC/DC. It was released on 25 July 1980 by Albert Productions and Atlantic Records. It is the band's first album to feature lead singer Brian Johnson, following the death of previous lead singer Bon Scott..",
                            Image = "images/ACDC.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Price = 2.30m,
                            Title = "AC-DC",
                            Type = "images/Music.png"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2837),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "As a massively multiplayer online game, World of Warcraft enables thousands of players from across the globe to come together online – undertaking grand quests and heroic exploits in a land of fantastic adventure",
                            Image = "images/worldofwarcraft.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Price = 5.50m,
                            Title = "World Of Warcraft",
                            Type = "images/VideoGame.png"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2839),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "After thirty years, Maverick is still pushing the envelope as a top naval aviator, but must confront ghosts of his past when he leads TOP GUN's elite graduates on a mission that demands the ultimate sacrifice from those chosen to fly it.",
                            Image = "images/TopGunMaverick.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Price = 2.50m,
                            Title = "Top Gun: Maverick",
                            Type = "images/Movie.png"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 9, 7, 9, 53, 40, 173, DateTimeKind.Local).AddTicks(2842),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "You know the album, the one with the zipper on it. Sticky Fingers represents the best-selling Rolling Stones album of all time as it celebrated its 50th anniversary in 2021.",
                            Image = "images/RollingStones.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Price = 3.50m,
                            Title = "The Rolling Stones - Sticky Fingers",
                            Type = "images/Music.png"
                        });
                });

            modelBuilder.Entity("Torentos.Shared.Product", b =>
                {
                    b.HasOne("Torentos.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}