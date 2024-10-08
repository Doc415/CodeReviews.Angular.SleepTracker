﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SleepTrackerAPI.Data;

#nullable disable

namespace SleepTrackerAPI.Migrations
{
    [DbContext(typeof(SleepContext))]
    [Migration("20240913181712_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SleepTrackerAPI.Models.SleepData", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SleepTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SleepLogs");

                    b.HasData(
                        new
                        {
                            Id = "febf2b3f-68f6-4fc4-9cd4-6d84334e0485",
                            Date = "2024-09-13",
                            SleepTime = 11780
                        },
                        new
                        {
                            Id = "586a0b2e-fe1e-4ea4-b752-39e1fbabd28d",
                            Date = "2024-09-12",
                            SleepTime = 6126
                        },
                        new
                        {
                            Id = "5c535dbd-d0c5-43bb-8a24-507938fa2e9f",
                            Date = "2024-09-11",
                            SleepTime = 10314
                        },
                        new
                        {
                            Id = "41977178-7d4a-42db-816c-a71af326f4cc",
                            Date = "2024-09-10",
                            SleepTime = 8237
                        },
                        new
                        {
                            Id = "d90fa6c3-10eb-40d6-b6fa-fbe97cfe9fcd",
                            Date = "2024-09-09",
                            SleepTime = 11654
                        },
                        new
                        {
                            Id = "d4188287-b518-4751-b695-1296bb0bdc0b",
                            Date = "2024-09-08",
                            SleepTime = 13824
                        },
                        new
                        {
                            Id = "772b91cf-4e05-4ebc-835e-4f5fef6d5a16",
                            Date = "2024-09-07",
                            SleepTime = 17898
                        },
                        new
                        {
                            Id = "79e7da68-c628-482d-b254-82b5866face1",
                            Date = "2024-09-06",
                            SleepTime = 17338
                        },
                        new
                        {
                            Id = "60870e47-ffaf-411e-bde9-2405568b2c2e",
                            Date = "2024-09-05",
                            SleepTime = 8156
                        },
                        new
                        {
                            Id = "0fb1e2ed-0a02-4f13-bc82-b7b42d0cb2fd",
                            Date = "2024-09-04",
                            SleepTime = 18276
                        },
                        new
                        {
                            Id = "9bee459c-969b-4b9b-b8f8-6266b0ef0623",
                            Date = "2024-09-03",
                            SleepTime = 16607
                        },
                        new
                        {
                            Id = "13e4295b-7e26-40ed-a2cb-626b0eb5ed4b",
                            Date = "2024-09-02",
                            SleepTime = 14528
                        },
                        new
                        {
                            Id = "76cd9fcb-e7fa-4292-8939-2482ae5b6009",
                            Date = "2024-09-01",
                            SleepTime = 14239
                        },
                        new
                        {
                            Id = "6db0de0e-c5cd-4548-ae59-08958f18a805",
                            Date = "2024-08-31",
                            SleepTime = 7757
                        },
                        new
                        {
                            Id = "d8cf77a6-f0e4-456c-a531-8716ae097a55",
                            Date = "2024-08-30",
                            SleepTime = 6860
                        },
                        new
                        {
                            Id = "24880a7b-2930-4b96-8ddc-b32e28fa1413",
                            Date = "2024-08-29",
                            SleepTime = 18051
                        },
                        new
                        {
                            Id = "01325aa5-5b17-4f73-a19d-884b4a160c4b",
                            Date = "2024-08-28",
                            SleepTime = 17952
                        },
                        new
                        {
                            Id = "99ccaa60-8992-4fc2-9972-dc88dc8c8eb6",
                            Date = "2024-08-27",
                            SleepTime = 11335
                        },
                        new
                        {
                            Id = "157c1e45-d352-4e2e-a29a-7296c76b62e1",
                            Date = "2024-08-26",
                            SleepTime = 13300
                        },
                        new
                        {
                            Id = "6f6c28da-bc21-4983-a7ed-1881dffa6205",
                            Date = "2024-08-25",
                            SleepTime = 9063
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
