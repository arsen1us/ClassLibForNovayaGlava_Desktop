using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibForNovayaGlava_Desktop.Comments
{
    public class ImageCommentModel
    {
        public string CommentId { get; set; } = null!;

        // Ограничение на кол-во вложений у комментария - 2 шт
        public List<string> AttachmentId { get; set; } = null!;
    }
}
