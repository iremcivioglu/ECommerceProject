using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Abstract
{
    public interface IShipmentServices
    {
        Task<Shipment> CreateShipment(Shipment shipment);
        Task<IEnumerable<Shipment>> GetShipments();
        Task<Shipment> GetShipmentById(int id);
        Task<Shipment> GetShipmentByCompanyName(string name);
        Task DeleteShipment(Shipment shipment);
        Task UpdateShipment(Shipment shipmentToUpdated, Shipment shipment);
    }
}
