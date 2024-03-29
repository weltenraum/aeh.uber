﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aeh.uber.Repository.EntityFramework;

namespace aeh.uber.Migrations
{
    [DbContext(typeof(UberContext))]
    [Migration("20190621220056_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.AboutMe", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutContent");

                    b.Property<string>("AboutHeading");

                    b.Property<string>("Cellphone");

                    b.Property<string>("Email");

                    b.Property<string>("Jobtitle");

                    b.Property<string>("LocationDescription");

                    b.Property<string>("LocationLink");

                    b.Property<string>("Messenger");

                    b.Property<string>("Name");

                    b.Property<string>("PicturePath");

                    b.Property<string>("Web");

                    b.HasKey("Id");

                    b.ToTable("AboutMes");
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutMeId");

                    b.Property<string>("Description");

                    b.Property<string>("From");

                    b.Property<string>("Heading");

                    b.Property<string>("KeytopicHeading");

                    b.Property<string>("Subheading");

                    b.Property<string>("TagHeading");

                    b.Property<string>("Until");

                    b.HasKey("Id");

                    b.HasIndex("AboutMeId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.Keytopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("ExperienceId");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.ToTable("Keytopics");
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("Level");

                    b.Property<int>("SkillGroupId");

                    b.HasKey("Id");

                    b.HasIndex("SkillGroupId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.SkillGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutMeId");

                    b.Property<string>("Description");

                    b.Property<bool>("SkillsContainingLevel");

                    b.HasKey("Id");

                    b.HasIndex("AboutMeId");

                    b.ToTable("SkillGroups");
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("ExperienceId");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.Experience", b =>
                {
                    b.HasOne("aeh.uber.Repository.EntityFramework.AboutMe", "AboutMe")
                        .WithMany("Experiences")
                        .HasForeignKey("AboutMeId");
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.Keytopic", b =>
                {
                    b.HasOne("aeh.uber.Repository.EntityFramework.Experience", "Experience")
                        .WithMany("Keytopics")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.Skill", b =>
                {
                    b.HasOne("aeh.uber.Repository.EntityFramework.SkillGroup", "SkillGroup")
                        .WithMany("Skills")
                        .HasForeignKey("SkillGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.SkillGroup", b =>
                {
                    b.HasOne("aeh.uber.Repository.EntityFramework.AboutMe", "AboutMe")
                        .WithMany("SkillGroups")
                        .HasForeignKey("AboutMeId");
                });

            modelBuilder.Entity("aeh.uber.Repository.EntityFramework.Tag", b =>
                {
                    b.HasOne("aeh.uber.Repository.EntityFramework.Experience", "Experience")
                        .WithMany("Tags")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
