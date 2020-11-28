using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyLibrary;
using System;

namespace MyLibraryTest
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var mock = new Mock<IUser>();
            mock.Setup(lw => lw.WriteMessage(It.IsAny<string>()));
            var logger = new User(mock.Object);

            //act
            string res = logger.WriteMessage(string.Empty);

            //assert
            Assert.IsNotNull(res);
        }
    }
}
