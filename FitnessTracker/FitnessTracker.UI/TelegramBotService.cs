using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FitnessTracker.UI
{
    public class TelegramBotService : ITelegramBotService
    {
        private readonly TelegramBotClient _botClient;

        public TelegramBotService(string botToken)
        {
            _botClient = new TelegramBotClient(botToken);
        }

        public async Task StartReceivingAsync()
        {
            _botClient.StartReceiving(Update, Error);
            Console.ReadLine();
        }

        private async Task Update(ITelegramBotClient client, Update update, CancellationToken token)
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
