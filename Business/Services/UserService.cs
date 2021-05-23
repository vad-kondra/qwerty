using System.Collections.Generic;
using Business.Services.Interfaces;
using Data.Entities;
using Data.Repositories.Interfaces;

namespace Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public void Add(User user)
        {
            _userRepository.Add(user);
        }
    }
}