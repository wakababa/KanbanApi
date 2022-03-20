﻿// <auto-generated />
using KanbanApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KanbanApi.Migrations
{
    [DbContext(typeof(KanbanApiContext))]
    partial class KanbanApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KanbanApi.Models.Column", b =>
                {
                    b.Property<int>("ColumnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ColumnId"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.HasKey("ColumnId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Column", (string)null);
                });

            modelBuilder.Entity("KanbanApi.Models.Issue", b =>
                {
                    b.Property<int>("IssueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IssueId"));

                    b.Property<int>("ColumnId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("IssueId");

                    b.HasIndex("ColumnId");

                    b.ToTable("Issue");
                });

            modelBuilder.Entity("KanbanApi.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Project", (string)null);
                });

            modelBuilder.Entity("KanbanApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("KanbanApi.Models.Column", b =>
                {
                    b.HasOne("KanbanApi.Models.Project", "Project")
                        .WithMany("Columns")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("KanbanApi.Models.Issue", b =>
                {
                    b.HasOne("KanbanApi.Models.Column", "Column")
                        .WithMany("Issues")
                        .HasForeignKey("ColumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Column");
                });

            modelBuilder.Entity("KanbanApi.Models.Project", b =>
                {
                    b.HasOne("KanbanApi.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("KanbanApi.Models.Column", b =>
                {
                    b.Navigation("Issues");
                });

            modelBuilder.Entity("KanbanApi.Models.Project", b =>
                {
                    b.Navigation("Columns");
                });

            modelBuilder.Entity("KanbanApi.Models.User", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
