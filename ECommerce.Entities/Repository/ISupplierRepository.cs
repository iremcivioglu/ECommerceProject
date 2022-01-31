using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Abstract
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        //Supplier CreateSupplier(Supplier supplier);
        //Task<List<Supplier>> GetSuppliers();
        //Supplier GetSupplierById(int id);
        Task<Supplier> GetSupplierByName(string name);
        //void DeleteSupplier(int id);
        //Supplier UpdateSupplier(Supplier supplier);
    }
}
