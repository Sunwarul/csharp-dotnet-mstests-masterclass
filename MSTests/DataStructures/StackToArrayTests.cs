using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSyntax.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSyntax.DataStructures.Tests
{
    [TestClass()]
    public class StackToArrayTests
    {
        [TestMethod()]
        public void StackToArrayTestChecker()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");

            var stackToArray = new StackToArray(stack);
            var actual = stackToArray.GetArray();
            string[] expected = {"one", "two", "four"};
        }
    }
}