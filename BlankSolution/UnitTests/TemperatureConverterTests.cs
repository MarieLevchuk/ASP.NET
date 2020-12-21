using Microsoft.VisualStudio.TestTools.UnitTesting;
using Converter.Models;

namespace UnitTests
{
    [TestClass]
    public class  TemperatureConverterTests
    {
        [TestMethod]
        public void ConvertCelsiusToFarenheit_20C_68Returned()
        {
            //arrange
            int expected = 68;
            int temperatureC = 20;
            var temperature = new Temperature();

            //act
            temperature.CelsiusDegree = temperatureC;
            temperature.ConvertCelsiusToFarenheit();
            var actual = temperature.FarenheitDegree;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
