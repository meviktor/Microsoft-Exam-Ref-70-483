//source: https://docs.microsoft.com/en-us/dotnet/api/system.flagsattribute?view=netframework-4.7.2
using System;

[FlagsAttribute]
public enum PhoneService
{
    None = 0,
    LandLine = 1,
    Cell = 2,
    Fax = 4,
    Internet = 8,
    Other = 16
}

public class FlagsAttributeExample
{
    public static void Main()
    {
        // Define three variables representing the types of phone service
        // in three households.
        var household1 = PhoneService.LandLine | PhoneService.Cell |
                         PhoneService.Internet;
        //   00000001 - land line
        //   00000010 - cell
        // | 00001000 - internet
        // ----------
        //   00001011 = household1

        var household2 = PhoneService.None;
        // 00000000 = household2 (None)

        var household3 = PhoneService.Cell | PhoneService.Internet;
        //   00000010 - cell
        // | 00001000 - internet
        // ----------
        //   00001010 = household3

        // Store the variables in an array for ease of access.
        PhoneService[] households = { household1, household2, household3 };

        // Which households have no service?
        for (int ctr = 0; ctr < households.Length; ctr++)
            // The only way you can check this. If you use a bitwise AND operator in this case the result will be PhoneService.None all the time.
            Console.WriteLine("Household {0} has phone service: {1}",
                              ctr + 1,
                              households[ctr] == PhoneService.None ?
                                  "No" : "Yes");
        Console.WriteLine();

        // Which households have cell phone service?
        for (int ctr = 0; ctr < households.Length; ctr++)
            // Using the bitwise AND operator to see that the flag/bit belongs to cell phone serivice is set or not.
            Console.WriteLine("Household {0} has cell phone service: {1}",
                              ctr + 1,
                              (households[ctr] & PhoneService.Cell) == PhoneService.Cell ?
                                 "Yes" : "No");
        Console.WriteLine();
        // Case: household 1
        //
        //    00001011 - household1
        //  & 00000010 - cell
        //  ----------
        //    00000010 - cell
        // This household has cell phone access, because the appropriate flag is set.

        // Which households have cell phones and land lines?
        var cellAndLand = PhoneService.Cell | PhoneService.LandLine;
        for (int ctr = 0; ctr < households.Length; ctr++)
            // Using the bitwise AND operator to see that the flags/bits belong to cell and land phone serivice are set or not.
            Console.WriteLine("Household {0} has cell and land line service: {1}",
                              ctr + 1,
                              (households[ctr] & cellAndLand) == cellAndLand ?
                                 "Yes" : "No");
        Console.WriteLine();

        // List all types of service of each household?//
        for (int ctr = 0; ctr < households.Length; ctr++)
            Console.WriteLine("Household {0} has: {1:G}",
                              ctr + 1, households[ctr]);
        Console.WriteLine();
    }
}
// The example displays the following output:
//    Household 1 has phone service: Yes
//    Household 2 has phone service: No
//    Household 3 has phone service: Yes
//
//    Household 1 has cell phone service: Yes
//    Household 2 has cell phone service: No
//    Household 3 has cell phone service: Yes
//
//    Household 1 has cell and land line service: Yes
//    Household 2 has cell and land line service: No
//    Household 3 has cell and land line service: No
//
//    Household 1 has: LandLine, Cell, Internet
//    Household 2 has: None
//    Household 3 has: Cell, Internet
