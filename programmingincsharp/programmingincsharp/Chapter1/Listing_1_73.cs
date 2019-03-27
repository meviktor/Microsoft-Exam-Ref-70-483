using System.Collections.Generic;

namespace Chapter1
{
    public static class Listing_1_73
    {
        //The compiler-generated code for a foreach loop
        public static void Main()
        {
            var people = new List<Person>
            {
                new Person(){ FirstName = "John", LastName = "Doe" },
                new Person(){ FirstName = "Jane", LastName = "Doe" }
            };

            List<Person>.Enumerator e = people.GetEnumerator();

            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null) d.Dispose();
            }

        }

        class Person
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }
        }
    }
}
