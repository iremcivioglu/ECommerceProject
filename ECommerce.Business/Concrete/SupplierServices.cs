//using ECommerce.Business.Abstract;
//using ECommerce.DataAccess.Abstract;
//using ECommerce.DataAccess.Concrete;
//using ECommerce.Entities;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.Business.Concrete
//{
//    public class SupplierServices : ISupplierServices 
//    {
//        private ISupplierRepository supplierRepository;
//        public SupplierServices()
//        {
//            supplierRepository = new SupplierRepository();
//        }

//        public Supplier CreateSupplier(Supplier supplier)
//        {
//            return supplierRepository.CreateSupplier(supplier);
//        }

//        public void DeleteSupplier(int id)
//        {
//            supplierRepository.DeleteSupplier(id);
//        }

//        public Supplier GetSupplierById(int id)
//        {
//            return supplierRepository.GetSupplierById(id);
//        }

//        public Supplier GetSupplierByName(string name)
//        {
//            return supplierRepository.GetSupplierByName(name);
//        }

//        public async Task<List<Supplier>> GetSuppliers()
//        {
//            return await supplierRepository.GetSuppliers();
//        }

//        public Supplier UpdateSupplier(Supplier supplier)
//        {
//            return supplierRepository.UpdateSupplier(supplier);
//        }
//    }
//}
