﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class MyArrayList<T>
    {
        private T[] elementData;
        private int size;
        private int capacity;

        public MyArrayList()
        {
            this.elementData = new T[0];
            this.size = 0;
            this.capacity = 0;
        }

        public MyArrayList(T[] array)
        {
            this.elementData = array;
            this.size = array.Length;
            this.capacity = array.Length;
        }

        public MyArrayList(int size)
        {
            this.size = 0;
            this.capacity = size;
            this.elementData = new T[this.capacity];
        }

        private void Resize(int resize = 0)
        {
            T[] newArray = new T[(int)((this.size + resize) * 1.5) + 1];
            for (int i = 0; i < this.size; i++)
            {
                newArray[i] = elementData[i];
            }
            this.elementData = newArray;
            this.capacity = newArray.Length;
        }

        public void Add(T item)
        {
            if (this.capacity == this.size)
            {
                this.Resize();
            }
            this.elementData[this.size++] = item;
        }

        public void AddAll(T[] array)
        {
            if (array == null)
                throw new Exception("Trying to add null array");
            if (array.Length == 0)
                return;
            if (array.Length + this.size >= capacity)
            {
                this.Resize(array.Length);
            }
            for (int i = 0; i < array.Length; i++)
            {
                this.elementData[this.size++] = array[i];
            }

        }

        public void Clear()
        {
            this.elementData = new T[0];
            this.size = 0;
            this.capacity = 0;
        }

        public bool Contains(object obj)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.elementData[i].Equals(obj))
                    return true;
            }
            return false;
        }

        public T[] ToArray(T[] array)
        {
            T[] values = new T[this.size];
            for (int i = 0; i < this.size; i++)
            {
                values[i] = this.elementData[i];
            }
            if (array == null)
            {
                array = new T[this.size];
                for (int i = 0; i < this.size; i++)
                {
                    array[i] = values[i];
                }
                return array;
            }
            return values;
        }
        public bool ContainsAll(T[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentNullException("array");
            {
                
            }
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
            if (array == null)
                throw new ArgumentNullException("array");
            if (array.Length == 0)
                return;
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
            this.size = ind;
        }

        public void RetainAll(T[] array)
        {
            if (array == null)
                throw new ArgumentNullException("array");
            if (array.Length == 0)
                return;
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
            this.capacity = newArray.Length;
            this.size = ind;
        }

        public int Size() => this.size;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.size)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.elementData[index];
            }
            set
            {
                if (index < 0 || index >= this.size)
                {
                    throw new IndexOutOfRangeException();
                }
                this.elementData[(int)index] = value;   
            }
        } 

        public T[] ToArray()
        {
            if (this.size == 0)
                throw new Exception("Trying to return an empty array");
            T[] temp = new T[this.size];
            for (int i = 0; i < this.size; i++)
            {
                temp[i] = this.elementData[i];
            }
            return temp;
        }

        public void Add(int index, T item)
        {
            if (index > this.size)
                throw new ArgumentOutOfRangeException("index");
            if (capacity <= this.size)
                this.Resize();
            for (int i = this.size; i > index; i--)
            {
                this.elementData[i] = this.elementData[i - 1];
            }
            this.elementData[index] = item;
            this.size++;
        }

        public void AddAll(int index, T[] array)
        {
            if (index > this.size)
                throw new ArgumentOutOfRangeException("index");
            if (array == null)
                throw new ArgumentNullException("array");
            if (array.Length == 0)
                return;
            if (this.capacity <= this.size + array.Length)
                this.Resize(array.Length);
            for (int i = this.size - 1; i >= index; i--)
            {
                this.elementData[i + array.Length] = this.elementData[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                this.elementData[index + i] = array[i];
            }
            this.size += array.Length;
        }

        public int IndexOf(object obj)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.elementData[i].Equals(obj))
                    return i;
            }
            return -1;
        }

        public int LastIndexOf(object obj)
        {
            for (int i = this.size - 1; i >= 0; i--)
            {
                if (this.elementData[i].Equals((object)obj))
                    return i;
            }
            return -1;
        }

        public T Get(int index)
        {
            if (index > this.size)
                throw new ArgumentOutOfRangeException("index");
            return this.elementData[index];
        }

        public T Remove(int index)
        {
            if (index > this.size)
                throw new ArgumentOutOfRangeException("index");
            T value = this.elementData[index];
            for (int i = index; i < this.size - 1; i++)
            {
                this.elementData[i] = this.elementData[i + 1];
            }
            this.size--;
            return value;
        }

        public void Set(int index, T item)
        {
            if (index > this.size)
                throw new ArgumentOutOfRangeException("index");
            this.elementData[index] = item;
        }

        public MyArrayList<T> SubList(int fromIndex, int toIndex)
        {
            MyArrayList<T> subList = new MyArrayList<T>(toIndex - fromIndex + 1);
            for(int i = 0; i < toIndex - fromIndex + 1; i++)
            {
                subList.Add(this.elementData[fromIndex + i]);
            };
            return subList;
        }
    }
}
