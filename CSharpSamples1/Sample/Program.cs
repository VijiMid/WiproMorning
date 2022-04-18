using System;

namespace Sample
{
    class Program
    {
        /*
           static void Main(string[] args)
           {           
                int a = 10;
                int b = 20;
                int c; // Third variable

                c = a;
                a = b;
                b = c;
                Console.WriteLine("a is : " + a);
                Console.WriteLine("b is : " + b);

               int a = 10;
               int b = 20;

               a = a + b; // a = 10 +20 - a = 30
               b = a - b; // b = 30 - 20 - b = 10
               a = a - b; // a = 30 - 20 - a =20


               Console.WriteLine("a is : " + a);
               Console.WriteLine("b is : " + b);

           }
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name : "); // Output Statement
            string name = Console.ReadLine();

            Console.WriteLine("Hello.... \n {0}", name);  // {0} - Interpolation
        }
    }
}
 