using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicee
{
     class CoPrime
    {
        public virtual int GetValue()
        {
            return 100;
        }
        
    }
    class Child : CoPrime
    {
        public override int GetValue()
        {
            return 100;
        }


        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine(c.GetValue());
            CoPrime p = new Child();
           // p.GetValue();
            Console.WriteLine(p.GetValue());
           
        }
    }
}
