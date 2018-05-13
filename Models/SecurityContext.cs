using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ManyToManyExample.Models
{
    public class SecurityContext:DbContext
    {
        public SecurityContext() 
            :base("DefaultConnection")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<SecurityPolicy> SecurityPolicy { get; set; }
    }
}