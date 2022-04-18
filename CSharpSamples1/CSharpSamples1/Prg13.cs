using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg13
    {
        public void Print()
        {
            Console.WriteLine("Enter No  : ");
            int no = Convert.ToInt32(Console.ReadLine()); // 5

            for (int i = no; i >= 1; i--)  // i-5, i-4, i-3
            {
                // This for loop to print space before start to print the cols
                for (int s = i; s <= no; s++)//s-5, s-4, s-3
                {
                    Console.Write(" ");
                }
                // This for loop for what to print
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
        }
    }
}
