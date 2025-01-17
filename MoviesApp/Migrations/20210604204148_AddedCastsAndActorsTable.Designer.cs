﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesApp.Data;

namespace MoviesApp.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20210604204148_AddedCastsAndActorsTable")]
    partial class AddedCastsAndActorsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviesApp.Models.Actor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CastID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CastID");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("MoviesApp.Models.Cast", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MovieID")
                        .IsUnique();

                    b.ToTable("Casts");
                });

            modelBuilder.Entity("MoviesApp.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoverURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MoviesApp.Models.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MovieID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("MoviesApp.Models.Actor", b =>
                {
                    b.HasOne("MoviesApp.Models.Cast", "Cast")
                        .WithMany("Actors")
                        .HasForeignKey("CastID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cast");
                });

            modelBuilder.Entity("MoviesApp.Models.Cast", b =>
                {
                    b.HasOne("MoviesApp.Models.Movie", "Movie")
                        .WithOne("Cast")
                        .HasForeignKey("MoviesApp.Models.Cast", "MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MoviesApp.Models.Review", b =>
                {
                    b.HasOne("MoviesApp.Models.Movie", "movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("movie");
                });

            modelBuilder.Entity("MoviesApp.Models.Cast", b =>
                {
                    b.Navigation("Actors");
                });

            modelBuilder.Entity("MoviesApp.Models.Movie", b =>
                {
                    b.Navigation("Cast");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
