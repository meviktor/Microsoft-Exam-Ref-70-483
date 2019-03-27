using System;

namespace Chapter1
{
    //Custom event arguments
    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }

    public class PubWithCustomEventArgs
    {
        public event EventHandler<MyArgs> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }
    public static class Listing_1_84
    {
        public static void CreateAndRaise()
        {
            PubWithCustomEventArgs p = new PubWithCustomEventArgs();
            p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);

            p.Raise();
        }
    }
}