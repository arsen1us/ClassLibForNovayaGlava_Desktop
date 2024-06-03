using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop
{
    public class TokenModel
    {
        public string Token { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;

        public TokenModel(string token, string refreshToken)
        {
            Token = token;
            RefreshToken = refreshToken;
        }
    }
}
