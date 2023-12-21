


namespace Findingvaliddate;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string input = " nksugdkbaidfugqkbiuh jjhgtes 04201889 kabsciuh 95101999 gj655488jbb ,mmnjjhg8876 66775555 99887777 ";

        var validDates = FindValidDates(input);

        Console.WriteLine("Valid Dates:");
        foreach (var date in validDates)
        {
            Console.WriteLine(date);
        }
    }

    static IEnumerable<string> FindValidDates(string input)
    {
        var regex = new Regex(@"\b(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])[1-9]\d{3}\b");

        var matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            yield return match.Value;
        }
    }
}
