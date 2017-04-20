using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataStructures
{
    internal static class GfGStack
    {
        public static int CountNumbersWhosePermutationGreaterThanNumber(int n)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                var digits = Helpers.NumbersToDigitConverter(i);
                int max = digits.First();
                bool isNumberValid = true;

                foreach (int digit in digits)
                {
                    if (digit > max)
                    {
                        isNumberValid = false;
                        break;
                    }

                    max = digit;
                }

                if (isNumberValid)
                {
                    count++;
                }
            }

            return count;
        }

        public static int GetMaxEqualSumOfStacks(int[] stack1, int[] stack2, int[] stack3)
        {
            int maxEqualSum = 0;
            int stack1CurrentIndex = 0;
            int stack2CurrentIndex = 0;
            int stack3CurrentIndex = 0;

            int stack1Sum = Helpers.GetSumOfStackElements(stack1);
            int stack2Sum = Helpers.GetSumOfStackElements(stack2);
            int stack3Sum = Helpers.GetSumOfStackElements(stack3);

            while (!(Helpers.IsStackEmpty(stack1, stack1CurrentIndex) && Helpers.IsStackEmpty(stack2, stack2CurrentIndex) && Helpers.IsStackEmpty(stack3, stack3CurrentIndex)))
            {
                if (stack1Sum == stack2Sum && stack2Sum == stack3Sum)
                {
                    maxEqualSum = stack3Sum;
                    break;
                }
                else
                {
                    if (stack1Sum > (stack2Sum + stack3Sum) / 2)
                    {
                        stack1Sum -= stack1[stack1CurrentIndex++];
                        continue;
                    }

                    if (stack2Sum > stack3Sum)
                    {
                        stack2Sum -= stack2[stack2CurrentIndex++];
                        continue;
                    }

                    stack3Sum -= stack3[stack3CurrentIndex++];
                }
            }

            return maxEqualSum;
        }

        internal enum NextComparison
        {
            Greater = 1,
            Smaller = 2
        }

        private static int[] NextNumber(int[] input, NextComparison nextComparison)
        {
            int[] result = new int[input.Length];
            Stack stack = new Stack();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                while (!stack.IsEmpty() && (nextComparison == NextComparison.Greater ?
                                             input[stack.Top()] <= input[i]
                                           : input[stack.Top()] >= input[i]))
                {
                    stack.Pop();
                }

                if (!stack.IsEmpty())
                {
                    result[i] = stack.Top();
                }
                else
                {
                    result[i] = -1;
                }

                stack.Push(i);
            }

            return result;
        }

        public static int[] NextSmallerOfNextGreater(int[] input)
        {
            int[] nextGreater = NextNumber(input, NextComparison.Greater);
            int[] nextSmaller = NextNumber(input, NextComparison.Smaller);
            int[] result = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int nextGreaterIndex = nextGreater[i];

                if (nextGreaterIndex == -1)
                {
                    result[i] = -1;
                    continue;                   
                }

                int nextSmallerOfNextGreaterIndex = nextSmaller[nextGreaterIndex];

                if (nextSmallerOfNextGreaterIndex == -1)
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = input[nextSmallerOfNextGreaterIndex];
                }                              
            }

            return result;
        }

        public static int MaxDifferenceBwNearestLeftAndRightElement(int[] input)
        {
            int[] leftNearestArray = LeftNearestElement(input);
            int[] rightNearestArray = RightNearestElement(input);
            int maxAbsDifference = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int difference = Math.Abs(leftNearestArray[i] - rightNearestArray[i]);

                if (maxAbsDifference < difference)
                {
                    maxAbsDifference = difference;
                }
            }

            return maxAbsDifference;
        }

        private static int[] LeftNearestElement(int[] input)
        {
            Stack stack = new Stack();
            int[] result = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {                
                while (!stack.IsEmpty() && stack.Top() >= input[i])
                {
                    stack.Pop();
                }

                if (stack.IsEmpty())
                {
                    stack.Push(input[i]);
                    result[i] = default(int);
                    continue;
                }

                result[i] = stack.Top();
                stack.Push(input[i]);

            }

            return result;
        }

        private static int[] RightNearestElement(int[] input)
        {
            Stack stack = new Stack();
            int[] result = new int[input.Length];

            for (int i = input.Length - 1; i >= 0; i--)
            {
                while (!stack.IsEmpty() && stack.Top() >= input[i])
                {
                    stack.Pop();
                }

                if (stack.IsEmpty())
                {
                    stack.Push(input[i]);
                    result[i] = default(int);
                    continue;
                }

                result[i] = stack.Top();
                stack.Push(input[i]);

            }

            return result;
        }
    }
}
