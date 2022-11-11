using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nowhealthtime_web.Models.classes
{
    public class BlogCategory
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryTitle { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}