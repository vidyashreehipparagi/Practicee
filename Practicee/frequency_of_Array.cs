using System;

namespace Practicee
{
    public class frequency_of_Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements of an array");
            int[] num = new int[10];
            int i, k, j;
            for (i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("----------");
            for (i = 0; i < num.Length; i++)
            {
                int count = 1;
                bool isVisited = false;
                for (k = i - 1; k>=0; k--)
                {
                    if (num[k] == num[i])
                    {
                        isVisited = true;
                        break;
                    }


                }
                if (isVisited == false)
                {
                    for (j = i + 1; j < num.Length; j++)
                    {
                        if (num[i] == num[j])
                        {
                            count++;
                        }
                    }
                }


                    //Console.WriteLine("frequency");
                    Console.WriteLine(num[i] + " -->" + count);

                    ////Console.WriteLine("UNique");
                    //if (count == 1)
                    //{
                    //  Console.WriteLine("Unique number==> "+num[i]);
                    //}
                    ////Console.WriteLine("duplicate numbers");
                    ////if (count > 1)
                    ////{
                    ////    Console.WriteLine(num[i]+"-->"+count);
                    ////}
            }
        }
    }
}
