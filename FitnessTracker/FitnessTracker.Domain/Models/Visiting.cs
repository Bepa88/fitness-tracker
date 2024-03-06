using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.Models
{
    public class Visiting
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WorkoutScheduleId { get; set; }
        public bool IsCheckining { get; set; }


    }
}
