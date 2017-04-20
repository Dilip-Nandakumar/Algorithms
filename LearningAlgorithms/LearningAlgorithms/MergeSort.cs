using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms
{
    class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            return RecursiveSort(array, 0, array.Length);
        }

        public static int[] LoopSort(int[] array)
        {
            for (int j = 1; j < array.Length - 1; j = j * 2)
            {
                for (int i = 0; i < array.Length; i = i + (j * 2))
                {
                    //Console.WriteLine("array" + i + ".." + j);
                    //Console.WriteLine("array" + (i + j) + ".." + j);
                    int maxLength = i + j + j;

                    if (maxLength > array.Length && j == 1)
                    {
                        MergeLoop(ref array, i - 2, i, i, (i + j));
                        break;
                    }

                    if (j != 1 && maxLength == array.Length - 1)
                    {
                        maxLength += 1;
                        MergeLoop(ref array, i, (i + j), (i + j), maxLength);
                        break;
                    }

                    MergeLoop(ref array, i, (i + j), (i + j), maxLength);
                }
            }

            return array;
        }

        private static void MergeLoop(ref int[] inputArray, int firstIndex, int firstLength, int secondIndex, int secondLength)
        {
            int mergedIndex = 0;
            int length = (firstLength - firstIndex) + (secondLength - secondIndex);
            int[] outputArray = new int[length];
            int inputIndex = firstIndex;

            while (firstIndex < firstLength && secondIndex < secondLength)
            {
                if (inputArray[firstIndex] < inputArray[secondIndex])
                {
                    outputArray[mergedIndex++] = inputArray[firstIndex++];
                }
                else
                {
                    outputArray[mergedIndex++] = inputArray[secondIndex++];
                }
            }

            if (firstIndex < firstLength)
            {
                while (firstIndex < firstLength)
                {
                    outputArray[mergedIndex++] = inputArray[firstIndex++];
                }
            }

            if (secondIndex < secondLength)
            {
                while (secondIndex < secondLength)
                {
                    outputArray[mergedIndex++] = inputArray[secondIndex++];
                }
            }

            for (int i = 0; i < outputArray.Length; i++)
            {
                inputArray[inputIndex + i] = outputArray[i];
            }
        }

        private static int[] RecursiveSort(int[] array, int startIndex, int length)
        {
            int divideLength = length / 2;
            int[] mergedArray;

            if (divideLength == default(int))
            {
                mergedArray = new int[1];
                mergedArray[0] = array[startIndex];
                return mergedArray;
            }

            int[] firstArray = RecursiveSort(array, startIndex, divideLength);
            int[] secondArray = RecursiveSort(array, startIndex + divideLength, length - divideLength);

            mergedArray = Merge(firstArray, secondArray);

            return mergedArray;
        }

        private static int[] Merge(int[] firstArray, int[] secondArray)
        {
            int firstIndex = 0, secondIndex = 0, mergedIndex = 0;
            int[] mergedArray = new int[firstArray.Length + secondArray.Length];

            while (firstIndex < firstArray.Length && secondIndex < secondArray.Length)
            {
                if (firstArray[firstIndex] < secondArray[secondIndex])
                {
                    mergedArray[mergedIndex++] = firstArray[firstIndex++];
                }
                else
                {
                    mergedArray[mergedIndex++] = secondArray[secondIndex++];
                }
            }

            if (firstIndex < firstArray.Length)
            {
                while (firstIndex < firstArray.Length)
                {
                    mergedArray[mergedIndex++] = firstArray[firstIndex++];
                }
            }

            if (secondIndex < secondArray.Length)
            {
                while (secondIndex < secondArray.Length)
                {
                    mergedArray[mergedIndex++] = secondArray[secondIndex++];
                }
            }

            return mergedArray;
        }
    }
}
