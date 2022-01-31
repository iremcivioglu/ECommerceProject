////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Threading.Tasks;
////using ECommerce.Business.Abstract;
////using ECommerce.Business.Concrete;
////using ECommerce.Entities;
////using Microsoft.AspNetCore.Http;
////using Microsoft.AspNetCore.Mvc;

//namespace ECommerceProject.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        private IProductServices _productServices;
//        public ProductController()
//        {
//            _productServices = new ProductServices();
//        }
//        [HttpGet]
//        public IActionResult Get()
//        {
//            var products = _productServices.GetProducts();
//            return Ok(products);
//        }
//        //[HttpPost]
//        //public IActionResult Post([FromBody] Product product)
//        //{
//        //    var createProduct = _productServices.CreateProduct(product);
//        //    return Ok(createProduct);
//        //}
//        //[HttpDelete("{id}")]
//        //public IActionResult Delete(int id)
//        //{
//        //    if (_productServices.GetProductById(id) != null)
//        //    {
//        //        _productServices.DeleteProduct(id);
//        //        return Ok("Deleted Product");
//        //    }
//        //    return NotFound();
//        //}
//    //    [HttpPut]
//    //    public IActionResult Put([FromBody] Product product)
//    //    {
//    //        if (_productServices.GetProductById(product.ProductId) != null)
//    //        {
//    //            return Ok(_productServices.UpdateProduct(product));
//    //        }
//    //        return NotFound();
//    //    }
//    //}
//}
