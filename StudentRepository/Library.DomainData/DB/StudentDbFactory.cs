using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DomainData.DB
{
    public class StudentDbFactory : IDesignTimeDbContextFactory<StudentDBContext>
    {
        public StudentDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var connectionstring = configuration.GetConnectionString("ManagerStudentDatabase");
            var optionBuilder = new DbContextOptionsBuilder<StudentDBContext>();
            optionBuilder.UseMySQL(connectionstring);
            return new StudentDBContext(optionBuilder.Options);
        }
    }
}
