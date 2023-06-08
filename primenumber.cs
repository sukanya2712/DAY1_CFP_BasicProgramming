using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class primenumber
    {
        public void prime()
        {
            Boolean flag = true;
            Console.WriteLine("Enter a number to check weather it is prime or not:- ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 2; i <= a / 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("is not a prime number");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("it is prime");
            }
        }
    }
}
