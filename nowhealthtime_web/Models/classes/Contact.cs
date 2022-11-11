using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nowhealthtime_web.Models.classes
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="(0:dd/MM/yyyy)")] //11 Kasım 2022
        public DateTime DateTime { get; set; }
    }
}