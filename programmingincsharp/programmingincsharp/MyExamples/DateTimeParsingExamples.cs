using System;
using System.Globalization;

namespace programmingincsharp.MyExamples
{
    public class DateTimeParsingExamples
    {
        private static string dateTimeString_noTimeZone = "02/05/2019 04:55";
        private static string dateTimeString_withTimeZone = "02/05/2019 04:55 -4:00";
        private static CultureInfo culture_hun = new CultureInfo("hu-HU");

        public static void Main()
        {
            Console.WriteLine("Culture of the current thread: {0}\n", CultureInfo.CurrentCulture);

            Console.WriteLine("String to convert (no timezone): {0}", dateTimeString_noTimeZone);
            Console.WriteLine("Parsed: {0}, Kind: {1}", DateTime.Parse(dateTimeString_noTimeZone), DateTime.Parse(dateTimeString_noTimeZone).Kind);
            Console.WriteLine("String to convert (with timezone): {0}", dateTimeString_withTimeZone);
            Console.WriteLine("Parsed: {0}\n", DateTime.Parse(dateTimeString_withTimeZone));

            Console.WriteLine("New culture to parse datetime: {0}\n", culture_hun);
            Console.WriteLine("String to convert (no timezone): {0}", dateTimeString_noTimeZone);
            Console.WriteLine("Parsed: {0}", DateTime.Parse(dateTimeString_noTimeZone, culture_hun));
            Console.WriteLine("String to convert (with timezone): {0}", dateTimeString_withTimeZone);
            Console.WriteLine("Parsed: {0}\n", DateTime.Parse(dateTimeString_withTimeZone, culture_hun));

            Console.WriteLine("Convetring datetime no timezone info containing using some of the DateTimeStyles enum values (with hungarian culture):");

            //no time zone - assume its local (so UTC+1) - donesn't necessary Assume... flag if it has a timezone info about UTC+? or UTC-?
            var adjUTC = DateTime.Parse(dateTimeString_noTimeZone, culture_hun, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal);
            //no time zone - assume universal (so UTC) - donesn't necessary the Assume... flag if it has a timezone info about UTC(+0)
            var assmUTC = DateTime.Parse(dateTimeString_noTimeZone, culture_hun, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);

            Console.WriteLine("AdjustToUniversal & AssumeLocal: {0}, Kind: {1}", adjUTC, adjUTC.Kind);
            Console.WriteLine("AdjustToUniversal & AssumeUniversal: {0}, Kind: {1}", assmUTC, assmUTC.Kind);
        }

        //Culture of the current thread: en-US
        //
        //String to convert(no timezone): 02/05/2019 04:55
        //Parsed: 2/5/2019 4:55:00 AM
        //String to convert(with timezone): 02/05/2019 04:55 -4:00
        //Parsed: 2/5/2019 9:55:00 AM
        //
        //New culture to parse datetime: hu-HU
        //
        //String to convert(no timezone): 02/05/2019 04:55
        //Parsed: 2/5/2019 4:55:00 AM
        //String to convert(with timezone): 02/05/2019 04:55 -4:00
        //Parsed: 2/5/2019 9:55:00 AM
    }
}