﻿// <auto-generated />
using System;
using Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations.Cafe
{
    [DbContext(typeof(CafeContext))]
    partial class CafeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Facility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("Rate");

                    b.Property<string>("WorkSchedule");

                    b.HasKey("Id");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("Entities.Models.GeoData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<Guid>("FacilityId");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("GeoData");
                });

            modelBuilder.Entity("Entities.Models.MediaData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FacilityId");

                    b.Property<string>("Path");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Entities.Models.UserFacility", b =>
                {
                    b.Property<Guid>("FacilityId");

                    b.Property<string>("UserId");

                    b.HasKey("FacilityId", "UserId");

                    b.ToTable("UserHasFacility");
                });

            modelBuilder.Entity("Entities.Models.GeoData", b =>
                {
                    b.HasOne("Entities.Models.Facility")
                        .WithMany("Geo")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Models.MediaData", b =>
                {
                    b.HasOne("Entities.Models.Facility")
                        .WithMany("Media")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Models.UserFacility", b =>
                {
                    b.HasOne("Entities.Models.Facility")
                        .WithMany("UserFacilities")
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
