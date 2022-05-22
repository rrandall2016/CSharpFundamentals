using System;

namespace ScratchPractice
{
    class MyList<T>
    {
        public int length;
        public int maxSize;

        T[] list;

        public MyList(int startCapacity)
        {
            length = 0;
            maxSize = startCapacity;
            list = new T[maxSize];
        }        
        public MyList()
        {
            length = 0;
            maxSize = 10;
            list = new T[maxSize];
        }
        public void AddItem(T item)
        {
            if (length == maxSize)
                Grow();

            list[length] = item;
            length++;

        }
        public void Grow()
        {
            //Create temp list that becomes new list
            int newSize = maxSize * 2;
            T[] tempList = new T[newSize];

            //Copy list items
            for (int i = 0; i < maxSize; i++)
            {
                tempList[i] = list[i];
            }

            maxSize = newSize;
            list = tempList;

        }
        public void removeItem()
        {
            length--;
        }
        public bool containsItem(T item)
        {
            for (int i = 0; i < length; i++)
            {
                if (Equals(list[i], item))
                {
                    return true;
                }

            }
            return false;

        }
        public T retrieveAt(int location)
        {
            if (location < 0 || location >= length)
            {
                throw new IndexOutOfRangeException();
            }
            return list[location];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
