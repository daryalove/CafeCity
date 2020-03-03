﻿// <auto-generated />
using System;
using Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations.Team
{
    [DbContext(typeof(TeamContext))]
    [Migration("20190904184258_FixKey")]
    partial class FixKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Badge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<byte[]>("FileContent");

                    b.Property<string>("FileType");

                    b.Property<Guid>("TeamId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("Entities.Models.Sliver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<byte[]>("FileContent");

                    b.Property<string>("FileType");

                    b.Property<string>("Rang");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Slivers");
                });

            modelBuilder.Entity("Entities.Models.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BadgeId");

                    b.Property<string>("City");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<double>("Latitude");

                    b.Property<string>("Leader");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.Property<string>("Section");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Entities.Models.UserBadge", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(450);

                    b.Property<Guid?>("BadgeId");

                    b.HasKey("UserId");

                    b.HasIndex("BadgeId");

                    b.ToTable("UserBadges");
                });

            modelBuilder.Entity("Entities.Models.UserSliver", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(450);

                    b.Property<Guid?>("SliverId");

                    b.HasKey("UserId");

                    b.HasIndex("SliverId");

                    b.ToTable("UserSlivers");
                });

            modelBuilder.Entity("Entities.Models.Badge", b =>
                {
                    b.HasOne("Entities.Models.Team", "Team")
                        .WithMany("Badges")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Entities.Models.UserBadge", b =>
                {
                    b.HasOne("Entities.Models.Badge", "Badge")
                        .WithMany("UserBadges")
                        .HasForeignKey("BadgeId");
                });

            modelBuilder.Entity("Entities.Models.UserSliver", b =>
                {
                    b.HasOne("Entities.Models.Sliver", "Sliver")
                        .WithMany("UserSlivers")
                        .HasForeignKey("SliverId");
                });
#pragma warning restore 612, 618
        }
    }
}
