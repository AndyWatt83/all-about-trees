using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace tree_structures.core
{
    public class LinkedList<T>
    {
        protected Node<T> head;

        protected class Node<T>
        {
            public T data;
            public Node<T> next;
        }

        public void Push(T item)
        {
            head = new Node<T> { data = item, next = head };
        }

        public T Peek()
        {
            if(head == null) return default(T);
            return head.data;
        }

        public T Pop()
        {
            var returnValue = this.Peek();
            head = head.next;
            return returnValue;
        }
    }
}