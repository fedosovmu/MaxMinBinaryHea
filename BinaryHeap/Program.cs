using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max binary heap");
            var maxHeap = new MaxBinaryHeap<int> (5, 3, 2, 1, 17, 18, 19, 8, 20, 9);
            while (maxHeap.Size > 0)
                Console.WriteLine("Extract: " + maxHeap.Extract());

            Console.WriteLine("\nMin binary heap");
            var minHeap = new MinBinaryHeap<int>(5, 3, 2, 1, 17, 18, 19, 8, 20, 9);
            while (minHeap.Size > 0)
                Console.WriteLine("Extract: " + minHeap.Extract());

            Console.ReadKey();
        }
    }
}
