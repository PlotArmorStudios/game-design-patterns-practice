using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class Heap
    {
        int[] data;
        int maxsize;
        int csize; //current size of the heap

        public Heap()
        {
            maxsize = 10; //default size of heap is 10
            data = new int[maxsize]; //heap tree represented as array
            csize = 0;
            for (int i = 0; i < data.Length; i++) //initialize all elements of the heap as -1
                data[i] = -1;
        }

        public int length()
        {
            return csize;
        }

        public bool isEmpty()
        {
            return csize == 0;
        }

        public void insert(int e)
        {
            if (csize == maxsize) //check if heap  is full
            {
                Console.WriteLine("No Space in Heap");
                return;
            }
            csize = csize + 1; //increment current size
            int hi = csize; //hi is used to represent the index where the element has to be inserted
            while (hi > 1 && e > data[hi / 2]) //this loop performs up-heap bubbling to maintain the relational property of the heap
            { 
                //the parent //the child
                data[hi] = data[hi / 2]; //we are assigning the element present at index hi (the parent) divided by 2 (the child)
                hi = hi / 2; //assign the index of the parent to the child node (move one level up in the binary tree
            }
            data[hi] = e;
        }

        public int max() //return element at the top of the heap
        {
            if (isEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            return data[1];
        }

        public void display()
        {
            for (int i = 0; i < data.Length; i++)
                Console.Write(data[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Heap h = new Heap();
            h.insert(25);
            h.insert(14);
            h.insert(2);
            h.insert(20);
            h.insert(10);
            h.display();
            h.insert(40);
            h.display();
            Console.ReadKey();
        }
    }
}
