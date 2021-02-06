using SocialMedia.Data;
using System.Collections.Generic;

namespace SocialMedia.Models
{
    public class PostDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        // How should we implement a reply
    }
}
