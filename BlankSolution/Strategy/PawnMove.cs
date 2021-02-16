using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class PawnMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Pawn moves");
        }
    }
}
