using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg1
    {
       public void Print()
        {
            Console.WriteLine("Enter a : ");
            int a = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter b : ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a>b)
            {
                Console.WriteLine((a - b) * 2);
            }
            else
            {
                Console.WriteLine(b - a);
            }
        }
    }
}
