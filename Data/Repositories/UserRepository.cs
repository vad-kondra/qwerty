using System;
using System.Collections.Generic;
using System.Linq;
using Data.Entities;
using Data.Repositories.Interfaces;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;

            var user = new User
            {
                RegistrationDate = DateTime.Now,
                LastActivityDate = DateTime.Now.AddSeconds(1)
            };
            _context.Add(user);
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            var users = _context.Users.ToList();

            return users;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}