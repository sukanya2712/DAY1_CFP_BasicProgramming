using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PowerofTwo
    {
        public void powertwo()
        {
            int maxPower = 10;
            for (int i = 0; i <= maxPower; i++)
            {
                long value = (long)Math.Pow(2, i);
                Console.WriteLine($"{i}\t{value}");
            }
        }
    }
}
