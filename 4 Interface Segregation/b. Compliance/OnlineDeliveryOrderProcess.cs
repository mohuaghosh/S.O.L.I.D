namespace xp.solid._4_Interface_Segregation.b._Compliance
{
    public abstract class OnlineDeliveryOrderProcess
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
