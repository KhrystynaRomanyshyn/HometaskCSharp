using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string version1 = "3.02.5";
            string version2 = "3.2.8";

            Console.WriteLine( GetNewestVersion(version1, version2));
            Console.WriteLine(GetNewerVersion(version1, version2));

            Console.ReadKey();
        }

        static string GetNewestVersion(string v1, string v2)
        {
            for(int i=0; i<=v1.Length; i++)
            {
                if (v1[i] != '.')
                {
                    if (v1[i] < v2[i])
                    {
                        return v2;
                    }
                    if (v1[i] > v2[i])
                    {
                        return v1;
                    }
                    continue;
                }
            }
            return "";
        }

        static string GetNewerVersion(string first, string second)
        {
            int[] firstParsed = first.Split('.').Select(s => int.Parse(s)).ToArray();
            int[] secondParsed = second.Split('.').Select(s => int.Parse(s)).ToArray();

            for (int i = 0; i < Math.Min(firstParsed.Length, secondParsed.Length); i++)
            {
                if (firstParsed[i] == secondParsed[i])
                {
                    continue;
                }

                return firstParsed[i] > secondParsed[i] ? first : second;
            }

            return first;
        }
    }
}
