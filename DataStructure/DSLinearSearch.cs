using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public static class DSLinearSearch
    {
        public static  void LinearSearch(int[] numbers, int expectedNumber)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == expectedNumber)
                {
                    count++;
                    continue;
                }
            }
            Console.WriteLine($"Total Number of Match : {count.ToString()}");
        }

        public static void LinearSearchExtension(this int[] numbers, int expNum)
        {
            int count = 0;
            foreach (var item in numbers)
            {
                if (item == expNum)
                {
                    count++;
                }
            }
            Console.WriteLine($"Total Number of Match : {count.ToString()}");
        }

       // over loading Extension method
        public static void LinearSearchExtension(this int[] numbers, int expNum, string name)
        {
            int count = 0;
            foreach (var item in numbers)
            {
                if (item == expNum)
                {
                    count++;
                }
            }
            Console.WriteLine($"Total Number of Match : {count.ToString()}");
        }

    }
}
