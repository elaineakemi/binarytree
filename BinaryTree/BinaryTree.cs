using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public int value;
        public Node left, right;

        public Node(int i)
        {
            this.value = i;
            left = null;
            right = null;
        }
    }

    public class BSTree
    {
        private Node root;
        private int _count = 0;

        public BSTree()
        {
            root = null;
            _count = 0;
        }

        /// <summary>
        /// Returns the number of nodes in the tree
        /// </summary>
        /// <returns>Number of nodes in the tree</returns>
        public int count()
        {
            return _count;
        }

        /// <summary>
        /// Find and return the tree node for a specific value.
        /// </summary>
        /// <param name="value">Value of node to locate</param>
        /// <returns>Returns null if it fails to find the node, else returns reference to node</returns>
        /// 
        public Node findValue(int value)
        {
            Node np = root;

            while (np != null)
            {
                if (value == np.value) { return np; }
                else if (value <= np.value) { np = np.left; }
                else { np = np.right; }
            }

            return null;
        }

        // Recursively locates a empty slot in the binary tree and insert the node
        private void add(Node node, ref Node tree)
        {
            if (tree == null) { tree = node; }
            else
            {
                if (node.value <= tree.value) { add(node, ref tree.left); }
                else { add(node, ref tree.right); }
            }
        }

        /// <summary>
        /// Add the value to the tree
        /// </summary>
        /// <param name="i">Value of node the node</param>
        /// <returns> Returns reference to the new node is the node was inserted.</returns>
        public Node insert(int i)
        {
            Node node = new Node(i);
            try
            {
                if (root == null) { root = node; }
                else { add(node, ref root); }
                _count++;
                return node;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Search for a node with value key. If found it returns a reference to the node parent.
        /// </summary>
        /// <param name="i"></param>
        /// <returns>Returns referente to the node parent, or null if it's the root.</returns>
        public Node findParent(int i)
        {
            Node target = this.findValue(i);
            Node current = root;
            Node parent = null;

            if (target == root || target == null) return null;
            while (current != null)
            {
                if (current.left == target || current.right == target)
                {
                    parent = current;
                    break;
                }
                if (target.value <= current.value && current.left != target)
                {
                    current = current.left;
                }
                if (target.value > current.value && current.right != target)
                {
                    current = current.right;
                }
            }
            return parent;
        }
    }
}