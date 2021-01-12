using System;

namespace CSharpSyntax.DataStructures
{
    public class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        public Stack()
        {
            top = -1;
        }

        // IsEmpty or not
        bool IsEmpty()
        {
            return (top < 0);
        }
        public bool Push(int value)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = value;
                return true;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow.");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        public int Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Underflow.");
                return 0;
            }
            else
            {
                Console.WriteLine($"Top most element is {stack[top]}");
                return stack[top];

            }
        }

        public void PrintStack()
        {
            Console.WriteLine("Items in the stack are: ");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
        public int SizeOfStack()
        {
            return (top + 1);
        }
    }
}
