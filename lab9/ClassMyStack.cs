using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class MyStack<T> : lab6.MyVector<T>
    {
        public void Push(T item)
        {
            this.Add(item);
        }

        public T Pop()
        {
            if (Empty())
            {
                throw new InvalidOperationException("Stack is Empty, cannot pop.");
            }
            return base.Remove(Size() - 1);
        }

        public T Peek()
        {
            return this[this.elementCount - 1];
        }

        public bool Empty()
        {
            return (this.elementCount == 0);
        }

        public int Search(T item)
        {
            int count = 0;
            for (int i = this.Size(); i > 0; i--)
            {
                if (!(this.elementData[i].Equals(item)))
                    count++;
                else
                    return count;
            }
            return -1;
        }
    }
}
