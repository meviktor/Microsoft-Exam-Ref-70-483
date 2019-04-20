using System;
using static Chapter2.Listing_2_72;
using static Chapter2.Listing_2_73;

namespace programmingincsharp.MyExamples.AttributesAndReflection
{
    public static class AttributesReflectionExample
    {
        public static void Main()
        {
            UsingAttributes();
            UsingRefletion();
        }

        private static void UsingAttributes()
        {
            Application app = new Application();
            bool targetedToSymbian = Attribute.IsDefined(typeof(Application), typeof(SymbianAttribute));
            if (targetedToSymbian)
            {
                try
                {
                    MobileAttribute platform = (MobileAttribute)Attribute.GetCustomAttribute(typeof(Application), typeof(MobileAttribute));
                }
                catch
                {
                    Console.WriteLine(":(");
                }
                SymbianAttribute s = (SymbianAttribute)Attribute.GetCustomAttribute(typeof(Application), typeof(SymbianAttribute));
            }
            Attribute[] allPlatforms = Attribute.GetCustomAttributes(typeof(Application));
        }

        private static void UsingRefletion()
        {
            Application app = new Application();
            app.AvgStars = 3.7;
            app.Name = "GoatSimulator";
            app.LatestVersion = "10.3.3";
            Type appType = app.GetType();
            //Listing_2_72
            DumpObject(app);
            ExecuteMethodThroughReflection(app, "ShowAppInfo", new Type[] { typeof(string) }, new object[] { "Viktor" });
        }
    }
}