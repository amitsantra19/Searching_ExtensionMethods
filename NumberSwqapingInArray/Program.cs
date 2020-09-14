using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSwqapingInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Search with Static input and method Call");
            int[] numbers = { 25,11,4,28,6,9,15 };
            Console.Write("Static Input set:   ");
            Console.WriteLine(string.Join(",", numbers));
            int expNum = 6;
            Console.WriteLine($"Expected Number to be Search from the Above list:{expNum.ToString()}");
            //DSLinearSearch.LinearSearch(numbers, expNum);
            NumberSwapInArray.SwapNumberInArray(numbers, expNum);
            Console.ReadKey();
        }
    }
}
