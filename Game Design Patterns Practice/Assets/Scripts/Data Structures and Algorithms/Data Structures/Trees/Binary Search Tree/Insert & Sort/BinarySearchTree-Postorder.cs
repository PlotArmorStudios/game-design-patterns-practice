using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BinaryTrees
{
    class BinarySearchTreePostorderRecursive
    {
        public Node Root;

        public BinarySearchTreePostorderRecursive()
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
    }
}