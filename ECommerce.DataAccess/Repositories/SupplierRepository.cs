//using ECommerce.DataAccess.Abstract;
//using ECommerce.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.DataAccess.Concrete
//{
//    public class SupplierRepository : IRepository<Supplier>, ISupplierRepository
//    {
//        ECommerceDbText eCommerceDbText = new ECommerceDbText();
//        private ECommerceDbText _context;
//        public SupplierRepository(ECommerceDbText context)
//        {
//            this._context = context;
//        }
//        public Supplier Create(Supplier variable)
//        {
//            eCommerceDbText.Add(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }

//        public void Delete(int id)
//        {
//            var deleteSupplier = GetById(id);
//            eCommerceDbText.Suppliers.Remove(deleteSupplier);
//            eCommerceDbText.SaveChanges();
//        }

//        public async Task<List<Supplier>> GetAll()
//        {
//            return eCommerceDbText.Suppliers.ToList();
//        }

//        public Supplier GetById(int id)
//        {
//            return eCommerceDbText.Suppliers.Find(id);
//        }
//        public Supplier Update(Supplier variable)
//        {
//            eCommerceDbText.Suppliers.Update(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }
//        public Supplier GetSupplierByName(string name)
//        {
//            return eCommerceDbText.Suppliers.Where(w => w.SupplierName == name).FirstOrDefault();
//        }
//        //public Supplier CreateSupplier(Supplier supplier)
//        //{
//        //    eCommerceDbText.Add(supplier);
//        //    eCommerceDbText.SaveChanges();
//        //    return supplier;
//        //}

//        //public void DeleteSupplier(int id)
//        //{
//        //    var deleteSupplier = GetSupplierById(id);
//        //    eCommerceDbText.Suppliers.Remove(deleteSupplier);
//        //    eCommerceDbText.SaveChanges();
//        //}

//        //public Supplier GetSupplierById(int id)
//        //{
//        //    return eCommerceDbText.Suppliers.Find(id);
//        //}

//        //public async Task<List<Supplier>> GetSuppliers()
//        //{
//        //    return eCommerceDbText.Suppliers.ToList();
//        //}

//        //public Supplier UpdateSupplier(Supplier supplier)
//        //{
//        //    eCommerceDbText.Suppliers.Update(supplier);
//        //    eCommerceDbText.SaveChanges();
//        //    return supplier;
//        //}
//    }
//}
