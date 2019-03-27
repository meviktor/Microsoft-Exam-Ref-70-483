using System;

namespace MyExamples
{
    public class DelegatesAndLambda
    {
        public Action ActionMethod()
        {
            int localVar1 = 1;
            Action a = () => Console.WriteLine("ActionMethod: Value of the variable 'localVar1' is {0}.", localVar1);
            return a;
        }

        public static Action StaticActionMethod()
        {
            int localVar2 = 2;
            Action a = () => Console.WriteLine("ActionMethod: Value of the variable 'localVar2' is {0}.", localVar2);
            return a;
        }

        public static void Main()
        {
            DelegatesAndLambda dal = new DelegatesAndLambda();

            Action actionFromInstanceMethod = dal.ActionMethod();
            Action actionFromStaticMethod = StaticActionMethod();

            actionFromInstanceMethod();
            actionFromStaticMethod();
        }
    }
}