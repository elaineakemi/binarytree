using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTree.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BSTree bt = new BSTree();
            // Added the values in an array so it would be easier to create the tests
            int[] arr1 = { 11, 3, 54, 6, 42, 95, 2, 45, 24, 23, 34 };

            for(int i=0; i<arr1.Length; i++)
            {
                bt.insert(arr1[i]);
            }
            
            Node parent = bt.findParent(45);
            Assert.AreEqual(42, parent.value);
        }

        [TestMethod]
        public void TestMethod2()
        {
            BSTree bt = new BSTree();
            int[] arr1 = { 11, 3, 54, 6, 42, 95, 2, 45, 24, 23, 34 };

            for (int i = 0; i < arr1.Length; i++)
            {
                bt.insert(arr1[i]);
            }

            Node parent = bt.findParent(34);
            Assert.AreEqual(24, parent.value);
        }

        [TestMethod]
        public void TestMethod3()
        {
            BSTree bt = new BSTree();
            int[] arr1 = { 22, 5, 91, 2, 47, 13, 32, 45, 95 };

            for (int i = 0; i < arr1.Length; i++)
            {
                bt.insert(arr1[i]);
            }

            Node parent = bt.findParent(32);
            Assert.AreEqual(47, parent.value);
        }

        /// <summary>
        /// Creates a tree with negative values.
        /// Expected to work the same as positive values.
        /// </summary>
        [TestMethod]
        public void FindParent_NegativeValueTree_Success()
        {
            BSTree bt = new BSTree();
            int[] arr1 = { -22, -5, -91, -2, -47, -13, -32, -45, -95 };

            for (int i = 0; i < arr1.Length; i++)
            {
                bt.insert(arr1[i]);
            }

            Node parent = bt.findParent(-32);
            Assert.AreEqual(-47, parent.value);
        }

        /// <summary>
        /// Attempts to locate the parent node of a value that was not 
        /// given to the tree to manage. Expected return is null.
        /// </summary>
        [TestMethod]
        public void FindParent_NonExistantValue_Null()
        {
            BSTree bt = new BSTree();
            int[] arr1 = { 22, 5, 91, 2, 47, 13, 32, 45, 95 };

            for (int i = 0; i < arr1.Length; i++)
            {
                bt.insert(arr1[i]);
            }

            Node parent = bt.findParent(-32);
            // Assert.AreEqual(null, parent.value);
            Assert.AreEqual(null, parent);
        }


        /// <summary>
        /// Insert 10 equal values to create tree.
        /// </summary>
        [TestMethod]
        public void Insert_SameValue_Success()
        {
            BSTree bt = new BSTree();
            int[] arr1 = { 42, 42, 42, 42, 42, 42, 42, 42, 42, 42 };

            for (int i = 0; i < arr1.Length; i++)
            {
                bt.insert(arr1[i]);
            }

            var nodeCount = bt.count();
            Assert.AreEqual(10, nodeCount);
        }
    }
}
