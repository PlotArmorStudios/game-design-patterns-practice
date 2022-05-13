using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTreeDeletion
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
    
    class BinarySearchTreeDeletion
    {
        Node root;

        public BinarySearchTreeDeletion()
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

        public bool delete(int e)
        {
            Node p = root;
            Node pp = null; //to point to the reference of the parent of the parent node of which we are deleting
            
            while (p != null && p.element != e) //search for element to remove
            {
                pp = p; //parent node and the parent of the parent node will be referencing the same node
                if (e < p.element) //is element in the left subtree?
                    p = p.left;
                else //element is in the right subtree
                    p = p.right;
            } //this while loop will continue until p references the node we want to delete. pp will be referencing its parent
            if (p == null) //check if the element we are deleting is present or not
                return false; //element is not found
            if (p.left != null && p.right != null) //subtrees arent null
            {//here we can choose the largest element from the left subtree or the smaller element from the right subtree
                //and replace the element of the node we are deleting
                Node s = p.left; //this is taking the largest element of the left subtree with this statement
                Node ps = p;
                while (s.right != null) //move to the rightmost node (the largest node)
                {
                    ps = s;
                    s = s.right; 
                }//at the end of this while loop, we have traversed to the element to the right with not child (leaf node). This is the largest element
                p.element = s.element; //replace elements ("deletion")
                p = s;
                pp = ps;
            }
            //second case of deletion. The node we are deleting has either left subtree or a right subtree
            Node c = null;
            if (p.left != null) //this if statement will assign the ref to the left or right subtree to object c
                c = p.left;
            else
                c = p.right; 
            if (p == root) //if the node we want to delete is the root, make the root null
                root = null;
            else 
            {
                if (p == pp.left) //if this is true, this means the node we are deleting is the left child of its parent
                    pp.left = c;
                else
                    pp.right = c;
            }
            return true;
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
                if (key == temproot.element)
                    return true;
                else if (key < temproot.element)
                    return search(temproot.left, key);
                else if (key > temproot.element)
                    return search(temproot.right, key);
            }
            return false;
        }

        static void Main(string[] args)
        {
            BinarySearchTreeDeletion B = new BinarySearchTreeDeletion();
            B.insert(B.root, 50);
            B.insert(B.root, 30);
            B.insert(B.root, 80);
            B.insert(B.root, 10);
            B.insert(B.root, 40);
            B.insert(B.root, 60);
            B.insert(B.root, 90);
            Console.WriteLine("Inorder Traversal");
            B.inorder(B.root);
            Console.WriteLine();
            B.delete(50);
            Console.WriteLine("Inorder Traversal");
            B.inorder(B.root);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
