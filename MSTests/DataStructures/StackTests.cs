using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSyntax.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSyntax.DataStructures.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void CreateASackInstance()
        {
            var stack = new Stack();
            Assert.IsInstanceOfType(stack, typeof(Stack));
        }

        [TestMethod()]
        public void PushElementIntoStack()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.SizeOfStack());
        }

        [TestMethod]
        public void PopElement()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            var popped = stack.Pop();
            Assert.AreEqual(popped, 2);
        }

        [TestMethod]
        public void SizeOfCount()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.SizeOfStack());
        }

        [TestMethod]
        public void PeekFromTopOfTheStack()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            int peeked = stack.Peek();
            Assert.AreEqual(peeked, 4);
        }
    }
}