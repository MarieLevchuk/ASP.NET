using System;

namespace Shapes
{
    public class Square: Figure
    {
        public double Side { get; set; }

        public Square (string name, double side) : base(name)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
