using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Decimal_To_binary
    {//decimal to binary
        static void Main(string[] args) {
            Console.WriteLine("Enter the Decimal Number : ");
            int number = int.Parse(Console.ReadLine());
            int i;
            int[] numberArray = new int[10];
            for (i = 0; number > 0; i++)
            {

                numberArray[i] = number % 2;
                number = number / 2;
            }
            Console.WriteLine("Binary Represenation of the given Number : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }
            Console.WriteLine();
        }
    }
}
