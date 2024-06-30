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
            modelBuilder.Entity<Experience>().HasData(
                new Experience() { Title="Developer", Company="Radfords", Framework= "Windows Forms, Blazor, MAUI, Xamarin, WPF", Languages="C#, VB.net, SQL", StartYear=2022, EndYear=null },
                new Experience() { Title="Junior Developer", Company="Radfords", Framework="Windows Forms, Xamarin, WPF", Languages="C#, VB.net, SQL", StartYear=2020, EndYear=2022 },
                new Experience() { Title="Junior Developer", Company="Cucumber", Languages="JavaScript", StartYear=2020, EndYear=2022 },
                new Experience() { Title="Kitchen Hand", Company="The Raft", Framework= "N/A", Languages ="N/A", StartYear=2016, EndYear=2020 },
                new Experience() { Title="Paper Deliverer", Company="Bay of Plenty Times", Framework = "N/A", Languages = "N/A", StartYear=2009, EndYear=2013 }
                );

            modelBuilder.Entity<Qualification>().HasData(
                new Qualification() { Title="NCEA Level 3", Location="Otumoetai College", Year=2016},
                new Qualification() { Title="Diploma in Applied Computing (Level 5 with distinction)", Location="Toi Ohomai", Year=2017},
                new Qualification() { Title="Skills for Entrepeneurs (Level 7)", Location="Toi Ohomai", Year=2018},
                new Qualification() { Title="Diploma in Software Development (Level 6)", Location="Toi Ohomai", Year=2018},
                new Qualification() { Title="Bachelors of Science, Major in Applied Computing", Location="University of Waikato", Year=2019}
                );
            modelBuilder.Entity<Project>().HasData(
                new Project() { Title="Blazor Portfolio", Description="Current web portfolio", Framework="Blazor", Languages="C#", GithubLink="https://github.com/Justiphi/BlazorPortfolio" },
                new Project() { Title="Web Portfolio", Description="previous web portfolio", Framework="ASP.net, ASP.net", Languages="C#, TypeScript", GithubLink="https://github.com/Justiphi/Travis-CV" },
                new Project() { Title="Tatenashi", Description="Discord Bot", Framework="Dotnet Core", Languages="C#", GithubLink="https://github.com/Justiphi/Tatenashi" },
                new Project() { Title="Pip Boy", Description="Code for Prop", Framework="PyGame", Languages="Python", GithubLink= "https://github.com/Justiphi/pipboy" },
                new Project() { Title="Project RIANTI", Description="Azure based Voice Assistant", Framework="WPF", Languages="C#", GithubLink= "https://github.com/Justiphi/Project-RIANTI" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
