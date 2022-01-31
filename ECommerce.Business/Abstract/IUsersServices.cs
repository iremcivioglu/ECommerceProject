using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IUsersServices
    {
        Task<Users> CreateUser(Users user);
        Task<IEnumerable<Users>> GetUsers();
        Task<Users> GetUserById(int id);
        Task<Users> GetUserByName(string name);
        Task UpdateUser(Users usersToUpdated, Users user);
        Task DeleteUser(Users user);

    }
}
