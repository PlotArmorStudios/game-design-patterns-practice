using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class QueuesArray
{
    int[] data;
    int front;
    int rear;
    int size;

    public QueuesArray(int n)
    {
        data = new int[n];
        front = 0;
        rear = 0;
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

    public bool IsFull()
    {
        return size == data.Length;
    }

    public void Enqueue(int e)
    {
        if (IsFull())
        {
            Debug.Log("Queue is Full");
            return;
        }
        else
        {
            data[rear] = e;
            rear = rear + 1;
            size = size + 1;
        }
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Debug.Log("Queue is Empty");
            return -1;
        }
        else
        {
            int e = data[front];
            front = front + 1;
            size = size - 1;
            return e;
        }
    }

    public void Display()
    {
        for (int i = front; i < rear; i++)
            Debug.Log(data[i] + "--");
    }
}