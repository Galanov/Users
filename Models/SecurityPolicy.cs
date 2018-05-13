using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyToManyExample.Models
{
    public class SecurityPolicy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public SecurityPolicy()
        {
            Users = new List<User>();
        }
    }
}