using ECommerce.DataAccess.Abstract;
using ECommerce.Entities;
using ECommerce.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Concrete
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(ECommerceDbText context) : base(context) { }
        private ECommerceDbText ECommerceDbText
        {
            get { return _eCommerceDbText as ECommerceDbText; }
        }

        public Task<Users> GetUserByName(string name)
        {
            return (Task<Users>)(IEnumerable<Users>)ECommerceDbText.Users.Where(w => w.UserName == name).SingleOrDefault();
        }
    }
}
