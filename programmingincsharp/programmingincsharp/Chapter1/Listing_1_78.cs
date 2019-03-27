using System.IO;

namespace Chapter1
{
    //Contravariance with delegates
    public static class Listing_1_78
    {
        static void DoSomething(TextWriter tw) { }

        public delegate void ContravarianceDel(StreamWriter tw);

        public static void Main()
        {
            ContravarianceDel del = DoSomething;
        }
    }
}