using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg6
    {
        public void Print()
        {
            Console.WriteLine("Enter Side 1  : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Side 2  : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Side 3  : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("All Lines are Equal");
            }
            else if (a != b && b != c)
            {
                Console.WriteLine("Scale Triangle");
            }
            else
            {
                Console.WriteLine("IsoScale Triangle");
            }
        }
    }
}
