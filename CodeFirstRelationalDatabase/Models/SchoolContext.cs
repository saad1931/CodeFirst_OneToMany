using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelationalDatabase.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
       : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-CT235QF;Initial Catalog=StudentCFRD;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne<Grade>(s => s.Grade)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.CurrentGradeId);
        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
