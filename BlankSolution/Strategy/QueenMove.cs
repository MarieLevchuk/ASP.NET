using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class QueenMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Queen moves");
        }
    }
}
