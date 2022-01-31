using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //Category CreateCategory(Category category);
        //Category GetCategoryById(int id);
        //Task<List<Category>> GetCategories();
        //void DeleteCategory(int id);
        //Category UpdateCategory(Category category);
        Task<IEnumerable<Category>> GetCategoryByName(string name);
    }
}
