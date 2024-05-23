using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop
{
    // Модель для списка чатов во вкладке мессенджер
    public class ChatUserModel : ChatModel
    {
        public string CompanionId { get; set; }
        public string CompanionNickName { get; set; }
    }
}
