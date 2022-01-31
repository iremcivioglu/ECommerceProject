//using ECommerce.Entities;
//using ECommerce.Entities.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.DataAccess.Concrete
//{
//    public class ProductRepository : IRepository <Product>, IProductRepository
//    {
//        ECommerceDbText eCommerceDbText = new ECommerceDbText();
//        private ECommerceDbText _context;
//        public ProductRepository(ECommerceDbText context)
//        {
//            this._context = context;
//        }
//        public Product Create(Product variable)
//        {
//            eCommerceDbText.Add(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }

//        public void Delete(int id)
//        {
//            var deleteProduct = GetById(id);
//            eCommerceDbText.Products.Remove(deleteProduct);
//            eCommerceDbText.SaveChanges();
//        }

//        public async Task<List<Product>> GetAll()
//        {
//            return eCommerceDbText.Products.ToList();
//        }

//        public Product GetById(int id)
//        {
//            return eCommerceDbText.Products.Find(id);
//        }
//        public Product Update(Product variable)
//        {
//            eCommerceDbText.Products.Update(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }
//        public Product GetProductByName(string name)
//        {
//            return eCommerceDbText.Products.Where(w => w.ProductName == name).FirstOrDefault();
//        }

//        //public Product CreateProduct(Product product)
//        //{
//        //    eCommerceDbText.Add(product);
//        //    eCommerceDbText.SaveChanges();
//        //    return product;
//        //}

//        //public void DeleteProduct(int id)
//        //{
//        //    var deleteProduct= GetProductById(id);
//        //    eCommerceDbText.Products.Remove(deleteProduct);
//        //    eCommerceDbText.SaveChanges();
//        //}

//        //public Product GetProductById(int id)
//        //{
//        //    return eCommerceDbText.Products.Find(id);
//        //}
//        //public async Task<List<Product>> GetProducts()
//        //{
//        //    return eCommerceDbText.Products.ToList();
//        //}
//        //public Product UpdateProduct(Product product)
//        //{
//        //    eCommerceDbText.Products.Update(product);
//        //    eCommerceDbText.SaveChanges();
//        //    return product;
//        //}
//    }
//}
