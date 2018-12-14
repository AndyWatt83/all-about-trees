using System;
using Xunit;
using tree_structures.core;

namespace tree_structures.tests
{
    public class TestLinkedList
    {
        [Fact]
        public void TestAdd()
        {
            var testLinkedList = new LinkedList<int>();

            testLinkedList.Push(1);
            Assert.True(testLinkedList.Peek == 1);
            testLinkedList.Push(2);
            Assert.True(testLinkedList.Peek == 2);
        }
    }
}