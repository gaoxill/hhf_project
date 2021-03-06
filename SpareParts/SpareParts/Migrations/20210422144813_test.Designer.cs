// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpareParts.Data.AppDbContext;

namespace SpareParts.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210422144813_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpareParts.Data.Model.new_account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("new_account_id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("new_account_mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("new_account_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("new_account_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("new_account_role")
                        .HasColumnType("int");

                    b.Property<Guid>("new_department_id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("new_accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
