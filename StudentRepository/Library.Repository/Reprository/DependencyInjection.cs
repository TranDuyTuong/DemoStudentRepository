using Library.DomainData.DB;
using Library.DomainData.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository.Reprository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var connectionstring = configuration.GetConnectionString("ManagerStudentDatabase");

            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IClassRepository, ClassReprository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<StudentDBContext>(opt => opt
                .UseMySQL(connectionstring));
            return services;
        }
    }
}
