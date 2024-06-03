using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop.UserModel
{
    public class AuthUserModel
    {
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;

        public AuthUserModel(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
