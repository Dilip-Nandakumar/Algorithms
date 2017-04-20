using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms
{
    static class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            int arrayCount = array.Length;

            for (int pass = 0; pass < arrayCount - 1; pass++)
            {
                int minimumIndex = pass;

                for (int iteration = pass + 1; iteration < arrayCount; iteration++)
                {
                    if (array[iteration] < array[minimumIndex])
                    {
                        minimumIndex = iteration;
                    }
                }

                if (minimumIndex != pass)
                {
                    Swap(ref array[pass],ref array[minimumIndex]);
                }
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
