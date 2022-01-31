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
//    public class ShipmentServices : IShipmentServices
//    {
//        private IShipmentRepository shipmentRepository;
//        public ShipmentServices()
//        {
//            shipmentRepository = new ShipmentRepository();
//        }

//        public Shipment CreateShipment(Shipment shipment)
//        {
//            return shipmentRepository.CreateShipment(shipment);
//        }

//        public void DeleteShipment(int id)
//        {
//            shipmentRepository.DeleteShipment(id);
//        }

//        public Shipment GetShipmentByCompanyName(string name)
//        {
//            return shipmentRepository.GetShipmentByCompanyName(name);
//        }

//        public Shipment GetShipmentById(int id)
//        {
//            return shipmentRepository.GetShipmentById(id);
//        }

//        public async Task<List<Shipment>> GetShipments()
//        {
//            return await shipmentRepository.GetShipments();
//        }

//        public Shipment UpdateShipment(Shipment shipment)
//        {
//            return shipmentRepository.UpdateShipment(shipment);
//        }
//    }
//}
