using System;

namespace Chapter1
{
    //Catching different Exception types
    public static class Listing_1_90
    {
        public static void Main()
        {
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again.", s);
            }
        }
    }
}