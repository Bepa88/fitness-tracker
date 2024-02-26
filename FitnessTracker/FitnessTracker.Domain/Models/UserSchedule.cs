using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.Models
{
    public class UserSchedule
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Schedule Schedule { get; set; }
        public bool IsCheckining { get; set; }


    }
}
