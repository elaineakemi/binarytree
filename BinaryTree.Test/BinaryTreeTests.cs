using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTree.Test
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        [TestCategory("UnitTests")]
        public void Should_Find_Parent_For_Given_Array_Elements()
        {
            int[] elements = { 11, 3, 54, 6, 42, 95, 2, 45, 24, 23, 34 };
            var binaryTree = BuildTree(elements);

            Node parent = binaryTree.FindParent(45);
            Assert.AreEqual(42, parent.Value);

            parent = binaryTree.FindParent(34);
            Assert.AreEqual(24, parent.Value);

            parent = binaryTree.FindParent(3);
            Assert.AreEqual(11, parent.Value);

            parent = binaryTree.FindParent(2);
            Assert.AreEqual(3, parent.Value);

            parent = binaryTree.FindParent(6);
            Assert.AreEqual(3, parent.Value);
        }

        [TestMethod]
        [TestCategory("UnitTests")]
        public void Should_Count_Total_Element()
        {
            int[] elements = { 11, 3, 54, 6, 42, 95, 2, 45, 24, 23, 34 };
            var binaryTree = BuildTree(elements);

            Assert.AreEqual(11, binaryTree.Count());
        }

        [TestMethod]
        [TestCategory("UnitTests")]
        public void Should_Find_Node_For_Given_Array_Element()
        {
            int[] elements = { 11, 3, 54, 6, 42, 95, 2, 45, 24, 23, 34 };
            var binaryTree = BuildTree(elements);

            var nodeValue = binaryTree.FindValue(54);
            Assert.IsNotNull(nodeValue);
            Assert.IsTrue(nodeValue.Value == 54);

            Assert.IsNotNull(nodeValue.Left);
            Assert.IsNotNull(nodeValue.Right);

            Assert.IsTrue(nodeValue.Left.Value == 42);
            Assert.IsTrue(nodeValue.Right.Value == 95);
        }

        [TestMethod]
        [TestCategory("UnitTests")]
        public void Should_Return_Null_If_Element_Is_Not_Found()
        {
            int[] elements = { 11, 3, 54, 6, 42, 95, 2, 45, 24, 23, 34 };
            var binaryTree = BuildTree(elements);

            var nodeValue = binaryTree.FindValue(108);
            Assert.IsNull(nodeValue);
        }

        [TestMethod]
        [TestCategory("UnitTests")]
        public void Should_Return_Null_If_Element_Is_Root_Node()
        {
            int[] elements = { 11, 3, 54, 6, 42, 95, 2, 45, 24, 23, 34 };
            var binaryTree = BuildTree(elements);

            var nodeValue = binaryTree.FindParent(11);
            Assert.IsNull(nodeValue);
        }

        [TestMethod]
        [TestCategory("UnitTests")]
        public void Should_Return_Node_For_Newly_Added_Element()
        {
            int[] elements = { 11, 3, 54, 6, 42, 95, 2, 45, 24, 23, 34 };
            var binaryTree = BuildTree(elements);

            var node =  binaryTree.Insert(7);

            Assert.IsNotNull(node);
            Assert.IsTrue(node.Value==7);
            Assert.IsNull(node.Left);
            Assert.IsNull(node.Right);
        }

        [TestMethod]
        [TestCategory("UnitTests")]
        public void Should_Return_Root_Node()
        {
            int[] elements = { 11, 3, 54, 6, 42, 95, 2, 45, 24, 23, 34 };
            var binaryTree = BuildTree(elements);

            var node = binaryTree.Root;

            Assert.IsNotNull(node);
            Assert.IsTrue(node.Value == 11);
            Assert.IsNotNull(node.Left);
            Assert.IsNotNull(node.Right);
        }

        private static BSTree BuildTree(int[] elements)
        {
            BSTree binaryTree = new BSTree();
            foreach (int element in elements)
            {
                binaryTree.Insert(element);
            }

            return binaryTree;
        }
    }
}
