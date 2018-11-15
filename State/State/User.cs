using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class User
    {
        private State _state;
        private string _name;

        public User(string name)
        {
            _name = name;
            _state = new LoggedOutState(this);
        }

        public string NextPage
        {
            get
            {
                return _state.NextPage;
            }
        }

        public State State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public void Login()
        {
            _state.Login();
        }

        public void Logout()
        {
            _state.Logout();
        }

        public void Upgrade()
        {
            _state.Upgrade();
        }
    }
}
