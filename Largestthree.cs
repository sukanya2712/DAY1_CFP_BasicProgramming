using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Largestthree
    {
        public void largest()
        {
            
                int number1 = 10; // Specify the first number
                int number2 = 25; // Specify the second number
                int number3 = 15; // Specify the third number

                int largest = FindLargest(number1, number2, number3);

                Console.WriteLine("The largest number among " + number1 + ", " + number2 + ", and " + number3 + " is: " + largest);
            

            static int FindLargest(int number1, int number2, int number3)
            {
                int largest = number1;

                if (number2 > largest)
                {
                    largest = number2;
                }

                if (number3 > largest)
                {
                    largest = number3;
                }

                return largest;
            }

        }
    }
}
