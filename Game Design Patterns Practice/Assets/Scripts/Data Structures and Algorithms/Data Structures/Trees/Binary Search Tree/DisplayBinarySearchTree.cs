using UnityEngine;

namespace BinaryTrees
{
    public class DisplayBinarySearchTree : MonoBehaviour
    {
        private void Start()
        {
            BinarySearchTree B = new BinarySearchTree();
            
            B.insert(B.Root, 50);
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
}