using ECommerce.DataAccess.Concrete;
using ECommerce.Entities;
using ECommerce.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ECommerceDbText context) : base(context) { }
        public async Task<IEnumerable<Category>> GetCategoryByName(string name)
        {
            return  (IEnumerable<Category>) ECommerceDbText.Categories.Where(w => w.CategoryName == name).SingleOrDefault();
        }
        private ECommerceDbText ECommerceDbText
        {
            get { return _eCommerceDbText as ECommerceDbText; }
        }
    }
}
