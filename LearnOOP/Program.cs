using System;
using CSharpSyntax.DataStructures;

namespace CSharpSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.PrintStack();
        }
    }
}
