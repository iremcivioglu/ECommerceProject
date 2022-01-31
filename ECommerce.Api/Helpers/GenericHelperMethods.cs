using ECommerce.Api.TokenModels;
using ECommerce.DataAccess;
using ECommerce.Entities;
using ECommerceApi.TokenModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Api.Helpers
{
    public class GenericHelperMethods
    {
        public GenericHelperMethods()
        {

        }
        public async Task<Token> CreateRefreshToken(Users user, IConfiguration _configuration, ECommerceDbText _context)
        {
            //User için token üretiliyor.
            TokenHandler tokenHandler = new TokenHandler(_configuration);
            Token token = tokenHandler.CreateToken(user);

            //Refresh token token süremize göre sürekli kendini yenileyen token
            //fresh token kullanıcı tablosuna işleniyor
            user.RefreshToken = token.RefreshToken;
            user.RefreshTokenEndDate = token.Expiration.AddMinutes(5); //refresh tokenın ayakta kalma süresi
            await _context.SaveChangesAsync();
            return token;
        }
    }
}
