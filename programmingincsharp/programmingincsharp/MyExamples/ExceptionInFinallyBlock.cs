using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExamples
{
    //What will happen when the finally block throws an exception?
    public static class ExceptionInFinallyBlock
    {
        public static void Main()
        {
            try
            {
                try
                {
                    //Causes FormatException...
                    int.Parse("NaN");
                }
                //catch(FormatException)
                //{
                    //Console.WriteLine("Catching FormatException");
                //}
                finally
                {
                    Console.WriteLine("Finally block.");
                    //If this line will is not commented out, the data of the FormatException will be lost
                    //throw new Exception("Exception thrown from finally block.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
