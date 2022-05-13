using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTreeSearching
{
    class BinarySearchTreeRecursiveSearch
    {
        public Node root;

        public BinarySearchTreeRecursiveSearch()
        {
            root = null;
        }

        public void insert(Node temproot, int e)
        {
            Node temp = null;
            while (temproot != null)
            {
                temp = temproot;
                if (e == temproot.element)
                    return;
                else if (e < temproot.element)
                    temproot = temproot.left;
                else if (e > temproot.element)
                    temproot = temproot.right;
            }
            Node n = new Node(e, null, null);
            if (root != null)
                if (e < temp.element)
                    temp.left = n;
                else
                    temp.right = n;
            else
                root = n;
        }

        public void inorder(Node temproot)
        {
            if (temproot != null)
            {
                inorder(temproot.left);
                Console.Write(temproot.element + " ");
                inorder(temproot.right);
            }
        }

        public void preorder(Node temproot)
        {
            if (temproot != null)
            {
                Console.Write(temproot.element + " ");
                preorder(temproot.left);
                preorder(temproot.right);
            }
        }

        public void postorder(Node temproot)
        {
            if (temproot != null)
            {
                postorder(temproot.left);
                postorder(temproot.right);
                Console.Write(temproot.element + " ");
            }
        }

        public bool search(Node temproot, int key)
        {
            if (temproot != null)
            {
                if (key == temproot.element) //if true, found the key
                    return true;
                else if (key < temproot.element) //if not equal, check left recursively
                    return search(temproot.left, key);
                else if (key > temproot.element)
                    return search(temproot.right, key); //if not equal, check right recursively
            }
            return false; //if element is not found
        }
    }
}
