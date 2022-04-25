using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class DeQueLinked
{
    private Node front;
    private Node rear;
    private int size;

    public DeQueLinked()
    {
        front = null;
        rear = null;
        size = 0;
    }

    public int Length()
    {
        return size;
    }

    public bool isEmpty()
    {
        return size == 0;
    }

    public void Addlast(int e)
    {
        Node newest = new Node(e, null);
        if (isEmpty())
            front = newest;
        else
            rear.next = newest;
        rear = newest;
        size = size + 1;
    }

    public void AddFirst(int e)
    {
        Node newest = new Node(e, null);
        if (isEmpty())
        {
            front = newest;
            rear = newest;
        }
        else
        {
            newest.next = front;
            front = newest;
        }

        size = size + 1;
    }

    public int RemoveFirst()
    {
        if (isEmpty())
        {
            Debug.Log("List is Empty");
            return -1;
        }

        int e = front.element;
        front = front.next;
        size = size - 1;
        if (isEmpty())
            rear = null;
        return e;
    }

    public int RemoveLast()
    {
        if (isEmpty())
        {
            Debug.Log("List is Empty");
            return -1;
        }

        Node p = front;
        int i = 1;
        while (i < size - 1)
        {
            p = p.next;
            i = i + 1;
        }

        rear = p;
        p = p.next;
        int e = p.element;
        rear.next = null;
        size = size - 1;
        return e;
    }

    public int Search(int key)
    {
        Node p = front;
        int index = 0;
        while (p != null)
        {
            if (p.element == key)
                return index;
            p = p.next;
            index = index + 1;
        }

        return -1;
    }

    public void Display()
    {
        Node p = front;
        while (p != null)
        {
            Console.Write(p.element + " --> ");
            p = p.next;
        }
    }

    public int First()
    {
        if (isEmpty())
        {
            Debug.Log("DeQueue is Empty");
            return -1;
        }

        return front.element;
    }

    public int Last()
    {
        if (isEmpty())
        {
            Debug.Log("DeQueue is Empty");
            return -1;
        }

        return rear.element;
    }

    static void Main(string[] args)
    {
        
    }
}