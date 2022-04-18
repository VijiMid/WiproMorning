using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples1
{
    class Prg4
    {
        // Console.ReadLine() - can get as a string
        //Convert.ToChar () - convert a string as a character
        //
        public void Print()
        {
            Console.WriteLine("Enter a Character  : ");
            // if you assign a character into a int datatype . It can get ascii code of a particular character
            int c = Convert.ToChar( Console.ReadLine());
            

            if (c >= 65 && c <= 90)
            {
                if(c=='A' || c=='E' || c== 'I' || c=='O' || c== 'U')
                { 
                Console.WriteLine("\t\tCapital Letter : " + (char)c + " Vowel ");
                }
                else
                {
                    Console.WriteLine("\t\tCapital Letter : " + (char)c + " Not Vowel ");
                }
            }
            else if (c >= 97 && c <= 122)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    Console.WriteLine("\t\tSmall Letter : " + (char)c + " Vowel ");
                }
                else
                {
                    Console.WriteLine("\t\tSmall Letter : " + (char)c + " Not Vowel ");
                }                
            }
            else if (c >= 48 && c <= 57)
            {
                Console.WriteLine("\t\tNumbers : " + (char)c);
            }
            else if (c >= 33 && c <= 47 || c >= 58 && c <= 63 || c >= 91 && c <= 96 || c >= 123 && c <= 126)
            {
                Console.WriteLine("\t\tSymbols : " + (char)c);
            }
        }
    }
}
