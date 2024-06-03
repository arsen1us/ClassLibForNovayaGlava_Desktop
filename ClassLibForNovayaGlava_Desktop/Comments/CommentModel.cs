using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop.Comments
{
    public class CommentModel
    {
        public string _id { get; set; } = null!;
        public string Text { get; set; } = null!;
        public string PostId { get; set; } = null!;
        public string UserId { get; set; } = null!;

        // Ограничение на кол-во вложений у комментария - 2 шт
        public List<string> AttachmentId { get; set; }

        // Id сообшения, на которое ответили
        public string ReplyCommentId { get; set; }
    }
}
