using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSamples
{
    class Coll_1
    {
      public  void display()
        {
            List<string> lst = new List<string>();
            Console.WriteLine("Enter No : ");
            int no = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1;i<=no;i++)
            {
                Console.WriteLine("Enter Element : ");
                lst.Add(Console.ReadLine());
            }

            for (int i = 0; i < no; i++)
            {
                Console.WriteLine(lst[i] + " ");
            }

            Console.WriteLine("Enter Element to remove : ");
            lst.Remove(Console.ReadLine());

            Console.WriteLine("List After removed the Element : ");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i] + " ");
            }

        }    

    }
}
