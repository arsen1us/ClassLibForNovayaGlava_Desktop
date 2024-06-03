using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop
{
    public class RefreshTokenModel
    {
        public string _id { get; set; } = null!;
        public string RefreshToken { get; set; } = null!;
        public string UserId { get; set; } = null!;

        public RefreshTokenModel(string id, string refreshToken, string userId)
        {
            _id = id;
            RefreshToken = refreshToken;
            UserId = userId;
        }
    }
}
