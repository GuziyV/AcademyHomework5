﻿// <auto-generated />
using System;
using Data_Access_Layer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PresentationLayer.Migrations
{
    [DbContext(typeof(AirportContext))]
    [Migration("20180714090856_changeRelationManyToManyToOneToMant")]
    partial class changeRelationManyToManyToOneToMant
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data_Access_Layer.Models.Crew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PilotId");

                    b.HasKey("Id");

                    b.HasIndex("PilotId");

                    b.ToTable("Crews");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Departure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CrewId");

                    b.Property<int>("RaceNumber");

                    b.Property<DateTime>("TimeOfDeparture");

                    b.HasKey("Id");

                    b.HasIndex("CrewId");

                    b.ToTable("Departures");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Flight", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime");

                    b.Property<string>("DepartureFrom");

                    b.Property<string>("Destination");

                    b.Property<DateTime>("TimeOfDeparture");

                    b.HasKey("Number");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Experience");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Plane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PlaneTypeId");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("Id");

                    b.HasIndex("PlaneTypeId");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.PlaneType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LoadCapacity");

                    b.Property<string>("Model");

                    b.Property<int>("NumberOfSeats");

                    b.HasKey("Id");

                    b.ToTable("PlaneTypes");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Stewardess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrewId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.HasIndex("CrewId");

                    b.ToTable("Stewardesses");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FlightNumber");

                    b.Property<double>("Price");

                    b.Property<int>("RaceNumber");

                    b.HasKey("Id");

                    b.HasIndex("FlightNumber");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Crew", b =>
                {
                    b.HasOne("Data_Access_Layer.Models.Pilot", "Pilot")
                        .WithMany()
                        .HasForeignKey("PilotId");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Departure", b =>
                {
                    b.HasOne("Data_Access_Layer.Models.Crew", "Crew")
                        .WithMany()
                        .HasForeignKey("CrewId");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Plane", b =>
                {
                    b.HasOne("Data_Access_Layer.Models.PlaneType", "PlaneType")
                        .WithMany()
                        .HasForeignKey("PlaneTypeId");
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Stewardess", b =>
                {
                    b.HasOne("Data_Access_Layer.Models.Crew")
                        .WithMany("Stewardesses")
                        .HasForeignKey("CrewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Data_Access_Layer.Models.Ticket", b =>
                {
                    b.HasOne("Data_Access_Layer.Models.Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
