using Microsoft.EntityFrameworkCore;
using WebApplication3.Data.Entities;
namespace WebApplication3.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<SubjectMarks> SubjectMarks { get; set; }
    }

}
