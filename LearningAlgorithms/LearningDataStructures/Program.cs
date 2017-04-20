using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Results");

            //Stack
            //Console.WriteLine("StackEmpty_Pop_ThrowsException::" + StackEmpty_Pop_ThrowsException());
            //Console.WriteLine("StackFull_Push_ThrowsException::" + StackFull_Push_ThrowsException());
            //Console.WriteLine("Stack_PushSingleValueAndPop_ReturnsPushedValue::" + Stack_PushSingleValueAndPop_ReturnsPushedValue());

            //Helpers
            //Console.WriteLine("NumberToDigits_SingleDigitNumber_ReturnSingleDigit::" + NumberToDigits_SingleDigitNumber_ReturnSingleDigit());
            //Console.WriteLine("NumberToDigits_ThreeDigitNumber_ReturnThreeDigit::" + NumberToDigits_ThreeDigitNumber_ReturnThreeDigit());

            //CountNumbersWhosePermutationGreaterThanNumber
            //Console.WriteLine(GfGStack.CountNumbersWhosePermutationGreaterThanNumber(15));
            //Console.WriteLine(GfGStack.CountNumbersWhosePermutationGreaterThanNumber(100));            

            //GetMaxEqualSumOfStacks
            //int[] stack1 = { 3, 2, 1, 1, 1 };
            //int[] stack2 = { 4, 3, 2, 1 };
            //int[] stack3 = { 2, 5, 4, 1 };
            //Console.WriteLine("GetMaxEqualSumOfStacks::" + GfGStack.GetMaxEqualSumOfStacks(stack1, stack2, stack3));

            //NextMaximumNumber
            //int[] input = { 5, 1, 9, 2, 5, 1, 7 };
            //int[] result = GfGStack.NextSmallerOfNextGreater(input);

            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine(input[i] + "------>" + result[i]);
            //}

            //MaxDifferenceBwNearestLeftAndRightElement
            int[] input = { 5, 1, 9, 2, 5, 1, 7 };
            int result = GfGStack.MaxDifferenceBwNearestLeftAndRightElement(input);

            Console.WriteLine("MaxDifferenceBwNearestLeftAndRightElement -----> " + result);

            Console.ReadKey();
        }

        private static bool StackEmpty_Pop_ThrowsException()
        {
            try
            {
                Stack stack = new Stack();
                stack.Pop();
                return false;
            }
            catch
            {
                return true;
            }

        }

        private static bool StackFull_Push_ThrowsException()
        {
            try
            {
                Stack stack = new Stack(1);
                stack.Push(5);
                stack.Push(10);
                return false;
            }
            catch
            {
                return true;
            }

        }

        private static bool Stack_PushSingleValueAndPop_ReturnsPushedValue()
        {
            try
            {
                Stack stack = new Stack(1);
                int pushValue = 5;
                stack.Push(pushValue);
                int popValue = stack.Pop();

                if (popValue == pushValue)
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }

        }

        private static bool NumberToDigits_SingleDigitNumber_ReturnSingleDigit()
        {
            var result = Helpers.NumbersToDigitConverter(1);

            if (result.Count == 1 && result.Contains(1))
            {
                return true;
            }

            return false;
        }

        private static bool NumberToDigits_ThreeDigitNumber_ReturnThreeDigit()
        {
            var result = Helpers.NumbersToDigitConverter(123);

            if (result.Count == 3 && result.Contains(1) && result.Contains(2) && result.Contains(3))
            {
                return true;
            }

            return false;
        }
    }
}
