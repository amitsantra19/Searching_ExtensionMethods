using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Search with Static input and method Call");
            int[] numbers = { 5, 10, 20, 30, 10, 21, 31, 10 };
            Console.Write("Static Input set:   ");
            Console.WriteLine(string.Join(",", numbers));
            int expNum = 10;
            Console.WriteLine($"Expected Number to be Search from the Above list:{expNum.ToString()}");
            DSLinearSearch.LinearSearch(numbers, expNum);
            Console.WriteLine();
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Linear Search with dynamic input and Extension method Call");
            Console.WriteLine("Enter the array size for Linear Searching");
            int x =Convert.ToInt32(Console.ReadLine());
            int[] listData =new int[x];
            Console.WriteLine("Enter the numbers of Array");
            for (int i = 0; i < listData.Length; i++)
            {
                listData[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the Expected number:");
            int expectedNumber = Convert.ToInt32(Console.ReadLine());
            listData.LinearSearchExtension(expectedNumber); // calling extension method
            listData.LinearSearchExtension(expectedNumber, "Amit"); // calling extension method

            Console.ReadKey();
        }
    }
}
