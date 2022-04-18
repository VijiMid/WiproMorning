using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg7
    {
        public void Print()
        {
            Console.WriteLine("Enter No  : ");
            int no = Convert.ToInt32(Console.ReadLine());
            /*

           for(int i=1;i<=no;i++) // initalization happens only once.
           {
               Console.Write("  " + "Your Name");
           } 

           // before end of } of for loop increment/decrement

           int i = 1;
           for (; i <= no; i++)
           {
               Console.Write("  " + "Viji");
           }
            */
            /*
            int i = 1;
            for (; i <= no; )
            {
                Console.Write("  " + "Viji");
                i++;
            }
            */
            /*
            int i = 0;
            for (; ++i <= no;)
            {
                Console.Write("  " + "Viji");
                
            }
            */
            /*
            for (int i = no; i > 0; i--) // initalization happens only once.
            {
                Console.Write("  " + i);
            }
            */
            /*
            for (int i = 1; i <= no; i=i+3) // initalization happens only once.
            {
                Console.Write("  " + i);
            }
            */
        }
    }
    }
