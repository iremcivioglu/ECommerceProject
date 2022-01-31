using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DataAccess;
using ECommerce.Entities.Model;

namespace ECommerce.Entities
{
    public interface IProductRepository : IRepository<Product>
    {
        //Product CreateProduct(Product product);
        //Product GetProductById(int id);
        //Task<List<Product>> GetProducts();
        //void DeleteProduct(int id);
        //Product UpdateProduct(Product product);
        Task<Product> GetProductByName(string name);
    }
}
