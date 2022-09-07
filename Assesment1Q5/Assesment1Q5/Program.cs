using System;
using System.Globalization;
using System.Threading;

//Write a C# Sharp program to compare four sets of words by using each member of the string comparison enumeration. The comparisons use the conventions of the English (United States) and Sami (Upper Sweden) cultures. 

//Note : The strings "encyclopedia" and "encyclopedia" are considered equivalent in the en-US culture but not in the Sami (Northern Sweden) culture.


namespace Assesment1Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String[] cultureNames = { "en-US", "sv-SE" };
            String[] strs1 = { "case",  "encyclopedia", "Archeology" };
            String[] strs2 = { "Case", "encyclopedia", "ARCHEOLOGY" };
            StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
                for (int ctr = 0; ctr <= strs1.GetUpperBound(0); ctr++)
                {
                    foreach (var comparison in comparisons)
                        Console.WriteLine($"{strs2[ctr]} = {strs2[ctr]} ({comparison}): {String.Equals(strs1[ctr], strs2[ctr], comparison)}");

                    
                }
                Console.WriteLine();
            }

        }
    }
}
