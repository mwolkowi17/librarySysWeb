﻿// <auto-generated />
using System;
using LibrarySysWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibrarySysWeb.Migrations
{
    [DbContext(typeof(LibrarySysWebContext))]
    partial class LibrarySysWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibrarySysWeb.Models.Book", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DateofRent")
                        .HasColumnType("int");

                    b.Property<int>("DateofReturn")
                        .HasColumnType("int");

                    b.Property<int?>("ReaderID")
                        .HasColumnType("int");

                    b.Property<int>("ReaderIDRent")
                        .HasColumnType("int");

                    b.Property<bool>("Rented")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("ReaderID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("LibrarySysWeb.Models.BookB", b =>
                {
                    b.Property<int>("BookBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Rented")
                        .HasColumnType("bit");

                    b.Property<int>("RentedbyReader")
                        .HasColumnType("int");

                    b.Property<string>("TitleB")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookBID");

                    b.ToTable("BookB");
                });

            modelBuilder.Entity("LibrarySysWeb.Models.Reader", b =>
                {
                    b.Property<int>("ReaderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReaderID");

                    b.ToTable("Reader");
                });

            modelBuilder.Entity("LibrarySysWeb.Models.Book", b =>
                {
                    b.HasOne("LibrarySysWeb.Models.Reader", null)
                        .WithMany("Books")
                        .HasForeignKey("ReaderID");
                });
#pragma warning restore 612, 618
        }
    }
}
