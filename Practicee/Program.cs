using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a= new Account();
            a.AccountNo = 1132;
            a.Type = "Current";
            a.balance = 0;
            Console.WriteLine($"Account Number={a.AccountNo}\nAccount Type={a.Type}\nAccount Balance={a.balance}");
        }
    }
}
