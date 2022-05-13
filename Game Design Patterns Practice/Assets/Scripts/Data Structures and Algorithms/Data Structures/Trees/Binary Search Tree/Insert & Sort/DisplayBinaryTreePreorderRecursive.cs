using UnityEngine;

namespace BinaryTrees
{
    public class DisplayBinaryTreePreorderRecursive : MonoBehaviour
    {
        private void Start()
        {
            BinarySearchTreePreorderRecursive B = new BinarySearchTreePreorderRecursive();
            B.insert(B.Root, 50);
            B.insert(B.Root, 30);
            B.insert(B.Root, 80);
            B.insert(B.Root, 10);
            B.insert(B.Root, 40);
            B.insert(B.Root, 60);
            B.insert(B.Root, 90);
            Debug.Log("Inorder Traversal");
            B.inorder(B.Root);
            Debug.Log("Pre Order Traversal");
            B.preorder(B.Root);

        }
    }
}