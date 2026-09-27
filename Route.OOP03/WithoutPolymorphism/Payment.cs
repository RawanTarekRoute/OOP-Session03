namespace Route.OOP03.WithoutPolymorphism
{
    internal class Payment
    {
        // Common Logic
        public void Pay()
        {
            if (this is WalletPayment)
            {
                // payment with wallet
            }
            else if (this is InstapayPayment)
            {
                // payment with instapay
            }
            else if (this is PaymopPayment)
            {
                // payment with paymop
            }
            else if (this is CashPayment)
            {
                // payment with cash
            }

        }
    }
}
