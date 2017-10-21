using System;

namespace BinaryTree
{
    public class BSTree
    {
        private Node _root;
        private int _count = 0;

        public BSTree()
        {
            _root = null;
            _count = 0;
        }

        /// <summary>
        /// Return the Root Node
        /// </summary>
        public Node Root
        {
            get { return _root; }
        }

        /// <summary>
        /// Returns the number of nodes in the tree
        /// </summary>
        /// <returns>Number of nodes in the tree</returns>
        public int Count()
        {
            return _count;
        }

        /// <summary>
        /// Find and return the tree node for a specific value.
        /// </summary>
        /// <param name="value">Value of node to locate</param>
        /// <returns>Returns null if it fails to find the node, else returns reference to node</returns>
        /// 
        public Node FindValue(int value)
        {
            Node np = _root;

            while (np != null)
            {
                if (value == np.Value) { return np; }
                else if (value <= np.Value) { np = np.Left; }
                else { np = np.Right; }
            }

            return null;
        }

        /// <summary>
        /// Add the value to the tree
        /// </summary>
        /// <param name="i">Value of node the node</param>
        /// <returns> Returns reference to the new node is the node was inserted.</returns>
        public Node Insert(int i)
        {
            Node node = new Node(i);
            if (_root == null) { _root = node; }
            else { Add(node, ref _root); }
            _count++;
            return node;
        }

        /// <summary>
        /// Search for a node with value key. If found it returns a reference to the node parent.
        /// </summary>
        /// <param name="i"></param>
        /// <returns>Returns referente to the node parent, or null if it's the root.</returns>
        public Node FindParent(int i)
        {
            Node target = this.FindValue(i);
            Node current = _root;
            Node parent = null;

            if (target == _root || target == null) return null;
            while (current != null)
            {
                if (current.Left == target || current.Right == target)
                {
                    parent = current;
                    break;
                }
                if (target.Value <= current.Value && current.Left != target)
                {
                    current = current.Left;
                }
                if (target.Value > current.Value && current.Right != target)
                {
                    current = current.Right;
                }
            }
            return parent;
        }

        // Recursively locates a empty slot in the binary tree and insert the node
        private static void Add(Node node, ref Node tree)
        {
            if (tree == null) { tree = node; }
            else
            {
                if (node.Value <= tree.Value) { Add(node, ref tree.Left); }
                else { Add(node, ref tree.Right); }
            }
        }
    }
}