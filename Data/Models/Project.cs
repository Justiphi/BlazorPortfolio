namespace BlazorPortfolio.Data.Models
{
    public class Project
    {
        public int? ProjectId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Languages { get; set; }
        public string? Framework { get; set; }
        public string? GithubLink { get; set; }
    }
}
