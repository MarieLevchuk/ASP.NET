using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ChessFigure
    {
        public string Color { get; }
        public IMovable Movable { private get; set; }
        public ChessFigure (string color, IMovable move)
        {
            Color = color;
            Movable = move;
        }
        public void Move()
        {
            Movable.Move();
        }
    }
}
