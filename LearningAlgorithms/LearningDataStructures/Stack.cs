using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataStructures
{
    class Stack
    {
        private int[] array;
        private int defaultSize = 50;

        private int currentIndex = 0;

        public Stack()
        {
            array = new int[defaultSize];
        }

        public Stack(int size)
        {
            array = new int[size];
        }

        public void Push(int element)
        {
            if (currentIndex == array.Length)
            {
                throw new InvalidOperationException("Stack is Full");
            }

            array[currentIndex++] = element;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            return array[--currentIndex];
        }

        public int Top()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");
            }

            int topIndex = currentIndex - 1;
            return array[topIndex];
        }

        public bool IsEmpty()
        {
            return currentIndex == 0;
        }
    }
}
