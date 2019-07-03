using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int CategoryId { get; set; }
        public DateTime PostDateTime { get; set; }
        public string PostTitle { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<TagPost> TagPosts { get; set; }


        public Post(int postId, int categoryId, DateTime postDateTime, string postTtile, string body, string author, string categoryName, string imageUrl)
        {
            PostId = postId;
            CategoryId = categoryId;
            PostTitle = postTtile;
            Body = body;
            Author = author;
            CategoryName = categoryName;
            ImageUrl = imageUrl;
        }

        public Post()
        {
            PostDateTime = DateTime.Now;
        }
    }
}
