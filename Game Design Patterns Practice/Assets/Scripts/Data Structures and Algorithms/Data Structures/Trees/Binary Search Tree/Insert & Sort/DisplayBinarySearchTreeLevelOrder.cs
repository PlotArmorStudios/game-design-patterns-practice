using UnityEngine;

namespace BinaryTrees
{
    public class DisplayBinarySearchTreeLevelOrder : MonoBehaviour
    {
        private void Start()
        {
            BinarySearchTreeLevelOrder B = new BinarySearchTreeLevelOrder();
            B.insert(B.root, 50);
            B.insert(B.root, 30);
            B.insert(B.root, 80);
            B.insert(B.root, 10);
            B.insert(B.root, 40);
            B.insert(B.root, 60);
            B.insert(B.root, 90);
            Debug.Log("Inorder Traversal");
            B.inorder(B.root);
            Debug.Log("Pre Order Traversal");
            B.preorder(B.root);
            Debug.Log("Post Order Traversal");
            B.postorder(B.root);
            Debug.Log("Level Order Traversal");
            B.levelorder();
        }
    }
}