using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FLIPCOIN
    {
        public void coin()
        {
            int numberOfFlips = 1000; // Specify the number of coin flips

            int headsCount = 0;
            int tailsCount = 0;

            Random random = new Random();

            for (int i = 0; i < numberOfFlips; i++)
            {
                int flipResult = random.Next(2); // Generates a random number (0 or 1)

                if (flipResult == 0)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }
            }

            double headsPercentage = (double)headsCount / numberOfFlips * 100;
            double tailsPercentage = (double)tailsCount / numberOfFlips * 100;

            Console.WriteLine("Heads: " + headsCount);
            Console.WriteLine("Tails: " + tailsCount);
        }
    }
}
