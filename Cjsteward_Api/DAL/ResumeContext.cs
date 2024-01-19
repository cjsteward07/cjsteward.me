using Cjsteward_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Cjsteward_Api.DAL
{
    public class ResumeContext : DbContext
    {
        public ResumeContext()
        {

        }
        
        public ResumeContext(DbContextOptions<ResumeContext> options) : base(options)
        {

        }

        public DbSet<AboutMe> AboutMe { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<JobDescription> JobDescription { get; set; }

        private static IConfigurationRoot _configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                _configuration = builder.Build();
                string cnstr = _configuration.GetConnectionString("Cjsteward_Db");
                optionsBuilder.UseSqlServer(cnstr);
            }
        }
    }
}
