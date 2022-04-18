using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg3
    {
        public void Print()
        {
            Console.WriteLine("Enter No1  : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter No2  : ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a==b)
            {
                Console.WriteLine("Both are Equal");
            }
            else if(a>b)
            {
                Console.WriteLine("No1 is bigger");
            }
            else
            {
                Console.WriteLine("No2 is bigger");
            }
         }
    }
}
