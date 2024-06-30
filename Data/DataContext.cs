using BlazorPortfolio.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Reflection.Metadata;
using static System.Net.WebRequestMethods;

namespace BlazorPortfolio.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Experience> Experience { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;TrustServerCertificate=True;Database=WebPortfolio;integrated security=true;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experience>().Property(p => p.Company).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Experience>().Property(p => p.Title).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Experience>().Property(p => p.Framework).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Experience>().Property(p => p.StartYear).IsRequired();
            modelBuilder.Entity<Experience>().Property(p => p.EndYear).IsRequired(false);

            modelBuilder.Entity<Experience>().HasData(
                new Experience() { ExperienceId=1, Title="Developer", Company="Radfords", Framework= "Windows Forms, Blazor, MAUI, Xamarin, WPF", Languages="C#, VB.net, SQL", StartYear=2022, EndYear=null },
                new Experience() { ExperienceId=2, Title="Junior Developer", Company="Radfords", Framework="Windows Forms, Xamarin, WPF", Languages="C#, VB.net, SQL", StartYear=2020, EndYear=2022 },
                new Experience() { ExperienceId=3, Title="Junior Developer", Company="Cucumber", Framework="", Languages="JavaScript", StartYear=2020, EndYear=2022 },
                new Experience() { ExperienceId=4, Title="Kitchen Hand", Company="The Raft", Framework= "N/A", Languages ="N/A", StartYear=2016, EndYear=2020 },
                new Experience() { ExperienceId=5, Title ="Paper Deliverer", Company="Bay of Plenty Times", Framework = "N/A", Languages = "N/A", StartYear=2009, EndYear=2013 }
                );



            modelBuilder.Entity<Qualification>().Property(p => p.Title).HasMaxLength(80).IsRequired();
            modelBuilder.Entity<Qualification>().Property(p => p.Location).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Qualification>().Property(p => p.Year).IsRequired();

            modelBuilder.Entity<Qualification>().HasData(
                new Qualification() { QualificationId=1, Title="NCEA Level 3", Location="Otumoetai College", Year=2016},
                new Qualification() { QualificationId=2, Title="Diploma in Applied Computing (Level 5 with distinction)", Location="Toi Ohomai", Year=2017},
                new Qualification() { QualificationId=3, Title="Skills for Entrepeneurs (Level 7)", Location="Toi Ohomai", Year=2018},
                new Qualification() { QualificationId=4, Title="Diploma in Software Development (Level 6)", Location="Toi Ohomai", Year=2018},
                new Qualification() { QualificationId=5, Title="Bachelors of Science, Major in Applied Computing", Location="University of Waikato", Year=2019}
                );



            modelBuilder.Entity<Project>().Property(p => p.Title).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.Description).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.Framework).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.Languages).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.GithubLink).HasMaxLength(100).IsRequired(false);

            modelBuilder.Entity<Project>().HasData(
                new Project() { ProjectId=1, Title="Blazor Portfolio", Description="Current web portfolio", Framework="Blazor", Languages="C#", GithubLink="https://github.com/Justiphi/BlazorPortfolio" },
                new Project() { ProjectId=2, Title="Web Portfolio", Description="previous web portfolio", Framework="ASP.net, ASP.net", Languages="C#, TypeScript", GithubLink="https://github.com/Justiphi/Travis-CV" },
                new Project() { ProjectId=3, Title="Tatenashi", Description="Discord Bot", Framework="Dotnet Core", Languages="C#", GithubLink="https://github.com/Justiphi/Tatenashi" },
                new Project() { ProjectId=4, Title="Pip Boy", Description="Code for Prop", Framework="PyGame", Languages="Python", GithubLink= "https://github.com/Justiphi/pipboy" },
                new Project() { ProjectId=5, Title="Project RIANTI", Description="Azure based Voice Assistant", Framework="WPF", Languages="C#", GithubLink= "https://github.com/Justiphi/Project-RIANTI" }
                );
        }
    }
}
