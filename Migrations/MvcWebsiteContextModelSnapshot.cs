﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcWebsite.Data;

namespace MvcWebsite.Migrations
{
    [DbContext(typeof(MvcWebsiteContext))]
    partial class MvcWebsiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcWebsite.Models.Classes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ClassPrice")
                        .HasColumnType("real");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("UserIsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}