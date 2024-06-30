namespace BlazorPortfolio.Data.Models
{
    public class Experience
    {
        public int? ExperienceId { get; set; }
        public string? Title { get; set; }
        public string? Company { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public string? Languages { get; set; }
        public string? Framework { get; set; }

        public int EndYearDisplay
        {
            get
            {
                if(EndYear == null)
                {
                    return DateTime.Now.Year;
                }
                else
                {
                    return EndYear.Value;
                }
            } 
        }
    }
}
