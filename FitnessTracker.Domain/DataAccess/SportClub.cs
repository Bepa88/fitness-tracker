using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.DataAccess
{
    public class SportClub : DbContext
    {
        public DbSet <User> Users { get; set; }
        public DbSet <Workout> Workouts { get; set; }
        public DbSet <Schedule> Schedules { get; set; }
        public DbSet <Visiting> Visitings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\DESKTOP-JQNEKV6;Database=SportClubDb;Trusted_Connection=True;");
        }

    }
}
