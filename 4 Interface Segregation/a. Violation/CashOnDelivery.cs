namespace xp.solid._4_Interface_Segregation.a._Violation
{
    public class CashOnDelivery : OrderProcess
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
