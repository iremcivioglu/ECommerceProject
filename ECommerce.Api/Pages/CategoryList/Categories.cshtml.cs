using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Api.Sevices;
using ECommerce.Business.Abstract;
using ECommerce.Entities;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;

namespace ECommerce.Api.Pages.CategoryList
{
    public class CategoriesModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepository;
        // private readonly ICategoryServices _categoryServices;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRazorRenderService _renderService;
        private readonly ILogger<CategoriesModel> _logger;

        public CategoriesModel(ILogger<CategoriesModel> logger, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IRazorRenderService renderService)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _renderService = renderService;
        }
        public IEnumerable<Category> Categories { get; set; }
        public void OnGet()
        {
        }
        public async Task<PartialViewResult> OnGetViewAllPartial()
        {
            Categories = await _categoryRepository.GetAllAsync();
            return new PartialViewResult
            {
                ViewName = "_ViewAll",
                ViewData = new ViewDataDictionary<IEnumerable<Category>>(ViewData, Categories)
            };
        }
        public async Task<JsonResult> OnGetCreateOrEditAsync(int id = 0)
        {
            if (id == 0)
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEdit", new Category()) });
            else
            {
                var thisCategory = await _categoryRepository.GetByIdAsync(id);
                return new JsonResult(new { isValid = true, html = await _renderService.ToStringAsync("_CreateOrEdit", thisCategory) });
            }
        }
        public async Task<JsonResult> OnPostCreateOrEditAsync(int id, Category category)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    await _categoryRepository.AddAsync(category);
                    await _unitOfWork.CommitAsync();
                }
                else
                {
                    category.CategoryId = id;
                    await _categoryRepository.UpdateAsync(category);
                    await _unitOfWork.CommitAsync();
                }
                Categories = await _categoryRepository.GetAllAsync();
                var html = await _renderService.ToStringAsync("_ViewAll", Categories);
                return new JsonResult(new { isValid = true, html });
            }
            else
            {
                var html = await _renderService.ToStringAsync("_CreateOrEdit", category);
                return new JsonResult(new { isValid = false, html });
            }
        }
        public async Task<JsonResult> OnPostDeleteAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            _categoryRepository.Remove(category);
            await _unitOfWork.CommitAsync();
            Categories = await _categoryRepository.GetAllAsync();
            var html = await _renderService.ToStringAsync("_ViewAll", Categories);
            return new JsonResult(new { isValid = true, html });
        }
    }
}
