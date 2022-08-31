﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2.Data;

namespace Project2.Migrations
{
    [DbContext(typeof(Project2Context))]
    partial class Project2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project2.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hero 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hero 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hero 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hero 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Hero 5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}