using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    class MaxBinaryHeap<T> where T : IComparable
    {
        private List<T> list;



        public virtual int Сompare(T a, T b)
        {
            return a.CompareTo(b);
        }



        public MaxBinaryHeap(params T[] array) 
        {
            this.list = new List<T>();
            foreach (T i in array)
                this.Insert(i);
        }



        public int Size
        {
            get
            {
                return this.list.Count;
            }
        }



        public void Insert(T value)
        {
            int brother = Size;
            this.list.Add(value);
            int parent = (brother - 1) / 2;

            while (brother > 0 && parent >= 0)
            {
                if (Сompare(this.list[parent], this.list[brother]) < 0)
                {
                    T temp = this.list[brother];
                    this.list[brother] = this.list[parent];
                    this.list[parent] = temp;
                }
                brother = parent;
                parent = (brother - 1) / 2;
            }
        }



        public T Extract()
        {
            T MaxValue = list[0];
            list[0] = list[Size - 1];
            list.RemoveAt(Size - 1);
            heapify(0);
            return MaxValue;
        }



        public void heapify(int i)
        {
            int left, right;
            left = 2 * i + 1;
            right = 2 * i + 2;
            if (left < Size && Сompare(this.list[i], this.list[left]) < 0)
            {
                T temp = this.list[i];
                this.list[i] = this.list[left];
                this.list[left] = temp;
                heapify(left);
            }
            if (right < Size && Сompare(this.list[i], this.list[right]) < 0)
            {
                T temp = this.list[i];
                this.list[i] = this.list[right];
                this.list[right] = temp;
                heapify(right);
            }
        }

    }
}
