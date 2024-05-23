using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop
{
    public class SignalRMessageModel
    {
        public string FromId { get; set; }
        public string ToId { get; set; }
        public string Message { get; set; }
    }
}
