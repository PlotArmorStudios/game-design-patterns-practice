using UnityEngine;

public class DisplayLinkedList : MonoBehaviour
{
    private LinkedList _list = new LinkedList();
    
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
        Debug.Log($"Size: {_list.Size}");
        
    }
}