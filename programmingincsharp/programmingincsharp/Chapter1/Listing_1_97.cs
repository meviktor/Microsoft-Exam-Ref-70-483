using System;
using System.Runtime.ExceptionServices;

namespace Chapter1
{
    public static class Listing_1_97
    {
        public static void Main()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch(FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if(possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}