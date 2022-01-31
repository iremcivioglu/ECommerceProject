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
//    public class PaymentController : ControllerBase
//    {
//        private IPaymentServices paymentServices;
//        public PaymentController()
//        {
//            paymentServices = new PaymentServices();
//        }
//        [HttpGet]
//        public IActionResult Get()
//        {
//            return Ok(paymentServices.GetPayments());
//        }
//        [HttpPost]
//        public IActionResult Post([FromBody] Payment payment)
//        {
//            return Ok(paymentServices.CreatePayment(payment));
//        }
//        [HttpDelete("id")]
//        public IActionResult Delete(int id)
//        {
//            if (paymentServices.GetPaymentById(id) != null)
//            {
//                paymentServices.DeletePayment(id);
//                return Ok("Deleted Payment");
//            }
//            return NotFound();
//        }
//        [HttpPut]
//        public IActionResult Update([FromBody] Payment payment)
//        {
//            if (paymentServices.GetPaymentById(payment.PaymentId) != null)
//            {
//                paymentServices.UpdatePayment(payment);
//                return Ok("Deleted Payment");
//            }
//            return NotFound();
//        }
//    }
//}
