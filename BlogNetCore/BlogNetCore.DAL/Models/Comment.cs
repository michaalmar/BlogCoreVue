using System;

namespace BlogNetCore.DAL.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime Added { get; set; }

        public string UserName { get; set; }


        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
