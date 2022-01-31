using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApplication.TokenModels
{
    public class Token
    {
        //Yetkiler tokenlara bağlı olarak verilir
        public string AccessToken { get; set; }
        public DateTime Expiration { get; set; } //token güncellenme date'i
        public string RefreshToken { get; set; } //AccessToken, RefreshToken'a bakar. Süre dolmuşsa (expiration) yeni bir token yükler.
    }
}
