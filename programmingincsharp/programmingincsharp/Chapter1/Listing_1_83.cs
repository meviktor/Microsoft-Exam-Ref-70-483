using System;

namespace Chapter1
{
    //Using the event keyword
    public class PubWithEvent
    {
        public event Action OnChange = delegate { };

        public void Raise()
        {
            OnChange();
        }
    }
    public static class Listing_1_83
    {
        public static void Main()
        {
            PubWithEvent p = new PubWithEvent();
            //p.OnChange = () => Console.WriteLine("This is not possible! Only subscribe(+=) and unsubscribe(-=)!");
            p.OnChange += () => Console.WriteLine("Event handler for OnChange event");
            //p.OnChange(); // Cannot raise the event outside of the publisher class
            p.Raise(); //Code which will raise the event can be called of couse
            //p.OnChange = null; //This is not allowed only for code of the PubWithEvent class
        }
    }
}