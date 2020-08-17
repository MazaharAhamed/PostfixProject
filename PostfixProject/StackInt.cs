using System;
using System.Collections.Generic;
using System.Text;

namespace PostfixProject
{
    class StackInt
    {
        private int[] stackArray;
        private int top;

        public StackInt()
        {
            stackArray = new char[10];
            top = -1;
        }

        public StackInt(int maxSize)
        {
            stackArray = new char[maxSize];
            top = -1;
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool isFull()
        {
            return (top == stackArray.Length - 1);
        }

        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            top = top + 1;
            stackArray[top] = x;
        }

        public int Pop()
        {
            int x;
            if (isEmpty())
            {
                Console.WriteLine("Stack Underflow");
            }
            x = stackArray[top];
            top = top - 1;
            return x;
        }

        public int Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            return stackArray[top];
        }
    }
}
