using UnityEngine;

public class DisplayStackArray : MonoBehaviour
{
    StacksArray _stack = new StacksArray(10);

    private void Start()
    {
        _stack.Push(5);
        _stack.Push(3);
        _stack.Display();
        Debug.Log("Size: " + _stack.Length());
        Debug.Log("Element Popped: " + _stack.Pop());
        Debug.Log("IsEmpty: " + _stack.IsEmpty());
        Debug.Log("Element Popped: " + _stack.Pop());
        Debug.Log("IsEmpty: " + _stack.IsEmpty());
        _stack.Push(7);
        _stack.Push(9);
        _stack.Display();
        Debug.Log("Element Top: " + _stack.Peek());
        _stack.Display();
    }
}