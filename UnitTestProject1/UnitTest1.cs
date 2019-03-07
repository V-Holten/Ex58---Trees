using System;
using System.Collections.Generic;
using Ex58___Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBST()
        {
            int[] data = { 47, 22, 68, 9, 33, 53, 88, 5, 17, 29, 46, 48 };
            List<int> controlList = new List<int>(data);
            controlList.Sort();

            MyBST<int> bst = new MyBST<int>();
            foreach (int intData in data)
            {
                bst.Insert(intData);
            }

            List<int> inOrderList = bst.InOrder();
            Assert.AreEqual(controlList.Count, inOrderList.Count);
            for (int i = 0; i < controlList.Count; i++)
            {
                Assert.AreEqual(controlList[i], inOrderList[i]);
            }
        }

    }
}
