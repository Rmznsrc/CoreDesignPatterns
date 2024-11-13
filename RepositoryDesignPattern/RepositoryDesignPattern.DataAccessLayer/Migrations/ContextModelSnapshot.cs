﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RepositoryDesignPattern.DataAccessLayer.Concrete;

namespace RepositoryDesignPattern.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("RepositoryDesignPattern.Entitylayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RepositoryDesignPattern.Entitylayer.Concrete.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("integer");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductStock")
                        .HasColumnType("integer");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("RepositoryDesignPattern.Entitylayer.Concrete.Product", b =>
                {
                    b.HasOne("RepositoryDesignPattern.Entitylayer.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RepositoryDesignPattern.Entitylayer.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
