#define test
//#undef alma
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3.MyExamples
{
    public class PreprocessorCompilerDirectives
    {
        public static void Main()
        {
            #region #if, #else, #elif, #endif, #warning, #error
#if DEBUG
            Console.WriteLine("Running in debug mode.");
#warning Debug mode is set.
#endif
#if !DEBUG
            Console.WriteLine("Release mode is enabled.");
#error You have enabled release mode!
#endif
#if test
            Console.WriteLine("Test is defined.");
#endif
#if RELEASE
            Console.WriteLine("Running in release mode.");
#elif DEBUG && test
            Console.WriteLine("Running in debug mode with defined test.");
#endif
            //use the -define compiler option...
#if !alma
            Console.WriteLine("alma is successfully undefined!");
#else
            Console.WriteLine("alma is defined.");
#endif
            #endregion

            ;// place a breakpoint here
            #region #line
#line 1000 "Line region"
            int i;
            int j;
#line default
            char c;
            float f;
#line hidden // numbering not affected
            string s;
            double d;
#line default
            #endregion

            #region #pragma warning
#pragma warning disable CS0168, S1481
            int asd;
#pragma warning restore CS0168
            int asd2;
            #endregion
        }
    }
}