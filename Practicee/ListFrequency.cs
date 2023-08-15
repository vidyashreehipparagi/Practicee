using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class ListFrequency
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<string> list = new List<string>();
            list.Add("Red");
            list.Add("Green");
            list.Add("White");
            list.Add("Black");
            list.Add("Red");
            list.Add("White");
            //int i, k, j;

            //for (i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.WriteLine("---------------------");
            //for (i = 0; i < list.Count; i++)
            //{
            //    int repeat = 1;
            //    bool isVisited = false;
            //    for (k = i - 1; k >= 0; k--)
            //    {
            //        if (list[k] == list[i])
            //        {
            //            isVisited = true;
            //            break;
            //        }


            //    }
            //    if (isVisited == false)
            //    {
            //        for (j = i + 1; j < list.Count; j++)
            //        {
            //            if (list[i] == list[j])
            //            {
            //                repeat++;
            //            }
            //        }


            //        Console.WriteLine(list[i] + " -->" + repeat);

            //    }


            Dictionary<string, int> dict = new Dictionary<string, int>();
            

          for (int i = 0; i < list.Count; i++)
            {
                int Count = 1;
                for (int j = i + 1; j < list.Count; j++)
                {


                    if (list[i] == list[j])
                    {
                        Count++;
                        //break;
                        list.RemoveAt(j);
                        // j--
                    }
                }
               // Console.WriteLine(list[i] + "-" + Count);
                dict.Add(list[i], Count);
            }
            foreach (KeyValuePair<string,int> item in dict)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }

        }

    }

        }
    

