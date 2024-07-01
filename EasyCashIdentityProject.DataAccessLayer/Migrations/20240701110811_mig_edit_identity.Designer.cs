﻿// <auto-generated />
using System;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240701110811_mig_edit_identity")]
    partial class mig_edit_identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EasyCashIdentityProject.EntityLayer.Concrete.CostumerAccount", b =>
                {
                    b.Property<int>("CostumerAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CostumerAccountID"), 1L, 1);

                    b.Property<string>("BankBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CostumerAccountBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CostumerAccountCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CostumerAccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CostumerAccountID");

                    b.ToTable("CostumerAccounts");
                });

            modelBuilder.Entity("EasyCashIdentityProject.EntityLayer.Concrete.CostumerAccountProcess", b =>
                {
                    b.Property<int>("CostumerAccountProcessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CostumerAccountProcessID"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ProcessDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProcessType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CostumerAccountProcessID");

                    b.ToTable("CostumerAccountProcesses");
                });
#pragma warning restore 612, 618
        }
    }
}
