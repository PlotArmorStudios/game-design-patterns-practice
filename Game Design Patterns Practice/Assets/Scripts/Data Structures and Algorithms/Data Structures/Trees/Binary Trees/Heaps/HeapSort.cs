using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heaps
{
    class Sort
    {
        public void heapsort(int[] A, int n)
        {
            Heap h = new Heap(); //create new heap
            for (int i = 0; i < n; i++) //insert the elements of the array into the heap
                h.insert(A[i]);
            int k = n - 1; //k is an index for array A
            for (int i = 0; i < n; i++) //delete the elements from the heap and store them back into the array
            {
                A[k] = h.deletemax(); //remove element from the heap and return it back to be assigned to the array
                k = k - 1; //decrement index k
            }
        }

        public void display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Sort s = new Sort();
            int[] A = { 63, 250, 835, 947, 651, 28 };
            Console.WriteLine("Original Array");
            s.display(A, 6);
            s.heapsort(A, 6);
            Console.WriteLine("Sorted Array");
            s.display(A, 6);
            Console.ReadKey();
        }
    }
}
