using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace tree_structures.core
{
    public class DoubleLinkedList<T>
    {
        private Node<T> head;
        private int count;
        private class Node<TNode>
        {
            public TNode data;
            public Node<TNode> next;
            public Node<TNode> previous;
        }

        public int Count
        {
            get => count;
        }

        public void Push(T item)
        {
            head = new Node<T> { data = item, next = head };
            head.next.previous = head;
            count += 1;
        }

        public T Peek()
        {
            if(head == null) return default(T);
            return head.data;
        }

        public T Pop()
        {
            if(head == null) return default(T);

            var returnValue = this.Peek();
            head = head.next;
            head.previous = null;
            count -= 1;
            return returnValue;
        }

        public void Append(T item)
        {
            var newNode = new Node<T> { data = item };
            count += 1;

            if (head == null)
            {
                head = newNode;
                return;
            }

            var last = head;
            while (last.next != null) last = last.next;

            last.next = newNode;
            newNode.previous = last;
        }

    }

}