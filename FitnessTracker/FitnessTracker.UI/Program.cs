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


namespace FitnessTracker.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IConfiguration Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddScoped(typeof(IBaseRepository<>),typeof(BaseRepository<>))
                .AddDbContext<SportClubDbContext>(
                options => options.UseSqlServer(connectionString))
                .BuildServiceProvider();


            var client = new TelegramBotClient("7079921487:AAG5Pfu-CVd8mM6LHiBwrMDj5G0OdGxdN2U");
            client.StartReceiving(Update, Error);
            Console.ReadLine();
        }

        async static Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                if (message.Text.ToLower().Contains("привіт"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Привіт");
                    return;
                }

            }
        }

        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
