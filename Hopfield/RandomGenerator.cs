using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Hopfield
{
    // Random number generator from date and time for noise
    public static class RandomGenerator
    {
        private static readonly Random Rand = new Random(DateTime.Now.Millisecond);

        public static bool Match(int probability)
        {
            return Rand.Next(100) < probability;
        }
    }
}
