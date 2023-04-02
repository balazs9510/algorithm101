using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DataStuctures
{
    public class LinkedList<T>
    {
        private class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }
            public Node(T data)
            {
                Data = data;
            }
        }

        private Node<T> _head;

        public int Length()
        {
            if (_head == null) return 0;

            var iterator = _head;
            var size = 1;
            while (iterator.Next != null)
            {
                size++;
                iterator = iterator.Next;
            }
            return size;
        }

        public void AddFront(T data)
        {
            var newNode = new Node<T>(data);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            newNode.Next = _head;
            _head = newNode;
        }

        public void AddBack(T data)
        {
            var newNode = new Node<T>(data);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            GetTail().Next = newNode;
        }

        public T GetFirst()
        {
            if (_head == null) throw new IndexOutOfRangeException("The Linked list is not filled.");

            return _head.Data;
        }

        public T GetLast()
        {
            if (_head == null) throw new IndexOutOfRangeException("The Linked list is not filled.");

            return GetTail().Data;
        }

        private Node<T> GetTail()
        {
            var iterator = _head;
            while (iterator.Next != null)
            {
                iterator = iterator.Next;
            }

            return iterator;
        }

        public void Clear()
        {
            _head = null;
        }
    }
}
