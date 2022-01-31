using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceDbText _context;
        private CustomerRepository _customerRepository;
        private CategoryRepository _categoryRepository;
        //private ProductRepository _productRepository;
        //private OrderRepository _orderRepository;
        //private PaymentRepository _paymentRepository;
        //private ShipmentRepository _shipmentRepository;
        //private SupplierRepository _supplierRepository;
        private UsersRepository _usersRepository;
        public UnitOfWork(ECommerceDbText context)
        {
            _customerRepository = new CustomerRepository(context);
            _categoryRepository = new CategoryRepository(context);
            //_productRepository = new ProductRepository(context);
            //_orderRepository = new OrderRepository(context);
            //_paymentRepository = new PaymentRepository(context);
            //_shipmentRepository = new ShipmentRepository(context);
            //_supplierRepository = new SupplierRepository(context);
            _usersRepository = new UsersRepository(context);
            this._context = context;
        }
        public IUsersRepository Users => _usersRepository = _usersRepository ?? new UsersRepository(_context);
        public ICustomerRepository Customers => _customerRepository = _customerRepository ?? new CustomerRepository(_context);
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
        //public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);
        //public IOrderRepository Orders => _orderRepository = _orderRepository ?? new OrderRepository(_context);
        //public IPaymentRepository Payments => _paymentRepository = _paymentRepository ?? new PaymentRepository(_context);
        //public IShipmentRepository Shipments => _shipmentRepository = _shipmentRepository ?? new ShipmentRepository(_context);
        //public ISupplierRepository Suppliers => _supplierRepository = _supplierRepository ?? new SupplierRepository(_context);
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
