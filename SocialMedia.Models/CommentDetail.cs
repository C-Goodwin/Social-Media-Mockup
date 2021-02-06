using System;

namespace SocialMedia.Models
{
    public class CommentDetail
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public Guid Author { get; set; }
    }
}
