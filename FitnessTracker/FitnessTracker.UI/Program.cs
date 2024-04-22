using FitnessTracker.Domain.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FitnessTracker.Domain.Repository;
using FitnessTracker.BusinessLogic;
using FitnessTracker.Telegram;
using FitnessTracker.BusinessLogic.Service;


namespace FitnessTracker.UI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            IConfiguration Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            var token = Configuration.GetConnectionString("Token");

            var serviceProvider = new ServiceCollection()
                .AddLogging()
                //.AddScoped(typeof(IBaseRepository<>),typeof(BaseRepository<>))
                //.AddDbContext<SportClubDbContext>(
                //options => options.UseSqlServer(connectionString))
                .AddBotService(() => token)
                .AddBusinessLogicService(connectionString)
                .BuildServiceProvider();

            var botService = serviceProvider.GetService<IBotService>();
            await botService.Start();

        }
    }
}
