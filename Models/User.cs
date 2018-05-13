using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ManyToManyExample.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SecurityPolicy> SecurityPolicy { get; set; }
        public User()
        {
            SecurityPolicy = new List<SecurityPolicy>();
        }
    }
}