using System;

namespace Chapter1
{
    //Using a finally block
    public static class Listing_1_91
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
                finally
                {
                    Console.WriteLine("Program complete.");
                }
            }
        }
    }
}