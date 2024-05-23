using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop
{
    public class ChatModel
    {
        public string _id { get; set; }
        public List<string> Members { get; set; } // сюда добавить, что всего 2 челика может быть в чате;
        public int LastMessageAt { get; set; } //Позиция последнего сообщение?
        public int __v { get; set; } //Что это?
    }
}
