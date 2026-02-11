using System;
using System.ComponentModel.DataAnnotations;

namespace miniblog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Treść jest wymagana")]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
