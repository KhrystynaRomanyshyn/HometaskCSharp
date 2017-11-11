using SpecialArrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_05_task1
{
    class Program
    {
        static void Main(string[] args)
        {

            var customArray = new CustomFirstIndexArray(5, 1, 2, 3, 4, 5, 6, 7);

            customArray[6] = 100;
            int x = customArray[9];
            int y = customArray[6];
        }
    }
}