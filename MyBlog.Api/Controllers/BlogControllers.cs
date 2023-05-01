using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace MyBlog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private static readonly List<BlogPost> _blogPosts = new List<BlogPost>
        {
            new BlogPost { Title = "My First Blog Post", Author = "John Smith", Content = "This is my first blog post.", Date = new DateTime(2023, 4, 30) },
            new BlogPost { Title = "My Second Blog Post", Author = "Jane Doe", Content = "This is my second blog post.", Date = new DateTime(2023, 5, 1) }
        };

        [HttpGet]
        public ActionResult<IEnumerable<BlogPost>> Get()
        {
            return (_blogPosts);
        }
    }

    internal class HttpGetAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
