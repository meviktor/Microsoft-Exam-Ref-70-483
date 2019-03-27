using System;

namespace Chapter1
{
    //Custom event accessor
    public class PubWithCustomEventAccessor
    {
        private event EventHandler<MyArgs> onChange = delegate { };
        public event EventHandler<MyArgs> OnChange
        {
            add
            {
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                }
            }
        }

        public void Raise()
        {
            onChange(this, new MyArgs(42));
        }
    }
    public static class Listing_1_85
    {
        public static void Main()
        {
            PubWithCustomEventAccessor p = new PubWithCustomEventAccessor();
            p.OnChange += (sender, e) => Console.WriteLine("Event handler for OnChange event. Event argument: {0}", e.Value);
            p.Raise();
        }
    }
}
