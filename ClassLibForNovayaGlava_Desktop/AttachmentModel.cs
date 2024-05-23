using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop
{
    //Модель вложения к сообщению;
    public class AttachmentModel
    {
        public string Id { get; set; }

        // Название файла
        public string FileName { get; set; }

        // Айди юзера, который прикрепил к сообщению данное вложение
        public string OwnerId { get; set; }

        // Айди сообщения, к которому прикреплено вложение
        public string MessageId { get; set; }

        // Тип вложения
        public string Type { get; set; }
    }
}
