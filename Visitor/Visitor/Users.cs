using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Users
    {
        private List<User> _usersList = new List<User>();

        public void Attach(User user)
        {
            _usersList.Add(user);
        }

        public void Detach(User user)
        {
            _usersList.Remove(user);
        }

        public void Accept(IVisitor visitor)
        {
            foreach(User user in _usersList)
            {
                user.Accept(visitor);
            }
        }
    }
}
