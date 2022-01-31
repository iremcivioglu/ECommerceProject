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
//    public class SupplierController : ControllerBase
//    {
//        private ISupplierServices supplierServices;
//        public SupplierController()
//        {
//            supplierServices = new SupplierServices();
//        }
//        [HttpGet]
//        public IActionResult Get()
//        {
//            return Ok(supplierServices.GetSuppliers());
//        }
//        [HttpPost]
//        public IActionResult Post([FromBody] Supplier supplier)
//        {
//            return Ok(supplierServices.CreateSupplier(supplier));
//        }
//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            if (supplierServices.GetSupplierById(id) != null)
//            {
//                supplierServices.DeleteSupplier(id);
//                return Ok("Deleted Supplier");
//            }
//            return NotFound();
//        }
//        [HttpPut]
//        public IActionResult Put([FromBody] Supplier supplier)
//        {
//            if (supplierServices.GetSupplierById(supplier.SupplierId) != null)
//            {
//                supplierServices.UpdateSupplier(supplier);
//                return Ok("Updated Supplier");
//            }
//            return NotFound();
//        }
//    }
//}
