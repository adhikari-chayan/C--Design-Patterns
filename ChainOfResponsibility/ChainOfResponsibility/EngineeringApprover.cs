using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class EngineeringApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            bool isValid = true;
            if(!String.IsNullOrEmpty(material.DrawingNumber))
            {
                isValid = false;
                reason = "There is no drawing for this material";
            }
            if(!String.IsNullOrEmpty(material.PartNumber))
            {
                isValid = false;
                reason = "There is no part number for this material";
            }

            if (isValid)
            {
                if (_nextApprover != null)
                {
                    return _nextApprover.ApproveMaterial(material, ref reason);
                }
            }
           
                return isValid;
        }
    }
}
