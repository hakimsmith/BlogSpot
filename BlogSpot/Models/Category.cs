using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        public virtual List<Post> Posts { get; set; }


        public Category(int categoryId, string categoryName, string imageUrl)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            ImageUrl = imageUrl;
        }
    }
}
