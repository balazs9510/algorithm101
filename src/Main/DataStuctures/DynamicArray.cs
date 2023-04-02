using System.Drawing;

namespace Main.DataStuctures
{
    public class DynamicArray<T> where T: class
    {
        private T[] _data;
        private int _size;
        private int _initialCapacity;

        public int Length => _size;
        public bool IsEmpty => _size == 0;
        public DynamicArray(int initialCapacity)
        {
            _initialCapacity = initialCapacity;
            _data = new T[initialCapacity];
        }

        public T this[int index]
        {
            get => GetValue(index);
            set => SetValue(index, value);
        }

        public T GetValue(int index)
        {
            return _data[index];
        }

        public void SetValue(int index, T value)
        {
            _data[index] = value;
        }

        public void Insert(int index, T value)
        {
            ResizeIfNeeded();

            for (int i = _size; i > index; i--)
            {
                _data[i] = _data[i - 1];
            }

            _data[index] = value;
            _size++;
        }

        public void Delete(int index)
        {
            for (int i = index; i < _size - 1; i++)
            {
                _data[i] = _data[i + 1];
            }

            if (index == _size)
            { // index is last element
                _data[index] = default;
            }
            else
            {
                _data[_size - 1] = default; // index not last element
            }
            _size--;
        }

        public void Add(T v)
        {
            ResizeIfNeeded();

            _data.SetValue(v, _size++);
        }

        public bool Contains(T v)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_data[i].ToString() == v.ToString()) return true;
            }

            return false;
        }

        private void ResizeIfNeeded()
        {
            if (_size == _initialCapacity)
            {
                Resize();
            }
        }

        private void Resize()
        {
            T[] newData = new T[_initialCapacity * 2];
            Array.Copy(_data, newData, _initialCapacity);

            _data = newData;
            _initialCapacity *= 2;
        }
    }
}