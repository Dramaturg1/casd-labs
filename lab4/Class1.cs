using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class MyArrayList<T>
    {
        private T[] elementData;
        private int size;
        private int capacity;

        public MyArrayList()
        {
            this.elementData = new T[0];
            this.size = 0;
            this.capacity = 4;
        }

        public MyArrayList(T[] array)
        {
            this.elementData = array;
            this.size = array.Length;
            this.capacity = this.size + 4;
        }

        public MyArrayList(int size)
        {
            this.size = capacity;
            this.capacity = size + 4;
            this.elementData = new T[this.size];
        }

        public void add(T item)
        {
            if (this.capacity == 0)
            {
                T[] newArray = new T[this.size];
                newArray = elementData;
                this.elementData = new T[(int)(this.size * 1.5 + 1)];
                this.elementData = newArray;
                this.size = elementData.Length;
                this.capacity = this.size-newArray.Length;
            }
            this.elementData[this.size++] = item;
            this.capacity--;
        }

        public void addAll(T[] array)
        {
            if (array.Length > this.capacity)
            {
                
            }
        }

        public void clear()
        {

        }

        public bool containsAll(T[] array)
        {

        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void removeAll(T[] array)
        {

        }

        public void retainAll(T[] array)
        {

        }

        public int getSize()
        {
            return this.size;
        }

        public T[] ToArray()
        {

        }

        public void add(int index, T item)
        {

        }

        public void addAll(int index, T[] array)
        {

        }

        public void get(int index)
        {

        }

        public int IndexOf(object obj)
        {

        }

        public int lastIndexOf(object obj)
        {

        }

        public void remove(int index)
        {

        }

        public void set(int index, T item)
        {

        }

        public MyArrayList<T> subList(int fromIndex, int toIndex)
        {

        }
    }
}
