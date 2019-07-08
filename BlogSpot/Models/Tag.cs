using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        public virtual List<TagPost> TagPosts { get; set; }


        public Tag(int tagId, string tagName)
        {
            TagId = tagId;
            TagName = tagName;
        }

        public Tag()
        {

        }
    }
}
