using System;

namespace Chapter1
{
    //Using an Action to expose an event
    public class Pub
    {
        public Action OnChange { get; set; }

        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }
    }

    public static class Listing_1_82
    {
        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
        }

        public static void Main()
        {
            CreateAndRaise();
        }
    }
}