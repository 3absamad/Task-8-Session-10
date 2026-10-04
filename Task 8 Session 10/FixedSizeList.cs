using System;
using System.Collections.Generic;
using System.Text;

namespace Task_8_Session_10
{
    internal class FixedSizeList<T>
    {
        private int _count;
        private T[] _items;


        public FixedSizeList(int capacity)
        {
            if(capacity <= 0) {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if(_count >= _items.Length)
            {
                throw new InvalidOperationException("List is full.");
            }
            _items[_count] = item;
            _count++;
        }

        public T Get(int index)
        {
            if(index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return _items[index];
        }
    }
}
