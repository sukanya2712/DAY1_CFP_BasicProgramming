using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EvenOdd
    {
        public void even()
        {
            
                int number = 7; // Specify the number to check

                if (IsEven(number))
                {
                    Console.WriteLine(number + " is even.");
                }
                else
                {
                    Console.WriteLine(number + " is odd.");
                }
            

            static bool IsEven(int number)
            {
                return number % 2 == 0;
            }
        }
    }
}
