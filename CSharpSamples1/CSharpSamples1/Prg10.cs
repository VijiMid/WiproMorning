using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg10
    {
        public void Print()
        {
            Console.WriteLine("Enter No  : ");
            int no = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= no; i++) // Rows
            {
                for (int j = 1; j <= i; j++)//cols
                {
                    Console.Write(" " + i);
                } // j++
                Console.WriteLine();
            } // i++
        }
    }
}
