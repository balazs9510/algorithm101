using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DataStuctures
{
    public class LinkedList
    {
        private class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
            }
        }

        private Node? _head;

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

        public void AddFront(int data)
        {
            var newNode = new Node(data);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            newNode.Next = _head;
            _head = newNode;
        }

        public void AddBack(int data)
        {
            var newNode = new Node(data);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            GetTail().Next = newNode;
        }

        public int GetFirst()
        {
            if (_head == null) throw new IndexOutOfRangeException("The Linked list is not filled.");

            return _head.Data;
        }

        public int GetLast()
        {
            if (_head == null) throw new IndexOutOfRangeException("The Linked list is not filled.");

            return GetTail().Data;
        }

        private Node GetTail()
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

        public void DeleteValue(int value)
        {
            if (_head == null) return;

           
            if (_head.Data == value)
            {
                _head = _head.Next;
                return;
            }

            Node current = _head;

            while (current.Next != null)
            {
                if (current.Next.Data == value)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
    }
}
