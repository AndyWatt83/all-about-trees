using System;
using System.Text;
using tree_structures.core;

namespace tree_structures.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new TreeNode<string>("Parent");
            root.Filters.Add(o => o.Contains("X"));

            {
                var child0 = root.AddChild("Child0");
                var child1 = root.AddChild("Child1");
                {
                    var child10 = child1.AddChild("XXXChild10");
                    var child11 = child1.AddChild("Child11");
                    var child12 = child1.AddChild("ZZZChild12");
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

            foreach(var node in root)
            {
                Console.WriteLine($"{GetIndent(node.Level)}{node.NodeData} : {node.FilterResult()}");
            }

            Console.WriteLine();

            foreach(var node in root)
            {
                Console.WriteLine($"{node.NodeData} : {node.ID} : {node.ParentID}");
            }
        }

        private static string GetIndent(int level)
        {
            var sb = new StringBuilder();
            for(int i = 0; i < level; i++)
            {
                sb.Append("  ");
            }
            return sb.ToString();
        }
    }
}
