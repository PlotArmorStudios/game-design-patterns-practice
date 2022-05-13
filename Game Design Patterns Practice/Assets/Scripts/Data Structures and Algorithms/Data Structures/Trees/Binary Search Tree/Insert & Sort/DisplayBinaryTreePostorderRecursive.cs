using UnityEngine;

namespace BinaryTrees
{
    public class DisplayBinaryTreePostorderRecursive : MonoBehaviour
    {
        private void Start()
        {
            BinarySearchTreePostorderRecursive B = new BinarySearchTreePostorderRecursive();
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
            Debug.Log("Post Order Traversal");
            B.postorder(B.Root);
        }
    }
}