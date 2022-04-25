using System;
using UnityEngine;

public class CircularLinkedList
{
    private Node Head;
    private Node Tail;
    private int Size;

    public CircularLinkedList()
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
        Node newest = new Node(element, null);
        if (IsEmpty())
        {
            newest.next = newest;
            Head = newest;
        }
        else
        {
            newest.next = Tail.next;
            Tail.next = newest;
        }

        Tail = newest;
        Size = Size + 1;
    }

    public void AddFirst(int element)
    {
        Node newest = new Node(element, null);
        if (IsEmpty())
        {
            newest.next = newest; //Assign the link of the newest node to itself
            Head = newest; //Assigning newest node as the head
            Tail = newest; //Assign newest node as tail as well
        }
        else
        {
            Tail.next = newest; // link is created between the tail and newest node
            newest.next = Head; //added new node to the beginning of the list
            Head = newest; //newest node is now first node of the list
        }

        Size = Size + 1;
    }

    public void AddAny(int element, int position)
    {
        if (position <= 0 || position >= Size)
        {
            Debug.Log("Invalid Position");
            return;
        }

        Node newest = new Node(element, null);
        Node p = Head;
        int i = 1;

        while (i < position - 1) //traverse to position before we will insert the node
        {
            p = p.next;
            i = i + 1;
        }

        newest.next = p.next; //create link between new node and next node of position
        p.next = newest;
        Size = Size + 1;
    }

    public int RemoveFirst()
    {
        if (IsEmpty())
        {
            Debug.Log("Circular List is Empty");
            return -1;
        }

        int element = Head.element; //retrieve first element of list
        Tail.next = Head.next; //assign tail's next reference
        Head = Head.next; //move the head to the next node
        Size = Size - 1;
        
        if (IsEmpty())
        {
            Head = null;
            Tail = null;
        }

        return element;
    }

    public int RemoveLast()
    {
        if (IsEmpty())
        {
            Debug.Log("Circular List is Empty");
            return -1;
        }
        
        Node pointer = Head;
        int i = 1;
        
        while (i < Length() - 1) //while loop traverse to last - 1 node
        {
            pointer = pointer.next;
            i = i + 1;
        }
        
        Tail = pointer; //make the last - 1 node the tail
        pointer = pointer.next; //move point to the last node
        Tail.next = Head; //circle tail to the head
        int element = pointer.element; //save the element of the last node
        Size = Size - 1;
        return element;
    }
    
    public int RemoveAny(int position)
    {
        if (position <= 0 || position >= Size - 1)
        {
            Debug.Log("Invalid Position");
            return -1;
        }
        
        Node pointer = Head; //assign a pointer to head
        int i = 1;
        
        while (i < position - 1) //traverse to position - 1 where the node will be deleted
        {
            pointer = pointer.next;
            i = i + 1;
        }
        
        int element = pointer.next.element; //retrieve what's being deleted
        pointer.next = pointer.next.next; //maintain the link from pointer node to the next of the node we are deleting
        Size = Size - 1;
        
        return element;
    }

    public void Display()
    {
        Node pointer = Head;
        int i = 0;
        while (i < Length())
        {
            Debug.Log(pointer.element + "-->");
            pointer = pointer.next;
            i = i + 1;
        }
    }
}