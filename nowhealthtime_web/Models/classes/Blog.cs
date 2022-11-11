using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nowhealthtime_web.Models.classes
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        public string BlogTittle { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "(0:dd/MM/yyyy)")] //11 Kasım 2022
        public  DateTime DateTime { get; set; }

        public string BlogImage { get; set; }

        [AllowHtml]
        public string BlogDescription { get; set; }

        public bool IsActive { get; set; }

        public int CategoryID { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }
    }
}