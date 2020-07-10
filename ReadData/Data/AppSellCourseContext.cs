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

        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            modelBuilder.Entity<InstructorCourse>().HasKey(ci => new {ci.CourseId,ci.InstructorId});
        }

        public DbSet<Course> Course { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}