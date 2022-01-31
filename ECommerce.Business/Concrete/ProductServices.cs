//using ECommerce.Business.Abstract;
//using ECommerce.Entities.Model;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.Business.Concrete
//{
//    public class ProductServices : IProductServices
//    {
//        private IProductServices _productServices;
//        public Product CreateProduct(Product product)
//        {
//            return _productServices.CreateProduct(product);
//        }

//        public void DeleteProduct(int id)
//        {
//            _productServices.DeleteProduct(id);
//        }

//        public Product GetProductById(int id)
//        {
//            return _productServices.GetProductById(id);
//        }

//        public Product GetProductByName(string name)
//        {
//            return _productServices.GetProductByName(name);
//        }

//        public async Task<List<Product>> GetProducts()
//        {
//            return await _productServices.GetProducts();
//        }

//        public Product UpdateProduct(Product product)
//        {
//            return _productServices.UpdateProduct(product);
//        }
//    }
//}
