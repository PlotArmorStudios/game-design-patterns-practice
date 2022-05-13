using UnityEngine;

namespace BinaryTreeSearching
{
    public class DisplayTreeSearch : MonoBehaviour
    {
        private void Start()
        {
            BinarySearchTree B = new BinarySearchTree();
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

            Debug.Log("Search Result: " + B.search(70));

        }
    }
}