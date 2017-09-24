using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new binary tree
            BSTree bt = new BSTree();

            // Insert data
            bt.insert(11);
            bt.insert(3);
            bt.insert(54);
            bt.insert(6);
            bt.insert(42);
            bt.insert(95);
            bt.insert(2);
            bt.insert(45);
            bt.insert(24);
            bt.insert(23);
            bt.insert(34);

            Node parent = bt.findParent(45);
            Console.WriteLine(parent == null ? "Parent could not be found." : parent.value.ToString());
            
            Console.Read();
        }
    }   
}
