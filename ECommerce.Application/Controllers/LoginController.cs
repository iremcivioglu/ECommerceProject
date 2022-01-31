using ECommerce.Application.Helpers;
using ECommerce.Application.TokenModels;
using ECommerce.DataAccess;
using ECommerce.Entities;
using ECommerceApplication.TokenModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; //Genişletilebilir metotlar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Application.Controllers
{
    //Static olan bir metottan static olmayan bir metot çağırılamaz.
    //Bir değerin değişmemesi için de static kullanılabilir.
    //Static değerler sadece constructor metotlar içinde değiştirilebilir.
    //Automapperconfiguration ve extensionconfiguration
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ECommerceDbText _context;// readonly interface ve classları static yaypmamızı sağlar.
        private readonly IConfiguration _configuration;
        private readonly GenericHelperMethods _genericHelperMethods;

        public LoginController(ECommerceDbText context, IConfiguration configuration, GenericHelperMethods genericHelperMethods)
        {
            _context = context;
            _configuration = configuration;
            _genericHelperMethods = genericHelperMethods;
        }
        //www.geldigitti.com/api/login/create --> action ile bu sayfaya erişebiliriz
        [HttpPost("Create")]
        public async Task<bool> Create([FromBody] Users user)//Task<bool>
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }
        [HttpPost("[action]")]
        public async Task<Token> Login([FromBody] UserLogin userLogin)
        {
            Users user = await _context.Users.FirstOrDefaultAsync(w => w.Email == userLogin.Email && w.Password == userLogin.Password);
            if (userLogin != null)
            {
                GenericHelperMethods createToken = new GenericHelperMethods();
                return await _genericHelperMethods.CreateRefreshToken(user, _configuration, _context);
            }
            return null;
        }
        [HttpPost("[action]")]
        public async Task<Token> RefreshTokenLogin([FromForm] string refreshToken)
        {
            Users user = await _context.Users.FirstOrDefaultAsync(w => w.RefreshToken == refreshToken);
            if (user != null && user?.RefreshTokenEndDate > DateTime.Now)
            {
                GenericHelperMethods createToken = new GenericHelperMethods();
                return await _genericHelperMethods.CreateRefreshToken(user, _configuration, _context);
            }
            return null;
        }
    }
}
