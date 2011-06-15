using System;
using System.Collections.Generic;

namespace JustinSoliz.Web.Models
{
    public class Post
    {
        public Post()
        {
            Author = Blog.Author;
            DateCreated = DateTime.UtcNow;
            DateModified = DateTime.UtcNow;
            IsPublished = false;
        }

        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public string Tags { get; set; }
        public string Excerpt { get; set; }
        public bool IsPublished { get; set; }
        public IList<Category> Categories { get; set; }

        public DateTime? DatePublished { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
