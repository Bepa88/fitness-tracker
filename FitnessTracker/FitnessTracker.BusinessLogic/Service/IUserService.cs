using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTracker.Domain.Models;

namespace FitnessTracker.BusinessLogic.Service
{
    public interface IUserService
    {
        Task<User> GetById(int id);
        Task<User> AddAsync(User entity);
    }
}
