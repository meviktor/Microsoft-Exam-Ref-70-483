using System;

namespace programmingincsharp.MyExamples.AttributesAndReflection
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public abstract class AppTargetAttribute : Attribute
    {
        public string Category { get; set; }

        public AppTargetAttribute(string category)
        {
            Category = category;
        }
    }
}