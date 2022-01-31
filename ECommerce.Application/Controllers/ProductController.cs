﻿using ECommerce.Business.Abstract;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        protected const int NONE_QUERY_MAX_COUNT = 100;
        private ECommerceDbText _context;
        private IProductServices _productService;


        public ProductController(IProductServices productService, ECommerceDbText context)
        {
            _productService = productService;
            _context = context;
        }



        [HttpPost("GetProducts")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
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
                var productdata = (from tempcustomer in await _productService.GetProducts() select tempcustomer);
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    productdata = productdata.OrderBy(s => s.ProductName == (sortColumn + " " + sortColumnDirection));
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    productdata = productdata.Where(m => m.ProductName.Contains(searchValue)
                                                || m.ProductBrand.Contains(searchValue)
                                                || m.ProductPrice.ToString().Contains(searchValue));
                }
                recordsTotal = productdata.Count();
                var data = productdata.Skip(skip).Take(pageSize).ToList();
                var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
                return Ok(jsonData);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost("[action]")]
        public async Task<ActionResult> Create([FromBody] Product product)
        {
            var createProduct = await _productService.CreateProduct(product);
            return Ok(createProduct);
        }

        [HttpPost("[action]/{id}")]
        public async Task Delete(int id)
        {
            if (id != 0)
            {
                var deleteData = await _productService.GetProductById(id);

                await _productService.DeleteProduct(deleteData);
            }


        }
        [HttpPut]
        public IActionResult Put([FromBody] Product product)
        {
            if (_productService.GetProductById(product.ProductId) != null)
            {
                return Ok(_productService.UpdateProduct(product));
            }
            return NotFound();
        }
    }
}
//[HttpGet("GetAll")]
//public async Task<ActionResult<IEnumerable<Product>>> GetAll()
//{
//    var products = await _productService.GetAllProduct();
//    return Ok(products);
//}

//[HttpGet("GetAlla")]
//public async Task<ActionResult<IEnumerable<Product>>> GetAlla()
//{
//    var draw = Request.Form["draw"].FirstOrDefault();
//    var start = Request.Form["start"].FirstOrDefault();
//    var length = Request.Form["length"].FirstOrDefault();
//    var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
//    var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
//    var searchValue = Request.Form["search[value]"].FirstOrDefault();
//    int pageSize = length != null ? Convert.ToInt32(length) : 0;
//    int skip = start != null ? Convert.ToInt32(start) : 0;
//    int recordsTotal = 0;
//    var productdata = (from tempcustomer in await _productService.GetAllProduct() select tempcustomer);
//    if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
//    {
//        productdata = productdata.OrderBy(s => s.ProductName == (sortColumn + " " + sortColumnDirection));
//    }
//    if (!string.IsNullOrEmpty(searchValue))
//    {
//        productdata = productdata.Where(m => m.ProductName.Contains(searchValue)
//                                    || m.ProductDescription.Contains(searchValue)
//                                    || m.ProductPrice.ToString().Contains(searchValue));
//    }
//    recordsTotal = productdata.Count();
//    var data = productdata.Skip(skip).Take(pageSize).ToList();
//    var jsonData = new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
//    return Ok(jsonData);
//}

//[HttpPost("GetAll")]
//public async Task<Response<IEnumerable<Product>>> GetAll()
//{
//    var products = await _productService.GetAllProduct();
//    if (!products.Any())
//    {
//        return new Response<IEnumerable<Product>>().NoContent();
//    }
//    //List olsaydı .count parantez yazmamız dpğru değil.
//    return new Response<IEnumerable<Product>>().Ok(products.Count(), products);
//}


//protected IQueryable<TEntity> _query;
//protected IQueryable<TEntity> SearchByPredicate(Expression<TEntity, bool> predicate)
//{
//    if (predicate == null)
//    {
//        throw new ArgumentException("predicate,query");
//    }
//    sorgu sonucu istenilen değer çekilir
//    SearchByPredicateImp(predicate);

//}
//protected IQueryable<TEntity> CreateQueryable()
//{
//    if (_query != null)
//        return _query;
//    _query = null;//DB'ye eriş ve sorguyu çek 
//    return _query;

//}


//IQueryable<TEntity> SearchByPredicateImp(Expression<Func<TEntity, bool>> predicate)
//{
//    bool limit = predicate == null && _query == null;
//    CreateQueryable();

//    if (predicate != null) _query = _query.Where(predicate);
//    if (limit) _query=_query.Take(NONE_QUERY_MAX_COUNT)
//            return _query;
//}

//public async override Task<Response<Product>> GetListByFilter(CustomRequestModel input)
//{
//    //Gerekli filtreler alınıp gidilip işlem yapılması gerekmektedir
//    SearchByPredicate(input)
//        return;
