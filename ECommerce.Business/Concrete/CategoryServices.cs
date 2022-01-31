using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.Entities;
using ECommerce.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class CategoryServices : ICategoryServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Category> CreateCategory(Category category)
        {
            await _unitOfWork.Categories.AddAsync(category);
            return category;
        }

        public async Task DeleteCategory(Category category)
        {
            _unitOfWork.Categories.Remove(category);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _unitOfWork.Categories.GetByIdAsync(id);
        }

        public async Task<Category> GetCategoryByName(string name)
        {
            return (Category)await _unitOfWork.Categories.GetCategoryByName(name);
        }

        public async Task UpdateCategory(Category categoryToUpdated, Category category)
        {
            categoryToUpdated.CategoryName = category.CategoryName;
            await _unitOfWork.CommitAsync();
        }
    }
}
