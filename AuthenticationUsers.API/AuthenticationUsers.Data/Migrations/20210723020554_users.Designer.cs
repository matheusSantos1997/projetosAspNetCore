﻿// <auto-generated />
using System;
using AuthenticationUsers.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthenticationUsers.Data.Migrations
{
    [DbContext(typeof(AuthenticationDbContext))]
    [Migration("20210723020554_users")]
    partial class users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("AuthenticationUsers.Business.models.Post", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contents")
                        .HasColumnName("contents")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasColumnType("varchar(20)");

                    b.Property<long?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("AuthenticationUsers.Business.models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnName("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Role")
                        .HasColumnName("role")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AuthenticationUsers.Business.models.Post", b =>
                {
                    b.HasOne("AuthenticationUsers.Business.models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}