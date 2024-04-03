using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.UI
{
    public interface ITelegramBotService
    {
        Task StartReceivingAsync();
    }
}
