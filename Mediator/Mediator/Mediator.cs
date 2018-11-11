using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Mediator : IMediator
    {

        private List<Colleague> _colleagueList = new List<Colleague>();
        public List<Colleague> Colleagues
        {
            get
            {
                return _colleagueList;
            }
        }

        public void PostMessage(Colleague sender, string message)
        {
            foreach(var c in _colleagueList)
            {
                if(c!=sender)
                {
                    c.ReceiveMessage(message, sender.Name);
                }
            }
        }

        public void Register(Colleague colleague)
        {
            _colleagueList.Add(colleague);
        }
    }
}
