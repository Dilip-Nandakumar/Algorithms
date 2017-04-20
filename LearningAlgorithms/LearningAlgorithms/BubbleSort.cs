using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms
{
    static class BubbleSort
    {
        public static int[] Sort(int[] array)
        {
            int iterationCount = array.Length - 1;
            bool swapped = false;

            for (int pass = 0; pass < iterationCount; pass++)
            {
                swapped = false;

                for (int elementIndex = 0; elementIndex < iterationCount - pass; elementIndex++)
                {
                    if (array[elementIndex] > array[elementIndex + 1])
                    {
                        Swap(ref array[elementIndex], ref array[elementIndex + 1]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            return array;
        }

        private static void Swap(ref int firstElement, ref int secondElement)
        {
            int temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }
    }
}
