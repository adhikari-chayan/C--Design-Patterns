using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
   public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public List<User> Followers { get; set; }

        public static User GetUser(Guid userId)
        {
            //get user from database

            //for demo retruning random user
            return new User
            {
                UserId = Guid.NewGuid()
            };
        }
    }
}
