using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Abstract
{
    public interface IShipmentRepository : IRepository<Shipment>
    {
        //Shipment CreateShipment(Shipment shipment);
        //Task<List<Shipment>> GetShipments();
        //Shipment GetShipmentById(int id);
        Task<Shipment> GetShipmentByCompanyName(string name);
        //void DeleteShipment(int id);
        //Shipment UpdateShipment(Shipment shipment);
    }
}
