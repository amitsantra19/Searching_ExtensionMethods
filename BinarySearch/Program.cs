using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Search with Static input and method Call");
            int[] numbers = { 5, 10, 20, 30, 31, 40, 45, 48, 50 };
            Console.Write("Static Input set:   ");
            Console.WriteLine(string.Join(",", numbers));
            int expNum = 5;
            Console.WriteLine($"Expected Number to be Search from the Above list:{expNum.ToString()}");
            //DSBinarySearch.BinarySearch(numbers,expNum);
            numbers.BinarySearchExtension(expNum);
            Console.ReadKey();
        }
    }
}
