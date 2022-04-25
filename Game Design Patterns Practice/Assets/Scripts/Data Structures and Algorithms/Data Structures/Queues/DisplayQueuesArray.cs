using UnityEngine;

public class DisplayQueuesArray : MonoBehaviour
{
    QueuesArray queue = new QueuesArray(10);

    private void Start()
    {
        queue.Enqueue(5);
        queue.Enqueue(3);
        queue.Display();
        Debug.Log("Size: " + queue.Length());
        Debug.Log("Element Removed: " + queue.Dequeue());
        Debug.Log("IsEmpty: " + queue.IsEmpty());
        Debug.Log("Element Removed: " + queue.Dequeue());
        Debug.Log("IsEmpty: " + queue.IsEmpty());
        queue.Enqueue(7);
        queue.Enqueue(9);
        queue.Enqueue(4);
        queue.Display();
        Debug.Log("Size: " + queue.Length());
    }
}