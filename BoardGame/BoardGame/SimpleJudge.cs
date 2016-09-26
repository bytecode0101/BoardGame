using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoardGame
{
    public class SimpleJudge : Judge
    {
        public override Pawn DecideTheWinner(Pawn p1, Pawn p2)
        {
            Console.WriteLine("{0} is fighting with {1}" , p1.Name, p2.Name);
            var winner = p1;
            Console.WriteLine("The winner is {0}" , winner.Name);
            for (int i = p2.Resources.Count -1 ; i >=0; i--)
            {
                var r = p2.Resources[i];
                p2.Resources.Remove(r);
                p1.Resources.Add(r);
            }
            return winner;

        }
    }
}