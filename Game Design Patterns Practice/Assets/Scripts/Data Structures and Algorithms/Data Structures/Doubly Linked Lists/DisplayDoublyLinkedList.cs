using UnityEngine;

public class DisplayDoublyLinkedList : MonoBehaviour
{
    private DoublyLinkedList _list;

    void Start()
    {
        _list = new DoublyLinkedList();
        _list.AddLast(7);
        _list.AddLast(4);
        _list.AddLast(12);
        _list.Display();
        Debug.Log("Size: " + _list.Length());

        _list.AddLast(8);
        _list.AddLast(3);
        _list.Display();
        Debug.Log("Size: " + _list.Length());
        
        _list.AddLast(15);
        _list.Display();
        Debug.Log("Size: " + _list.Length());
        
        _list.AddAny(20, 3);
        _list.Display();
        Debug.Log("Size: " + _list.Length());
        
        int element = _list.RemoveFirst();
        _list.Display();
        Debug.Log($"Removed {element}");
        Debug.Log("Size: " + _list.Length());
        
        element = _list.RemoveLast();
        _list.Display();
        Debug.Log($"Removed {element}");
        Debug.Log("Size: " + _list.Length());
        
        element = _list.RemoveAny(3);
        _list.Display();
        Debug.Log($"Removed {element}");
        Debug.Log("Size: " + _list.Length());
    }
}