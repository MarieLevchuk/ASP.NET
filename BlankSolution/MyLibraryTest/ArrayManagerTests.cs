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

        [TestMethod]
        public void CountEvenNumber_6789_2Returned()
        {
            //arrange
            int[] arr = { 6, 7, 8, 9 };
            int expected = 2;

            //act
            int actual = ArrayManager.CountEvenNumber(arr);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CountEvenNumber_NullArray_ExpectedExeption()
        {
            //arrange
            int[] arr = null;
            
            //act
            int actual = ArrayManager.CountEvenNumber(arr);
        }
    }
}
