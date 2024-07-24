using EngineerExam.Application.Repositories;
using EngineerExam.Persistance.Context;
using EngineerExam.Persistance.Repositories.Impelementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerExam.Persistance
{
    public static class PersistenceServiceRegistration
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {


            services.AddDbContext<EngineerExamContext>(options =>
                              options.UseSqlServer(configuration.GetConnectionString("SqlServercnn")));


            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ILevelRepository, LevelRepository>();
        }
    }
}
