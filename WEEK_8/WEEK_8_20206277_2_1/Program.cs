using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_8_20206277_2_1
{
    public class BST
    {
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int d)
            {
                data = d;
                left = right = null;
            }
        }
        public Node root;
        public BST()
        {
            root = null;
        }
        public BST(int data)
        {
            root = new Node(data);
        }
        public void insert(int d)
        {
            root = insertRec(root, d);
        }
        public Node insertRec(Node node, int d)
        {
            if (node == null)
            {
                return new Node(d);
            }
            if (d < node.data)
            {
                node.left = insertRec(node.left, d);
            }
            else if (d > node.data)
            {
                node.right = insertRec(node.right, d);
            }
            return node;
        }
        public void inorder()
        {
            inorderRec(root);
        }
        public void inorderRec(Node node)
        {
            if (node == null)
            {
                return;
            }
            inorderRec(node.left);
            Console.Write(node.data + " ");
            inorderRec(node.right);
        }

        int minValue(Node node)
        {
            int minvalue = node.data;
            while (node.left != null)
            {
                minvalue = node.left.data;
                node = node.left;
            }
            return minvalue;
        }

        public void delete(int d)
        {
            root = deleteRec(root, d);
        }
        public Node deleteRec(Node node, int d)
        {
            if (node == null)
            {
                return null;
            }
            if (d < node.data)
            {
                node.left = deleteRec(node.left, d);
            }
            else if (d > node.data)
            {
                node.right = deleteRec(node.right, d);
            }
            else
            {
                if (node.left == null)
                {
                    return node.right;
                }
                else if (node.right == null)
                {
                    return node.left;
                }
                node.data = minValue(node.right);
                node.right = deleteRec(node.right, node.data);
            }
            return node;
        }
        public int countNodes(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            return countNodes(node.left) + countNodes(node.right) + 1;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            BST bst = new BST();
            bst.insert(50);
            bst.insert(30);
            bst.insert(20);
            bst.insert(40);
            bst.insert(70);
            bst.insert(60);
            bst.insert(80);
            bst.insert(10);
            bst.insert(90);
            bst.insert(100);
            bst.inorder();
            Console.WriteLine();
            bst.delete(20);
            bst.inorder();
            Console.WriteLine();
            int count = bst.countNodes(bst.root);
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
