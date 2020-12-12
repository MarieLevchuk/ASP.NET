using Converter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                return Ok(_temperature.FarenheitDegree);
            }
            else
                return BadRequest(" ");
        }
    }
}
