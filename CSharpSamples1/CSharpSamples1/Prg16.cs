using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg16
    {
        public void Print()
        {
            Console.WriteLine("Enter No  : ");
            int no = Convert.ToInt32(Console.ReadLine()); // 5

            for (int i = no; i >=1; i--)  // i-5, i-4, i-3
            {

                // This for loop for what to print
                for (int j = i; j >=1; j--)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
        }
    }
}
