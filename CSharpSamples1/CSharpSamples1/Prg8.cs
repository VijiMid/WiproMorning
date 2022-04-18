using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg8
    {
        public void Print()
        {
            Console.WriteLine("Enter No  : ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Table  : ");
            int table = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=no;i++)
            {
                Console.WriteLine("{0}*{1}={2}", i, table, (i * table));
            }
        }
        }
}
