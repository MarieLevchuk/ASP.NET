using Converter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Controllers
{
    public class ConverterController : ControllerBase
    {
        ITemperature _temperature = new Temperature();
        IValidator validator = new TemperatureValidator();

        [HttpGet]
        public IActionResult ConvertTemperture(int temperatureC)
        {
            if (validator.ValueIsValid(temperatureC))
            {
                _temperature.CelsiusDegree = temperatureC;
                _temperature.ConvertCelsiusToFarenheit();
                return Ok();
            }
            else
                return LocalRedirect("https://www.it-academy.by");
        }

        [HttpGet]
        public FileResult SendTxtFile(int temperatureC)
        {
            var filePath = @"Files";
            using (FileStream fstream = new FileStream($"{filePath}/temperatureC.txt", FileMode.OpenOrCreate))
            {
                byte[] byteArray = BitConverter.GetBytes(temperatureC);
                fstream.Write(byteArray, 0, byteArray.Length);                
            }
            return File(filePath, "text/plain", "temperatureC.txt");
        }

        public IActionResult IsValid()
        {
            if (validator.ValueIsValid(_temperature.CelsiusDegree))
            {
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}
