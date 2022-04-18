using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg5
    {
        public void Print()
        {
            Console.WriteLine("Enter X  : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Y  : ");
            int y = Convert.ToInt32(Console.ReadLine());

            if(x==0 && y == 0)
            {
                Console.WriteLine("Points at the Origin {0} and {1} ", x, y);
            }
            else if(x>0 && y>0)
            {
                Console.WriteLine("Points at the First Quadrant {0} and {1} ", x, y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Points at the Second Quadrant {0} and {1} ", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Points at the Third Quadrant {0} and {1} ", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Points at the Fourth Quadrant {0} and {1} ", x, y);
            }

        }
    }
    }
