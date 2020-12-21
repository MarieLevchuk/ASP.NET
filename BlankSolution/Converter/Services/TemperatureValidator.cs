using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Models
{
    public class TemperatureValidator : IValidator
    {
        int _min = -273;
        public bool ValueIsValid(int temperatureC)
        {
            return temperatureC >= _min ? true : false;
        }
    }
}
