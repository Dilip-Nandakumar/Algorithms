using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 2, 5, 15, 7, 39, 1, 9 , 12, 10};
            ////int[] inputArray = { 5, 7, 9, 2 };
            ////int[] outputArray = InsertionSort.Sort(inputArray);
            int[] outputArray = QuickSort.Sort(inputArray);

            foreach (var output in outputArray)
            {
                Console.WriteLine(output);
            }
            //MergeSort.LoopSort(inputArray);
            
            Console.ReadKey();
        }
    }
}
