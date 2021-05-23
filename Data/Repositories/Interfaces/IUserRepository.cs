using System.Collections.Generic;
using Data.Entities;

namespace Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        void Add(User user);
    }
}