using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Concrete
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ECommerceDbText context) : base(context) { }
        private ECommerceDbText ECommerceDbText
        {
            get { return _eCommerceDbText as ECommerceDbText; }
        }
    }
}
