using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Models
{
    public class TagPost
    {
        public int TagPostId { get; set; }

        public virtual int PostId { get; set; }
        public virtual Post Post { get; set; }
        public virtual int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
