using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int WorkoutId { get; set; }
        //public List<Workout> Workouts { get; set; } = new List<Workout>();
    }
}
