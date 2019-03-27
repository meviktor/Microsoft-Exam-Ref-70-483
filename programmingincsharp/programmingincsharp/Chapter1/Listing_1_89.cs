using System;

namespace Chapter1
{
    //Catching a FormatException
    public static class Listing_1_89
    {
        public static void Main()
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s)) break;

                try
                {
                    int i = int.Parse(s);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again.", s);
                }
            }
        }
    }
}