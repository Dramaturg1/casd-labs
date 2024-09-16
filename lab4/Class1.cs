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

        private void Resize()
        {
            T[] newArray = new T[(int)(this.size * 1.5) + 1];
            for (int i = 0; i < this.size; i++)
            {
                newArray[i] = elementData[i];
            }
            this.elementData = newArray;
            this.capacity = newArray.Length - this.size;
        }

        public void Add(T item)
        {
            if (this.capacity == 0)
            {
                this.Resize();
            }
            this.elementData[this.size++] = item;
            this.capacity--;
        }

        public void AddAll(T[] array)
        {
            if (array.Length > this.capacity)
            {
                T[] newArray = new T[(int)((this.size + array.Length) * 1.5 + 1)];
                for (int i = 0; i < this.size; i++)
                {
                    newArray[i] = elementData[i];
                }
                this.elementData = newArray;
                this.capacity = newArray.Length - this.size;
            }
            for (int i = 0; i < array.Length; i++)
            {
                this.elementData[this.size++] = array[i];
                capacity--;
            }

        }

        public void Clear()
        {
            this.elementData = new T[0];
            this.size = 0;
            this.capacity = 0;
        }

        public bool ContainsAll(T[] array)
        {
            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    if (array[i].Equals(this.elementData[j]) && !found)
                    {
                        found = true;
                    }
                }
                if (!found)
                    return false;
            }
            return true;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void RemoveAll(T[] array)
        {
            T[] newArray = new T[this.size];
            int ind = 0;
            for (int i = 0; i < this.size; i++)
            {
                bool found = false;
                for (int j = 0; j < array.Length; j++)
                {
                    if (this.elementData[i].Equals(array[j]))
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    newArray[ind++] = this.elementData[i];
                }
            }
            this.elementData = newArray;
            this.capacity = newArray.Length - ind;
            this.size = ind;
        }

        public void RetainAll(T[] array)
        {
            T[] newArray = new T[this.size];
            int ind = 0;
            for (int i = 0; i < this.size; i++)
            {
                bool found = false;
                for (int j = 0; j < array.Length; j++)
                {
                    if (this.elementData[i].Equals(array[j]))
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    newArray[ind++] = this.elementData[i];
                }
            }
            this.elementData = newArray;
            this.capacity = newArray.Length - ind;
            this.size = ind;
        }

        public int GetSize() => this.size;

        public T[] ToArray()
        {
            T[] temp = new T[this.size];
            for (int i = 0; i < this.size; i++)
            {
                temp[i] = this.elementData[i];
            }
            return temp;
        }

        public void Add(int index, T item)
        {
            if (capacity == 0)
                this.Resize();
            for (int i = this.size; i > index; i--)
            {
                this.elementData[i] = this.elementData[i - 1];
            }
            this.elementData[index] = item;
            capacity--;
            this.size++;
        }

        public void AddAll(int index, T[] array)
        {

        }

        public T Get(int index)
        {
            return this.elementData[index];
        }

        public int IndexOf(object obj)
        {

        }

        public int LastIndexOf(object obj)
        {

        }

        public void Remove(int index)
        {

        }

        public void Set(int index, T item)
        {

        }

        public MyArrayList<T> SubList(int fromIndex, int toIndex)
        {

        }
    }
}
