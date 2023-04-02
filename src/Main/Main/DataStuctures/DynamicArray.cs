namespace Main.DataStuctures
{
    public class DynamicArray<T>
    {
        private T[] _data;
        private int _size;
        private int _initialCapacity;

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
    }
}