﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class StringRevrse
    {
        

       
      
            static void Main(string[] args)
            {
            //string character reverse
                Console.WriteLine("Enter any string");
                string str = Console.ReadLine();

                string[] array = str.Split(' ');
                string reverse_value = "";

                for (int i = 0; i < array.Length; i++)
                {
                    string word = array[i];
                    string reverse_word = " ";

                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        reverse_word += word[j];
                    }
                    reverse_value = reverse_value + reverse_word;
                }
                Console.WriteLine(reverse_value);
            }
        }
    }

    
