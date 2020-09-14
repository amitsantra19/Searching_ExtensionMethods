using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSwqapingInArray
{
    public class NumberSwapInArray
    {
        public static void SwapNumberInArray(int[] numbers, int givenValue)
        {
            LinkedList<int> linkList = new LinkedList<int>();
            var temp = linkList.AddLast(givenValue);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (givenValue > numbers[i] && givenValue != numbers[i])
                {
                    linkList.AddAfter(temp, numbers[i]);
                }
                else
                {
                    linkList.AddBefore(temp, numbers[i]);
                }
            }

            foreach (var item in linkList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
