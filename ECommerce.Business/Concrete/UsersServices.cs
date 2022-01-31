using ECommerce.Business.Abstract;
using ECommerce.DataAccess;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class UsersServices : IUsersServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsersServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<Users> CreateUser(Users user)
        {
            await _unitOfWork.Users.AddAsync(user);
            return user;
        }

        public async Task DeleteUser(Users user)
        {
            _unitOfWork.Users.Remove(user);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Users> GetUserById(int id)
        {
            return await _unitOfWork.Users.GetByIdAsync(id);
        }

        public async Task<Users> GetUserByName(string name)
        {
            return (Users)await _unitOfWork.Users.GetUserByName(name);
        }

        public async Task<IEnumerable<Users>> GetUsers()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }

        public async Task UpdateUser(Users usersToUpdated, Users user)
        {
            usersToUpdated.UserName = user.UserName;
            await _unitOfWork.CommitAsync();
        }
    }
}
