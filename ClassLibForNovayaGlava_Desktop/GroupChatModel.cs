using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop
{
    public class GroupChatModel : ChatModel
    {
        public string Name;
        public string ImageBase64;
        public string[] Muted;

        //Наследуется:
        //id
        //lastMessageAt
        //__v
        //members
    }
}
