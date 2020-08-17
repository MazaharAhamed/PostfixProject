using System;
using System.Collections.Generic;
using System.Text;

namespace PostfixProject
{
    class StackChar
    {
        private char[] stackArray;
        private int top;

        public StackChar()
        {
            stackArray = new char[10];
            top = -1;
        }

        public StackChar(int maxSize)
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

        public void Push(char x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            top = top + 1;
            stackArray[top] = x;
        }

        public char Pop()
        {
            char x;
            if (isEmpty())
            {
                Console.WriteLine("Stack Underflow");
            }
            x = stackArray[top];
            top = top - 1;
            return x;
        }

        public char Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            return stackArray[top];
        }
    }
}
