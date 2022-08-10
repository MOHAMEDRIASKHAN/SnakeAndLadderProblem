using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class CheckTheOption
    {

        public static void checkingOption()
        {
            Random random = new Random();
            int check = random.Next(3);
            Console.WriteLine("Dise Number : " + check);

            if (check == 0)
            {
                Console.WriteLine("Player in idle Position ");
            }
            else if (check == 1)
            {
                Console.WriteLine("Player moved in forward position");
            }
            else
            {
                Console.WriteLine("Player move in Backward Direction");
            }
        }
  }
}
