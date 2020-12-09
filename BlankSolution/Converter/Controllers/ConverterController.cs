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

        [HttpGet]
        public IActionResult ConvertTemperture(int temperatureC)
        {
            _temperature.CelsiusDegree = temperatureC;
            _temperature.ConvertCelsiusToFarenheit();
            return Ok(_temperature.FarenheitDegree);
        }
    }
}
