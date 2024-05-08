using EFTask1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EFTask1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Taask> Taasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFTask1;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taask>().ToTable("NewTask");
            modelBuilder.Entity<Taask>().Property(b => b.Date).HasColumnName("Deadline");       //Search

        }
    }
}
