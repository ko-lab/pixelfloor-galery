﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20190312112625_ArtPieceId")]
    partial class ArtPieceId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("Entities.ArtData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArtPieceId");

                    b.Property<string>("Color");

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.HasKey("Id");

                    b.HasIndex("ArtPieceId");

                    b.ToTable("ArtDatas");
                });

            modelBuilder.Entity("Entities.ArtPiece", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Artist");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("ArtPieces");
                });

            modelBuilder.Entity("Entities.ArtData", b =>
                {
                    b.HasOne("Entities.ArtPiece")
                        .WithMany("Data")
                        .HasForeignKey("ArtPieceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
