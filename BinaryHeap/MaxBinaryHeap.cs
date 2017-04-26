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



        public MaxBinaryHeap(params T[] array) 
        {
            this.list = new List<T>();
            foreach (T i in array)
                this.Insert(i);
        }



        public virtual int Сompare(T a, T b)
        {
            return a.CompareTo(b);
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
            this.list.Add(value);
            int elem = Size - 1;
            int parent = (Size - 2) / 2;

            while (elem > 0 && parent >= 0)
            {
                if (Сompare(this.list[parent], this.list[elem]) < 0)
                {
                    T temp = this.list[elem];
                    this.list[elem] = this.list[parent];
                    this.list[parent] = temp;
                }
                elem = parent;
                parent = (elem - 1) / 2;
            }
        }



        public T Extract()
        {
            T maxValue = list[0];
            list[0] = list[Size - 1];
            list.RemoveAt(Size - 1);
            heapify(0);
            return maxValue;
        }



        public void heapify(int i)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

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
