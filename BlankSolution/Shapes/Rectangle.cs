using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle: Figure
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(string name, double height, double width) : base(name)
        {
            Height = height;
            Width = width;
        }

        public override double GetArea()
        {
            return Height*Width;
        }
    }
}
