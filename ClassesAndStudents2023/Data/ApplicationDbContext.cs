using ClassesAndStudents2023.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassesAndStudents2023.Data
{
    public class ApplicationDbContext : DbContext
    {
        private ILogger<ApplicationDbContext> _logger;
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public ApplicationDbContext(DbContextOptions options, ILogger<ApplicationDbContext> logger) : base(options)
        {
            _logger = logger;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
