using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class QueuesLinked
{
    Node front;
    Node rear;
    int size;

    public QueuesLinked()
    {
        front = null;
        rear = null;
        size = 0;
    }

    public int Length()
    {
        return size;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public void Enqueue(int e)
    {
        Node newest = new Node(e, null);
        if (IsEmpty())
            front = newest;
        else
            rear.next = newest;
        rear = newest;
        size = size + 1;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }

        int e = front.element;
        front = front.next;
        size = size - 1;
        if (IsEmpty())
            rear = null;
        return e;
    }

    public void Display()
    {
        Node p = front;
        while (p != null)
        {
            Console.Write(p.element + "-->");
            p = p.next;
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        QueuesLinked q = new QueuesLinked();
        q.Enqueue(5);
        q.Enqueue(3);
        q.Display();
        Console.WriteLine("Size: " + q.Length());
        Console.WriteLine("Element Removed: " + q.Dequeue());
        Console.WriteLine("IsEmpty: " + q.IsEmpty());
        Console.WriteLine("Element Removed: " + q.Dequeue());
        Console.WriteLine("IsEmpty: " + q.IsEmpty());
        q.Enqueue(7);
        q.Enqueue(9);
        q.Enqueue(4);
        q.Display();
        Console.WriteLine("Size: " + q.Length());
        Console.ReadKey();
    }
}