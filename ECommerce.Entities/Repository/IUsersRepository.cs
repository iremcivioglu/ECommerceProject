using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Abstract
{
    public interface IUsersRepository : IRepository<Users>
    {
        //CRUD
        //Users CreateUser(Users user);
        //Task<List<Users>> GetUsers();
        //Users GetUserById(int id);
        Task<Users> GetUserByName(string name);
        //Users UpdateUser(Users user);
        //void DeleteUser(int id);

    }
}
