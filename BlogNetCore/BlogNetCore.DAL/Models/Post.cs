using System;
using System.Collections.Generic;

namespace BlogNetCore.DAL.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }

        public string AuthorName { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}
