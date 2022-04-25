using UnityEngine;

public class DisplayStackLinkedList : MonoBehaviour
{
    StacksLinked stack = new StacksLinked();

    private void Start()
    {
        stack.Push(5);
        stack.Push(3);
        stack.Display();
        Debug.Log("Size: " + stack.Length());
        Debug.Log("Element Removed: " + stack.Pop());
        Debug.Log("IsEmpty: " + stack.IsEmpty());
        Debug.Log("Element Removed: " + stack.Pop());
        Debug.Log("IsEmpty: " + stack.IsEmpty());
        stack.Push(7);
        stack.Push(9);
        stack.Display();
        Debug.Log("Element Top: " + stack.Peek());
        stack.Display();
    }
}