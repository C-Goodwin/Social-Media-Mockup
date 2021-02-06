using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        public Guid Author { get; set; }
<<<<<<< HEAD
        public virtual ICollection<Reply> Replies { get; set; }
=======
        public virtual ICollection<Reply> Replies {get; set;}
        [ForeignKey("Post")]
        public int PostId { get; set; }

>>>>>>> 4e5d4b5277e2dfefdd964caa6668370f27ba0950
    }
}
