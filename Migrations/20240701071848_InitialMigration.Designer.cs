﻿// <auto-generated />
using System;
using BlazorPortfolio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorPortfolio.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240701071848_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorPortfolio.Data.Models.Experience", b =>
                {
                    b.Property<int?>("ExperienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ExperienceId"));

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("EndYear")
                        .HasColumnType("int");

                    b.Property<string>("Framework")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Languages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StartYear")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ExperienceId");

                    b.ToTable("Experience");

                    b.HasData(
                        new
                        {
                            ExperienceId = 1,
                            Company = "Radfords",
                            Framework = "Windows Forms, Blazor, MAUI, Xamarin, WPF",
                            Languages = "C#, VB.net, SQL",
                            StartYear = 2022,
                            Title = "Developer"
                        },
                        new
                        {
                            ExperienceId = 2,
                            Company = "Radfords",
                            EndYear = 2022,
                            Framework = "Windows Forms, Xamarin, WPF",
                            Languages = "C#, VB.net, SQL",
                            StartYear = 2020,
                            Title = "Junior Developer"
                        },
                        new
                        {
                            ExperienceId = 3,
                            Company = "Cucumber",
                            EndYear = 2019,
                            Framework = "",
                            Languages = "JavaScript",
                            StartYear = 2019,
                            Title = "Junior Developer"
                        },
                        new
                        {
                            ExperienceId = 4,
                            Company = "The Raft",
                            EndYear = 2020,
                            Framework = "N/A",
                            Languages = "N/A",
                            StartYear = 2016,
                            Title = "Kitchen Hand"
                        },
                        new
                        {
                            ExperienceId = 5,
                            Company = "Bay of Plenty Times",
                            EndYear = 2013,
                            Framework = "N/A",
                            Languages = "N/A",
                            StartYear = 2009,
                            Title = "Paper Deliverer"
                        });
                });

            modelBuilder.Entity("BlazorPortfolio.Data.Models.Project", b =>
                {
                    b.Property<int?>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ProjectId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Framework")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GithubLink")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Languages")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Description = "Current web portfolio",
                            Framework = "Blazor",
                            GithubLink = "https://github.com/Justiphi/BlazorPortfolio",
                            Languages = "C#",
                            Title = "Blazor Portfolio"
                        },
                        new
                        {
                            ProjectId = 2,
                            Description = "previous web portfolio",
                            Framework = "ASP.net, ASP.net",
                            GithubLink = "https://github.com/Justiphi/Travis-CV",
                            Languages = "C#, TypeScript",
                            Title = "Web Portfolio"
                        },
                        new
                        {
                            ProjectId = 3,
                            Description = "Discord Bot",
                            Framework = "Dotnet Core",
                            GithubLink = "https://github.com/Justiphi/Tatenashi",
                            Languages = "C#",
                            Title = "Tatenashi"
                        },
                        new
                        {
                            ProjectId = 4,
                            Description = "Code for Prop",
                            Framework = "PyGame",
                            GithubLink = "https://github.com/Justiphi/pipboy",
                            Languages = "Python",
                            Title = "Pip Boy"
                        },
                        new
                        {
                            ProjectId = 5,
                            Description = "Azure based Voice Assistant",
                            Framework = "WPF",
                            GithubLink = "https://github.com/Justiphi/Project-RIANTI",
                            Languages = "C#",
                            Title = "Project RIANTI"
                        });
                });

            modelBuilder.Entity("BlazorPortfolio.Data.Models.Qualification", b =>
                {
                    b.Property<int?>("QualificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("QualificationId"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("QualificationId");

                    b.ToTable("Qualifications");

                    b.HasData(
                        new
                        {
                            QualificationId = 1,
                            Location = "Otumoetai College",
                            Title = "NCEA Level 3",
                            Year = 2016
                        },
                        new
                        {
                            QualificationId = 2,
                            Location = "Toi Ohomai",
                            Title = "Diploma in Applied Computing (Level 5 with distinction)",
                            Year = 2017
                        },
                        new
                        {
                            QualificationId = 3,
                            Location = "Toi Ohomai",
                            Title = "Skills for Entrepeneurs (Level 7)",
                            Year = 2018
                        },
                        new
                        {
                            QualificationId = 4,
                            Location = "Toi Ohomai",
                            Title = "Diploma in Software Development (Level 6)",
                            Year = 2018
                        },
                        new
                        {
                            QualificationId = 5,
                            Location = "University of Waikato",
                            Title = "Bachelors of Science, Major in Applied Computing",
                            Year = 2019
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
