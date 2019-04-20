namespace programmingincsharp.Chapter2
{
    //Using an implicit and an explicit operator on a custom type
    public static class Listing_2_25
    {
       public static void Main()
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            int truncatedAmount = (int)m;
        }
    }
}