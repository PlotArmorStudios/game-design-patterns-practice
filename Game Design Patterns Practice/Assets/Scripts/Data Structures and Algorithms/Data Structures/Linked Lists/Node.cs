using System.Collections;
using System.Collections.Generic;

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