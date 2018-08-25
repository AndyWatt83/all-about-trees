﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace tree_structures.core
{
    public class TreeNode<T> : IEnumerable<TreeNode<T>>
    {
        public T NodeData { get; set; }
        public TreeNode<T> Parent { get; set; }
        public ICollection<TreeNode<T>> Children {get; set; } = new List<TreeNode<T>>();

        public TreeNode(T nodeData)
        {
            this.NodeData = nodeData;
        }

        public bool IsRoot { get { return this.Parent == null; } }

        public bool IsLeaf { get { return this.Children.Count().Equals(0); } }

        public int Level
        {
            get
            {
                if (this.IsRoot) return 0;
                return Parent.Level + 1;
            }
        }

        public TreeNode<T> AddChild(T child)
        {
            TreeNode<T> childNode = new TreeNode<T>(child) { Parent = this};
            this.Children.Add(childNode);
            return childNode;
        }

        // IEnumerable Implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<TreeNode<T>> GetEnumerator()
        {
            yield return this;
            foreach (var directChild in this.Children)
                foreach (var anyChild in directChild)
                    yield return anyChild;
        }

        // Filtering code
        public static ICollection<Func<T, bool>> Filters { get; } = new List<Func<T, bool>>();

        public bool FilterChildren{ get; } = true;

        public bool FilterResult()
        {
            var match = false;
            foreach(var filter in TreeNode<T>.Filters)
                if(filter.Invoke(this.NodeData))
                    match = true;

            if (this.FilterChildren)
                foreach(var node in this.Children)
                    if(node.FilterResult())
                        match = true;

            return match;
        }
    }
}