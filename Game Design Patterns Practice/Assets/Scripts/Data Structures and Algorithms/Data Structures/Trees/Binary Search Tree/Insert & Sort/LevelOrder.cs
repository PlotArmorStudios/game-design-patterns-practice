using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BinaryTrees
{
    class BinarySearchTreeLevelOrder
    {
        public Node root;

        public BinarySearchTreeLevelOrder()
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

        public void levelorder()
        {
            QueuesLinked q = new QueuesLinked();
            Node t = root; //reference the root of the tree
            Debug.Log(t.element + " ");
            q.enqueue(t); //enqueue the node
            while (!q.isEmpty()) //if queue is not empty
            {
                t = (Node) q.dequeue(); //reference the first node of the queued tree
                if (t.left != null) //check left child of dequeued element
                {
                    Debug.Log(t.left.element + " "); //print left child if true
                    q.enqueue(t.left); //enqueue the child (discarding the parent node)
                }

                if (t.right != null) //check right child of dequeued element
                {
                    Debug.Log(t.right.element + " ");
                    q.enqueue(t.right);
                }
            }
        }
    }
}