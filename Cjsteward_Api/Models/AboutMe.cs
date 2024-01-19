namespace Cjsteward_Api.Models
{
    public class AboutMe
    {
        public int Id { get; set; }
        public string? MyPictureWeb {  get; set; }
        public byte[]? MyPictureStored { get; set; }
        public string? Name { get; set; }
        public string? Summary { get; set; }
        public string? Email { get; set; }
        public string? TechnicalSkills { get; set; }


    }
}
