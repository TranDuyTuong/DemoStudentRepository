using Library.DomainData.Configuration;
using Library.DomainData.Extestion;
using Library.TableData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.DB
{
    public class StudentDBContext: DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IStudentConfiguration());
            modelBuilder.ApplyConfiguration(new IClassConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<T_Student> T_Students { get; set; }
        public DbSet<T_Class> T_Classes { get; set; }
    }
}
