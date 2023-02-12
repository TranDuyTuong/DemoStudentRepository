using Library.TableData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.Extestion
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_Student>().HasData(
                new T_Student() { IDStudent = 1, NameStudent = "Marry", IDClassStudent = 1 },
                new T_Student() { IDStudent = 2, NameStudent = "Jsen", IDClassStudent = 2 },
                new T_Student() { IDStudent = 3, NameStudent = "Cherry", IDClassStudent = 3 },
                new T_Student() { IDStudent = 4, NameStudent = "Leon", IDClassStudent = 4 },
                new T_Student() { IDStudent = 5, NameStudent = "Messis", IDClassStudent = 1 }
                );
            modelBuilder.Entity<T_Class>().HasData(
                new T_Class() { IDClass = 1, NameClass = "11B" },
                new T_Class() { IDClass = 2, NameClass = "10B" },
                new T_Class() { IDClass = 3, NameClass = "12B" },
                new T_Class() { IDClass = 4, NameClass = "11A" }
                );
        }
    }
}
