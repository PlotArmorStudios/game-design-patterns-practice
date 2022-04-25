using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class StacksArray
{
    int[] data;
    int top;

    public StacksArray(int n) //n = size of the array
    {
        data = new int[n]; //creates a new array
        top = 0;
    }

    public int Length()
    {
        return top;
    }

    public bool IsEmpty()
    {
        return top == 0; //top refers to 'above' the last object inserted
    }

    public bool IsFull()
    {
        return top == data.Length;
    }

    public void Push(int e)
    {
        if (IsFull())
        {
            Debug.Log("Stack if Full/Overflow");
            return;
        }
        else
        {
            data[top] = e;
            top = top + 1;
        }
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Debug.Log("Stack is Empty/UnderFlow");
            return -1;
        }

        int e = data[top - 1]; //Access top of the array
        top = top - 1; //reassign top to the last index of the array
        return e;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Debug.Log("Stack is Empty");
            return -1;
        }

        return data[top - 1];
    }

    public void Display()
    {
        for (int i = 0; i < top; i++)
            Debug.Log(data[i] + "--");
    }
}