using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {            
            ChessFigure pawn = new ChessFigure("white", new PawnMove());
            pawn.Move();

            pawn.Movable = new QueenMove();
            pawn.Move();
        }
    }
}
