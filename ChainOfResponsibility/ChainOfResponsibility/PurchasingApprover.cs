using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class PurchasingApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            if(material.Budget<10000)
            {
                //purchasing can approve anything under $10k
                return true;
            }
            else if(material.Budget <100000)
            {
                //for up to $100k, it needs to be aproved by finance
                if (_nextApprover != null)
                {
                    return _nextApprover.ApproveMaterial(material, ref reason);
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
