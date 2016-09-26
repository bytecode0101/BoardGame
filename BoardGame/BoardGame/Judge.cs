using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public abstract class Judge : Game
    {
        public abstract Pawn DecideTheWinner(Pawn p1, Pawn p2);
        
    }
}