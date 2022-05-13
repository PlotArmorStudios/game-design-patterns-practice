using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BinaryTrees
{
    class BinarySearchTreeRecursive
    {
        public Node Root;

        public BinarySearchTreeRecursive()
        {
            Root = null;
        }

        public Node insert(Node temproot, int e) //will return the reference of the node
        {
            if (temproot != null) //if the temproot is not equal to null
            {
                if (e < temproot.element) //check if the element we are inserting is less than the element is the node
                    temproot.left = insert(temproot.left, e); //move to the left subtree
                else if (e > temproot.element)
                    temproot.right = insert(temproot.right, e); //move to the right subtree
            }
            else //once temproot is null, insert new node
            {
                Node n = new Node(e, null, null);
                temproot = n;
            }
            return temproot;
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