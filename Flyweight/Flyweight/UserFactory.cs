using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
   public class UserFactory
    {
        public static int _usersCount = 0;

        private Dictionary<Guid, User> _users = new Dictionary<Guid, User>();

        public User GetUser(Guid userId)
        {
            if (_users.ContainsKey(userId))
                return _users[userId];

            User user = User.GetUser(userId);
            _users.Add(userId,user);
            _usersCount++;

            return user;
        }
    }
}
