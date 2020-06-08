﻿// <auto-generated />
using System;
using Marvel.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Marvel.Repository.Migrations
{
    [DbContext(typeof(MarvelContext))]
    partial class MarvelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Marvel.Domain.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<DateTime>("modified")
                        .HasColumnName("Modified")
                        .HasColumnType("datetime2")
                        .HasMaxLength(100);

                    b.Property<string>("name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("resourceURI")
                        .HasColumnName("ResourceURI")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Comic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("available")
                        .HasColumnName("Available")
                        .HasColumnType("int");

                    b.Property<string>("collectionURI")
                        .HasColumnName("CollectionURI")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Comic");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.ComicSummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComicId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("resourceURI")
                        .HasColumnName("ResourceURI")
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.HasKey("Id");

                    b.HasIndex("ComicId");

                    b.ToTable("ComicSummary");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("available")
                        .HasColumnName("Available")
                        .HasColumnType("int");

                    b.Property<string>("collectionURI")
                        .HasColumnName("CollectionURI")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Event");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.EventSummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("resourceURI")
                        .HasColumnName("ResourceURI")
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("EventSummary");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("extension")
                        .HasColumnName("Extension")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("path")
                        .HasColumnName("Path")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("available")
                        .HasColumnName("Available")
                        .HasColumnType("int");

                    b.Property<string>("collectionURI")
                        .HasColumnName("CollectionURI")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Serie");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.SerieSummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SerieId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("resourceURI")
                        .HasColumnName("ResourceURI")
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.HasKey("Id");

                    b.HasIndex("SerieId");

                    b.ToTable("SerieSummary");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("available")
                        .HasColumnName("Available")
                        .HasColumnType("int");

                    b.Property<string>("collectionURI")
                        .HasColumnName("CollectionURI")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Story");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.StorySummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StoryId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("resourceURI")
                        .HasColumnName("ResourceURI")
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.Property<string>("type")
                        .HasColumnName("Type")
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.HasKey("Id");

                    b.HasIndex("StoryId");

                    b.ToTable("StorySummary");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Url", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnName("Type")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("url")
                        .HasColumnName("Url")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Url");
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Comic", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Character", "Character")
                        .WithOne("comics")
                        .HasForeignKey("Marvel.Domain.Entities.Comic", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marvel.Domain.Entities.ComicSummary", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Comic", "Comic")
                        .WithMany("items")
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Event", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Character", "Character")
                        .WithOne("events")
                        .HasForeignKey("Marvel.Domain.Entities.Event", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marvel.Domain.Entities.EventSummary", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Event", "Event")
                        .WithMany("items")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Image", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Character", "Character")
                        .WithOne("thumbnail")
                        .HasForeignKey("Marvel.Domain.Entities.Image", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Serie", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Character", "Character")
                        .WithOne("series")
                        .HasForeignKey("Marvel.Domain.Entities.Serie", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marvel.Domain.Entities.SerieSummary", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Serie", "Serie")
                        .WithMany("items")
                        .HasForeignKey("SerieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Story", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Character", "Character")
                        .WithOne("stories")
                        .HasForeignKey("Marvel.Domain.Entities.Story", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marvel.Domain.Entities.StorySummary", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Story", "Story")
                        .WithMany("items")
                        .HasForeignKey("StoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Marvel.Domain.Entities.Url", b =>
                {
                    b.HasOne("Marvel.Domain.Entities.Character", "Character")
                        .WithMany("urls")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
