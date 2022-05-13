using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BinaryTreeSearching
{
    public class Node
    {
        public int element;
        public Node left;
        public Node right;

        public Node(int e, Node l, Node r)
        {
            element = e;
            left = l;
            right = r;
        }
    }
    
    class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
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
                Debug.Log(temproot.element + " ");
                inorder(temproot.right);
            }
        }

        public void preorder(Node temproot)
        {
            if (temproot != null)
            {
                Debug.Log(temproot.element + " ");
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
                Debug.Log(temproot.element + " ");
            }
        }

        public bool search(int key)
        {
            Node temproot = root; //assign a pointer to the root of the tree
            while (temproot != null) //loop through nodes
            {
                if (key == temproot.element) //check if the root pointer's element is equal to the key
                    return true;
                else if (key < temproot.element) //if not equal, check left
                    temproot = temproot.left; //now point to the left subtree
                else if (key > temproot.element) //if not equal, check right
                    temproot = temproot.right; //now point to the right subtree
            }
            return false; //if element is not found
        }
    }
}
