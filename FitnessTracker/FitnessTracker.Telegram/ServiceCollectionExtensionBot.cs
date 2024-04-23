using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTracker.BusinessLogic.Service;
using Microsoft.Extensions.DependencyInjection;

namespace FitnessTracker.Telegram
{
    public static class ServiceCollectionExtensionBot
    {
        public static IServiceCollection AddBotService(this IServiceCollection services, Func<string> token)
        {
            services.AddScoped<IBotService, BotService>(provider =>
            {
                // Resolve dependencies from the DI container
                var userService = provider.GetRequiredService<IUserService>();
                var workoutService = provider.GetRequiredService<IWorkoutService>();
                var workoutScheduleService = provider.GetRequiredService<IWorkoutScheduleService>();
                var scheduleService = provider.GetRequiredService<IScheduleService>();
                var visitingService = provider.GetRequiredService<IVisitingService>();

                // Create an instance of BotService with the required dependencies
                return new BotService(botToken, userService, workoutService, workoutScheduleService, scheduleService, visitingService);
            });
            return services;
        }
    }
}
