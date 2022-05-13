using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BinaryTrees
{
    class BinarySearchTreePreorderRecursive
    {
        public Node Root;

        public BinarySearchTreePreorderRecursive()
        {
            Root = null;
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
            if (Root != null)
                if (e < temp.element)
                    temp.left = n;
                else
                    temp.right = n;
            else
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

        public void preorder(Node temproot)
        {
            if (temproot != null)
            {
                Debug.Log(temproot.element + " ");
                preorder(temproot.left); //visit left subtree. happens with each node
                preorder(temproot.right); //visit right subtree. happens with each node
            }
        }
    }
}
