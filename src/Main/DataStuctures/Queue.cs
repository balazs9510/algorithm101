using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DataStuctures
{
    public class Queue
    {
        private Node<int> _head, _tail;


        public void Add(int data)
        {
            var node = new Node<int>(data);

            if (_tail == null)
            {
                _head = _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
        }

        public int? Peek()
        {
            return _head?.Data;
        }

        public int? Remove()
        {
            var data = _head?.Data;
            _head = _head?.Next;
            if (_head == null) { _tail = null; }

            return data;
        }

        public bool IsEmpty => _tail == null;

    }
}
