using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clinic2104API.data
{
    public class ClinicContext:IdentityDbContext<ApplicationUsers>
    {
        IConfiguration config;

        public ClinicContext(IConfiguration _config)
        {
            config = _config;
        }

        public DbSet<Country> countries { get; set; }

        public DbSet<Patient> patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("clinicConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
