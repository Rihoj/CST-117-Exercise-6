using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_Exercise_6
{
    class Randomizer
    {
        public static Random random = new Random();
        public static int generate(int max)
        {
            return random.Next(1, max + 1);
        }
    }
}
