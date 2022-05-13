using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heaps
{
    class Heap
    {
        int[] data;
        int maxsize;
        int csize;

        public Heap()
        {
            maxsize = 10;
            data = new int[maxsize];
            csize = 0;
            for (int i = 0; i < data.Length; i++)
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
            if (csize == maxsize)
            {
                Console.WriteLine("No Space in Heap");
                return;
            }
            csize = csize + 1;
            int hi = csize;
            while (hi > 1 && e > data[hi / 2])
            {
                data[hi] = data[hi / 2];
                hi = hi / 2;
            }
            data[hi] = e;
        }

        public int deletemax()
        {
            if (isEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            int e = data[1]; //retrieve the element at the root of the binary tree(the heap)
            data[1] = data[csize]; //assign the last element of the heap as the root of the binary tree
            data[csize] = -1; //"delete" the last element in the heap. Now the element that was in the root of the heap is gone
            csize = csize - 1; //decrement the current size of the heap
            
            //perform down-heap bubbling. traverse an element down a tree into the right place (make it a child of larger elements
            int i = 1; //assign 1 to a variable
            int j = i * 2; //assign i * 2 to a variable
            while (j <= csize)
            {
                if (data[j] < data[j + 1]) //determine which child is greater. If this is true then the right child is greater than the left child
                    j = j + 1;
                if (data[i] < data[j]) //check if the element in the parent is less than the element in the child node
                {//if this is true, swap the element in the parent node with the element in the child node to maintain relational property
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    //these statements move the indices to the next level in the binary tree
                    i = j;
                    j = i * 2;
                } 
                else //(the element in the parent node is greater than the child node) dont perform downheap bubbling
                    break;
            }
            return e;
        }

        public int max()
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
            h.insert(40);
            h.display();

            int element = h.deletemax();
            Console.WriteLine("Element Deleted: " + element);
            h.display();

            Console.ReadKey();
        }
    }
}
