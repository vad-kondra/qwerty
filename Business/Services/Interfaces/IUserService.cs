using System.Collections.Generic;
using Data.Entities;

namespace Business.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        void Add(User user);
    }
}