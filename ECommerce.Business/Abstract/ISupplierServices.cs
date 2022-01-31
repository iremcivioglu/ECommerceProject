using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface ISupplierServices
    {
        Task<Supplier> CreateSupplier(Supplier supplier);
        Task<IEnumerable<Supplier>> GetSuppliers();
        Task<Supplier> GetSupplierById(int id);
        Task<Supplier> GetSupplierByName(string name);
        Task DeleteSupplier(Supplier supplier);
        Task UpdateSupplier(Supplier supplierToUpdated, Supplier supplier);
    }
}
