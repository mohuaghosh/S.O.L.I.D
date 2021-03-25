namespace xp.solid._4_Interface_Segregation.b._Compliance
{
    public class OnlineDelivery : OnlineDeliveryOrderProcess
    {

        public override bool ValidateShippingAddress()
        {
            return true;

        }

        public override bool ValidatePaymentInformation()
        {
            return true;
        }


        public override void ProcessOrder()
        {
            // Do Order Processing
        }
    }
}
