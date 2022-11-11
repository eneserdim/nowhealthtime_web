using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace nowhealthtime_web.Models.classes
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}