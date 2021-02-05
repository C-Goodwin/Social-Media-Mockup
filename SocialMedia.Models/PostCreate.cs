using System.ComponentModel.DataAnnotations;

namespace SocialMedia.Models
{
    public class PostCreate
    {
        [Required]
        public string Title { get; set; }
        public string Text { get; set; }

    }
}
