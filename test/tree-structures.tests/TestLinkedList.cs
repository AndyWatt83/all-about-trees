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
            Assert.True(testLinkedList.Peek() == 1);
            testLinkedList.Push(2);
            Assert.True(testLinkedList.Peek() == 2);
        }

        [Fact]
        public void TestPop()
        {
            var testLinkedList = new LinkedList<int>();

            testLinkedList.Push(1);
            testLinkedList.Push(2);
            testLinkedList.Push(3);

            var result = testLinkedList.Pop();
            Assert.True(result == 3);

            result = testLinkedList.Pop();
            Assert.True(result == 2);

            result = testLinkedList.Pop();
            Assert.True(result == 1);
        }

        [Fact]
        public void TestEmptyIntegerList()
        {
            var testLinkedList = new LinkedList<int>();
            var result = -999; // set not non-default value, to prove that it is re-set to default
            result = testLinkedList.Peek();
            Assert.True(result == 0);
        }

        [Fact]
        public void TestEmptyDoubleList()
        {
            var testLinkedList = new LinkedList<double>();
            var result = -999.5; // set not non-default value, to prove that it is re-set to default
            result = testLinkedList.Peek();
            Assert.True(result == 0.0);
        }

        [Fact]
        public void TestEmptyStringList()
        {
            var testLinkedList = new LinkedList<string>();
            var result = "Hello World"; // set not non-default value, to prove that it is re-set to default
            result = testLinkedList.Peek();
            Assert.True(result == null);
        }
    }
}