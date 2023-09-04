using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzAssaignment
{
    internal class Flip_Coin
    {

        public static void Flip(int n)
        {
            int headsCount = 0;
            int tailsCount = 0;
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }
            }

            double headsPercentage = (double)headsCount / n * 100;
            double tailsPercentage = (double)tailsCount / n * 100;

            Console.WriteLine($"Heads: {headsPercentage:F2}% ");
            Console.WriteLine($" Tails: {tailsPercentage:F2}%");
        }
    }
}

