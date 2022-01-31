using ECommerce.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IProductServices
    {
        Task<Product> CreateProduct(Product product);
        Task<Product> GetProductById(int id);
        Task<IEnumerable<Product>> GetProducts();
        Task DeleteProduct(int id);
        Task UpdateProduct(Product produtToUpdated, Product product);
        Task<Product> GetProductByName(string name);
    }
}
