using UnityEngine;

public class DisplayDequeuesLinked : MonoBehaviour
{
    DeQueLinked _dequeLinked = new DeQueLinked();

    private void Start()
    {
        _dequeLinked.AddFirst(5);
        _dequeLinked.AddFirst(3);
        _dequeLinked.Addlast(7);
        _dequeLinked.Addlast(12);
        _dequeLinked.Display();
        Debug.Log("Size: " + _dequeLinked.Length());
        Debug.Log("Front Element Removed: " + _dequeLinked.RemoveFirst());
        Debug.Log("Rear Element Removed: " + _dequeLinked.RemoveLast());
        _dequeLinked.Display();
        Debug.Log("First Element: " + _dequeLinked.First());
        Debug.Log("Last Element: " + _dequeLinked.Last());
    }
}