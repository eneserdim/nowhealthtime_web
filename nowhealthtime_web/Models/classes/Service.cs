using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nowhealthtime_web.Models.classes
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
    }
}