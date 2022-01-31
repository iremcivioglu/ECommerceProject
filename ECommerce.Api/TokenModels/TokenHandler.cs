using ECommerce.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Entities.Model;
using ECommerceApi.TokenModels;

namespace ECommerce.Api.TokenModels
{
    public class TokenHandler
    {
        public IConfiguration Configuration { get; set; }
        public TokenHandler(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //Token üretecek metot
        public Token CreateToken(Users user)
        {
            Token token = new Token();
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"])); //SecurityKEy'in yansımasını alır.
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256); //Şifreli kimlik oluşturulur.
            token.Expiration = DateTime.Now.AddMinutes(5); //Token süresine 5 dk ekler
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                issuer: Configuration["Token:Issuer"], //Configuration appsettings dosyasına erişmek için kullanılır.
                audience: Configuration["Token:Audience"],
                expires: token.Expiration,
                notBefore: DateTime.Now, //NotBefore --> Token üretildikten sonra kaç dk sonra devreye girsin
                signingCredentials: signingCredentials
                );

            //Bu satır token'ı üretiyor.
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            token.AccessToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);

            token.RefreshToken = CreateRefreshToken();
            return token;

        }

        //32 karakterlik string array tuttuk
        //Randamgenerator ile array'in içini doldurduk
        //Bu arrayi 64 stringe çevirip geri döndürdük.
        public string CreateRefreshToken() //oluşturulan refresh token önceki tokendan daha uzun olur
        {
            byte[] tokenArray = new byte[32];
            using (RandomNumberGenerator generator = RandomNumberGenerator.Create())
            //Token unique olsun istiyorsak randomgenerator yerine GUID kullanılmalı
            {
                generator.GetBytes(tokenArray);
                return Convert.ToBase64String(tokenArray);
            }
            //Token örneği--> UrgaBW1P2d7OCu2MQWQYsOvIju7HUeiJIGQ/eKQK+EA=
        }
    }
}
