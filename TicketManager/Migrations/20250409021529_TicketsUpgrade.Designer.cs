﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketManager.Context;

#nullable disable

namespace TicketManager.Migrations
{
    [DbContext(typeof(TicketManagerContext))]
    [Migration("20250409021529_TicketsUpgrade")]
    partial class TicketsUpgrade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("TicketManager.Domian.Employee", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateEdit")
                        .HasColumnType("TEXT");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<char>("situation")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TicketManager.Domian.Ticket", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("dateEdit")
                        .HasColumnType("TEXT");

                    b.Property<long>("employeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("quantity")
                        .HasColumnType("INTEGER");

                    b.Property<char>("situation")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
