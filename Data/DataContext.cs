using BlazorPortfolio.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
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
        public class ConfigModel
        {
            public string? ConnectionString { get; set; } //connection string for future database plans
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string file;

            file = Path.Combine(AppContext.BaseDirectory, "_config.json");

            //ensures _config.json exists
            if (!System.IO.File.Exists(file))
            {
                throw new ApplicationException("Unable to locate the _config.json file.");
            }

            //loads configuration from _config.json file into memory
            var config = JsonConvert.DeserializeObject<ConfigModel>(System.IO.File.ReadAllText(file));

            if (config == null)
            {
                throw new ApplicationException("Could not parse config file");
            }

            optionsBuilder.UseSqlServer(config?.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experience>().Property(p => p.Company).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Experience>().Property(p => p.Title).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Experience>().Property(p => p.Framework).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Experience>().Property(p => p.StartYear).IsRequired();
            modelBuilder.Entity<Experience>().Property(p => p.EndYear).IsRequired(false);

            modelBuilder.Entity<Experience>().HasData(
                //new Experience() { ExperienceId = 1, Title = "Developer", Company = "Radfords", Framework = "Windows Forms, Xamarin, WPF, Blazor, MAUI", Languages = "C#, VB.net, SQL", StartYear = 2022, EndYear = null, SoftwareBased = true },
                //new Experience() { ExperienceId = 2, Title = "Junior Developer", Company = "Radfords", Framework = "Windows Forms, Xamarin, WPF", Languages = "C#, VB.net, SQL", StartYear = 2020, EndYear = 2022, SoftwareBased = true },
                new Experience() { ExperienceId = 6, Title = "Full Stack Developer", Company = "Radfords", Framework = "Windows Forms, Xamarin, WPF, Blazor, MAUI", Languages = "C#, VB.net, SQL", StartYear = 2020, EndYear = 2024, SoftwareBased = true },
                new Experience() { ExperienceId = 3, Title = "Developer", Company = "Cucumber", Framework = "jQuery", Languages = "JavaScript, HTML, CSS", StartYear = 2019, EndYear = 2019, SoftwareBased = true },
                new Experience() { ExperienceId = 4, Title = "Kitchen Hand", Company = "The Raft", Framework = "N/A", Languages = "N/A", StartYear = 2016, EndYear = 2020, SoftwareBased = false },
                new Experience() { ExperienceId = 5, Title = "Paper Deliverer", Company = "Bay of Plenty Times", Framework = "N/A", Languages = "N/A", StartYear = 2009, EndYear = 2013, SoftwareBased = false }
                );



            modelBuilder.Entity<Qualification>().Property(p => p.Title).HasMaxLength(80).IsRequired();
            modelBuilder.Entity<Qualification>().Property(p => p.Location).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Qualification>().Property(p => p.Year).IsRequired();

            modelBuilder.Entity<Qualification>().HasData(
                new Qualification() { QualificationId = 1, Title = "NCEA Level 3", Location = "Otumoetai College", Year = 2016 },
                new Qualification() { QualificationId = 2, Title = "Diploma in Applied Computing (Level 5 with distinction)", Location = "Toi Ohomai", Year = 2017 },
                new Qualification() { QualificationId = 3, Title = "Skills for Entrepeneurs (Level 7)", Location = "Toi Ohomai", Year = 2018 },
                new Qualification() { QualificationId = 4, Title = "Diploma in Software Development (Level 6)", Location = "Toi Ohomai", Year = 2018 },
                new Qualification() { QualificationId = 5, Title = "Bachelors of Science, Major in Applied Computing", Location = "University of Waikato", Year = 2019 },
                new Qualification() { QualificationId = 6, Title = "Certificate in Health and Safety Representation (Level 3)", Location = "EMA+", Year = 2020 },
                new Qualification() { QualificationId = 7, Title = "Foundational C# with Microsoft", Location = "FreeCodeCamp", Year = 2024 }
                );



            modelBuilder.Entity<Project>().Property(p => p.Title).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.Description).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.Framework).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.Languages).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Project>().Property(p => p.GithubLink).HasMaxLength(100).IsRequired(false);

            modelBuilder.Entity<Project>().HasData(
                new Project() { ProjectId = 1, Title = "Blazor Portfolio", Description = "Current web portfolio", Framework = "Blazor", Languages = "C#", GithubLink = "https://github.com/Justiphi/BlazorPortfolio" },
                new Project() { ProjectId = 2, Title = "Web Portfolio", Description = "Previous web portfolio", Framework = "ASP.net, React", Languages = "C#, TypeScript", GithubLink = "https://github.com/Justiphi/Travis-CV" },
                new Project() { ProjectId = 3, Title = "Tatenashi", Description = "Discord Bot", Framework = "Dotnet Core", Languages = "C#", GithubLink = "https://github.com/Justiphi/Tatenashi" },
                new Project() { ProjectId = 4, Title = "Pip Boy", Description = "Code for pip boy prop", Framework = "PyGame", Languages = "Python", GithubLink = "https://github.com/Justiphi/pipboy" },
                new Project() { ProjectId = 5, Title = "Project RIANTI", Description = "Azure based Voice Assistant (superseded by ADA-MKII)", Framework = "WPF, Avalonia", Languages = "C#", GithubLink = "https://github.com/Justiphi/Project-RIANTI" },
                new Project() { ProjectId = 6, Title = "Dice & Coins", Description = "MTG dice and coin generator used for tutoring programming", Framework = "MAUI", Languages = "C#", GithubLink = "https://github.com/Justiphi/DiceApp" },
                new Project() { ProjectId = 7, Title = "ADA-MKII", Description = "Voice Assistant", Framework = "MAUI", Languages = "C#", GithubLink = "https://github.com/Justiphi/ADA-MKII" },
                new Project() { ProjectId = 8, Title = "People Counter", Description = "Proof of concept Computer Vision application", Framework = "WPF", Languages = "C#", GithubLink = "https://github.com/Justiphi/peoplecounter" }
                );
        }
    }
}
