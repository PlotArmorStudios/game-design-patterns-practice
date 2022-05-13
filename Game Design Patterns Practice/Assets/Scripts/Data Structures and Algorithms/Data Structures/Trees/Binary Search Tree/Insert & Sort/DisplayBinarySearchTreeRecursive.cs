using BinaryTrees;
using UnityEngine;

public class DisplayBinarySearchTreeRecursive : MonoBehaviour
{
    private void Start()
    {
        BinarySearchTreeRecursive B = new BinarySearchTreeRecursive();
        B.Root = B.insert(B.Root, 50); //only need to initialize once to set the first root node
        B.insert(B.Root, 30);
        B.insert(B.Root, 80);
        B.insert(B.Root, 10);
        B.insert(B.Root, 40);
        B.insert(B.Root, 60);
        B.insert(B.Root, 90);
        Debug.Log("Inorder Traversal");
        B.inorder(B.Root);
    }
}