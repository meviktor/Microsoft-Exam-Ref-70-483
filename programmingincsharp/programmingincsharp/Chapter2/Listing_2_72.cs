using System;
using System.Reflection;

namespace Chapter2
{
    //Getting the value of a field through reflection
    //For use of DumpObject method, see: MyExamples/AttributesAndReflection/AttributesAndReflectionExample/UsingReflection.
    public static class Listing_2_72
    {
        public static void DumpObject(object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach(FieldInfo field in fields)
            {
                if(field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }
        }
    }
}