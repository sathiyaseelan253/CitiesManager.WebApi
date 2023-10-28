﻿// <auto-generated />
using System;
using CitiesManager.WebApi.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CitiesManager.WebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CitiesManager.WebApi.Models.City", b =>
                {
                    b.Property<Guid>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityID");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityID = new Guid("057fb3c5-115f-4b00-8f35-cc5646d386d1"),
                            CityName = "Brazil"
                        },
                        new
                        {
                            CityID = new Guid("fc569e5d-75ea-4860-b7b0-a175b1672659"),
                            CityName = "London"
                        },
                        new
                        {
                            CityID = new Guid("06c704c5-5964-4a41-ab93-63e07ce7b8b8"),
                            CityName = "New Delhi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
