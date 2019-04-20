using System;
using System.Reflection;

namespace Chapter2
{
    public static class Listing_2_73
    {
        public static object ExecuteMethodThroughReflection(object obj, string methodName, Type[] parameterTypes, object[] parameters)
        {
            MethodInfo methodToExecute = obj.GetType().GetMethod(methodName, parameterTypes);
            object res = methodToExecute.Invoke(obj, parameters);
            return res;
        }
    }
}