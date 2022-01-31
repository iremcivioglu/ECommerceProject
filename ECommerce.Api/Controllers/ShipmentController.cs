//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using ECommerce.Business.Abstract;
//using ECommerce.Business.Concrete;
//using ECommerce.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace ECommerce.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ShipmentController : ControllerBase
//    {
//        private IShipmentServices shipmentServices;
//        public ShipmentController()
//        {
//            shipmentServices = new ShipmentServices();
//        }
//        [HttpGet]
//        public IActionResult Get()
//        {
//            return Ok(shipmentServices.GetShipments());
//        }
//        [HttpPost]
//        public IActionResult Post([FromBody] Shipment shipment)
//        {
//            return Ok(shipmentServices.CreateShipment(shipment));
//        }
//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            if(shipmentServices.GetShipmentById(id) != null)
//            {
//                shipmentServices.DeleteShipment(id);
//                return Ok("Deleted Shipment");
//            }
//            return NotFound();
//        }
//        [HttpPut]
//        public IActionResult Put([FromBody] Shipment shipment)
//        {
//            if (shipmentServices.GetShipmentById(shipment.ShipmentId) != null)
//            {
//                shipmentServices.UpdateShipment(shipment);
//                return Ok("Updated Shipment");
//            }
//            return NotFound();
//        }
//    }
//}
