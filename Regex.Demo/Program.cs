using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex.Demo
{
    public class Program
    {
        private static void Main(string[] args)
        {

            const string strSource = @"[AA1]+[B1]+[A330]+[BZ1]";
            var regex = new System.Text.RegularExpressions.Regex(@"(\[)([A-Z]+)(\d+)(\])(.?)");
            var matchs = regex.Matches(strSource);
            var i = 0;
            var result = string.Empty;
            foreach (Match match in matchs)
            {
                i++;
                var s0 = match.Groups[0].Value;
                var s1 = match.Groups[1].Value;
                var s2 = match.Groups[2].Value;
                var s3 = match.Groups[4].Value;
                var s4 = match.Groups[5].Value;

                result += $"{s1}{s2}{i}{s3}{s4}";
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
