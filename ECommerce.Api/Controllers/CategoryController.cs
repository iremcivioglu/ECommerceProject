using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ECommerce.Api.Helpers;
using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.DataAccess;
using ECommerce.Entities;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryServices _categoryServices;
        private readonly ECommerceDbText _context;
        private readonly IConfiguration _configuration;
        private readonly GenericHelperMethods _genericHelperMethods;
        public CategoryController(ECommerceDbText context, IConfiguration configuration, GenericHelperMethods genericHelperMethods, ICategoryServices categoryServices)
        {
            _context = context;
            _configuration = configuration;
            _genericHelperMethods = genericHelperMethods;
            this._categoryServices = categoryServices;
        }
        //[HttpGet("[action]")]
        //public async Task<Response<IEnumerable<Category>>> GetCategories()

        //{
        //    var categories = await _categoryServices.GetCategories();
        //    if (!categories.Any())
        //    {
        //        return new Response<IEnumerable<Category>>().NoContent();
        //    }
        //    //List olsaydı .count parantez yazmamız dpğru değil.
        //    return new Response<IEnumerable<Category>>().Ok(categories.Count(), categories);
        //}
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(new { data = _context.Categories.ToList() });
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            if (result == null)
            {
                return new JsonResult(new { success = false, message = "Error While Deleting" });
            }
            _context.Categories.Remove(result);
            await _context.SaveChangesAsync();
            return new JsonResult(new { success = true, message = "Deleting Successfyl" });
        }
        //[HttpGet("[action]")]
        //public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        //{
        //    var categories = await _categoryServices.GetCategories();
        //    return Ok(categories);
        //}
        //[HttpPost("[action]")]
        //public async Task<bool> Create([FromBody] Category category)
        //{
        //    _context.Categories.Add(category);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}
        //[HttpPost]
        //public ActionResult Delete(int id)
        //{

        //    {
        //        using (ECommerceDbText db = new ECommerceDbText())
        //        {
        //            Category cat = db.Categories.Where(x => x.CategoryId == id).FirstOrDefault<Category>();
        //            db.Categories.Remove(cat);
        //            db.SaveChanges();
        //        }
        //        return new JsonResult(id);

        //    }
        //}
        //public IActionResult Delete([FromBody] Category category)
        //{
        //    this._context.Categories.Remove(category);
        //    this._context.SaveChanges();
        //    return Ok(category);
        //    //if (_context.Categories.Find(id) != null)
        //    //{
        //    //    var category = _context.Categories.Find(id);
        //    //    _context.Categories.Remove(category);
        //    //    _context.SaveChanges();
        //    //    return Ok("Deleted Customer");
        //    //}
        //    //return NotFound();
        //}
        //[HttpPost]
        //public ActionResult DeleteCategory(int id)
        //{
        //    var deleteCategory = _context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
        //    if (deleteCategory == null)
        //    {
        //        return new JsonResult(HttpStatusCode.BadRequest);
        //    }
        //    _context.Categories.Remove(deleteCategory);
        //    _context.SaveChanges();
        //    return null;
        //}
        //if (await _categoryServices.GetCategoryById(id) != null)
        //{
        //    _context.DeleteCategory(category);
        //    return Ok("Deleted Category");

        //}
        //return NotFound();
        //[HttpPut]
        //public IActionResult Put([FromBody] Category category)
        //{
        //    if (categoryServices.GetCategoryById(category.CategoryId) != null)
        //    {
        //        categoryServices.UpdateCategory(category);
        //        return Ok("Updated Category");

        //    }
        //    return NotFound();
        //}
        //[HttpGet]
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    //var entity = _context.GetCategoryById((int)id);
        //    var entity = _context.Categories.Where(x => x.CategoryId == id).FirstOrDefault<Category>();

        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }

        //    var model = new Category()
        //    {
        //        CategoryId = entity.CategoryId,
        //        CategoryName = entity.CategoryName,
        //        CategoryDescription = entity.CategoryDescription,
        //    };
        //    return Ok(model);
        //}

        //[HttpPost]
        //public IActionResult Edit(Category model)
        //{
        //    //var entity = _categoryServices.GetCategoryById(model.CategoryId);
        //    var entity = _context.Categories.Where(x => x.CategoryId == model.CategoryId).FirstOrDefault<Category>();
        //    if (entity == null)
        //    {
        //        return NotFound();
        //    }
        //    entity.CategoryId = model.CategoryId;
        //    entity.CategoryName = model.CategoryName;
        //    entity.CategoryDescription = model.CategoryDescription;

        //    _categoryServices.UpdateCategory(entity);

        //    return RedirectToAction("ProductList");
        //}
    }
    
}
