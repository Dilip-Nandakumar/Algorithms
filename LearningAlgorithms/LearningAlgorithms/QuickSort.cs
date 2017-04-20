using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms
{
    public class QuickSort
    {
        public static int count = 0;

        public static int[] Sort(int[] array)
        {
            return Sort(array, 0, array.Length - 1);
        }

        private static int[] Sort(int[] array, int startIndex, int lastIndex)
        {
            count++;

            if (lastIndex <= startIndex)
            {
                return array;
            }

            int pivot = array[lastIndex];
            int wall = startIndex;

            for (int i = startIndex; i < lastIndex; i++)
            {
                if (array[i] < pivot)
                {
                    Swap(ref array[wall++], ref array[i]);
                }
            }

            Swap(ref array[wall], ref array[lastIndex]);
            Sort(array, startIndex, wall - 1);
            Sort(array, wall + 1, lastIndex);

            return array;
        }

        private static void Swap(ref int firstNumber, ref int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
    }
}
