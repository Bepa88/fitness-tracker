using FitnessTracker.Domain.Models;
using FitnessTracker.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.BusinessLogic.Service
{
    internal class UserService : IUserService
    {
        private readonly IBaseRepository<User> _userRepository;

        public UserService(IBaseRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> AddAsync(User user)
        {
            return _userRepository.AddAsync(user);
        }

        public Task<User> GetById(int id)
        {
            return _userRepository.GetByIdAsync(id);
        }


    }
}
