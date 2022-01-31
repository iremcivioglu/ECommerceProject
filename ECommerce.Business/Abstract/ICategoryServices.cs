using ECommerce.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface ICategoryServices
    {
        Task<Category> CreateCategory(Category category);
        Task UpdateCategory(Category categoryToUpdated, Category category);
        Task<Category> GetCategoryById(int id);
        Task<IEnumerable<Category>> GetCategories();
        Task <Category> GetCategoryByName(string name);
        Task DeleteCategory(Category category);

    }
}
