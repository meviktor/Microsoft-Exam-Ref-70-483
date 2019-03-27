using System;
using System.Threading.Tasks;

namespace Chapter1
{
    //A potential problem with multithreaded code
    public static class Listing_1_39
    {
        private static /*volatile*/ int _flag = 0;
        private static int _value = 0;

        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }

        public static void Thread2()
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }

        public static void Main()
        {
            var t1 = Task.Run(() => Thread1());

            Thread2();

            t1.Wait();
        }
    }
}