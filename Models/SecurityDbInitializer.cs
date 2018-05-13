using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ManyToManyExample.Models
{
    public class SecurityDbInitializer: DropCreateDatabaseAlways<SecurityContext>
    {
        protected override void Seed(SecurityContext context)
        {
            User u1 = new User { Name = "User1" };
            User u2 = new User { Name = "User2" };
            User u3 = new User { Name = "User3" };
            context.Users.Add(u1);
            context.Users.Add(u2);
            context.Users.Add(u3);

            SecurityPolicy s1 = new SecurityPolicy { Name = "Admin" ,Users = new List<User> { u1 } };
            SecurityPolicy s2 = new SecurityPolicy { Name = "User", Users = new List<User> { u1, u2 } };
            SecurityPolicy s3 = new SecurityPolicy { Name = "Other", Users = new List<User> { u1, u2, u3 } };

            context.SecurityPolicy.Add(s1);
            context.SecurityPolicy.Add(s2);
            context.SecurityPolicy.Add(s3);
            base.Seed(context);
        }
    }
}