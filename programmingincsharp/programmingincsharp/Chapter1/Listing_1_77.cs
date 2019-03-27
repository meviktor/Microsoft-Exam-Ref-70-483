using System.IO;

namespace Chapter1
{
    //Covariance
    public static class Listing_1_77
    {
        public delegate TextWriter CovarianceDel();

        public static StreamWriter MethodStream()
        {
            return null;
        }

        public static StringWriter MethodString()
        {
            return null;
        }

        public static void Main()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }
    }
}