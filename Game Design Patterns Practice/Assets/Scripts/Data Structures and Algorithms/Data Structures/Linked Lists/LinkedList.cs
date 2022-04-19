using System;
using UnityEngine;

public class LinkedList
{
    public LinkedList List;
    public Node Head;
    public Node Tail;

    public int Size;

    public LinkedList()
    {
        Head = null;
        Tail = null;
        Size = 0;
    }

    public int Length()
    {
        return Size;
    }

    public bool IsEmpty()
    {
        return Size == 0;
    }

    public void AddLast(int element)
    {
        Node Newest = new Node(element, null);

        if (IsEmpty()) Head = Newest;
        else Tail.Next = Newest;

        Tail = Newest;
        Size++;
    }

    public void AddFirst(int e)
    {
        Node Newest = new Node(e, null);

        if (IsEmpty())
        {
            Head = Newest;
            Tail = Newest;
        }
        else
        {
            Newest.Next = Head;
            Head = Newest;
        }

        Size++;
    }

    public void AddAny(int e, int position)
    {
        if (position <= 0 || position >= Size)
        {
            Debug.Log("Position invalid.");
            return;
        }

        Node newest = new Node(e, null);
        Node p = Head;
        int i = 1;
        while (
            i < position -
            1) //position - 1 because we don't want to point to the position, we want to point to the node before the position so we can insert at the position
        {
            p = p.Next; //next -> next -> next ->
            i++;
        }

        //assign link from the newest node to the next of p
        //you want to do this first to not lose the references of the next of p and the rest of the list
        newest.Next = p.Next;
        //assign the link from node p to the newest node
        //now the old link to p.Next is gone
        p.Next = newest;
        Size++;
    }

    //Delete at beginning of linked list
    public int RemoveFirst()
    {
        if (IsEmpty())
        {
            Debug.Log("List is empty.");
            return -1;
        }
        else
        {
            int element = Head.Element;
            Head = Head.Next;
            Size--;
            if (IsEmpty())
                Tail = null;
            
            return element;
        }
    }
    
    public void Display()
    {
        Node pointer = Head;

        while (pointer != null)
        {
            Debug.Log($"{pointer.Element} --> ");
            pointer = pointer.Next;
        }
    }
}