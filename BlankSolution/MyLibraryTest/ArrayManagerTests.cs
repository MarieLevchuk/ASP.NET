using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using System;

namespace MyLibraryTest
{
    [TestClass]
    public class ArrayManagerTests
    {
        [TestMethod]
        public void FindMax_2345_5Returned()
        {
            //arrange

            int[] arr = { 2, 3, 4, 5 };
            int expected = 5;

            //act

            int actual = ArrayManager.FindMax(arr);

            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
