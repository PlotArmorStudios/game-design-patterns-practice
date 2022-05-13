using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashChain
{
    class HashChain
    {
        int hashtablesize;
        LinkedList[] hashtable; //each element of the array of the hash table will be a linked list

        public HashChain()
        {
            hashtablesize = 10;
            hashtable = new LinkedList[hashtablesize]; //has table is initialized to the size of 10
            //allocate memory  to each linked list in the hash table
            for (int i = 0; i < hashtablesize; i++)
                hashtable[i] = new LinkedList(); //this is how memory is allocated for the linked lists of the chains for each element of the hash table
        }

        public int hashcode(int key) //hash value of the key
        {
            return key % hashtablesize;
        }

        public void insert(int element) 
        {
            int i = hashcode(element); //store the hash code of the element as the index
            hashtable[i].insertsorted(element); //at the index, add this element to a list (linked list)
        }

        public bool search(int key)
        {
            int i = hashcode(key); //store the hash code of the element as the index
            return hashtable[i].search(key) != -1; //hashtable[i] is the linked list of that index. Use the search method of the linked list.
            //Search will return -1 is the key is not found
        }

        public void display()
        {
            for (int i = 0; i < hashtablesize; i++)
            {
                Console.Write("[" + i + "]");
                hashtable[i].display();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            HashChain h = new HashChain();
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
