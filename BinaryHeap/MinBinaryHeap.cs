using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    class MinBinaryHeap<T> : MaxBinaryHeap<T> where T : IComparable
    {
        public MinBinaryHeap (params T[] array) : base(array) { }

        public override int Сompare(T a, T b)
        {
            return a.CompareTo(b) * -1;
        }
    }
}
