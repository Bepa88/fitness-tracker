using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.Models
{
    public class WorkoutSchedule
    {
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        public int VisitingId { get; set; }
        public Visiting Visiting { get; set; }
    }
}
