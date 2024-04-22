using FitnessTracker.Domain.DataAccess;
using FitnessTracker.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain
{
    public static class ServiceCollectionExtensionDomain
    {
        public static IServiceCollection AddDomainService(this IServiceCollection services, string connectionString)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddDbContext<SportClubDbContext>(
                options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
