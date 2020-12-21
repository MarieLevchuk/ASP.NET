using Microsoft.VisualStudio.TestTools.UnitTesting;
using Converter.Models;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Converter.Controllers;

namespace UnitTests
{
    [TestClass]
    public class ConverterControllerTests
    {
        [TestMethod]
        public void HttpGetConvertTemperture_10C_InstanceOfType()
        {
            //arrange
            int temperatureC = 10;            
            var controller = new ConverterController();
            var expectedType =typeof(OkResult);

            //act
            var actual = controller.ConvertTemperture(temperatureC);

            //assert
            Assert.IsInstanceOfType(actual, expectedType);
        }
    }
}
