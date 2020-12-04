using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Figure
    {
        public string Name { get; set; }

        public Figure (string name)
        {
            Name = name;
        }
        public abstract double GetArea();
        /*Здесь применен Liskov substitution principle. Невыполнением этого принципа было бы
        наследование Square от Rectangle*/
    }
}
