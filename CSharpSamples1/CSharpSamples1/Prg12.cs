using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg12
    {
        public void Print()
        {
            Console.WriteLine("Enter No  : ");
            int no = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= no; i++)  // i-2 , i-3,i -4
            {
                // This for loop to print space before start to print the cols
               for(int s=i;s<=no;s++)
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
