using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public static class WinningMoment
    {
        public static void DisplayWinningMoment()
        {
            const int WinPoint = 1;

            Random r = new Random();
            int dice = r.Next(7);

            Console.WriteLine("Dice Number : " +dice);

            if (dice == WinPoint)
            {
                Console.WriteLine("Player Win the Game");
            }
            else
            {
                Console.WriteLine("Player stay the same position");
            }

        }
    }
}
