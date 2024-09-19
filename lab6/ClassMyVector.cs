using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab6
{
    public class MyVector<T>
    {
        private T[] elementData;
        private int elementCount;
        private int capacityIncrement;

        public MyVector(int initialCapacity, int capacityIncrement)
        {
            this.elementData = new T[initialCapacity];
            this.elementCount = 0;
            this.capacityIncrement = capacityIncrement;
        }

        public MyVector(int initialCapacity)
        {
            this.elementData = new T[initialCapacity];
            this.elementCount = 0;
            this.capacityIncrement = 0;
        }

        public MyVector()
        {
            this.elementData = new T[10];
            this.elementCount = 0;
            this.capacityIncrement = 0;
        }

        public MyVector(T[] a)
        {
            this.elementData = new T[a.Length];
            this.elementCount = a.Length;
            Array.Copy(a, this.elementData, a.Length);
            this.capacityIncrement = 0;
        }

        private void Grow()     //ресайз вектора
        {
            int newCapacity;
            if (capacityIncrement > 0)
            {
                newCapacity = this.elementData.Length + capacityIncrement;
            }
            else
            {
                newCapacity = this.elementData.Length * 2;
            }
            if (newCapacity < elementCount + 1)
            {
                newCapacity = elementCount + 1;
            }
            Array.Resize(ref this.elementData, newCapacity);
        }

        public T this[int index]    //индексатор (геттер и сеттер)
        {
            get
            {
                if (index >= this.elementCount || index <0) throw new IndexOutOfRangeException();
                return this.elementData[index];
            }
            set
            {
                if (index >= this.elementCount || index < 0) throw new IndexOutOfRangeException();
                this.elementData[index] = value;
            }
        }

        private void OffsetLeft(int startIndex)      //сдвиг вектора
        {
            for(int i = startIndex; i < this.elementCount - 1; i++)
            {
                this.elementData[i] = this.elementData[i + 1];
            }
            this.elementCount--;
            this.elementData[this.elementCount] = default(T);
        }

        public void Add(T e)
        {
            if (e == null) throw new ArgumentNullException("e");
            if (this.elementCount >= this.elementData.Length)
            {
                this.Grow();
            }
            this.elementData[this.elementCount++] = e;
        }

        public void AddAll(T[] a)
        {
            if (a == null) throw new ArgumentNullException("a");
            foreach(T item in a)
            {
                this.Add(item);
            }
        }

        public void Clear()
        {
            this.elementData = null;
            this.elementCount = 0;
        }

        public bool Contains(object o)
        {
            foreach(T item in this.elementData)
            {
                if (item.Equals(o)) return true;
            }
            return false;
        }

        public bool ContainsAll(T[] a)
        {
            for(int i = 0; i < this.elementCount; i++)
            {
                bool found = false;
                for (int j = 0; j < a.Length; j++)
                {
                    if (this.elementData[i].Equals(a[j]))
                    {
                        found = true;
                    }
                }
                if (!found) return false;
            }
            return true;
        }

        public bool IsEmpty()
        {
            return this.elementCount == 0;
        }

        public void Remove(object o)
        {
            for(int i = this.elementCount - 1; i >= 0; i--)
            {
                if (this.elementData[i].Equals(o) && this.elementData[i] != null)
                {
                    this.OffsetLeft(i);
                }
            }
        }

        public void RemoveAll(T[] a)
        {
            if (a == null || a.Length == 0) throw new ArgumentNullException(nameof(a), "Array cannot be null or empty");
            T[] newArray = new T[this.elementCount];
            int index = 0;
            for (int i = 0; i < this.elementData.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j].Equals(this.elementData[i])) {
                        found = true;
                    }
                }
                if (!found)
                {
                    newArray[index++] = this.elementData[i];
                }
            }
            this.elementCount = newArray.Length;
            this.elementData = newArray;
        }

        public void RetainAll(T[] a)
        {
            if (a == null || a.Length == 0) throw new ArgumentNullException(nameof(a), "Array cannot be null or empty");
            T[] newArray = new T[this.elementCount];
            int index = 0;
            for (int i = 0; i < this.elementData.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j].Equals(this.elementData[i]))
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    newArray[index++] = this.elementData[i];
                }
            }
            this.elementCount = newArray.Length;
            this.elementData = newArray;
        }

        public int Size() => this.elementCount;

        public T[] ToArray()
        {
            T[] array = new T[this.elementCount];
            Array.Copy(this.elementData, array, this.elementCount);
            return array;
        }

        public T[] toArray(T[] a)
        {
            if (a == null || a.Length < elementCount)
            {
                a = new T[elementCount];
            }
            Array.Copy(elementData, 0, a, 0, elementCount);
            return a;
        }

        public void Add(int index, T e)
        {
            if (this.elementCount + 1 >= this.elementCount)
            {
                this.Grow();
            }
            for (int i = this.elementCount; i > index; i--)
            {
                this.elementData[i] = this.elementData[i - 1];
            }
            this.elementData[index] = e;
            this.elementCount++;
        }

        public void AddAll(int index, T[] a)
        {
            if (index < 0 || index >= this.elementCount) throw new ArgumentOutOfRangeException(nameof(index));
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (a.Length == 0) return;
            while (this.elementData.Length < this.elementCount + a.Length)
            {
                this.Grow();
            }
            for (int i = this.elementCount - 1; i >= index; i--)
            {
                this.elementData[i + a.Length] = this.elementData[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                this.elementData[index + i] = a[i];
            }
            this.elementCount += a.Length;
        }

        public T Get(int index) => this.elementData[index];

        public int indexOf(object o)
        {
            for (int i = 0; i < this.elementCount; i++)
            {
                if (this.elementData[i].Equals(o)) return i;
            }
            return -1;
        }

        public int LastIndexOf(object o)
        {
            for (int i = this.elementCount -1 ; i >= 0; i--)
            {
                if (this.elementData[i].Equals(o)) return i;
            }
            return -1;
        }

        public T Remove(int index)
        {
            T item = this.elementData[index];
            this.OffsetLeft(index);
            return item;
        }
        
        public void Set(int index, T e) => this.elementData[index] = e; 

        public MyVector<T> SubList(int fromIndex, int toIndex)
        {
            MyVector<T> subList = new MyVector<T>(toIndex - fromIndex);
            for (int i = fromIndex; i < toIndex; i++)
            {
                subList.Add(this.elementData[i]);
            }
            return subList;
        }

        public object FirstElement() => this.elementData[0];

        public object LastElement() => this.elementData[this.elementCount - 1];

        public void RemoveElementAt(int pos) => this.OffsetLeft(pos);

        public void RemoveRange(int begin, int end)
        {
            if (begin < 0 || begin  >= this.elementCount || end < 0 || end >= this.elementCount)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (begin == end) this.OffsetLeft(begin);
            for (int i = 0; i < end - begin; i++)
            {
                this.OffsetLeft(begin);
            }
        }


    }
}
