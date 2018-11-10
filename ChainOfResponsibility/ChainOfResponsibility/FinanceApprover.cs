using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class FinanceApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            if(material.Budget <100000)
            {
                if(_nextApprover!=null)
                {
                    _nextApprover.ApproveMaterial(material, ref reason);
                }

                return true;
            }
            else
            {
                reason = "Budget is crossing specified limit.";
                return false;
            }
        }
    }
}
