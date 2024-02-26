using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public ICollection<Workout> Workouts { get; set; }
        public ICollection<UserSchedule> UserSchedules { get; set; }

    }
}
