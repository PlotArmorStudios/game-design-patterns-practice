using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


class StacksLinked
{
    Node top;
    int size;

    public StacksLinked()
    {
        top = null;
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

    public void Push(int e)
    {
        Node newest = new Node(e, null);
        if (IsEmpty())
        {
            top = newest;
        }
        else
        {
            newest.next = top;
            top = newest;
        }

        size = size + 1;
    }

    public int Pop() //Grab object off the top
    {
        if (IsEmpty())
        {
            Debug.Log("Stack is empty");
            return -1;
        }

        int e = top.element;
        top = top.next;
        size = size - 1;
        return e;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Debug.Log("Stack is empty");
            return -1;
        }

        return top.element;
    }

    public void Display()
    {
        Node p = top;
        while (p != null)
        {
            Debug.Log(p.element + "-->");
            p = p.next;
        }
    }
}