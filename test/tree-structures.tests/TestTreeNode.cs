using System;
using Xunit;
using tree_structures.core;

namespace tree_structures.tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestFiltering()
        {
            // Arrange
            var testTree = this.TestData();

            // Act

            // Assert

        }

        private TreeNode<string> TestData()
        {
            var root = new TreeNode<string>("Parent");
            {
                var child0 = root.AddChild("Child0");
                var child1 = root.AddChild("Child1");
                {
                    var child10 = child1.AddChild("Child10");
                    var child11 = child1.AddChild("Child11");
                    var child12 = child1.AddChild("Child12");
                    {
                        var child120 = child12.AddChild("Child120");
                        {
                            var child1200 = child120.AddChild("Child1200-X");
                        }
                    }
                }
                var child2 = root.AddChild("Child2");
                {
                    var child20 = child2.AddChild("Child20");
                    var child21 = child2.AddChild("Child21");
                }
                var child3 = root.AddChild("Child3");
            }
            return root;
        }
    }
}
