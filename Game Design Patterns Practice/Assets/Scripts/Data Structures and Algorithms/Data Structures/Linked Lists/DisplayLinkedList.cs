using UnityEngine;

public class DisplayLinkedList : MonoBehaviour
{
    private LinkedList _list = new LinkedList();
    private LinkedList _newList = new LinkedList();

    private void Start()
    {
        _list.AddLast(7);
        _list.AddLast(4);
        _list.AddLast(12);
        _list.Display();
        Debug.Log($"Size: {_list.Size}");
        
        _list.AddLast(8);
        _list.AddLast(3);
        _list.Display();
        Debug.Log($"Size: {_list.Size}");
        
        _list.AddFirst(15);
        _list.Display();
        Debug.Log($"Size: {_list.Size}");
        
        _list.AddFirst(25);
        _list.Display();
        Debug.Log($"Size: {_list.Size}");
        
        _list.AddAny(20, 3);
        _list.Display();
        Debug.Log($"Size: {_list.Size}");
        
        _list.AddAny(40, 5);
        _list.Display();
        Debug.Log($"Size: {_list.Size}");

        int element = _list.RemoveFirst();
        Debug.Log($"Removed element {element}");
        _list.Display();
        Debug.Log($"Size: {_list.Size}");
        
        element = _list.RemoveLast();
        Debug.Log($"Removed element {element}");
        _list.Display();
        Debug.Log($"Size: {_list.Size}");
        
        element = _list.RemoveAny(3);
        Debug.Log($"Removed element {element}");
        _list.Display();
        Debug.Log($"Size: {_list.Size}");
        
        element = _list.Search(12);
        Debug.Log($"Element is at index {element}");
        _list.Display();
        Debug.Log($"Size: {_list.Size}");

        _newList.Insertsorted(7);
        _newList.Insertsorted(3);
        _newList.Insertsorted(12);
        _newList.Insertsorted(8);
        _newList.Insertsorted(3);
        _newList.Display();
        Debug.Log($"Size: {_list.Size}");
    }
}