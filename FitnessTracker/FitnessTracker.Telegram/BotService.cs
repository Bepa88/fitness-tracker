using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Args;
using FitnessTracker.BusinessLogic.Service;
using FitnessTracker.Domain.Models;
using Telegram.Bot.Types.ReplyMarkups;
using User = FitnessTracker.Domain.Models.User;

namespace FitnessTracker.Telegram
{
    public class BotService : IBotService
    {
        private readonly TelegramBotClient _botClient;
        private readonly IUserService _userService;
        private readonly IWorkoutService _workoutService;
        private readonly IWorkoutScheduleService _workoutScheduleService;
        private readonly IScheduleService _scheduleService;
        private readonly IVisitingService _visitingService;

        public BotService(string botToken, IUserService userService, IWorkoutService workoutService, IWorkoutScheduleService workoutScheduleService, IScheduleService scheduleService, IVisitingService visitingService)
        {
            _botClient = new TelegramBotClient(botToken);
            _userService = userService;
            _workoutService = workoutService;
            _workoutScheduleService = workoutScheduleService;
            _scheduleService = scheduleService;
            _visitingService = visitingService;
        }

        public async Task Start()
        {
            _botClient.StartReceiving(Update, Error);
            await Task.Delay(-1);
        }


        private async Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message != null && message.Text != null)
            {
                if (message.Text.ToLower() == "start")
                {
                    var userId = message.From.Id;
                    // Check if the user is present in the system
                    User user = await _userService.GetById((int)userId);
                    if (user == null)
                    {
                        _userService.AddAsync(user);
                    }
                    else
                    {

                    }
                }
            }
            //var message = update.Message;
            //if (message != null && message.Text != null)
            //{
            //    if (message.Text.ToLower().Contains("привіт"))
            //    {
            //        await client.SendTextMessageAsync(message.Chat.Id, "Привіт");
            //        return;
            //    }

            //}
        }

        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            Console.WriteLine($"Error: {exception.Message}");
            return Task.CompletedTask;
        }
    }
}
