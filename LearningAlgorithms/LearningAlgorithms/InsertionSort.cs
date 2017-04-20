using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms
{
    static class InsertionSort
    {
        public static int[] Sort(int[] inputArray)
        {
            int inputSize = inputArray.Length;            

            for (int inputIndex = 1; inputIndex < inputSize; inputIndex++)
            {
                int insertValue = inputArray[inputIndex];
                int outputIndex = inputIndex - 1;

                while (outputIndex >= 0 && insertValue < inputArray[outputIndex])
                {
                    inputArray[outputIndex + 1] = inputArray[outputIndex];                    
                    outputIndex--;
                }

                inputArray[++outputIndex] = insertValue;                
            }

            return inputArray;
        }
    }
}
