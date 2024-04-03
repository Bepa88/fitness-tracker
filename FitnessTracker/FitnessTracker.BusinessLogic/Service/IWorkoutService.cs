using FitnessTracker.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.BusinessLogic.Service
{
    public interface IWorkoutService
    {
        Task<Workout> GetById(int id);
    }
}
