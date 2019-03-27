using System;

namespace Chapter1
{
    //Rethrowing an exception
    public static class Listing_1_95
    {
        public static void Main()
        {
            try
            {
                SomeOperation();
            }
            catch(Exception logEx)
            {
                Log(logEx);
                //throw;

                //If you execute this line instead of the throw statement above
                //the stack trace of the exception will "start" from here (Main), not from the place where the exception was thrown in real (ExceptionMethod):
                //throw logEx;

                //Wrapping the original exception in a new Exception instance, and rethrow the new one
                //The original exception stack data (stack trace, etc.) will be preserved (will be written out to the console as well), besides the data of the new exception
                throw new Exception("My inner exception is the original exception.", logEx);
            }
        }

        private static void SomeOperation()
        {
            ExceptionMethod();
        }

        private static void ExceptionMethod()
        {
            throw new Exception("An exception was thrown...");
        }

        private static void Log(Exception e)
        {
            Console.WriteLine("An exception caught at {0}, message: {1}", DateTime.Now, e.Message);
        }
    }
}