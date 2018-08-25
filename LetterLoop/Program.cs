using System;
using System.Globalization;

namespace LetterLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some nonsense");
            var inputs = Console.ReadLine();
            var i = 0;
            char[] myChar = {'-'};
            var finalOutput = "";         

            foreach (var input in inputs)
            {
                string output = new String(input, ++i);
                finalOutput += output + "-";
            }
            var printOutput = finalOutput.TrimEnd(myChar);
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            var titleCase = textInfo.ToTitleCase(printOutput);

            Console.Write(titleCase);
            Console.ReadLine();
        }
    }
}
