using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Models
{
    public interface ITemperature
    {
        public int CelsiusDegree { get; set; }
        public int FarenheitDegree { get; set; }
        public void ConvertCelsiusToFarenheit();
    }
}
