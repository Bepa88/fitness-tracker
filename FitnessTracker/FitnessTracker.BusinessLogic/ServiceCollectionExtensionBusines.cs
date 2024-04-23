using FitnessTracker.BusinessLogic.Service;
using FitnessTracker.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.BusinessLogic
{
    public static class ServiceCollectionExtensionBusines
    {
        public static IServiceCollection AddBusinessLogicService(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IScheduleService, ScheduleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVisitingService, VisitingService>();
            services.AddScoped<IWorkoutScheduleService, WorkoutScheduleService>();
            services.AddScoped<IWorkoutService, WorkoutService>();
            services.AddDomainService(connectionString);

            return services;
        }
    }
}
