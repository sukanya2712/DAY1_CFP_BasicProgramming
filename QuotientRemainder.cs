using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class QuotientRemainder
    {
        public void quotient()
        {
            int dividend = 17; 
            int divisor = 4;

            int quotient = ComputeQuotient(dividend, divisor);
            int remainder = ComputeRemainder(dividend, divisor);

            Console.WriteLine("Dividend: " + dividend);
            Console.WriteLine("Divisor: " + divisor);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        

        static int ComputeQuotient(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        static int ComputeRemainder(int dividend, int divisor)
        {
            return dividend % divisor;
        }
    }
    }
}
