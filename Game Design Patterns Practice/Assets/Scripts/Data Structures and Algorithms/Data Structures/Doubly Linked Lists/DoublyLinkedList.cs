using UnityEngine;

public class DoublyLinkedList
{
    private Node Head;
    private Node Tail;
    private int Size;

    public DoublyLinkedList()
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

    public void AddLast(int e)
    {
        Node newest = new Node(e, null, null);
        if (IsEmpty())
        {
            Head = newest;
            Tail = newest;
        }
        else
        {
            Tail.next = newest;
            newest.prev = Tail; //assign the reference of the previous node
            Tail = newest;
        }

        Size = Size + 1;
    }

    public void AddFirst(int e)
    {
        Node newest = new Node(e, null, null);

        if (IsEmpty())
        {
            Head = newest;
            Tail = newest;
        }
        else
        {
            newest.next = Head; //Link will be created between the newest node and the first node of the list 
            Head.prev = newest; //Link created between the head node to the newest node
            Head = newest; //newest node now the head node of the list
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

        Node newest = new Node(element, null, null);
        Node pointer = Head;
        int i = 1;
        while (i < position - 1)
        {
            pointer = pointer.next;
            i = i + 1;
        }

        newest.next = pointer.next;
        pointer.next.prev = newest;
        pointer.next = newest;
        newest.prev = pointer;
        Size = Size + 1;
    }


    public int RemoveFirst()
    {
        if (IsEmpty())
        {
            Debug.Log("Doubly List is Empty");
            return -1;
        }

        int element = Head.element;
        Head = Head.next;
        Size = Size - 1;
        if (IsEmpty())
            Tail = null;
        else
            Head.prev = null;
        return element;
    }

    public int RemoveLast()
    {
        if (IsEmpty())
        {
            Debug.Log("Doubly List is Empty");
            return -1;
        }

        int e = Tail.element;
        Tail = Tail.prev;
        Tail.next = null;
        Size = Size - 1;
        return e;
    }

    public int RemoveAny(int position)
    {
        if (position <= 0 || position >= Size - 1)
        {
            Debug.Log("Invalid Position");
            return -1;
        }

        Node pointer = Head;
        int i = 1;
        
        while (i < position - 1)
        {
            pointer = pointer.next;
            i = i + 1;
        }

        int element = pointer.next.element; //retrieve element we are deleting
        pointer.next = pointer.next.next; //maintain the link from the node of node p to the next node of the node we are deleting
        pointer.next.prev = pointer; //take care of the previous link
        Size = Size - 1;
        
        return element;
    }

    public void Display()
    {
        Node pointer = Head;
        while (pointer != null)
        {
            Debug.Log(pointer.element + "-->");
            pointer = pointer.next;
        }
    }
}