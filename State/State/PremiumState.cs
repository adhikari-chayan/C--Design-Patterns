using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
   public class PremiumState:State
    {
        public PremiumState(State state)
        {
            _nextPage = "Premium Main Page";
            _user = state.User;
            Initialize();
        }

        public void Initialize()
        {
            _level = 2;
        }

        public override void Login()
        {
            _level = 1;
            StateChangeCheck();
        }

        public override void Logout()
        {
            _level = 0;
            StateChangeCheck();
        }

        public override void Upgrade()
        {
            _level = 2;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            switch (_level)
            {
                case 0:
                    _user.State = new LoggedOutState(this);
                    break;
                case 1:
                    _user.State = new StandardState(this);
                    break;
                case 2:
                    _user.State = this;
                    break;

            }
        }
    }
}
