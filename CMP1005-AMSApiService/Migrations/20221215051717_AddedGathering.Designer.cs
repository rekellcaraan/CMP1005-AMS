// <auto-generated />
using System;
using CMP1005_AMSApiService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMP1005_AMSApiService.Migrations
{
    [DbContext(typeof(AMSDBContext))]
    [Migration("20221215051717_AddedGathering")]
    partial class AddedGathering
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("AMSLibrary.Models.Attendance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("GatheringDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("GatheringLabel")
                        .HasColumnType("TEXT");

                    b.Property<string>("GatheringSchedule")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("AMSLibrary.Models.Attendee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AttendanceId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeOfEntry")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AttendanceId");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("AMSLibrary.Models.Gathering", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AttendeesCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("GatheringDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("GatheringLabel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Gatherings");
                });

            modelBuilder.Entity("AMSLibrary.Models.Attendee", b =>
                {
                    b.HasOne("AMSLibrary.Models.Attendance", null)
                        .WithMany("Attendees")
                        .HasForeignKey("AttendanceId");
                });

            modelBuilder.Entity("AMSLibrary.Models.Attendance", b =>
                {
                    b.Navigation("Attendees");
                });
#pragma warning restore 612, 618
        }
    }
}
