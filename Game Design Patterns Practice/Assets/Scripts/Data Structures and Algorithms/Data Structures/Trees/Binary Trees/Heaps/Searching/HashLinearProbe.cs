﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class HashLinearProbe
    {
        int hashtablesize;
        int[] hashtable;

        public HashLinearProbe()
        {
            hashtablesize = 10;
            hashtable = new int[hashtablesize];
        }

        public int hashcode(int key)
        {
            return key % hashtablesize;
        }

        public int lprobe(int element)
        {
            int i = hashcode(element); //compute hash code of this element
            int j = 0;
            while (hashtable[(i + j) % hashtablesize] != 0) //perform linear probing and find an empty place where the element can be inserted
                j = j + 1; //if true, increment variable j
            return (i + j) % hashtablesize;
        }

        public void insert(int element)
        {
            int i = hashcode(element); //compute hash code of this element
            if (hashtable[i] == 0) //if hashtable element contains 0, store element here
                hashtable[i] = element;
            else //if not 0, store element in one of the subsequent cells
            {
                i = lprobe(element);
                hashtable[i] = element;
            }
        }

        public bool search(int key)
        {
            int i = hashcode(key);
            int j = 0;
            while (hashtable[(i + j) % hashtablesize] != key) 
            {
                if (hashtable[(i + j) % hashtablesize] == 0)
                    return false;
                j = j + 1;
            }
            return true;
        }

        public void display()
        {
            for (int i = 0; i < hashtablesize; i++)
                Console.Write(hashtable[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            HashLinearProbe h = new HashLinearProbe();
            h.insert(54);
            h.insert(78);
            h.insert(64);
            h.insert(92);
            h.insert(34);
            h.insert(86);
            h.insert(28);
            h.display();
            Console.WriteLine("Element Found: " + h.search(44));
            Console.ReadKey();
        }
    }
}
