using BlazorPortfolio.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorPortfolio.Data
{
    public static class DataLoader
    {
        public static List<Qualification> GetQualifications()
        {
            List<Qualification> qualifications = new List<Qualification>();

            using(var db = new DataContext())
            {
                qualifications = db.Qualifications.OrderByDescending(x => x.Year).ToList();
            }

            return qualifications;
        }

        public static List<Experience> GetExperience(bool includeAll = false)
        {
            List<Experience> experienceList;

            using(var db = new DataContext())
            {
                IQueryable<Experience> experience = db.Experience.OrderByDescending(x => x.StartYear);

                if (!includeAll)
                {
                    experience = experience.Where(x => x.SoftwareBased == true);
                }

                experienceList = experience.ToList();
            }

            return experienceList;
        }

        public static List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();

            using(var db = new DataContext())
            {
                projects = db.Projects.OrderBy(x => x.Title).ToList();
            }

            return projects;
        }

    }
}
