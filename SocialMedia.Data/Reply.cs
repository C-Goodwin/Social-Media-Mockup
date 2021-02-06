using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }
        [Required]
        public string Text { get; set; }
        public Guid Author { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        [ForeignKey("Comment")]
        public int CommentId { get; set; }

    }
}
