//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using ECommerce.Business.Abstract;
//using ECommerce.Business.Concrete;
//using ECommerce.Entities;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Ecommerce.Api
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UsersController : ControllerBase
//    {
//        private IUsersServices _usersServices;
//        public UsersController(IUsersServices usersServices)
//        {
//            _usersServices = usersServices;
//        }
//        [HttpGet("Get")]
//        public async Task<ActionResult<IEnumerable<ActionResult>>> Get()
//        {
//            var users = await _usersServices.GetUsers();
//            return Ok(users);
//        }
//        [HttpPost]
//        public async Task<ActionResult> Post([FromBody] Users user)
//        {
//            var createUser = _usersServices.CreateUser(user);
//            return Ok(createUser);
//        }
//        [HttpDelete("{id}")]
//        public IActionResult Delete(Users user)
//        {
//            if (_usersServices.GetUserById(user.Id) != null)
//            {
//                _usersServices.DeleteUser(user);
//                return Ok("Deleted User");
//            }
//            return NotFound();
//        }
//        //[HttpPut]
//        //public IActionResult Put([FromBody] Users user)
//        //{
//        //    if (_usersServices.GetUserById(user.Id) != null)
//        //    {
//        //        _usersServices.UpdateUser(user);
//        //        return Ok("Updated");
//        //    }
//        //    return NotFound();
//        //}

//    }
//}
