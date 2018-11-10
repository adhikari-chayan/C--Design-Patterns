using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
   public abstract class Approver
    {
        protected Approver _nextApprover;

        public void SetNextApprover(Approver nextApprover)
        {
            _nextApprover = nextApprover;
        }

        public abstract bool ApproveMaterial(Material material, ref string reason);
    }
}
