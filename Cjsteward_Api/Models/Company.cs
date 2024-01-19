using System.ComponentModel.DataAnnotations;

namespace Cjsteward_Api.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public int? StartYear { get; set; }
        public int? StartMonth { get; set; }
        public int? EndYear { get; set; }
        public int? EndMonth { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Title { get; set; }
        public ICollection<JobDescription>? JobDescriptions { get; } = new List<JobDescription>();

    }
}
