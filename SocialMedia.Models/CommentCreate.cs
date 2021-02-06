using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models
{
    public class CommentCreate
    {
        [Required]
        public string Text { get; set; }
    }
}
