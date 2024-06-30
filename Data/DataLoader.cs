using BlazorPortfolio.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorPortfolio.Data
{
    public class DataLoader
    {
        public List<Qualification> GetQualifications()
        {
            List<Qualification> qualifications = new List<Qualification>();

            using(var db = new DataContext())
            {
                qualifications = db.Qualifications.OrderByDescending(x => x.Year).ToList();
            }

            return new List<Qualification>();
        }

        public List<Experience> GetExperience()
        {
            List<Experience> experience = new List<Experience>();

            using(var db = new DataContext())
            {
                experience = db.Experience.OrderByDescending(x => x.StartYear).ToList();
            }

            return new List<Experience>();
        }

        public List<Project> GetProjects()
        {
            List<Project> projects = new List<Project>();

            using(var db = new DataContext())
            {
                projects = db.Projects.OrderBy(x => x.Title).ToList();
            }

            return new List<Project>();
        }

    }
}
