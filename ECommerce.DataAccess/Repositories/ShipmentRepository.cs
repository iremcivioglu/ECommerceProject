//using ECommerce.DataAccess.Abstract;
//using ECommerce.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ECommerce.DataAccess.Concrete
//{
//    public class ShipmentRepository : IRepository<Shipment>, IShipmentRepository
//    {
//        ECommerceDbText eCommerceDbText = new ECommerceDbText();
//        private ECommerceDbText _context;
//        public ShipmentRepository(ECommerceDbText context)
//        {
//            this._context = context;
//        }
//        public Shipment Create(Shipment variable)
//        {
//            eCommerceDbText.Add(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }

//        public void Delete(int id)
//        {
//            var deleteShipment = GetById(id);
//            eCommerceDbText.Shipments.Remove(deleteShipment);
//            eCommerceDbText.SaveChanges();
//        }

//        public async Task<List<Shipment>> GetAll()
//        {
//            return eCommerceDbText.Shipments.ToList();
//        }

//        public Shipment GetById(int id)
//        {
//            return eCommerceDbText.Shipments.Find(id);
//        }
//        public Shipment Update(Shipment variable)
//        {
//            eCommerceDbText.Shipments.Update(variable);
//            eCommerceDbText.SaveChanges();
//            return variable;
//        }
//        public Shipment GetShipmentByCompanyName(string name)
//        {
//            return eCommerceDbText.Shipments.Where(w => w.CompanyName == name).FirstOrDefault();
//        }
//        //public Shipment CreateShipment(Shipment shipment)
//        //{
//        //    eCommerceDbText.Add(shipment);
//        //    eCommerceDbText.SaveChanges();
//        //    return shipment;
//        //}

//        //public void DeleteShipment(int id)
//        //{
//        //    var deleteShipment = GetShipmentById(id);
//        //    eCommerceDbText.Shipments.Remove(deleteShipment);
//        //    eCommerceDbText.SaveChanges();
//        //}

//        //public Shipment GetShipmentById(int id)
//        //{
//        //    return eCommerceDbText.Shipments.Find(id);
//        //}

//        //public async Task<List<Shipment>> GetShipments()
//        //{
//        //    return eCommerceDbText.Shipments.ToList();
//        //}

//        //public Shipment UpdateShipment(Shipment shipment)
//        //{
//        //    eCommerceDbText.Shipments.Update(shipment);
//        //    eCommerceDbText.SaveChanges();
//        //    return shipment;
//        //}
//    }
//}
