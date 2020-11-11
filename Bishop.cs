using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{
    internal class Bishop : Piece
    {
        public Bishop(string symbol) : base(symbol)
        {
            Symbol = symbol;
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }
    }
}