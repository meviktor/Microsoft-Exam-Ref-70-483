using System;
using System.Text.RegularExpressions;

public class RegularExpressionExample
{
    public static void Main()
    {
        string pattern = @"\b.*[.?!;:](\s|\z)";
        string input = "this. what: is? go, thing.";
        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}