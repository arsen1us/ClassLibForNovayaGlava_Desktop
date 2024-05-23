using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop
{
    public class PostModel
    {
        public string _id { get; set; }
        // morePics - так называется на бэкенде js
        public string Images { get; set; }
        public string UserId { get; set; }

        // хз что такое 
        public string WallId { get; set; }
    }
}
