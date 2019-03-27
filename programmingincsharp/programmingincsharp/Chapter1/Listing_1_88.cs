namespace Chapter1
{
    //Parsing an invalid number
    public static class Listing_1_88
    {
        public static void Main()
        {
            string s = "NaN";
            int i = int.Parse(s);
        }
    }
}