using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSyntax.DataStructures
{
    public class StackToArray
    {
        private Stack<string> _stack = new Stack<string>();
        public StackToArray(Stack<string> stack)
        {
            _stack = stack;
        }

        public string[] GetArray()
        {
            String[] stringFromStack = _stack.ToArray();
            return stringFromStack;
        }
    }
}
