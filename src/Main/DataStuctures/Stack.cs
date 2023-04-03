using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DataStuctures
{
    public class Stack
    {
        private Node<int> _head;

        public void Push(int v)
        {
            var newNode = new Node<int>(v);

            newNode.Next = _head;

            _head = newNode;
        }

        public int Length()
        {
            if (_head == null) return 0;
            int length = 1;

            var iterator = _head;
            while (iterator.Next != null) { length++; iterator = iterator.Next; }
            return length;
        }

        public int? Peek()
        {
            return _head?.Data;
        }

        public int? Pop()
        {
            var data = _head?.Data;
            _head = _head?.Next;

            return data;
        }

        public bool IsEmpty => _head == null;
    }
}
