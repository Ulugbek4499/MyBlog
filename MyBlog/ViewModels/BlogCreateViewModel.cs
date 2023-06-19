using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MyBlog.ViewModels
{
    public class BlogCreateViewModel
    {
        //[Required(ErrorMessage = "Title is required.")]
        [MinLength(10, ErrorMessage = "Title must be at least 10 characters.")]
        //[Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}