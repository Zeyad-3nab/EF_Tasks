using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<HomeWork> HomeWorks { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFTaskD021;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
        .HasMany(e => e.courses)
        .WithMany(e => e.Students);

        }
    }
}
