namespace programmingincsharp.Chapter2
{
    //Implementing an implivit an explicit conversion operator
    public class Money
    {
        public Money(decimal amount)
        {
            Amount = amount;
        }

        public decimal Amount { get; set; }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        //Q: Can be replaced to 'implicit'. In this case why would we this operator as explicit?
        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }
}