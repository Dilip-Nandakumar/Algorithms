using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataStructures
{
    internal static class Helpers
    {
        public static List<int> NumbersToDigitConverter(int number)
        {
            List<int> result = new List<int>();

            while (number>0)
            {
                int reminder = number % 10;
                result.Add(reminder);
                number = number - reminder;
                number = number / 10;
            }

            return result;
        }

        public static int GetSumOfStackElements(int[] stack)
        {
            int sum = 0;

            for (int i = 0; i < stack.Length; i++)
            {
                sum += stack[i];
            }

            return sum;
        }

        public static bool IsStackEmpty(int[] stack, int currentIndex)
        {
            return stack.Length == 0 || currentIndex >= stack.Length;
        }
    }
}
