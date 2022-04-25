using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BinaryTrees
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
        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void insert(Node temproot, int e)
        {
            Node temp = null; //Used to store the reference of the parent node to which we will be inserting a new node or element
            while (temproot != null) //search for the place the new node should be inserted
            {
                temp = temproot;
                if (e == temproot.element) //check if inserted element is already present in the binary search tree. CANNOT HAVE DUPLICATE ELEMENTS IN A SEARCH TREE
                    return;
                else if (e < temproot.element) //Check if element we are inserting is less than the element in the node
                    temproot = temproot.left; //if above is true, we will move temproot to the left subtree
                else if (e > temproot.element) //check if element is greater
                    temproot = temproot.right; //if true, move to the right subtree
            } //once this loop ends, we have found where to insert the element

            Node n = new Node(e, null, null); //create new node
            if (Root != null) //check if binary tree is not empty
            {
                if (e < temp.element) //check if the new node should be the left child or the right child
                    temp.left = n; //should be left node
                else
                    temp.right = n; //should be left node
            }
            else //binary search (sub)tree is empty
                Root = n;
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
    }
}