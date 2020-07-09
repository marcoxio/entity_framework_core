using Microsoft.EntityFrameworkCore;
using ReadData.Entities;

namespace ReadData.Data
{
    public class AppSellCourseContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=CoursesOnline;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Course> Course { get; set; }
    }
}