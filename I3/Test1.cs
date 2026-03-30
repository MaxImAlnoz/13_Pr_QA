using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListApp;
using System.Collections.Generic;

namespace ListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Average()
        {
            var list = new IntegerList(new List<int> { 1, 2, 3, 4 });
            Assert.AreEqual(2.5, list.GetAverage());
        }

        [TestMethod]
        public void Test_Sort()
        {
            var list = new IntegerList(new List<int> { 1, 5, 3 });
            list.SortDescending();

            CollectionAssert.AreEqual(
                new List<int> { 5, 3, 1 },
                list.GetList()
            );
        }

        [TestMethod]
        public void Test_Remove()
        {
            var list = new IntegerList(new List<int> { 1, 2, 100 });
            list.RemoveByDeviation(10);

            CollectionAssert.AreEqual(
                new List<int> { 1, 2 },
                list.GetList()
            );
        }

        [TestMethod]
        public void Test_NoRemove()
        {
            var list = new IntegerList(new List<int> { 1, 2, 3 });
            list.RemoveByDeviation(10);

            CollectionAssert.AreEqual(
                new List<int> { 1, 2, 3 },
                list.GetList()
            );
        }

        [TestMethod]
        public void Test_OneElement()
        {
            var list = new IntegerList(new List<int> { 5 });
            Assert.AreEqual(5, list.GetAverage());
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void Test_Empty()
        {
            new IntegerList(new List<int>());
        }
    }
}