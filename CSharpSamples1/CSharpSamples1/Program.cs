using System;
 


namespace CSharpSamples1 
{
    class Program
    {
        /*
        
       static void Main(string[] args)  
       {
           Console.WriteLine("Enter Name : ");
           string name = Console.ReadLine();
           Console.WriteLine("Name  is : {0} ",name);
       }        
       */
        /*
       static void Main(string[] args)
       {            
           Console.WriteLine("\"Wipro\"");
           Console.WriteLine("\n\n\n\n\"Wipro\"");
           Console.WriteLine("\n\t\t\t\t\t\"Wipro\"");
           Console.WriteLine("\'Wipro\'");
       }
        */
        /*
        static void Main(string[] args)
        {
                  Console.WriteLine("\n\n\t\t*\n\n\n\t*\t\t*\n\n\n\t\t*");            
        }
        */
        /*
        static void Main(string[] args)
        {
            // time save and less memory space
            Console.WriteLine("Enter Name and Email: ");
            Console.WriteLine("Name is : {0}\nEmail is : {1}", 
                Console.ReadLine(), Console.ReadLine());
        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a : ");
           int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quotient : {0}\nReminder is : {1}", a/b,a%b);
        }
        */
        /*
        static void Main(string[] args)
        {
            int a = 5;
            int b;
            Console.WriteLine("a is : " + a); // 5
            b = a++;
            Console.WriteLine("a is : " + a); //6
            Console.WriteLine("b is : " + b); // 5
            b = ++a;
            Console.WriteLine("a is : " + a); //7
            Console.WriteLine("b is : " + b); //7
            b = a--;
            Console.WriteLine("a is : " + a);//6
            Console.WriteLine("b is : " + b);//7
            b = --a;
            Console.WriteLine("a is : " + a); //5
            Console.WriteLine("b is : " + b); //5
        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no : ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.Write(no % 10);
            no = no / 10;
            Console.Write(no % 10);
            no = no / 10;
            Console.Write(no % 10);
            no = no / 10;
            Console.Write(no % 10);
            no = no / 10;
            Console.Write(no % 10); 

        }
        */
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            string s = (a > b) ? (a > c) ? "a is big" : "c is big" : (b > c) ? "b is big" : "c is big";
            Console.WriteLine(s);            
        }
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character : ");
            char c = Convert.ToChar(Console.ReadLine());
            switch(c)
            {
                case 'a':      
                case 'e': 
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U': 
                    Console.WriteLine("Vowel : {0}", c);
                    break;
                default: 
                    Console.WriteLine("Not Vowel : {0}", c);
                    break;
            }
        
        }
        */

    }
} 

