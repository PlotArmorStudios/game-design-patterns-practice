using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public int Element;
    public Node Next;

    public Node(int element, Node next)
    {
        Element = element;
        Next = next;
    }
}

public class LinkedList
{
    public LinkedList List;
    public Node Newest;
    public Node Head { get; set; }
    public Node Tail { get; set; }
    public Node Pointer { get; set; }

    public bool IsEmpty { get; set; }
    private int Size;

    public void AddLast(int element)
    {
        Newest = new Node(element, null);

        if (IsEmpty) Head = Newest;
        else Tail.Next = Newest;

        Tail = Newest;
        Size++;
        IsEmpty = false;
    }

    public void Display()
    {
        Pointer = Head;
  
        while (Pointer != null)
        {
            Debug.Log(Pointer.Element);
            Pointer = Pointer.Next;
        }
    }
}