﻿// <auto-generated />
using Comp586ProjectServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Comp586ProjectServer.Migrations
{
    [DbContext(typeof(spa586Context))]
    [Migration("20201206223453_fixed-relationships")]
    partial class fixedrelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Comp586ProjectServer.Models.BoardGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DesignerId")
                        .HasColumnType("int")
                        .HasColumnName("DesignerId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DesignerId");

                    b.ToTable("BoardGame");
                });

            modelBuilder.Entity("Comp586ProjectServer.Models.Designer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Designer");
                });

            modelBuilder.Entity("Comp586ProjectServer.Models.BoardGame", b =>
                {
                    b.HasOne("Comp586ProjectServer.Models.Designer", "Designer")
                        .WithMany("BoardGames")
                        .HasForeignKey("DesignerId")
                        .HasConstraintName("FK_BoardGames_Designers")
                        .IsRequired();

                    b.Navigation("Designer");
                });

            modelBuilder.Entity("Comp586ProjectServer.Models.Designer", b =>
                {
                    b.Navigation("BoardGames");
                });
#pragma warning restore 612, 618
        }
    }
}
