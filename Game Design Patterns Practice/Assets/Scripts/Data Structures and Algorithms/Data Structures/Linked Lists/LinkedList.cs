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
        else Tail.next = Newest;

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
            Newest.next = Head;
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
            p = p.next; //next -> next -> next ->
            i++;
        }

        //assign link from the newest node to the next of p
        //you want to do this first to not lose the references of the next of p and the rest of the list
        newest.next = p.next;
        //assign the link from node p to the newest node
        //now the old link to p.Next is gone
        p.next = newest;
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
            //retrieve element from the beginning of the linked list
            int element = Head.element;
            //move the head to the next node
            Head = Head.next;
            Size--;
            if (IsEmpty())
                Tail = null;

            return element;
        }
    }

    //Unfortonutely, you cannot easily remove an element from the end of a linked list
    //In order to delete an element from the end of the linked list
    //we must traverse the node before the last node
    //cannot use tail reference since we cannot move backwards using "next"
    public int RemoveLast()
    {
        if (IsEmpty())
        {
            Debug.Log("List is empty");
            return -1;
        }

        Node pointer = Head;
        int i = 1;
        
        while (i < Size - 1)
        {
            pointer = pointer.next;
            i++;
        }

        Tail = pointer;
        pointer = pointer.next;
        int e = pointer.element;
        Tail.next = null;
        Size--;
        return e;
    }

    public int RemoveAny(int position)
    {
        if (position <= 0 || position >= Size - 1)
        {
            Debug.Log("Invalid Position");
            return -1;
        }
        
        Node p = Head;
        int i = 1;
        //traverse to the position before the position you want to delete
        while (i < position - 1)
        {
            p = p.next;
            i = i + 1;
        }
        
        int e = p.next.element;
        p.next = p.next.next;
        Size = Size - 1;
        return e;
    }    
    
    public int Search(int key)
    {
        Node pointer = Head;
        int index = 0; //where the pointer is pointing in the list
        
        while (pointer != null)
        {
            if (pointer.element == key)
                return index; //return where pointer is pointing
            pointer = pointer.next;
            index = index + 1; //pointer advances
        }
        return -1;
    }

    public void Insertsorted(int e)
    {
        Node newest = new Node(e, null);
        
        if (IsEmpty())
            Head = newest;
        else
        {
            Node pointer = Head;
            Node q = Head;
            
            //search for the position where the new element has to be inserted
            while (pointer != null && pointer.element < e)
            {
                q = pointer;
                pointer = pointer.next;
            }
            
            //if this is true that means the element that we are inserting is smaller than all the other elements in the linked list
            if (pointer == Head)
            {
                newest.next = Head;
                Head = newest;
            }
            else //insert the element after the position references by node q
            {
                newest.next = q.next;
                q.next = newest;
            }
        }
        Size = Size + 1;
    }
    
    public void Display()
    {
        Node pointer = Head;

        while (pointer != null)
        {
            Debug.Log($"{pointer.element} --> ");
            pointer = pointer.next;
        }
    }
}