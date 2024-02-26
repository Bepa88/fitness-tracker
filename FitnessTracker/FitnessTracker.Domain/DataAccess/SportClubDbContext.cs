using FitnessTracker.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Domain.DataAccess
{
    public class SportClubDbContext : DbContext
    {
        public DbSet <User> Users  => Set<User> ();
        public DbSet <Workout> Workouts => Set<Workout> ();
        public DbSet <Schedule> Schedules => Set<Schedule>();
        public DbSet <UserSchedule> UserSchedules => Set<UserSchedule>();

        //public SportClubDbContext(DbContextOptions<SportClubDbContext> options) : base(options)
        //{ 
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\DESKTOP-JQNEKV6;Database=SportClubDb;Trusted_Connection=True;");
        }
    }
}
