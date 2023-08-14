﻿// <auto-generated />
using CineFile.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CineFile.Migrations
{
    [DbContext(typeof(CineFileContext))]
    [Migration("20230814232050_BugFixMigration")]
    partial class BugFixMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CineFile.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Genre = "Childrens",
                            Title = "Matilda"
                        },
                        new
                        {
                            MovieId = 2,
                            Genre = "Action",
                            Title = "Ironman"
                        },
                        new
                        {
                            MovieId = 3,
                            Genre = "Romance",
                            Title = "Edward Scissorhands"
                        },
                        new
                        {
                            MovieId = 4,
                            Genre = "Childrens",
                            Title = "Pippy Longstocking"
                        },
                        new
                        {
                            MovieId = 5,
                            Genre = "Action",
                            Title = "John Wick 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
