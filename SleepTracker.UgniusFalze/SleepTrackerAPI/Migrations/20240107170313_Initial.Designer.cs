﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SleepTracker.UgniusFalze.Models;

#nullable disable

namespace SleepTracker.UgniusFalze.Migrations
{
    [DbContext(typeof(SleepRecordContext))]
    [Migration("20240107170313_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SleepTracker.UgniusFalze.Models.SleepRecord", b =>
                {
                    b.Property<int>("SleepRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SleepRecordId"));

                    b.Property<DateTime>("RecordEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("RecordStart")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("SleepRecordId");

                    b.ToTable("SleepRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
