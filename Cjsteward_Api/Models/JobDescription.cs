namespace Cjsteward_Api.Models
{
    public class JobDescription
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string? BulletPoint { get; set; }
        public Company Company { get; set; } = null!;
    }
}
