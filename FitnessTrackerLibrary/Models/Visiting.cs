using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrackerLibrary.Models
{
    public class Visiting
    {
        public int Id { get; set; }
        public List<Workout> Workouts { get; set; } = new List<Workout>();
        public List<User> Users { get; set; } = new List<User>();
    }
}
