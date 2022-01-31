using ECommerce.DataAccess;
using ECommerce.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        ICategoryRepository Categories { get; }
        //IProductRepository Products { get; }
        //IOrderRepository Orders { get; }
        //IPaymentRepository Payments { get; }
        //IShipmentRepository Shipments { get; }
        //ISupplierRepository Suppliers { get; }
        IUsersRepository Users { get; }
        Task<int> CommitAsync();
    }
}
