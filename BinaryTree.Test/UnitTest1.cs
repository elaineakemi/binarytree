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
    }
}
