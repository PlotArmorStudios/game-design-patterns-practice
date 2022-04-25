using UnityEngine;

public class DisplayCircularLinkedList : MonoBehaviour
{
    private CircularLinkedList _list = new CircularLinkedList();
    private CircularLinkedList _newList = new CircularLinkedList();

    private void Start()
    {
        _list.AddLast(7);
        _list.AddLast(4);
        _list.AddLast(12);
        _list.Display();
        Debug.Log($"Size: {_list.Length()}");
        
        _list.AddLast(8);
        _list.AddLast(3);
        _list.Display();
        Debug.Log($"Size: {_list.Length()}");
        
        _list.AddFirst(25);
        _list.Display();
        Debug.Log($"Size: {_list.Length()}");
        
        _list.AddFirst(35);
        _list.Display();
        Debug.Log($"Size: {_list.Length()}");
        
        _list.AddAny(20, 3);
        _list.Display();
        Debug.Log($"Size: {_list.Length()}");
        
        _list.AddAny(30, 3);
        _list.Display();
        Debug.Log($"Size: {_list.Length()}");
        
        int element = _list.RemoveFirst();
        _list.Display();
        Debug.Log($"Removed Element: {element}");
        Debug.Log($"Size: {_list.Length()}");
        
        element = _list.RemoveLast();
        _list.Display();
        Debug.Log($"Removed Element: {element}");
        Debug.Log($"Size: {_list.Length()}");
        
        element = _list.RemoveAny(3);
        _list.Display();
        Debug.Log($"Removed Element: {element}");
        Debug.Log($"Size: {_list.Length()}");
    }
}