using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public static class WinningPosition
    {
        public static void WinOrNot()
        {
            const int zeroposition = 0;
            const int nonzeroposition = 1;

            Random random = new Random();
            int dice = random.Next(2);
            Console.WriteLine("Dice : " + dice);

            if (dice == nonzeroposition)
            {
                Console.WriteLine("Player reached winning point");
            }
            else if (dice == zeroposition)
            {
                Console.WriteLine("Player restart the game");
}
        }
    }
}
