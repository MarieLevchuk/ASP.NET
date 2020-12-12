using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Converter.Models
{
    public interface IValidator
    {
        public bool ValueIsValid(int value);
    }
}
