using System;
using System.Collections.Generic;
using System.Text;

namespace xp.solid._4_Interface_Segregation.a._Violation
{

    public abstract class OrderProcess
    {
        public virtual bool ValidateShippingAddress()
        {
            return true;
        }

        public virtual bool ValidatePaymentInformation()
        {
            return true;
        }


        public virtual void ProcessOrder()
        {
            // Do Order Processing
        }



    }
}
