using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
   public abstract class State
    {
        protected User _user;
        protected string _nextPage;
        protected int _level;

        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }

        public string NextPage
        {
            get
            {
                return _nextPage;
            }
            set
            {
                _nextPage = value;
            }
        }

        public abstract void Login();
        public abstract void Logout();
        public abstract void Upgrade();
    }
}
