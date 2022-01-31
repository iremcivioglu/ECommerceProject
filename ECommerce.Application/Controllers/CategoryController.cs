using ECommerce.Application.Helpers;
using ECommerce.Business.Abstract;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Application.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryServices _categoryServices;
        private readonly ECommerceDbText _context;
        public CategoryController(ICategoryServices categoryServices)
        {
            this._categoryServices = categoryServices;
        }

        [HttpGet("[action]")]
        public async Task<Response<IEnumerable<Category>>> GetAllData()
        {
            var category = await _categoryServices.GetCategories();
            return new Response<IEnumerable<Category>>().Ok(category.Count(), category);
        }
        [HttpPost("GetCategories")]
        public async Task<Response<IEnumerable<Category>>> GetCategories()
        {
            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;
                //var companies = await _companyServices.GetAllCompanies();
                var categoryData = (from tempcategory in await _categoryServices.GetCategories() select tempcategory);
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    categoryData = categoryData.OrderBy(s => s.CategoryName == (sortColumn + " " + sortColumnDirection));
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    categoryData = categoryData.Where(m => m.CategoryName.Contains(searchValue)
                                                || m.CategoryDescription.Contains(searchValue));
                    }
                recordsTotal = categoryData.Count();
                var data = categoryData.Skip(skip).Take(pageSize).ToList();
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                //return Ok(jsonData);
                return new Response<IEnumerable<Category>>().Ok(categoryData.Count(), categoryData);
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        [HttpPost("[action]")]
        public async Task<Response<Category>> Create(Category category)
        {

            try
            {
                if (category.CategoryId == 0)
                    await _categoryServices.CreateCategory(category);
                else await _categoryServices.UpdateCategory(category);
                return new Response<Category>().Ok(1, category);
            }
            catch (Exception ex)
            {
                return new Response<Category>().Error(1, category, ex.ToString());
            }

            //await _context.Customers.AddAsync(customer);
            // await _context.SaveChangesAsync();
            // return true;

        }

        [HttpPost("[action]/{id}")]
        public async Task Delete(int id)
        {
            if (id != 0)
            {
                var deleteData = await _categoryServices.GetCategoryById(id);

                await _categoryServices.DeleteCategory(deleteData);
            }


        }


    }
}
