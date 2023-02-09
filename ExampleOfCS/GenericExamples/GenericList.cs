using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.GenericExamples
{
    internal class GenericList<T>
    {
        private class Node
        {
            private Node? next;
            public Node? Next
            {
                get { return next; }
                set { next = value; }
            }

            private T data;
            public T Data
            {
                get { return data; }
                set { data = value; }
            }

            public Node(T t)
            {
                next = null;
                data = t;
            }
        }

        private Node? head;
        private T[] obj = new T[100];

        public GenericList()
        {
            head = null;
        }

        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
}
