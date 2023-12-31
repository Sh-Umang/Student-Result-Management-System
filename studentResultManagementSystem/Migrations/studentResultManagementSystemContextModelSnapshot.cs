﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using studentResultManagementSystem.Data;

#nullable disable

namespace studentResultManagementSystem.Migrations
{
    [DbContext(typeof(studentResultManagementSystemContext))]
    partial class studentResultManagementSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentResultManagement.Models.Result", b =>
                {
                    b.Property<string>("std_id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(0);

                    b.Property<string>("sub_id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.Property<int>("assignment_marks")
                        .HasColumnType("int");

                    b.Property<int>("practical_marks")
                        .HasColumnType("int");

                    b.Property<string>("result_obt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("theory_marks")
                        .HasColumnType("int");

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.HasKey("std_id", "sub_id");

                    b.HasIndex("sub_id");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("StudentResultManagement.Models.Student", b =>
                {
                    b.Property<string>("symbol_no")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_no")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("symbol_no");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentResultManagement.Models.Subject", b =>
                {
                    b.Property<string>("subject_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("subject_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("subject_id");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("StudentResultManagement.Models.Result", b =>
                {
                    b.HasOne("StudentResultManagement.Models.Student", "student")
                        .WithMany()
                        .HasForeignKey("std_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentResultManagement.Models.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("sub_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student");

                    b.Navigation("subject");
                });
#pragma warning restore 612, 618
        }
    }
}
