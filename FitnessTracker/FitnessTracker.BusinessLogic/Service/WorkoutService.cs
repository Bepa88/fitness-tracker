using FitnessTracker.Domain.Models;
using FitnessTracker.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.BusinessLogic.Service
{
    public class WorkoutService
    {
        private readonly IBaseRepository<Workout> _workoutRepository;

        public WorkoutService(IBaseRepository<Workout> workoutRepository)
        {
            _workoutRepository = workoutRepository;
        }
        public Task<Workout> GetById(int id)
        {
            return _workoutRepository.GetByIdAsync(id);
        }

    }
}
