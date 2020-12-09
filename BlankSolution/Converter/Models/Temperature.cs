using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Models
{
    public class Temperature: ITemperature
    {
        public int CelsiusDegree { get; set; }
        public int FarenheitDegree { get; set; }
        public void ConvertCelsiusToFarenheit()
        {
            FarenheitDegree = (int)(CelsiusDegree * 9 / 5 + 32);
        }       
    }
}
