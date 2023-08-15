using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Num_frequency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp =num;
            for(int i=0;i<=9;i++)  //i<9 the number is in between 0-9
            {
                int count = 0;
                while(num>0)
                {
                    int digit = num % 10; //to seprate digit
                    if(digit==i)          //if comparing digit is equals to num that is in between 1 to 9
                    {
                        count++;
                    }
                    num = num / 10;
                }
                num = temp;       //here all digits will separate , so check for another condition so it will use already stored num 
                if(count!=0)
                {
                    Console.WriteLine(i + "-->" + count);
                }
            }
        }
    }
}
