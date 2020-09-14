using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class DSBinarySearch
    {
        public static void BinarySearch(int[] numbers, int expnum)
        {
            int last = numbers.Length-1;
            int first = 0;
            while (first <= last)
            {
                int mid = (first+last)/2;
                if (expnum == numbers[mid])
                {
                    Console.WriteLine($"Data Matched: {expnum.ToString()} at index {mid.ToString()}");
                    break;
                }
                if (expnum > numbers[mid])
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }
        }

        public static void BinarySearchExtension(this int[] numbers, int expnum)
        {
            int last = numbers.Length - 1;
            int first = 0;
            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (expnum == numbers[mid])
                {
                    Console.WriteLine($"Data Matched: {expnum.ToString()} at index {mid.ToString()}");
                    break;
                }
                else
                {
                    if (expnum > numbers[mid]) first = mid + 1;
                    else last = mid - 1;
                }
            }
        }
    }
}
