using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nowhealthtime_web.Models.classes
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutTittle { get; set; }
        public string AboutDescription { get; set; }
    }
}