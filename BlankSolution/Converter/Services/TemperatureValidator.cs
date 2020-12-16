using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Models
{
    public class TemperatureValidator : IValidator
    {
        public bool ValueIsValid(int temperatureC)
        {
            return temperatureC >= -273 ? true : false;
        }
    }
}
