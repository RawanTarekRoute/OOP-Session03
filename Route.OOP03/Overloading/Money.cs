namespace Route.OOP03.Overloading
{
    internal class Money
    {
        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; set; }
        public string Currency { get; set; }


        // 1. static
        // 2. public 
        // 3. return type
        // 4. operator keyword

        public static Money operator + (Money right, Money left)
        {
            if (right.Currency != left.Currency)
            {
                throw new InvalidOperationException("Can't add two different currencies");
            }

            return new Money(right.Amount + left.Amount, right.Currency);
        }


        // Show((object) 5)
        // Show(employee)
        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }
    }
}
